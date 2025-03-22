namespace RPS_Game
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
            btnRock = new Button();
            btnScissors = new Button();
            btnPaper = new Button();
            picPlayer = new PictureBox();
            picBot = new PictureBox();
            lbPlayer = new Label();
            lbBot = new Label();
            pResult = new Label();
            bResult = new Label();
            Round = new Label();
            btnReset = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBot).BeginInit();
            SuspendLayout();
            // 
            // btnRock
            // 
            btnRock.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRock.ForeColor = Color.DarkRed;
            btnRock.Location = new Point(37, 402);
            btnRock.Name = "btnRock";
            btnRock.Padding = new Padding(7, 8, 8, 7);
            btnRock.Size = new Size(98, 51);
            btnRock.TabIndex = 0;
            btnRock.Tag = "R";
            btnRock.Text = "Rock";
            btnRock.UseVisualStyleBackColor = true;
            btnRock.Click += ChooseAChoice;
            // 
            // btnScissors
            // 
            btnScissors.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnScissors.ForeColor = Color.DarkRed;
            btnScissors.Location = new Point(416, 402);
            btnScissors.Name = "btnScissors";
            btnScissors.Padding = new Padding(7, 8, 8, 7);
            btnScissors.Size = new Size(98, 51);
            btnScissors.TabIndex = 1;
            btnScissors.Tag = "S";
            btnScissors.Text = "Scissors";
            btnScissors.UseVisualStyleBackColor = true;
            btnScissors.Click += ChooseAChoice;
            // 
            // btnPaper
            // 
            btnPaper.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPaper.ForeColor = Color.DarkRed;
            btnPaper.Location = new Point(220, 402);
            btnPaper.Name = "btnPaper";
            btnPaper.Padding = new Padding(7, 8, 8, 7);
            btnPaper.Size = new Size(98, 51);
            btnPaper.TabIndex = 2;
            btnPaper.Tag = "P";
            btnPaper.Text = "Paper";
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += ChooseAChoice;
            // 
            // picPlayer
            // 
            picPlayer.Location = new Point(138, 152);
            picPlayer.Name = "picPlayer";
            picPlayer.Size = new Size(100, 100);
            picPlayer.SizeMode = PictureBoxSizeMode.Zoom;
            picPlayer.TabIndex = 3;
            picPlayer.TabStop = false;
            // 
            // picBot
            // 
            picBot.Location = new Point(472, 152);
            picBot.Name = "picBot";
            picBot.Size = new Size(100, 100);
            picBot.SizeMode = PictureBoxSizeMode.Zoom;
            picBot.TabIndex = 4;
            picBot.TabStop = false;
            // 
            // lbPlayer
            // 
            lbPlayer.AutoSize = true;
            lbPlayer.BackColor = Color.IndianRed;
            lbPlayer.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPlayer.ForeColor = Color.Transparent;
            lbPlayer.Location = new Point(138, 88);
            lbPlayer.Name = "lbPlayer";
            lbPlayer.Size = new Size(117, 23);
            lbPlayer.TabIndex = 5;
            lbPlayer.Text = "Player Choice";
            // 
            // lbBot
            // 
            lbBot.AutoSize = true;
            lbBot.BackColor = Color.IndianRed;
            lbBot.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbBot.ForeColor = Color.Transparent;
            lbBot.Location = new Point(472, 88);
            lbBot.Name = "lbBot";
            lbBot.Size = new Size(96, 23);
            lbBot.TabIndex = 6;
            lbBot.Text = "Bot Choice";
            // 
            // pResult
            // 
            pResult.AutoSize = true;
            pResult.BackColor = Color.YellowGreen;
            pResult.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pResult.ForeColor = Color.Maroon;
            pResult.Location = new Point(138, 311);
            pResult.Name = "pResult";
            pResult.Size = new Size(113, 23);
            pResult.TabIndex = 7;
            pResult.Text = "Player Result";
            // 
            // bResult
            // 
            bResult.AutoSize = true;
            bResult.BackColor = Color.YellowGreen;
            bResult.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bResult.ForeColor = Color.Maroon;
            bResult.Location = new Point(472, 311);
            bResult.Name = "bResult";
            bResult.Size = new Size(92, 23);
            bResult.TabIndex = 8;
            bResult.Text = "Bot Result";
            // 
            // Round
            // 
            Round.AutoSize = true;
            Round.BackColor = Color.Linen;
            Round.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Round.ForeColor = Color.DarkRed;
            Round.Location = new Point(316, 311);
            Round.Name = "Round";
            Round.Size = new Size(89, 23);
            Round.TabIndex = 9;
            Round.Text = "Rounds: 3";
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.Maroon;
            btnReset.Location = new Point(597, 402);
            btnReset.Name = "btnReset";
            btnReset.Padding = new Padding(7, 8, 8, 7);
            btnReset.Size = new Size(94, 48);
            btnReset.TabIndex = 10;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += Reset_All;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(176, 9);
            label1.Name = "label1";
            label1.Size = new Size(355, 38);
            label1.TabIndex = 11;
            label1.Text = "Rock Paper Scissors Game";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 499);
            Controls.Add(label1);
            Controls.Add(btnReset);
            Controls.Add(Round);
            Controls.Add(bResult);
            Controls.Add(pResult);
            Controls.Add(lbBot);
            Controls.Add(lbPlayer);
            Controls.Add(picBot);
            Controls.Add(picPlayer);
            Controls.Add(btnPaper);
            Controls.Add(btnScissors);
            Controls.Add(btnRock);
            Name = "Form1";
            Text = "RPS";
            ((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBot).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRock;
        private Button btnScissors;
        private Button btnPaper;
        private PictureBox picPlayer;
        private PictureBox picBot;
        private Label lbPlayer;
        private Label lbBot;
        private Label pResult;
        private Label bResult;
        private Label Round;
        private Button btnReset;
        private Label label1;
    }
}
