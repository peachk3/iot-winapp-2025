namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // 기본생성자
            Person peachk = new Person();
            peachk.Name = TxtName.Text.Trim();
            peachk.Age = int.Parse(TxtAge.Text.Trim());
            peachk.Gender = char.Parse(TxtGender.Text.Trim());
            peachk.Phone = TxtPhone.Text.Trim();

            // 매개변수 생성자
            Person hugo = new Person("유고", 40, 'F', "010-0000-0000");

            TxtResult.Text += peachk.ToString();
            peachk.GetUp();
            peachk.GoToSchool();

            // static일 경우는 객체를 생성하지 않음
            Person.GetNumber();
        }
    }
}
