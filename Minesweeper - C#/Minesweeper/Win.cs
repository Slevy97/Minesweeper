using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Minesweeper
{
    public partial class Win : Form
    {
        private void Best()
        {
            ///
            int best_time = 0;
            int games_played = 1;
            int games_won = 1;
            if (File.Exists("best.txt"))
            {
                using (StreamReader file = new StreamReader("best.txt"))
                {
                    string best_time_string = file.ReadLine();
                    if (best_time_string == "N/A")
                        best_time = 0;
                    else
                        best_time = int.Parse(best_time_string);
                    games_played = int.Parse(file.ReadLine());
                    games_won = int.Parse(file.ReadLine());
                    games_played++;
                    games_won++;
                    file.Close();
                    if ((best_time <= int.Parse(TimeLabel.Text)) && (best_time !=0))
                        BestTimeLabel.Text = best_time.ToString();
                    else
                    {
                        best_time = int.Parse(TimeLabel.Text);
                        BestTimeLabel.Text = best_time.ToString();
                    }
                    Gplayed.Text = games_played.ToString();
                    Gwon.Text = games_won.ToString();
                }
                using (StreamWriter file = new StreamWriter("best.txt"))
                {
                    
                    file.WriteLine(best_time.ToString());
                    file.WriteLine(games_played.ToString());
                    file.WriteLine(games_won.ToString());
                    file.Close();
                }
            }
            else
            {

                using (StreamWriter file = File.CreateText("best.txt"))
                {
                    file.WriteLine(TimeLabel.Text);
                    file.WriteLine("1");
                    file.WriteLine("1");
                    file.Close();
                    BestTimeLabel.Text = TimeLabel.Text;
                    Gplayed.Text = games_played.ToString();
                    Gwon.Text = games_won.ToString();
                }
            }

            ///
        }

        public Win(string time)
        {
            InitializeComponent();
            TimeLabel.Text = time;
            Best();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            Input.FileNumber++;
            Settings.DontStop = false;
            this.Close();
        }

    }
}
