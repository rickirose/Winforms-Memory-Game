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
    public partial class PlayerForm : Form
    {
        public string PlayerName { get; private set; }
        public PlayerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a name!");
                return;
            }

            PlayerName = textBox1.Text.Trim();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnPlay.Enabled = !string.IsNullOrWhiteSpace(textBox1.Text);
        }
    }
}
