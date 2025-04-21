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
                MessageBox.Show("값을 채워주세요.");
                return;
            }
            else
            {
                // 위의 문제가 없을 때 동작
                LblResult.Text = "처리결과 : ";
                TxtResult.Text= "처리 예정";
            }
        }
    }
}
