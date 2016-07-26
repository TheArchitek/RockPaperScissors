namespace RockPaperScissors
{
    partial class Form1
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
            this.btn_Rock = new System.Windows.Forms.Button();
            this.btn_Paper = new System.Windows.Forms.Button();
            this.btn_Scissors = new System.Windows.Forms.Button();
            this.rtb_console = new System.Windows.Forms.RichTextBox();
            this.pb_userChoice = new System.Windows.Forms.PictureBox();
            this.pb_AIchoice = new System.Windows.Forms.PictureBox();
            this.wins = new System.Windows.Forms.Label();
            this.loses = new System.Windows.Forms.Label();
            this.draws = new System.Windows.Forms.Label();
            this.winsNumber = new System.Windows.Forms.Label();
            this.losesNumber = new System.Windows.Forms.Label();
            this.drawsNumber = new System.Windows.Forms.Label();
            this.btn_newGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_AIWins = new System.Windows.Forms.Label();
            this.lb_humanWins = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_userChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AIchoice)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Rock
            // 
            this.btn_Rock.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_Rock.Location = new System.Drawing.Point(133, 567);
            this.btn_Rock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Rock.Name = "btn_Rock";
            this.btn_Rock.Size = new System.Drawing.Size(83, 48);
            this.btn_Rock.TabIndex = 0;
            this.btn_Rock.Text = "Rock";
            this.btn_Rock.UseVisualStyleBackColor = false;
            this.btn_Rock.Click += new System.EventHandler(this.btn_Rock_Click);
            // 
            // btn_Paper
            // 
            this.btn_Paper.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_Paper.Location = new System.Drawing.Point(279, 567);
            this.btn_Paper.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Paper.Name = "btn_Paper";
            this.btn_Paper.Size = new System.Drawing.Size(83, 48);
            this.btn_Paper.TabIndex = 1;
            this.btn_Paper.Text = "Paper";
            this.btn_Paper.UseVisualStyleBackColor = false;
            this.btn_Paper.Click += new System.EventHandler(this.btn_Paper_Click);
            // 
            // btn_Scissors
            // 
            this.btn_Scissors.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_Scissors.Location = new System.Drawing.Point(425, 565);
            this.btn_Scissors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Scissors.Name = "btn_Scissors";
            this.btn_Scissors.Size = new System.Drawing.Size(83, 48);
            this.btn_Scissors.TabIndex = 2;
            this.btn_Scissors.Text = "Scissors";
            this.btn_Scissors.UseVisualStyleBackColor = false;
            this.btn_Scissors.Click += new System.EventHandler(this.btn_Scissors_Click);
            // 
            // rtb_console
            // 
            this.rtb_console.Location = new System.Drawing.Point(460, 447);
            this.rtb_console.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtb_console.Name = "rtb_console";
            this.rtb_console.Size = new System.Drawing.Size(168, 95);
            this.rtb_console.TabIndex = 7;
            this.rtb_console.Text = "";
            // 
            // pb_userChoice
            // 
            this.pb_userChoice.BackColor = System.Drawing.Color.Cornsilk;
            this.pb_userChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_userChoice.Location = new System.Drawing.Point(203, 297);
            this.pb_userChoice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb_userChoice.Name = "pb_userChoice";
            this.pb_userChoice.Size = new System.Drawing.Size(233, 246);
            this.pb_userChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_userChoice.TabIndex = 6;
            this.pb_userChoice.TabStop = false;
            // 
            // pb_AIchoice
            // 
            this.pb_AIchoice.BackColor = System.Drawing.Color.Cornsilk;
            this.pb_AIchoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_AIchoice.Location = new System.Drawing.Point(203, 43);
            this.pb_AIchoice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb_AIchoice.Name = "pb_AIchoice";
            this.pb_AIchoice.Size = new System.Drawing.Size(233, 246);
            this.pb_AIchoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_AIchoice.TabIndex = 6;
            this.pb_AIchoice.TabStop = false;
            // 
            // wins
            // 
            this.wins.AutoSize = true;
            this.wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wins.Location = new System.Drawing.Point(40, 272);
            this.wins.Name = "wins";
            this.wins.Size = new System.Drawing.Size(60, 25);
            this.wins.TabIndex = 8;
            this.wins.Text = "Wins";
            // 
            // loses
            // 
            this.loses.AutoSize = true;
            this.loses.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loses.Location = new System.Drawing.Point(40, 363);
            this.loses.Name = "loses";
            this.loses.Size = new System.Drawing.Size(70, 25);
            this.loses.TabIndex = 9;
            this.loses.Text = "Loses";
            // 
            // draws
            // 
            this.draws.AutoSize = true;
            this.draws.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draws.Location = new System.Drawing.Point(40, 454);
            this.draws.Name = "draws";
            this.draws.Size = new System.Drawing.Size(72, 25);
            this.draws.TabIndex = 10;
            this.draws.Text = "Draws";
            // 
            // winsNumber
            // 
            this.winsNumber.AutoSize = true;
            this.winsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winsNumber.Location = new System.Drawing.Point(152, 278);
            this.winsNumber.Name = "winsNumber";
            this.winsNumber.Size = new System.Drawing.Size(18, 20);
            this.winsNumber.TabIndex = 11;
            this.winsNumber.Text = "0";
            this.winsNumber.Click += new System.EventHandler(this.winsNumber_Click);
            // 
            // losesNumber
            // 
            this.losesNumber.AutoSize = true;
            this.losesNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.losesNumber.Location = new System.Drawing.Point(152, 370);
            this.losesNumber.Name = "losesNumber";
            this.losesNumber.Size = new System.Drawing.Size(18, 20);
            this.losesNumber.TabIndex = 11;
            this.losesNumber.Text = "0";
            // 
            // drawsNumber
            // 
            this.drawsNumber.AutoSize = true;
            this.drawsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawsNumber.Location = new System.Drawing.Point(152, 461);
            this.drawsNumber.Name = "drawsNumber";
            this.drawsNumber.Size = new System.Drawing.Size(18, 20);
            this.drawsNumber.TabIndex = 11;
            this.drawsNumber.Text = "0";
            // 
            // btn_newGame
            // 
            this.btn_newGame.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_newGame.Location = new System.Drawing.Point(500, 389);
            this.btn_newGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_newGame.Name = "btn_newGame";
            this.btn_newGame.Size = new System.Drawing.Size(87, 28);
            this.btn_newGame.TabIndex = 12;
            this.btn_newGame.Text = "New Game";
            this.btn_newGame.UseVisualStyleBackColor = false;
            this.btn_newGame.Click += new System.EventHandler(this.btn_newGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(517, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Human Wins";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "AI Wins";
            // 
            // lb_AIWins
            // 
            this.lb_AIWins.AutoSize = true;
            this.lb_AIWins.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AIWins.Location = new System.Drawing.Point(64, 120);
            this.lb_AIWins.Name = "lb_AIWins";
            this.lb_AIWins.Size = new System.Drawing.Size(22, 24);
            this.lb_AIWins.TabIndex = 15;
            this.lb_AIWins.Text = "0";
            // 
            // lb_humanWins
            // 
            this.lb_humanWins.AutoSize = true;
            this.lb_humanWins.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_humanWins.Location = new System.Drawing.Point(553, 120);
            this.lb_humanWins.Name = "lb_humanWins";
            this.lb_humanWins.Size = new System.Drawing.Size(22, 24);
            this.lb_humanWins.TabIndex = 15;
            this.lb_humanWins.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(643, 628);
            this.Controls.Add(this.lb_humanWins);
            this.Controls.Add(this.lb_AIWins);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_newGame);
            this.Controls.Add(this.drawsNumber);
            this.Controls.Add(this.losesNumber);
            this.Controls.Add(this.winsNumber);
            this.Controls.Add(this.draws);
            this.Controls.Add(this.loses);
            this.Controls.Add(this.wins);
            this.Controls.Add(this.rtb_console);
            this.Controls.Add(this.pb_userChoice);
            this.Controls.Add(this.pb_AIchoice);
            this.Controls.Add(this.btn_Scissors);
            this.Controls.Add(this.btn_Paper);
            this.Controls.Add(this.btn_Rock);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "RockPaperScissors";
            ((System.ComponentModel.ISupportInitialize)(this.pb_userChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AIchoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Rock;
        private System.Windows.Forms.Button btn_Paper;
        private System.Windows.Forms.Button btn_Scissors;
        private System.Windows.Forms.PictureBox pb_AIchoice;
        private System.Windows.Forms.PictureBox pb_userChoice;
        private System.Windows.Forms.RichTextBox rtb_console;
        private System.Windows.Forms.Label wins;
        private System.Windows.Forms.Label loses;
        private System.Windows.Forms.Label draws;
        public System.Windows.Forms.Label winsNumber;
        public System.Windows.Forms.Label losesNumber;
        public System.Windows.Forms.Label drawsNumber;
        private System.Windows.Forms.Button btn_newGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_AIWins;
        private System.Windows.Forms.Label lb_humanWins;
    }
}

