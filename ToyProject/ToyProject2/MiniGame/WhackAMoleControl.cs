using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace MiniGame
{
    public partial class WhackAMoleControl : UserControl
    {

        // 필드 선언
        private Button[,] moleButtons = new Button[4, 4]; // 4x4 버튼 배열
        private System.Windows.Forms.Timer moleTimer = new System.Windows.Forms.Timer();
        private Random rand = new Random();
        private Label LblScore = new Label();
        private int score = 0;
        private int gameTime = 30;
        private System.Windows.Forms.Timer gameTimer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer hitTimer = new System.Windows.Forms.Timer();
        private Button hitButton = null;

        Image moleImage = Image.FromFile("image/mole.png"); // 상대경로 기준


        public WhackAMoleControl()
        {
            InitializeComponent();
            StartWhackAMoleGame();
        }

        private void StartWhackAMoleGame()
        {
            int buttonSize = 90; // 버튼 크기 설정
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(buttonSize, buttonSize);
                    btn.Location = new Point(col * buttonSize, row * buttonSize);
                    btn.Click += Mole_Click; // 클릭 이벤트 연결
                    moleButtons[row, col] = btn;
                    Controls.Add(btn);
                }
            }
            moleTimer.Interval = 700;
            moleTimer.Tick += MoleTimer_Tick;
            moleTimer.Start();

            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();
        }


        // 두더지 등장
        private void MoleTimer_Tick(object sender, EventArgs e)
        {
            // 모든 버튼 초기화
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    moleButtons[row, col].BackgroundImage = null;
                    moleButtons[row, col].Tag = null;
                }
            }

            // 랜덤 위치에 두더지 등장
            int moleRow = rand.Next(4);
            int moleCol = rand.Next(4);

            moleButtons[moleRow, moleCol].BackgroundImage = moleImage;
            moleButtons[moleRow, moleCol].BackgroundImageLayout = ImageLayout.Stretch;
            moleButtons[moleRow, moleCol].Tag = "mole";
        }

        // 점수 획득
        private void Mole_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn.Tag != null && btn.Tag.ToString() == "mole")
            {
                score++;
                LblScore.Text = $"점수: {score}";

                // 일단 두더지를 숨기고 타이머로 다시 갱신
                btn.BackgroundImage = null;
                btn.Tag = null;

                hitButton = btn;
                hitTimer.Interval = 700; // 0.7초 후 재설정
                hitTimer.Start();
            }
        }

        // 게임 시간 관리
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            gameTime--;
            if (gameTime <= 0)
            {
                moleTimer.Stop();
                gameTimer.Stop();
                MessageBox.Show($"게임 종료!\n 점수: {score}점", "게임 결과");
            }
        }
        private void HitTimer_Tick(object sender, EventArgs e)
        {
            hitTimer.Stop();

            if (hitButton != null)
            {
                hitButton.BackgroundImage = moleImage;
                hitButton.BackgroundImageLayout = ImageLayout.Stretch;
                hitButton.Tag = "mole";
            }

            hitButton = null;
        }

    }
}
