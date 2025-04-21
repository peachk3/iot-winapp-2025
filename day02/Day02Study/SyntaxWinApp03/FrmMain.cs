namespace SyntaxWinApp03
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            // �б⹮
            if (TxtPain.Text == "�ƴϿ�")
            {
                MessageBox.Show("���� ���ư�����.");
            }
            else if (TxtPain.Text == "��")
            {
                string PainPoint = CboPainPoint.SelectedItem.ToString();

                // switch ��
                switch (PainPoint)
                {
                    case "�Ӹ�":
                        MessageBox.Show("�Ű���� ���ϴ�", "����� ����");
                        break;
                    case "��":
                        MessageBox.Show("�Ȱ��� ���ϴ�", "����� ����");
                        break;
                    case "��":
                        MessageBox.Show("�̺����İ��� ���ϴ�", "����� ����");
                        break;
                    case "��":
                        MessageBox.Show("�̺����İ��� ���ϴ�", "����� ����");
                        break;
                    case "����":
                        MessageBox.Show("������ ���ϴ�", "����� ����");
                        break;
                    case "��":
                        MessageBox.Show("��ȭ���� ���ϴ�", "����� ����");
                        break;
                    default:
                        break;
                }
            }


            //MessageBox.Show("Hello, World!", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TxtPain_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Ű���������� ���͸� �Է��ϸ� C, C++ i���� ����
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show(TxtPain.Text, "�Է°�");
            }
        }

        private void CboPainPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPoint = CboPainPoint.SelectedItem.ToString();
            MessageBox.Show(selectedPoint, "��������");
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            // for��
            for (int x = 2; x < 10; x++)
            {
                for (int y = 1; y < 10; y++)
                {
                    var result = x + "x" + y + "=" + (x * y);

                    TxtResult.Text += result + " ";
                }
                TxtResult.Text += "\r\n";   // ���� ������� \r\n�� ���� ��� ��
            }
        }

        int clickNum = 0;

        private void BtnWhile_Click(object sender, EventArgs e)
        {
            // ���ѹݺ�
            while (true)
            {
                MessageBox.Show("��� " + clickNum);
                clickNum++;

                if (clickNum == 10)
                {
                    break; // �ݺ��� Ż�� for, while, do while
                    //continue; �� �ľ��� ��
                    // goto;�� �����ϸ� ���� �� ��
                }
            }
        }
    }
}
