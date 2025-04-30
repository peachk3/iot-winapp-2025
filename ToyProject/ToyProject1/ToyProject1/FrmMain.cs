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

        // DataTable ���� ����
        private void InitializeScheduleTable()
        {
            scheduleTable.Columns.Add("��¥", typeof(DateTime));
            scheduleTable.Columns.Add("���� ����", typeof(string));
            scheduleTable.Columns.Add("���� �з�", typeof(string));
            scheduleTable.Columns.Add("���� ����", typeof(string));
            scheduleTable.Columns.Add("�߿䵵", typeof(string));
            TblSch.DataSource = scheduleTable;
        }
        // ������ư/�޺��ڽ� ���� + DataGridView ����
        private void InitializeControls()
        {
            RdoHigh.Text = "����";
            RdoMiddle.Text = "����";
            RdoLow.Text = "����";

            string[] categories = {"����", "����", "����", "ģ��", "��Ÿ" };
            string[] searchCategories = { "", "����", "����", "����", "ģ��", "��Ÿ" };

            CboCategory.Items.AddRange(categories);
            CboSearchCate.Items.AddRange(searchCategories);
            CboCategory.SelectedIndex = 0;
            CboSearchCate.SelectedIndex = 0;

            TblSch.RowHeadersVisible = false;
            TblSch.AllowUserToAddRows = false;
            AddCheckboxColumn();
            // �߿䵵 ������
            TblSch.CellFormatting += TblSch_CellFormatting;
            BtnModify.Click += BtnModify_Click;

        }

        // üũ�ڽ� �� �߰�
        private void AddCheckboxColumn()
        {
            // �̹� �߰��Ǿ� ���� ���� ��쿡�� �߰�
            if (!TblSch.Columns.Contains("chk"))
            {
                DataGridViewCheckBoxColumn chkCol = new DataGridViewCheckBoxColumn();
                chkCol.Name = "chk";
                chkCol.HeaderText = "";
                chkCol.Width = 30;
                chkCol.ReadOnly = false;
                chkCol.TrueValue = true;
                chkCol.FalseValue = false;

                TblSch.Columns.Insert(0, chkCol); // ���� �տ� ����
            }
        }

        // ���� ���
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
                MessageBox.Show("���� ������ �Է��ϼ���.", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else if (string.IsNullOrWhiteSpace(schCategory))
            {
                MessageBox.Show("���� �з��� �����ϼ���.", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrWhiteSpace(schContent))
            {
                MessageBox.Show("���� ������ �Է��ϼ���.", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (editingRow != null)
            {
                // ���� �� ����
                editingRow["��¥"] = schDate;
                editingRow["���� ����"] = schTitle;
                editingRow["���� �з�"] = schCategory;
                editingRow["���� ����"] = schContent;
                editingRow["�߿䵵"] = importance;

                editingRow = null; // ���� �Ϸ� �� �ʱ�ȭ
            }
            else
            {
                scheduleTable.Rows.Add(schDate, schTitle, schCategory, schContent, importance);
            }
            CalendarBolding();
            ClearInputFields();
        }

        // �Է� �ʵ� �ʱ�ȭ
        private void ClearInputFields()
        {
            TxtTitle.Clear();
            TxtContent.Clear();
            CboCategory.SelectedIndex = 0;
            RdoMiddle.Checked = true;
        }


        // �߿䵵 ����
        private void BtnSortByImportance_Click(object sender, EventArgs e)
        {
            DataView dv = scheduleTable.DefaultView;
            dv.Sort = "�߿䵵 DESC";
            TblSch.DataSource = dv.ToTable();
        }

        // ���� ����
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TblSch.SelectedRows.Count > 0)
            {
                var row = TblSch.SelectedRows[0];
                row.Cells["���� ����"].Value = TxtTitle.Text;
                row.Cells["���� ����"].Value = TxtContent.Text;
                //row.Cells["���� �з�"].Value = CboCategory.SelectedItem.ToString();
                row.Cells["�߿䵵"].Value = RdoHigh.Checked ? "����" :
                                             RdoMiddle.Checked ? "����" : "����";

                scheduleTable.AcceptChanges();
            }
        }

        // ���� �˻�
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DataView dv = scheduleTable.DefaultView;
            string dateStart = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string dateEnd = dateTimePicker1.Value.AddDays(1).ToString("yyyy-MM-dd");
            //dv.RowFilter = "��¥ >='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'and ��¥ < '" + dateTimePicker1.Value.AddDays(1.0).ToShortDateString() + "'";
            string filter = $"��¥ >= '{dateStart}' AND ��¥ < '{dateEnd}'";


            if (CboSearchCate.SelectedIndex > 0)
            {
                string selectedCategory = CboSearchCate.SelectedItem.ToString();
                filter += $" AND [���� �з�] = '{selectedCategory}'";
            }
            //dv.RowFilter = $"���� �з� = ''";
            dv.RowFilter = filter;
            DataTable resultTable = dv.ToTable();

            if (resultTable.Rows.Count == 0)
            {
                // ���� ������ ������ �ӽ� ���̺� ����
                DataTable emptyTable = scheduleTable.Clone(); // �÷� ������ ����
                emptyTable.Rows.Add(null, "������ �����ϴ�", "", "", "");
                TblSch.DataSource = emptyTable;
            }
            else
            {
                TblSch.DataSource = resultTable;
            }
        }

        // ���� ����
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // üũ�� �ุ ��� ����
            for (int i = TblSch.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = TblSch.Rows[i];
                if (Convert.ToBoolean(row.Cells["chk"].Value) == true)
                {
                    if (row.DataBoundItem is DataRowView drv)
                    {
                        drv.Row.Delete(); // DataTable���� ����
                    }
                }
            }

            scheduleTable.AcceptChanges(); // ���� �ݿ�

        }
        // �߿䵵 ǥ��
        private void TblSch_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (TblSch.Columns[e.ColumnIndex].Name == "�߿䵵" && e.Value != null)
            {
                Console.WriteLine("importance ��: " + e.Value.ToString()); // �α� Ȯ��
                string importance = e.Value.ToString();

                switch (importance)
                {
                    case "����":
                        e.Value = "�ڡڡ�";
                        break;
                    case "����":
                        e.Value = "�ڡ�";
                        break;
                    case "����":
                        e.Value = "��";
                        break;
                }

                e.FormattingApplied = true;
            }
        }

        // ������ �ִ� ��¥�� ���� ǥ��
        private void CalendarBolding()
        {
            List<DateTime> boldDates = new List<DateTime>();

            foreach (DataRow row in scheduleTable.Rows)
            {
                if (row["��¥"] != DBNull.Value)
                {
                    boldDates.Add((DateTime)row["��¥"]);
                }
            }

            CalToDoList.BoldedDates = boldDates.ToArray();
            CalToDoList.UpdateBoldedDates();
        }

        // â ����� Ȯ��
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("�����Ͻðڽ��ϱ�?", "����", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true; // ���� ���
            }
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            // üũ�� ���� ã��
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
                MessageBox.Show("������ ������ �����ϼ���.", "�˸�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            editingRow = selectedRowView.Row;

            // �Է�â�� ������ ä���
            CalToDoList.SetDate((DateTime)editingRow["��¥"]);
            TxtTitle.Text = editingRow["���� ����"].ToString();
            CboCategory.SelectedItem = editingRow["���� �з�"].ToString();
            TxtContent.Text = editingRow["���� ����"].ToString();

            string importance = editingRow["�߿䵵"].ToString();
            switch (importance)
            {
                case "����":
                case "�ڡڡ�":
                    RdoHigh.Checked = true;
                    break;
                case "����":
                case "�ڡ�":
                    RdoMiddle.Checked = true;
                    break;
                case "����":
                case "��":
                    RdoLow.Checked = true;
                    break;
            }
        }
    }
}
