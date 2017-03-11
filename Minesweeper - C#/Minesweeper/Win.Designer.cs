namespace Minesweeper
{
    partial class Win
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Win));
            this.besttimetext2 = new System.Windows.Forms.Label();
            this.timetext2 = new System.Windows.Forms.Label();
            this.PlayAgain = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.BestTimeLabel = new System.Windows.Forms.Label();
            this.Gplayed = new System.Windows.Forms.Label();
            this.Gwon = new System.Windows.Forms.Label();
            this.besttimetext1 = new System.Windows.Forms.Label();
            this.timetext1 = new System.Windows.Forms.Label();
            this.gamesplayed = new System.Windows.Forms.Label();
            this.gameswon = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // besttimetext2
            // 
            this.besttimetext2.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.besttimetext2.Location = new System.Drawing.Point(218, 19);
            this.besttimetext2.Name = "besttimetext2";
            this.besttimetext2.Size = new System.Drawing.Size(86, 26);
            this.besttimetext2.TabIndex = 23;
            this.besttimetext2.Text = "seconds";
            this.besttimetext2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timetext2
            // 
            this.timetext2.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timetext2.Location = new System.Drawing.Point(218, 45);
            this.timetext2.Name = "timetext2";
            this.timetext2.Size = new System.Drawing.Size(86, 26);
            this.timetext2.TabIndex = 21;
            this.timetext2.Text = "seconds";
            this.timetext2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlayAgain
            // 
            this.PlayAgain.BackColor = System.Drawing.Color.DarkCyan;
            this.PlayAgain.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.PlayAgain.FlatAppearance.BorderSize = 0;
            this.PlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayAgain.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgain.Location = new System.Drawing.Point(224, 224);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(163, 32);
            this.PlayAgain.TabIndex = 19;
            this.PlayAgain.Text = "Play Again";
            this.PlayAgain.UseVisualStyleBackColor = false;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.DarkCyan;
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(40, 224);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(163, 32);
            this.Exit.TabIndex = 18;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(19, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(375, 37);
            this.title.TabIndex = 13;
            this.title.Text = "Congatulations, you won the game !";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(194, 68);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(58, 26);
            this.TimeLabel.TabIndex = 27;
            this.TimeLabel.Text = "N/A";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BestTimeLabel
            // 
            this.BestTimeLabel.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BestTimeLabel.Location = new System.Drawing.Point(194, 94);
            this.BestTimeLabel.Name = "BestTimeLabel";
            this.BestTimeLabel.Size = new System.Drawing.Size(58, 26);
            this.BestTimeLabel.TabIndex = 28;
            this.BestTimeLabel.Text = "N/A";
            this.BestTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Gplayed
            // 
            this.Gplayed.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gplayed.Location = new System.Drawing.Point(194, 120);
            this.Gplayed.Name = "Gplayed";
            this.Gplayed.Size = new System.Drawing.Size(58, 26);
            this.Gplayed.TabIndex = 29;
            this.Gplayed.Text = "N/A";
            this.Gplayed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Gwon
            // 
            this.Gwon.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gwon.Location = new System.Drawing.Point(194, 144);
            this.Gwon.Name = "Gwon";
            this.Gwon.Size = new System.Drawing.Size(58, 26);
            this.Gwon.TabIndex = 30;
            this.Gwon.Text = "N/A";
            this.Gwon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // besttimetext1
            // 
            this.besttimetext1.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.besttimetext1.Location = new System.Drawing.Point(34, 46);
            this.besttimetext1.Margin = new System.Windows.Forms.Padding(0);
            this.besttimetext1.Name = "besttimetext1";
            this.besttimetext1.Size = new System.Drawing.Size(111, 25);
            this.besttimetext1.TabIndex = 14;
            this.besttimetext1.Text = "Best Time : ";
            this.besttimetext1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timetext1
            // 
            this.timetext1.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timetext1.Location = new System.Drawing.Point(80, 19);
            this.timetext1.Margin = new System.Windows.Forms.Padding(0);
            this.timetext1.Name = "timetext1";
            this.timetext1.Size = new System.Drawing.Size(62, 26);
            this.timetext1.TabIndex = 15;
            this.timetext1.Text = "Time : ";
            this.timetext1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gamesplayed
            // 
            this.gamesplayed.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesplayed.Location = new System.Drawing.Point(4, 71);
            this.gamesplayed.Margin = new System.Windows.Forms.Padding(0);
            this.gamesplayed.Name = "gamesplayed";
            this.gamesplayed.Size = new System.Drawing.Size(138, 26);
            this.gamesplayed.TabIndex = 16;
            this.gamesplayed.Text = "Games played : ";
            this.gamesplayed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gameswon
            // 
            this.gameswon.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameswon.Location = new System.Drawing.Point(1, 97);
            this.gameswon.Margin = new System.Windows.Forms.Padding(0);
            this.gameswon.Name = "gameswon";
            this.gameswon.Size = new System.Drawing.Size(141, 24);
            this.gameswon.TabIndex = 17;
            this.gameswon.Text = "     Games won : ";
            this.gameswon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gameswon);
            this.groupBox1.Controls.Add(this.gamesplayed);
            this.groupBox1.Controls.Add(this.timetext1);
            this.groupBox1.Controls.Add(this.besttimetext1);
            this.groupBox1.Controls.Add(this.besttimetext2);
            this.groupBox1.Controls.Add(this.timetext2);
            this.groupBox1.Location = new System.Drawing.Point(40, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 158);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 270);
            this.Controls.Add(this.Gwon);
            this.Controls.Add(this.Gplayed);
            this.Controls.Add(this.BestTimeLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Win";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label besttimetext2;
        private System.Windows.Forms.Label timetext2;
        private System.Windows.Forms.Button PlayAgain;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label BestTimeLabel;
        private System.Windows.Forms.Label Gplayed;
        private System.Windows.Forms.Label Gwon;
        private System.Windows.Forms.Label besttimetext1;
        private System.Windows.Forms.Label timetext1;
        private System.Windows.Forms.Label gamesplayed;
        private System.Windows.Forms.Label gameswon;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}