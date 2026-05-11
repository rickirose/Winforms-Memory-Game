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
            for (int i=0; i<24; i++)
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

            }
        }
    }
}
