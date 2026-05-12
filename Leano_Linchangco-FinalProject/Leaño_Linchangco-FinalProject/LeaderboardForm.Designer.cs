namespace Leaño_Linchangco_FinalProject
{
    partial class LeaderboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lstbxLeaderBoard = new ListBox();
            btnMenu = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(528, 73);
            label1.TabIndex = 3;
            label1.Text = "LEADERBOARD";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstbxLeaderBoard
            // 
            lstbxLeaderBoard.BackColor = Color.Black;
            lstbxLeaderBoard.Font = new Font("MS Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstbxLeaderBoard.ForeColor = SystemColors.MenuBar;
            lstbxLeaderBoard.FormattingEnabled = true;
            lstbxLeaderBoard.Location = new Point(29, 105);
            lstbxLeaderBoard.Name = "lstbxLeaderBoard";
            lstbxLeaderBoard.Size = new Size(499, 379);
            lstbxLeaderBoard.TabIndex = 4;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Black;
            btnMenu.Font = new Font("MS Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = SystemColors.Control;
            btnMenu.Location = new Point(113, 514);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(325, 57);
            btnMenu.TabIndex = 13;
            btnMenu.Text = "RETURN TO MENU";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // LeaderboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(558, 601);
            Controls.Add(btnMenu);
            Controls.Add(lstbxLeaderBoard);
            Controls.Add(label1);
            Name = "LeaderboardForm";
            Text = "Leaderboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstbxLeaderBoard;
        private Button btnMenu;
    }
}