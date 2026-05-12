namespace Leaño_Linchangco_FinalProject
{
    public partial class Form1 : Form
    {
        private Image cardBack = Properties.Resources.Back;

        private List<Image> icons = new List<Image>();
        private void LoadResources()
        {
            List<Image> faces = new List<Image>
            {
                Properties.Resources.Pierro, Properties.Resources.Capitano,
                Properties.Resources.Dottore, Properties.Resources.Columbina,
                Properties.Resources.Arlecchino, Properties.Resources.Pulcinella,
                Properties.Resources.Scaramouche, Properties.Resources.Sandrone,
                Properties.Resources.Signora, Properties.Resources.Pantalone,
                Properties.Resources.Descender, Properties.Resources.Tartaglia
            };
            foreach (var face in faces)
            {
                icons.Add(face);
                icons.Add(face); // add pairs
            }
        }

        private Button firstClicked;
        private Button secondClicked;
        private int score = 100;
        private bool isFlipping = false;
        private bool isBusy = false;
        private string currentPlayerName;
        private int consecutiveMatches = 0;

        public Form1()
        {
            InitializeComponent();
            using (PlayerForm pf = new PlayerForm())
            {
                if (pf.ShowDialog() != DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }

                currentPlayerName = pf.PlayerName;
            }

            AssignIconsToButtons();
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();
        }

        private void AssignIconsToButtons()
        {
            LoadResources();
            Random random = new Random();
            while (icons.Count > 0)
            {
                int index = random.Next(icons.Count);
                Image selectedImage = icons[index];
                Button btn = new Button
                {
                    Dock = DockStyle.Fill,
                    BackgroundImage = cardBack,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Tag = selectedImage,
                    Margin = new Padding(5)
                };

                icons.RemoveAt(index);
                btn.Click += Card_Click;
                tableLayoutPanel1.Controls.Add(btn);
            }
        }

        // Flip animation
        private async Task FlipCard(Button btn, bool isFaceUp)
        {
            isFlipping = true;
            int originalWidth = btn.Width;
            int originalLeft = btn.Left;

            // squeeze card size
            for (int i = originalWidth; i > 0; i -= 20)
            {
                btn.Width = i;
                btn.Left += 10;
                await Task.Delay(10);
            }

            // change card face
            if (isFaceUp)
            {
                btn.BackgroundImage = (Image)btn.Tag;
            }
            else
            {
                btn.BackgroundImage = Properties.Resources.Back;
            }

            // expand card size back to original
            for (int i = 0; i < originalWidth; i += 15)
            {
                btn.Width = i;
                btn.Left -= 7;
                await Task.Delay(10);
            }

            btn.Width = originalWidth;
            isFlipping = false;
        }

        private async void Card_Click(object sender, EventArgs e)
        {
            if (isBusy || isFlipping) return;   // Added isBusy for extra safety.

            Button clickedBtn = sender as Button;
            if (clickedBtn == null || clickedBtn == firstClicked) return;

            if (clickedBtn.Enabled == false) return;

            if (firstClicked == null)
            {
                firstClicked = clickedBtn;
                await FlipCard(firstClicked, true);
                return;
            }

            if (clickedBtn == firstClicked) return;

            secondClicked = clickedBtn;
            await FlipCard(secondClicked, true);

            // Prevents further clicks until match check.
            isBusy = true;
            await CheckForMatch();
            isBusy = false;
        }

        private async Task CheckForMatch()
        {
            if (firstClicked.Tag == secondClicked.Tag)
            {
                // Combo increase
                consecutiveMatches++;

                // Base score increase
                int baseGain = 10;

                // Combo Multiplier (1.5x)
                double multiplier = Math.Pow(1.5, consecutiveMatches - 1);
                int gainedScore = (int)(baseGain * multiplier);
                score += gainedScore;
                UpdateScore();

                firstClicked.Enabled = false;
                secondClicked.Enabled = false;

                firstClicked = null;
                secondClicked = null;
                CheckWin();
            }
            else
            {
                // Reset combo
                consecutiveMatches = 0;

                UpdateScore();

                await Task.Delay(750); // Let the player see their mistake

                await FlipCard(firstClicked, false);
                await FlipCard(secondClicked, false);

                firstClicked = null;
                secondClicked = null;
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (score > 10)
            {
                score--;
                UpdateScore();
            }
        }

        private void UpdateScore()
        {
            lblScore.Text = "Score: " + score + "PTS";
        }

        private void CheckWin()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Button btn && btn.Enabled == true)
                    return;
            }
            gameTimer.Stop();
            MessageBox.Show($"Congratulations {currentPlayerName} ! You completed the board!\nFinal Score: {score}");

            // save high score
            ScoreManager.SaveScore(currentPlayerName, score);

            // show leaderboards
            ShowLeaderboard();

            //ReturnToPlayerForm();
        }

        private void ResetGame()
        {
            gameTimer.Stop();

            // Clear buttons and reset variables
            firstClicked = null;
            secondClicked = null;
            score = 100;
            consecutiveMatches = 0;
            UpdateScore();

            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.ColumnCount = 6;

            for (int i = 0; i < 4; i++)
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25f));
            for (int i = 0; i < 6; i++)
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66f));

            icons.Clear();
            LoadResources();
            AssignIconsToButtons();

            gameTimer.Start();
        }
        private void ReturnToPlayerForm()
        {
            this.Hide(); // hide game form

            using (PlayerForm pf = new PlayerForm())
            {
                if (pf.ShowDialog() != DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }

                currentPlayerName = pf.PlayerName;
            }

            // restart game state
            ResetGame();

            this.Show(); // show game again
        }
        private void ShowLeaderboard()
        {
            LeaderboardForm lb = new LeaderboardForm();
            lb.ShowDialog();

            ReturnToPlayerForm();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit? Your progress will be lost!", "Return to menu?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                gameTimer.Stop();
                ReturnToPlayerForm();
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset the board?","Reset Board",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ResetGame();
            }
        }
    }
}
