namespace SyntaxWinApp02
{
    public partial class FrnMain : Form
    {
        public FrnMain()
        {
            InitializeComponent();
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            // 연산자 : =, +, -, *, /, %, ^, +=, -=., *=
            // &&, ||, &, |, ^, !
            int val = 2 ^ 10;

            int result = 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2;

            //MessageBox.Show(((3 > 2) && (10 < 9)).ToString(), "알림", MessageBoxButtons.OK);
            MessageBox.Show(result.ToString(), "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
