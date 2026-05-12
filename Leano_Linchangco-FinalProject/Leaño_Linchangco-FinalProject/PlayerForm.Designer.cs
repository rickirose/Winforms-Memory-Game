namespace Leaño_Linchangco_FinalProject
{
    partial class PlayerForm
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
            tbxName = new TextBox();
            btnPlay = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            btnLeaderboard = new Button();
            btnQuit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // tbxName
            // 
            tbxName.BackColor = SystemColors.ScrollBar;
            tbxName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxName.Location = new Point(283, 176);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(266, 39);
            tbxName.TabIndex = 0;
            tbxName.TextChanged += textBox1_TextChanged;
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.Red;
            btnPlay.Font = new Font("MS Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlay.ForeColor = SystemColors.Control;
            btnPlay.Location = new Point(283, 241);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(266, 57);
            btnPlay.TabIndex = 1;
            btnPlay.Text = "PLAY";
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(160, 69);
            label1.Name = "label1";
            label1.Size = new Size(529, 73);
            label1.TabIndex = 2;
            label1.Text = "MEM-MATCHER";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(359, 154);
            label2.Name = "label2";
            label2.Size = new Size(119, 19);
            label2.TabIndex = 3;
            label2.Text = "INPUT NAME";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Back;
            pictureBox1.Image = Properties.Resources.Back;
            pictureBox1.Location = new Point(1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.Back;
            pictureBox2.Image = Properties.Resources.Back;
            pictureBox2.Location = new Point(1, 157);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(142, 144);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.Back;
            pictureBox3.Image = Properties.Resources.Back;
            pictureBox3.Location = new Point(1, 321);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(142, 144);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.Back;
            pictureBox4.Image = Properties.Resources.Back;
            pictureBox4.Location = new Point(715, 321);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(142, 144);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.Back;
            pictureBox5.Image = Properties.Resources.Back;
            pictureBox5.Location = new Point(715, 157);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(142, 144);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = Properties.Resources.Back;
            pictureBox6.Image = Properties.Resources.Back;
            pictureBox6.Location = new Point(715, -2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(142, 144);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 7;
            pictureBox6.TabStop = false;
            // 
            // btnLeaderboard
            // 
            btnLeaderboard.BackColor = Color.Red;
            btnLeaderboard.Font = new Font("MS Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLeaderboard.ForeColor = SystemColors.Control;
            btnLeaderboard.Location = new Point(283, 304);
            btnLeaderboard.Name = "btnLeaderboard";
            btnLeaderboard.Size = new Size(266, 57);
            btnLeaderboard.TabIndex = 10;
            btnLeaderboard.Text = "LEADERBOARD";
            btnLeaderboard.UseVisualStyleBackColor = false;
            btnLeaderboard.Click += btnLeaderboard_Click;
            // 
            // btnQuit
            // 
            btnQuit.BackColor = Color.Red;
            btnQuit.Font = new Font("MS Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuit.ForeColor = SystemColors.Control;
            btnQuit.Location = new Point(283, 367);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(266, 57);
            btnQuit.TabIndex = 11;
            btnQuit.Text = "QUIT GAME";
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += btnQuit_Click;
            // 
            // PlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(857, 461);
            Controls.Add(btnQuit);
            Controls.Add(btnLeaderboard);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnPlay);
            Controls.Add(tbxName);
            Name = "PlayerForm";
            Text = "Mem-Matcher";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxName;
        private Button btnPlay;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button btnLeaderboard;
        private Button btnQuit;
    }
}