namespace Leaño_Linchangco_FinalProject
{
    public partial class Form1 : Form
    {
        private List<string> icons = new List<string>()
        {
            "Pierro", "Pierro", "Capitano", "Capitano", "Dottore", "Dottore",
            "Columbina", "Columbina", "Arlecchino", "Arlecchino", "Pulchinella", "Pulchinella",
            "Scaramouche", "Scaramouche", "Sandrone", "Sandrone", "Signora", "Signora",
            "Pantalone", "Pantalone", "Descender", "Descender", "Tartaglia", "Tartaglia"
        };

        private Button firstClicked;
        private Button secondClicked;
        private int timeLeft = 120; //2 mins
        private bool isFlipping = false;

        public Form1()
        {
            InitializeComponent();
            AssignIconsToButtons();
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();
        }

        private void AssignIconsToButtons()
        {
            Random random = new Random();
            for (int i = 0; i < 24; i++)
            {
                Button btn = new Button
                {
                    Dock = DockStyle.Fill,
                    Font = new Font("Arial", 24, FontStyle.Bold),
                    Text = "",
                    BackColor = Color.LightBlue,
                    Tag = icons[random.Next(icons.Count)],
                    Margin = new Padding(5)
                };
                icons.Remove((string)btn.Tag);
                btn.Click += Card_Click;
                tableLayoutPanel1.Controls.Add(btn, i % 6, i / 6);
            }
        }

        // Flip animation
        private async Task FlipCard(Button btn, bool isFaceUp)
        {
            isFlipping = true;
            int originalWidth = btn.Width;

            // squeeze card size
            for (int i = originalWidth; i > 0; i -= 15)
            {
                btn.Width = i;
                btn.Left += 7;
                await Task.Delay(10);
            }

            // change card face
            if (isFaceUp)
            {
                btn.Text = btn.Tag.ToString();
                btn.BackColor = Color.White;
            }
            else
            {
                btn.Text = "";
                btn.BackColor = Color.LightBlue;
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
            if (isFlipping) return;

            Button clickedBtn = sender as Button;
            if (clickedBtn == null || clickedBtn.Text != "") return;

            if (firstClicked == null)
            {
                firstClicked = clickedBtn;
                await FlipCard(firstClicked, true);
                return;
            }

            secondClicked = clickedBtn;
            await FlipCard(secondClicked, true);

            CheckForMatch();
        }

        private async void CheckForMatch()
        {
            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
                CheckWin();
            }
            else
            {
                timeLeft -= 5; // Lose 5 points/seconds
                UpdateScore();

                await Task.Delay(1000); // Let the player see their mistake

                await FlipCard(firstClicked, false);
                await FlipCard(secondClicked, false);

                firstClicked = null;
                secondClicked = null;
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            UpdateScore();

            if (timeLeft <= 0)
            {
                gameTimer.Stop();
                MessageBox.Show("Time's up! You lose!");
                ResetGame();
            }
        }

        private void UpdateScore()
        {
            // lblScore.Text = something to show score
        }

        private void CheckWin()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Button btn = control as Button;
                if (btn != null && btn.Text == "")
                    return;
            }
            gameTimer.Stop();
            MessageBox.Show("Congratulations! You win!");
            // save high score
            ResetGame();
        }

        private void ResetGame()
        {
            // Clear buttons and reset variables
            firstClicked = null;
            secondClicked = null;
            timeLeft = 120;
            UpdateScore();
            tableLayoutPanel1.Controls.Clear();
            icons = new List<string>()
            {
                "Pierro", "Pierro", "Capitano", "Capitano", "Dottore", "Dottore",
                "Columbina", "Columbina", "Arlecchino", "Arlecchino", "Pulchinella", "Pulchinella",
                "Scaramouche", "Scaramouche", "Sandrone", "Sandrone", "Signora", "Signora",
                "Pantalone", "Pantalone", "Descender", "Descender", "Tartaglia", "Tartaglia"
            };
            AssignIconsToButtons();
            gameTimer.Start();

        }
    }
}
