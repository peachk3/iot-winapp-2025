namespace SyntaxWinApp04
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnMessage_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "" || TxtAge.Text == "")
            {
                MessageBox.Show("���� ä���ּ���.");
                return;
            }
            else
            {
                // ���� ������ ���� �� ����
                LblResult.Text = "ó����� : ";
                TxtResult.Text= "ó�� ����";
            }
        }
    }
}
