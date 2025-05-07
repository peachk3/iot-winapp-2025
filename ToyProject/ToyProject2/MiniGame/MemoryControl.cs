using System.Data;
using System.Diagnostics;

namespace MiniGame
{
    public partial class MemoryControl : UserControl
    {
        private List<Button> cardButtons = new List<Button>();
        private List<string> cardValues = new List<string>();
        private Button firstClicked = null;
        private Button secondClicked = null;
        private System.Windows.Forms.Timer revealTimer = new System.Windows.Forms.Timer();

        // 카드 앞면 보여지는 시간 타이머
        private System.Windows.Forms.Timer showAllTimer = new System.Windows.Forms.Timer();

        // 이미지
        private Image backImage;
        private Dictionary<string, Image> frontImages = new Dictionary<string, Image>();
        private int currentPairs = 3; // 시작 쌍 수
        private const int maxPairs = 8; // 마지막 단계
        private const int startPairs = 3; // 다시 시작할 쌍 수


        public MemoryControl()
        {
            InitializeComponent();
            revealTimer.Interval = 1000;
            revealTimer.Tick += RevealTimer_Tick;
            StartGame();
        }

        private void StartGame()
        {
            ClearBoard();
            LoadImages();
            GenerateCardValues(currentPairs);
            CreateBoard(cardValues.Count);
            ShowAllCardsTemporarily();
        }

        private void ClearBoard()
        {
            foreach (var btn in cardButtons)
                this.Controls.Remove(btn);

            cardButtons.Clear();
            cardValues.Clear();
            firstClicked = null;
            secondClicked = null;
        }

        private void LoadImages()
        {
            frontImages.Clear();
            for (int i = 1; i <= currentPairs; i++)
            {
                string path = $"image/mini{i}.png";
                frontImages[i.ToString()] = Image.FromFile(path);
            }

            backImage = Image.FromFile("image/back.jpg");
        }


        private void GenerateCardValues(int pairCount)
        {
            cardValues.Clear();
            for (int i = 1; i <= pairCount; i++)
            {
                cardValues.Add(i.ToString());
                cardValues.Add(i.ToString());
            }

            var rng = new Random();
            cardValues = cardValues.OrderBy(x => rng.Next()).ToList();
        }

        private void CreateBoard(int totalCards)
        {

            int columns = (int)Math.Ceiling(Math.Sqrt(totalCards));
            int rows = (int)Math.Ceiling((double)totalCards / columns);
            int btnSize = 80;
            int spacing = 10;
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns && index < totalCards; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(btnSize, btnSize);
                    btn.Location = new Point(j * (btnSize + spacing), i * (btnSize + spacing));
                    btn.Tag = cardValues[index];
                    btn.BackgroundImage = frontImages[cardValues[index]];
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.Click += Card_Click;
                    this.Controls.Add(btn);
                    cardButtons.Add(btn);
                    index++;
                }
            }
        }

        private void ShowAllCardsTemporarily()
        {
            foreach (var btn in cardButtons)
            {
                string tag = btn.Tag.ToString();
                btn.BackgroundImage = frontImages[tag]; // 앞면 표시
            }

            showAllTimer.Interval = 3000;
            showAllTimer.Tick += HideAllCards;
            showAllTimer.Start();
        }

        private void HideAllCards(object sender, EventArgs e)
        {
            showAllTimer.Stop();
            showAllTimer.Tick -= HideAllCards;

            foreach (var btn in cardButtons)
            {
                btn.BackgroundImage = backImage; // 뒷면으로
            }
        }


        private void Card_Click(object sender, EventArgs e)
        {
            Button clicked = sender as Button;

            if (clicked == null || clicked.BackgroundImage != backImage || revealTimer.Enabled)
                return;

            string tag = clicked.Tag.ToString();
            clicked.BackgroundImage = frontImages[tag];

            if (firstClicked == null)
            {
                firstClicked = clicked;
                return;
            }

            secondClicked = clicked;

            if (firstClicked.Tag.ToString() == secondClicked.Tag.ToString())
            {
                firstClicked = null;
                secondClicked = null;

                bool allMatched = cardButtons.All(b => b.BackgroundImage != backImage);

                if (allMatched)
                {
                    if (currentPairs == 8)
                    {
                        MessageBox.Show("클리어! 처음으로 돌아갑니다.", "게임 클리어");
                        currentPairs = startPairs; // 3쌍으로 초기화
                        StartGame();
                    }
                    else
                    {
                        MessageBox.Show("성공! 다음 단계로 갑니다.", "게임 결과");
                        currentPairs = currentPairs == 3 ? 6 : 8; // 3 → 6 → 8
                        StartGame();
                    }
                }
            }
            else
            {
                revealTimer.Start(); // 틀림 → 다시 가리기
            }
        }

        private void RevealTimer_Tick(object sender, EventArgs e)
        {
            revealTimer.Stop();
            firstClicked.BackgroundImage = backImage;
            secondClicked.BackgroundImage = backImage;
            firstClicked = null;
            secondClicked = null;
        }
    }
}
