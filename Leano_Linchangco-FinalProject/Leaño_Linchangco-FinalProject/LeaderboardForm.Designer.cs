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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(161, 9);
            label1.Name = "label1";
            label1.Size = new Size(499, 79);
            label1.TabIndex = 3;
            label1.Text = "LEADER BOARD";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstbxLeaderBoard
            // 
            lstbxLeaderBoard.BackColor = Color.White;
            lstbxLeaderBoard.Font = new Font("MS Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstbxLeaderBoard.FormattingEnabled = true;
            lstbxLeaderBoard.Location = new Point(161, 101);
            lstbxLeaderBoard.Name = "lstbxLeaderBoard";
            lstbxLeaderBoard.Size = new Size(499, 316);
            lstbxLeaderBoard.TabIndex = 4;
            // 
            // LeaderboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstbxLeaderBoard);
            Controls.Add(label1);
            Name = "LeaderboardForm";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstbxLeaderBoard;
    }
}