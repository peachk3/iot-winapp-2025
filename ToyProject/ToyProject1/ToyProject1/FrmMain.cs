using System.Data;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;

namespace ToyProject1
{
    public partial class FrmMain : Form
    {
        private DataTable scheduleTable = new DataTable();
        private DataRow editingRow = null;

        public FrmMain()
        {
            InitializeComponent();
            InitializeScheduleTable();
            InitializeControls();
        }

        // DataTable 구조 설정
        private void InitializeScheduleTable()
        {
            scheduleTable.Columns.Add("날짜", typeof(DateTime));
            scheduleTable.Columns.Add("일정 제목", typeof(string));
            scheduleTable.Columns.Add("일정 분류", typeof(string));
            scheduleTable.Columns.Add("일정 내용", typeof(string));
            scheduleTable.Columns.Add("중요도", typeof(string));
            TblSch.DataSource = scheduleTable;
        }
        // 라디오버튼/콤보박스 설정 + DataGridView 설정
        private void InitializeControls()
        {
            RdoHigh.Text = "높음";
            RdoMiddle.Text = "보통";
            RdoLow.Text = "낮음";

            string[] categories = {"업무", "개인", "가족", "친구", "기타" };
            string[] searchCategories = { "", "업무", "개인", "가족", "친구", "기타" };

            CboCategory.Items.AddRange(categories);
            CboSearchCate.Items.AddRange(searchCategories);
            CboCategory.SelectedIndex = 0;
            CboSearchCate.SelectedIndex = 0;

            TblSch.RowHeadersVisible = false;
            TblSch.AllowUserToAddRows = false;
            AddCheckboxColumn();
            // 중요도 포맷팅
            TblSch.CellFormatting += TblSch_CellFormatting;
            BtnModify.Click += BtnModify_Click;

        }

        // 체크박스 열 추가
        private void AddCheckboxColumn()
        {
            // 이미 추가되어 있지 않은 경우에만 추가
            if (!TblSch.Columns.Contains("chk"))
            {
                DataGridViewCheckBoxColumn chkCol = new DataGridViewCheckBoxColumn();
                chkCol.Name = "chk";
                chkCol.HeaderText = "";
                chkCol.Width = 30;
                chkCol.ReadOnly = false;
                chkCol.TrueValue = true;
                chkCol.FalseValue = false;

                TblSch.Columns.Insert(0, chkCol); // 제일 앞에 삽입
            }
        }

