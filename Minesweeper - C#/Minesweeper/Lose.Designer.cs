namespace Minesweeper
{
    partial class Lose
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
            System.Windows.Forms.Label title;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lose));
            this.gameswon = new System.Windows.Forms.Label();
            this.gamesplayed = new System.Windows.Forms.Label();
            this.timetext1 = new System.Windows.Forms.Label();
            this.Gwon = new System.Windows.Forms.Label();
            this.GPlayed = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.besttimetext2 = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Button();
            this.PlayAgain = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            title = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            title.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title.ForeColor = System.Drawing.Color.Black;
            title.Location = new System.Drawing.Point(12, 23);
            title.Name = "title";
            title.Size = new System.Drawing.Size(546, 41);
            title.TabIndex = 42;
            title.Text = "Sorry, you lost this game. Better luck next time !";
            title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameswon
            // 
            this.gameswon.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameswon.Location = new System.Drawing.Point(48, 95);
            this.gameswon.Margin = new System.Windows.Forms.Padding(0);
            this.gameswon.Name = "gameswon";
            this.gameswon.Size = new System.Drawing.Size(141, 24);
            this.gameswon.TabIndex = 35;
            this.gameswon.Text = "     Games won : ";
            this.gameswon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gamesplayed
            // 
            this.gamesplayed.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesplayed.Location = new System.Drawing.Point(51, 57);
            this.gamesplayed.Margin = new System.Windows.Forms.Padding(0);
            this.gamesplayed.Name = "gamesplayed";
            this.gamesplayed.Size = new System.Drawing.Size(138, 26);
            this.gamesplayed.TabIndex = 34;
            this.gamesplayed.Text = "Games played : ";
            this.gamesplayed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timetext1
            // 
            this.timetext1.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timetext1.Location = new System.Drawing.Point(127, 19);
            this.timetext1.Margin = new System.Windows.Forms.Padding(0);
            this.timetext1.Name = "timetext1";
            this.timetext1.Size = new System.Drawing.Size(62, 26);
            this.timetext1.TabIndex = 33;
            this.timetext1.Text = "Time : ";
            this.timetext1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Gwon
            // 
            this.Gwon.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gwon.Location = new System.Drawing.Point(210, 93);
            this.Gwon.Name = "Gwon";
            this.Gwon.Size = new System.Drawing.Size(66, 26);
            this.Gwon.TabIndex = 41;
            this.Gwon.Text = "N/A";
            this.Gwon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GPlayed
            // 
            this.GPlayed.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPlayed.Location = new System.Drawing.Point(210, 57);
            this.GPlayed.Name = "GPlayed";
            this.GPlayed.Size = new System.Drawing.Size(66, 26);
            this.GPlayed.TabIndex = 40;
            this.GPlayed.Text = "N/A";
            this.GPlayed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(210, 19);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(66, 26);
            this.TimeLabel.TabIndex = 38;
            this.TimeLabel.Text = "N/A";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // besttimetext2
            // 
            this.besttimetext2.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.besttimetext2.Location = new System.Drawing.Point(282, 19);
            this.besttimetext2.Name = "besttimetext2";
            this.besttimetext2.Size = new System.Drawing.Size(86, 26);
            this.besttimetext2.TabIndex = 37;
            this.besttimetext2.Text = "seconds";
            this.besttimetext2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Restart
            // 
            this.Restart.BackColor = System.Drawing.Color.DarkCyan;
            this.Restart.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.Restart.FlatAppearance.BorderSize = 0;
            this.Restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restart.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart.Location = new System.Drawing.Point(189, 207);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(183, 32);
            this.Restart.TabIndex = 45;
            this.Restart.Text = "Restart this game";
            this.Restart.UseVisualStyleBackColor = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // PlayAgain
            // 
            this.PlayAgain.BackColor = System.Drawing.Color.DarkCyan;
            this.PlayAgain.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.PlayAgain.FlatAppearance.BorderSize = 0;
            this.PlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayAgain.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgain.Location = new System.Drawing.Point(387, 207);
            this.PlayAgain.Margin = new System.Windows.Forms.Padding(0);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(163, 32);
            this.PlayAgain.TabIndex = 44;
            this.PlayAgain.Text = "Play again";
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
            this.Exit.Location = new System.Drawing.Point(12, 207);
            this.Exit.Margin = new System.Windows.Forms.Padding(0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(163, 32);
            this.Exit.TabIndex = 43;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gameswon);
            this.groupBox1.Controls.Add(this.gamesplayed);
            this.groupBox1.Controls.Add(this.timetext1);
            this.groupBox1.Controls.Add(this.Gwon);
            this.groupBox1.Controls.Add(this.GPlayed);
            this.groupBox1.Controls.Add(this.TimeLabel);
            this.groupBox1.Controls.Add(this.besttimetext2);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 136);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            // 
            // Lose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 252);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.Exit);
            this.Controls.Add(title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label gameswon;
        private System.Windows.Forms.Label gamesplayed;
        private System.Windows.Forms.Label timetext1;
        private System.Windows.Forms.Label Gwon;
        private System.Windows.Forms.Label GPlayed;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label besttimetext2;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Button PlayAgain;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}