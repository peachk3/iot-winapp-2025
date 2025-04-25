using System.Data;
using System.Windows.Forms;

namespace WinFormPractice
{
    public partial class FrmMain : Form
    {
        private DataTable scheduleTable = new DataTable();

        public FrmMain()
        {
            InitializeComponent();

            scheduleTable.Columns.Add("날짜/시간", typeof(DateTime));
            scheduleTable.Columns.Add("일정 제목", typeof(string));
            scheduleTable.Columns.Add("일정 내용", typeof(string));
            scheduleTable.Columns.Add("중요도", typeof(string));

            TblSch.DataSource = scheduleTable;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true; // 종료 취소
            }
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            DateTime schDate = CalToDoList.SelectionStart;
            string schTitle = TxtTitle.Text;
            string schContent = TxtContent.Text;
            string importance = RdoHigh.Checked ? RdoHigh.Text :
                                RdoMiddle.Checked ? RdoMiddle.Text :
                                RdoLow.Checked ? RdoLow.Text : RdoMiddle.Text;

            scheduleTable.Rows.Add(schDate, schTitle, schContent, importance);

            TxtResult.Text = $"{schDate:yyyy-MM-dd}\r\n{schTitle}\r\n{schContent}\r\n{importance}";

            CalendarBolding();
        }


        private void CalendarBolding(){

            List<DateTime> boldDates = new List<DateTime>();

            foreach (DataRow row in scheduleTable.Rows)
            {
                if (row["날짜/시간"] != DBNull.Value)
                {
                    boldDates.Add((DateTime)row["날짜/시간"]);
                }
            }

            CalToDoList.BoldedDates = boldDates.ToArray();
            CalToDoList.UpdateBoldedDates();
        }

    }
}
