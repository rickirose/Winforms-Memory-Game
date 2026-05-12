namespace Leaño_Linchangco_FinalProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblScore = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            btnRestart = new Button();
            btnMenu = new Button();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.IndianRed;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Font = new Font("Microsoft Sans Serif", 5.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(15, 82);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(657, 426);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("MS Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.ForeColor = SystemColors.Menu;
            lblScore.Location = new Point(249, 520);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(192, 24);
            lblScore.TabIndex = 1;
            lblScore.Text = "Score: 100 PTS";
            // 
            // gameTimer
            // 
            gameTimer.Interval = 1000;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(71, 6);
            label1.Name = "label1";
            label1.Size = new Size(529, 73);
            label1.TabIndex = 3;
            label1.Text = "MEM-MATCHER";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.Firebrick;
            btnRestart.Font = new Font("MS Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestart.ForeColor = SystemColors.Control;
            btnRestart.Location = new Point(15, 556);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(325, 57);
            btnRestart.TabIndex = 11;
            btnRestart.Text = "RESTART";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Firebrick;
            btnMenu.Font = new Font("MS Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = SystemColors.Control;
            btnMenu.Location = new Point(348, 556);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(325, 57);
            btnMenu.TabIndex = 12;
            btnMenu.Text = "QUIT TO MENU";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(685, 625);
            Controls.Add(btnMenu);
            Controls.Add(btnRestart);
            Controls.Add(label1);
            Controls.Add(lblScore);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Mem-Matcher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
        private Label label1;
        private Button button1;
        private Button btnRestart;
        private Button btnMenu;
    }
}