        // 일정 등록
        private void BtnCheck_Click(object sender, EventArgs e)
        {
            DateTime schDate = CalToDoList.SelectionStart;
            string schTitle = TxtTitle.Text;
            string schCategory = CboCategory.SelectedItem.ToString();
            string schContent = TxtContent.Text;
            string importance = RdoHigh.Checked ? RdoHigh.Text :
                                RdoMiddle.Checked ? RdoMiddle.Text :
                                RdoLow.Checked ? RdoLow.Text : RdoMiddle.Text;

            if (string.IsNullOrWhiteSpace(schTitle))
            {
                MessageBox.Show("일정 제목을 입력하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else if (string.IsNullOrWhiteSpace(schCategory))
            {
                MessageBox.Show("일정 분류를 선택하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrWhiteSpace(schContent))
            {
                MessageBox.Show("일정 내용을 입력하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (editingRow != null)
            {
                // 기존 행 수정
                editingRow["날짜"] = schDate;
                editingRow["일정 제목"] = schTitle;
                editingRow["일정 분류"] = schCategory;
                editingRow["일정 내용"] = schContent;
                editingRow["중요도"] = importance;

                editingRow = null; // 수정 완료 후 초기화
            }
            else
            {
                scheduleTable.Rows.Add(schDate, schTitle, schCategory, schContent, importance);
            }
            CalendarBolding();
            ClearInputFields();
        }

        // 입력 필드 초기화
        private void ClearInputFields()
        {
            TxtTitle.Clear();
            TxtContent.Clear();
            CboCategory.SelectedIndex = 0;
            RdoMiddle.Checked = true;
        }


        // 중요도 정렬
        private void BtnSortByImportance_Click(object sender, EventArgs e)
        {
            DataView dv = scheduleTable.DefaultView;
            dv.Sort = "중요도 DESC";
            TblSch.DataSource = dv.ToTable();
        }

        // 일정 수정
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TblSch.SelectedRows.Count > 0)
            {
                var row = TblSch.SelectedRows[0];
                row.Cells["일정 제목"].Value = TxtTitle.Text;
                row.Cells["일정 내용"].Value = TxtContent.Text;
                //row.Cells["일정 분류"].Value = CboCategory.SelectedItem.ToString();
                row.Cells["중요도"].Value = RdoHigh.Checked ? "높음" :
                                             RdoMiddle.Checked ? "보통" : "낮음";

                scheduleTable.AcceptChanges();
            }
        }

        // 일정 검색
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DataView dv = scheduleTable.DefaultView;
            string dateStart = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string dateEnd = dateTimePicker1.Value.AddDays(1).ToString("yyyy-MM-dd");
            //dv.RowFilter = "날짜 >='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'and 날짜 < '" + dateTimePicker1.Value.AddDays(1.0).ToShortDateString() + "'";
            string filter = $"날짜 >= '{dateStart}' AND 날짜 < '{dateEnd}'";


            if (CboSearchCate.SelectedIndex > 0)
            {
                string selectedCategory = CboSearchCate.SelectedItem.ToString();
                filter += $" AND [일정 분류] = '{selectedCategory}'";
            }
            //dv.RowFilter = $"일정 분류 = ''";
            dv.RowFilter = filter;
            DataTable resultTable = dv.ToTable();

            if (resultTable.Rows.Count == 0)
            {
                // 기존 구조와 동일한 임시 테이블 생성
                DataTable emptyTable = scheduleTable.Clone(); // 컬럼 구조만 복사
                emptyTable.Rows.Add(null, "일정이 없습니다", "", "", "");
                TblSch.DataSource = emptyTable;
            }
            else
            {
                TblSch.DataSource = resultTable;
            }
        }

        // 일정 삭제
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // 체크된 행만 골라서 삭제
            for (int i = TblSch.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = TblSch.Rows[i];
                if (Convert.ToBoolean(row.Cells["chk"].Value) == true)
                {
                    if (row.DataBoundItem is DataRowView drv)
                    {
                        drv.Row.Delete(); // DataTable에서 삭제
                    }
                }
            }

            scheduleTable.AcceptChanges(); // 변경 반영

        }
        // 중요도 표시
        private void TblSch_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (TblSch.Columns[e.ColumnIndex].Name == "중요도" && e.Value != null)
            {
                Console.WriteLine("importance 값: " + e.Value.ToString()); // 로그 확인
                string importance = e.Value.ToString();

                switch (importance)
                {
                    case "높음":
                        e.Value = "★★★";
                        break;
                    case "보통":
                        e.Value = "★★";
                        break;
                    case "낮음":
                        e.Value = "★";
                        break;
                }

                e.FormattingApplied = true;
            }
        }

        // 일정이 있는 날짜에 굵게 표시
        private void CalendarBolding()
        {
            List<DateTime> boldDates = new List<DateTime>();

            foreach (DataRow row in scheduleTable.Rows)
            {
                if (row["날짜"] != DBNull.Value)
                {
                    boldDates.Add((DateTime)row["날짜"]);
                }
            }

            CalToDoList.BoldedDates = boldDates.ToArray();
            CalToDoList.UpdateBoldedDates();
        }

        // 창 종료시 확인
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true; // 종료 취소
            }
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            // 체크된 행을 찾기
            DataRowView selectedRowView = null;

            foreach (DataGridViewRow row in TblSch.Rows)
            {
                if (Convert.ToBoolean(row.Cells["chk"].Value) == true)
                {
                    selectedRowView = row.DataBoundItem as DataRowView;
                    break;
                }
            }

            if (selectedRowView == null)
            {
                MessageBox.Show("수정할 일정을 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            editingRow = selectedRowView.Row;

            // 입력창에 데이터 채우기
            CalToDoList.SetDate((DateTime)editingRow["날짜"]);
            TxtTitle.Text = editingRow["일정 제목"].ToString();
            CboCategory.SelectedItem = editingRow["일정 분류"].ToString();
            TxtContent.Text = editingRow["일정 내용"].ToString();

            string importance = editingRow["중요도"].ToString();
            switch (importance)
            {
                case "높음":
                case "★★★":
                    RdoHigh.Checked = true;
                    break;
                case "보통":
                case "★★":
                    RdoMiddle.Checked = true;
                    break;
                case "낮음":
                case "★":
                    RdoLow.Checked = true;
                    break;
            }
        }
    }
}
