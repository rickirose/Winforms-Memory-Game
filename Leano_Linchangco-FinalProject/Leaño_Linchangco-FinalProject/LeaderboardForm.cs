using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leaño_Linchangco_FinalProject
{
    public partial class LeaderboardForm : Form
    {
        public LeaderboardForm()
        {
            InitializeComponent();
            LoadLeaderboard();
        }

        private void LoadLeaderboard()
        {
            var scores = ScoreManager.GetTopScores();

            lstbxLeaderBoard.Items.Clear();

            int rank = 1;
            foreach (var s in scores)
            {
                lstbxLeaderBoard.Items.Add($"{rank}. {s.Name} - {s.Score}");
                rank++;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
