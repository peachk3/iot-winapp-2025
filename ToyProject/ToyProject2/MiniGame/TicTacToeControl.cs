﻿namespace MiniGame
{
    public partial class TicTacToeControl : UserControl
    {
        private Button[,] buttons = new Button[3, 3]; // 3x3 버튼 배열
        private bool isPlayerX = true; // 현재 플레이어가 X인지 O인지 구분
        private Image xImage; // X 이미지
        private Image oImage; // O 이미지

        public TicTacToeControl()
        {
            InitializeComponent();
            LoadImages();
            CreateBoard();
        }
        private void LoadImages()
        {
            //리소스에서 X, O 이미지를 불러옴
            xImage = Image.FromFile("image/mini_X.png");
            oImage = Image.FromFile("image/mini_O.png");
        }

        private void CreateBoard()
        {
            int buttonSize = 120; // 버튼 크기 설정
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(buttonSize, buttonSize);
                    btn.Location = new Point(col * buttonSize, row * buttonSize);
                    btn.Click += Button_Click; // 클릭 이벤트 연결
                    btn.BackgroundImageLayout = ImageLayout.Stretch; // 이미지가 버튼에 맞게 조정되도록 설정
                    buttons[row, col] = btn;
                    Controls.Add(btn);
                }
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton.BackgroundImage == null) // 이미 선택된 칸은 클릭하지 않도록
            {
                clickedButton.BackgroundImage = isPlayerX ? xImage : oImage; // X 또는 O 표시
                if (CheckWin()) // 승리 조건 체크
                {
                    MessageBox.Show($"{(isPlayerX ? "X" : "O")} 승리!", "게임 종료");
                    ResetBoard(); // 게임 종료 후 보드 초기화
                }
                isPlayerX = !isPlayerX; // 플레이어 전환
            }
        }

        private bool CheckWin()
        {
            // 가로, 세로, 대각선 승리 조건 체크
            for (int i = 0; i < 3; i++)
            {
                // 가로
                if (buttons[i, 0].BackgroundImage != null && buttons[i, 0].BackgroundImage == buttons[i, 1].BackgroundImage && buttons[i, 1].BackgroundImage == buttons[i, 2].BackgroundImage)
                    return true;
                // 세로
                if (buttons[0, i].BackgroundImage != null && buttons[0, i].BackgroundImage == buttons[1, i].BackgroundImage && buttons[1, i].BackgroundImage == buttons[2, i].BackgroundImage)
                    return true;
            }
            // 대각선
            if (buttons[0, 0].BackgroundImage != null && buttons[0, 0].BackgroundImage == buttons[1, 1].BackgroundImage && buttons[1, 1].BackgroundImage == buttons[2, 2].BackgroundImage)
                return true;
            if (buttons[0, 2].BackgroundImage != null && buttons[0, 2].BackgroundImage == buttons[1, 1].BackgroundImage && buttons[1, 1].BackgroundImage == buttons[2, 0].BackgroundImage)
                return true;

            return false;
        }

        private void ResetBoard()
        {
            // 보드 초기화
            foreach (var button in buttons)
            {
                button.Text = "";
            }
            isPlayerX = true; // X부터 시작
        }
    }
}
