namespace MiniGame
{
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
        }
        private void LoadGame(UserControl gameControl)
        {
            panelGameArea.Controls.Clear();
            gameControl.Dock = DockStyle.Fill;
            panelGameArea.Controls.Add(gameControl);
        }

        private void ShowGame(UserControl gameControl)
        {
            panelGameArea.Controls.Clear();
            gameControl.Dock = DockStyle.Fill;
            panelGameArea.Controls.Add(gameControl);
        }

        private void BtnTicTacToe_Click(object sender, EventArgs e)
        {
            LoadGame(new TicTacToeControl());
        }

        private void BtnMemory_Click(object sender, EventArgs e)
        {
            ShowGame(new MemoryControl());

        }
    }
}
