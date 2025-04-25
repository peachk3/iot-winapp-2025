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

            scheduleTable.Columns.Add("��¥/�ð�", typeof(DateTime));
            scheduleTable.Columns.Add("���� ����", typeof(string));
            scheduleTable.Columns.Add("���� ����", typeof(string));
            scheduleTable.Columns.Add("�߿䵵", typeof(string));

            TblSch.DataSource = scheduleTable;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("�����Ͻðڽ��ϱ�?", "����", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true; // ���� ���
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
                if (row["��¥/�ð�"] != DBNull.Value)
                {
                    boldDates.Add((DateTime)row["��¥/�ð�"]);
                }
            }

            CalToDoList.BoldedDates = boldDates.ToArray();
            CalToDoList.UpdateBoldedDates();
        }

    }
}
