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
            // �⺻������
            Person peachk = new Person();
            peachk.Name = TxtName.Text.Trim();
            peachk.Age = int.Parse(TxtAge.Text.Trim());
            peachk.Gender = char.Parse(TxtGender.Text.Trim());
            peachk.Phone = TxtPhone.Text.Trim();

            // �Ű����� ������
            Person hugo = new Person("����", 40, 'F', "010-0000-0000");

            TxtResult.Text += peachk.ToString();
            peachk.GetUp();
            peachk.GoToSchool();

            // static�� ���� ��ü�� �������� ����
            Person.GetNumber();
        }
    }
}
