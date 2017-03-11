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
using System.Media;

namespace Minesweeper
{
    public partial class canvas : Form
    {
        StreamReader file;
        int Fails;
        int[,] table = new int[12, 12];
        int tableN;
        List<MButtons> Buttons = new List<MButtons>();
        List<Coord> Points = new List<Coord>();
        private void ButtonsReady()
        {
            Buttons.Add(new MButtons(1, 1, btn1, false));
            Buttons.Add(new MButtons(1, 2, btn2, false));
            Buttons.Add(new MButtons(1, 3, btn3, false));
            Buttons.Add(new MButtons(1, 4, btn4, false));
            Buttons.Add(new MButtons(1, 5, btn5, false));
            Buttons.Add(new MButtons(1, 6, btn6, false));
            Buttons.Add(new MButtons(1, 7, btn7, false));
            Buttons.Add(new MButtons(1, 8, btn8, false));
            Buttons.Add(new MButtons(1, 9, btn9, false));
            //
            Buttons.Add(new MButtons(2, 1, btn10, false));
            Buttons.Add(new MButtons(2, 2, btn11, false));
            Buttons.Add(new MButtons(2, 3, btn12, false));
            Buttons.Add(new MButtons(2, 4, btn13, false));
            Buttons.Add(new MButtons(2, 5, btn14, false));
            Buttons.Add(new MButtons(2, 6, btn15, false));
            Buttons.Add(new MButtons(2, 7, btn16, false));
            Buttons.Add(new MButtons(2, 8, btn17, false));
            Buttons.Add(new MButtons(2, 9, btn18, false));
            //
            Buttons.Add(new MButtons(3, 1, btn19, false));
            Buttons.Add(new MButtons(3, 2, btn20, false));
            Buttons.Add(new MButtons(3, 3, btn21, false));
            Buttons.Add(new MButtons(3, 4, btn22, false));
            Buttons.Add(new MButtons(3, 5, btn23, false));
            Buttons.Add(new MButtons(3, 6, btn24, false));
            Buttons.Add(new MButtons(3, 7, btn25, false));
            Buttons.Add(new MButtons(3, 8, btn26, false));
            Buttons.Add(new MButtons(3, 9, btn27, false));
            //
            Buttons.Add(new MButtons(4, 1, btn28, false));
            Buttons.Add(new MButtons(4, 2, btn29, false));
            Buttons.Add(new MButtons(4, 3, btn30, false));
            Buttons.Add(new MButtons(4, 4, btn31, false));
            Buttons.Add(new MButtons(4, 5, btn32, false));
            Buttons.Add(new MButtons(4, 6, btn33, false));
            Buttons.Add(new MButtons(4, 7, btn34, false));
            Buttons.Add(new MButtons(4, 8, btn35, false));
            Buttons.Add(new MButtons(4, 9, btn36, false));
            //
            Buttons.Add(new MButtons(5, 1, btn37, false));
            Buttons.Add(new MButtons(5, 2, btn38, false));
            Buttons.Add(new MButtons(5, 3, btn39, false));
            Buttons.Add(new MButtons(5, 4, btn40, false));
            Buttons.Add(new MButtons(5, 5, btn41, false));
            Buttons.Add(new MButtons(5, 6, btn42, false));
            Buttons.Add(new MButtons(5, 7, btn43, false));
            Buttons.Add(new MButtons(5, 8, btn44, false));
            Buttons.Add(new MButtons(5, 9, btn45, false));
            //
            Buttons.Add(new MButtons(6, 1, btn46, false));
            Buttons.Add(new MButtons(6, 2, btn47, false));
            Buttons.Add(new MButtons(6, 3, btn48, false));
            Buttons.Add(new MButtons(6, 4, btn49, false));
            Buttons.Add(new MButtons(6, 5, btn50, false));
            Buttons.Add(new MButtons(6, 6, btn51, false));
            Buttons.Add(new MButtons(6, 7, btn52, false));
            Buttons.Add(new MButtons(6, 8, btn53, false));
            Buttons.Add(new MButtons(6, 9, btn54, false));
            //
            Buttons.Add(new MButtons(7, 1, btn55, false));
            Buttons.Add(new MButtons(7, 2, btn56, false));
            Buttons.Add(new MButtons(7, 3, btn57, false));
            Buttons.Add(new MButtons(7, 4, btn58, false));
            Buttons.Add(new MButtons(7, 5, btn59, false));
            Buttons.Add(new MButtons(7, 6, btn60, false));
            Buttons.Add(new MButtons(7, 7, btn61, false));
            Buttons.Add(new MButtons(7, 8, btn62, false));
            Buttons.Add(new MButtons(7, 9, btn63, false));
            //
            Buttons.Add(new MButtons(8, 1, btn64, false));
            Buttons.Add(new MButtons(8, 2, btn65, false));
            Buttons.Add(new MButtons(8, 3, btn66, false));
            Buttons.Add(new MButtons(8, 4, btn67, false));
            Buttons.Add(new MButtons(8, 5, btn68, false));
            Buttons.Add(new MButtons(8, 6, btn69, false));
            Buttons.Add(new MButtons(8, 7, btn70, false));
            Buttons.Add(new MButtons(8, 8, btn71, false));
            Buttons.Add(new MButtons(8, 9, btn72, false));
            //
            Buttons.Add(new MButtons(9, 1, btn73, false));
            Buttons.Add(new MButtons(9, 2, btn74, false));
            Buttons.Add(new MButtons(9, 3, btn75, false));
            Buttons.Add(new MButtons(9, 4, btn76, false));
            Buttons.Add(new MButtons(9, 5, btn77, false));
            Buttons.Add(new MButtons(9, 6, btn78, false));
            Buttons.Add(new MButtons(9, 7, btn79, false));
            Buttons.Add(new MButtons(9, 8, btn80, false));
            Buttons.Add(new MButtons(9, 9, btn81, false));
        }

        //

        // Constructor
        public canvas()
        {
            InitializeComponent();
            Timer.Enabled = false;
            Final.Interval = 1;
            Final.Enabled = false;
            new Settings();
            new Input();
            ButtonsReady();
            Music.LoadMusic();
            StartGame();
        }

        //Read from file
        //
        private void iniTable()
        {
            Fails = 0;
        Varf:
            if (Fails >= 4)
            {
                MessageBox.Show("Error : There is no table !", "Error");
                Environment.Exit(0);
            }
            if (Input.FileNumber > 4)
                Input.FileNumber = 1;
            if (Input.FileNumber == 1)
            {
                if (File.Exists("Tables/m1.in"))
                    file = new StreamReader("Tables/m1.in");
                else { Input.FileNumber++; Fails++; goto Varf; }
            }
            else
                if (Input.FileNumber == 2)
                {
                    if (File.Exists("Tables/m2.in"))
                        file = new StreamReader("Tables/m2.in");
                    else { Input.FileNumber++; Fails++; goto Varf; }
                }
                else
                    if (Input.FileNumber == 3)
                    {
                        if (File.Exists("Tables/m3.in"))
                            file = new StreamReader("Tables/m3.in");
                        else { Input.FileNumber++; Fails++; goto Varf; }
                    }
                    else
                        if (Input.FileNumber == 4)
                        {
                            if (File.Exists("Tables/m4.in"))
                                file = new StreamReader("Tables/m4.in");
                            else { Input.FileNumber++; Fails++; goto Varf; }
                        }
                        else { }
            try
            {
                string number = file.ReadLine();
                tableN = int.Parse(number);
                for (int i = 1; i <= tableN; i++)
                {
                    string line = file.ReadLine();
                    string[] sa = line.Split(' ');
                    for (int j = 1; j <= tableN; j++)
                    {
                        table[i, j] = int.Parse(sa[j - 1]);
                    }
                }
            }
            catch
            {
                for (int i = 1; i <= tableN; i++)
                    for (int j = 1; j <= tableN; j++)
                        table[i, j] = 0;
            }
            for(int i=0;i<=tableN+1;i++)
            {
                table[0,i] = -1;
                table[tableN + 1,i] = -1;
                table[i,0] = -1;
                table[i, tableN + 1] = -1;
            }
            try
            {
                file.Close();
            }
            catch { };
        }
        //
        //

        private void iniButtons()
        {
            for(int i = 0;i<Buttons.Count();i++)
            {
                Buttons[i].b.Visible = true;
                Buttons[i].b.Enabled = true;
                Buttons[i].b.Text = "";
                Buttons[i].b.BackColor = Color.DarkCyan;
               Buttons[i].b.Paint -= new System.Windows.Forms.PaintEventHandler(this.btn1_Paint);
                Buttons[i].b.Paint -= new System.Windows.Forms.PaintEventHandler(this.btn_Paint);
                Buttons[i].b.Click -= new System.EventHandler(this.btn1_Click);
               Buttons[i].b.Click += new System.EventHandler(this.btn1_Click);
                Buttons[i].RightClick = false;
                Buttons[i].ButtonPressed = false;
               Buttons[i].b.Invalidate();
               Buttons[i].b.NotifyDefault(false);
            }
          
        }

        private void StartGame()
        {
            new Settings();
            Points.Clear();
            Timer.Enabled = false;
            Final.Enabled = false;
            TimeLabel.Text = "0";
            BombLabel.Text = "10";
            iniTable();
           iniButtons();
        }

        //   MENU
        //
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Input.FileNumber++;
            StartGame();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Minesweeper made by Slevy", "About");
        }
        //
        //

        //Footer
        //
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            try
            {
                g.DrawImage(new Bitmap("Resources/clock.png"), 0, 0, clock.Size.Width, clock.Size.Height);
               
            }
            catch
            {
                g.DrawImage(new Bitmap("../../Resources/clock.png"), 0, 0, clock.Size.Width, clock.Size.Height);
            }
            finally { }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Settings.Time++;
            TimeLabel.Text = Settings.Time.ToString();
            TimeLabel.Invalidate();
        }

        private void BombPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            try
            {
                g.DrawImage(new Bitmap("Resources/bomb.png"), 0, 0, BombPanel.Size.Width, BombPanel.Size.Height);
            }  
            catch
            {
                 g.DrawImage(new Bitmap("../../Resources/bomb.png"), 0, 0, BombPanel.Size.Width, BombPanel.Size.Height);
            }
            finally{}
        }

        //

        // Game Methods

        private bool CheckWin()
        {
            int nr =0 ;
            for (int i = 0; i < Buttons.Count; i++)
                if ((Buttons[i].ButtonPressed == true) && (table[Buttons[i].i,Buttons[i].j] != 7))
                    nr++;
            if (nr == 71)
            {
                Settings.Win = true;
                Settings.GameOver = true;
                return true;
            }
            return false;
        }

        private void ShowBombs()
        {
            for(int i=0;i<Buttons.Count;i++)
                if(table[Buttons[i].i,Buttons[i].j] == 7)
                {
                    Buttons[i].b.Enabled = false;
                    Buttons[i].b.Paint -= new System.Windows.Forms.PaintEventHandler(this.btn_Paint);
                    Buttons[i].b.Paint += new System.Windows.Forms.PaintEventHandler(this.btn1_Paint);
                    if (Settings.Win)
                        Buttons[i].b.BackColor = Color.LightCyan;
                    Buttons[i].b.Invalidate();
                }
        }

        private void DeactivateButtons()
        {
            for(int i=0;i<Buttons.Count();i++)
            {
                Buttons[i].b.Enabled = false;
                Buttons[i].b.NotifyDefault(false);
            }
        }

        private bool Exists(Coord c)
        {
            for(int i=0;i<Points.Count();i++)
            {
                if ((Points[i].X == c.X) && (Points[i].Y == c.Y))
                    return true;
            }
            return false;
        }

        private void fill(int x,int y,int poz)
        {
            if(table[x,y] == 0) 
            {
                if (!Buttons[poz].RightClick)
                {
                    table[x, y] = 8;
                    fill(x + 1, y, poz+9);
                    fill(x - 1, y, poz-9);
                    fill(x, y + 1, poz+1);
                    fill(x, y - 1, poz-1);
                     //
                    fill(x + 1, y + 1, poz + 10);
                    fill(x + 1, y - 1, poz + 8);
                    fill(x - 1, y + 1, poz - 8);
                    fill(x - 1, y - 1, poz - 10);
                }
            }
            else
            {
                if ((table[x, y] >= 1) && (table[x, y] <= 5))
                    if ((!Buttons[poz].RightClick) && (!Exists(new Coord(x,y,poz))))
                        Points.Add(new Coord(x, y,poz));
            }
        }

        private void Action2(int x, int y, Button btn, int poz)
        {
            if (!Settings.GameOver)
            {
                if ((table[x, y] >= 1) && (table[x, y] <= 5))
                {
                    btn.BackColor = Color.Gainsboro;
                    btn.Text = table[x, y].ToString();
                    btn.Enabled = false;                 
                }
                else
                    if (table[x, y] == 7)
                    {
                        Settings.GameOver = true;
                        btn.BackColor = Color.Firebrick;
                        Timer.Enabled = false;
                        DeactivateButtons();
                        ShowBombs();
                        Lose l = new Lose(TimeLabel.Text);
                        l.Show();
                        Final.Enabled = true;
                    }
                    else
                    {
                        if (table[x, y] == 0)
                        {
                            fill(x, y, poz);
                                for (int i = 0; i < Buttons.Count(); i++)
                                {
                                    if (table[Buttons[i].i, Buttons[i].j] == 8)
                                    {
                                        Buttons[i].b.BackColor = Color.Gainsboro;
                                        Buttons[i].b.Enabled = false;
                                        Buttons[i].ButtonPressed = true;
                                    }
                                }
                            for (int i = 0; i < Points.Count(); i++)
                            {
                                int pozz = Points[i].Poz;
                                int cx = Points[i].X;
                                int cy = Points[i].Y;
                               Button bt = Buttons[pozz].b;
                               bt.Text = table[cx, cy].ToString();
                                bt.Enabled = false;
                                bt.BackColor = Color.Gainsboro;
                               Buttons[pozz].ButtonPressed = true;
                                }
                            }
                        }

                if (CheckWin())
                {
                    Timer.Enabled = false;
                    ShowBombs();
                    DeactivateButtons();
                    Win w = new Win(TimeLabel.Text);
                    w.Show();
                    Final.Enabled = true;
                }
            }
        }

        private void Action(Button btn)
        {
            if (!Settings.GameOver)
            {
                int x = 0, y = 0;
                int poz = 0;
                bool right = false;
                for (int i = 0; i < Buttons.Count; i++)
                    if (Buttons[i].b == btn)
                    {
                        x = Buttons[i].i;
                        y = Buttons[i].j;
                        poz = i;
                        Buttons[i].ButtonPressed = true;
                        if (Buttons[i].RightClick)
                            right = true;
                        break;
                    }
                if (!right)
                    Action2(x, y, btn, poz);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (Settings.DontStop == false)
                Settings.DontStop = true;
            if (!Settings.GameOver)
            {
                Button b = (Button)sender;
                if (Settings.StartTimer == false)
                {
                    Settings.StartTimer = true;
                    Timer.Enabled = true;
                }
                Action(b);
            }
        }

        //Buttons Paint

        private void btn1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Button b = (Button)sender;
            if ((Settings.GameOver))
            {
                try
                {
                    g.DrawImage(new Bitmap("Resources/bomb.png"), 5, 5, b.Size.Width - 10, b.Size.Height - 10);

                }
                catch
                {
                    g.DrawImage(new Bitmap("../../Resources/bomb.png"), 5, 5, b.Size.Width - 10, b.Size.Height - 10);
                }
                finally { }
            }
        }

        private void btn_Paint(object sender,PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Button b = (Button)sender;
                try
                {
                    g.DrawImage(new Bitmap("Resources/steag.png"), 5, 5, b.Size.Width - 10, b.Size.Height - 10);
                  
                }
                catch
                {
                    g.DrawImage(new Bitmap("../../Resources/steag.png"), 5, 5, b.Size.Width - 10, b.Size.Height - 10);
                }
                finally { }
        }
        //
        //

        private void btn1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!Settings.GameOver)
            {
                    if (e.Button == MouseButtons.Right)
                    {
                        if (Settings.StartTimer == false)
                        {
                            Settings.StartTimer = true;
                            Timer.Enabled = true;
                        }
                        Button b = (Button)sender;
                        int x = 0;
                        for (int i = 0; i < Buttons.Count(); i++)
                            if (Buttons[i].b == b)
                            {
                                x = i;
                                break;
                            }
                        if(Buttons[x].RightClick == false)
                        { 
                         if(10 - Settings.FlagsNumber >0)
                        {
                            Buttons[x].RightClick = true;
                            b.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Paint);
                            b.Click -= new System.EventHandler(btn1_Click);
                            Settings.FlagsNumber++;
                        }
                        }
                        else
                        {   Buttons[x].RightClick = false;
                            b.Paint -= new System.Windows.Forms.PaintEventHandler(this.btn_Paint);
                            b.Click += new System.EventHandler(btn1_Click);
                            Settings.FlagsNumber--;
                        }
                      b.Invalidate();
                        BombLabel.Text = (10 - Settings.FlagsNumber).ToString();
                        BombLabel.Invalidate();
                    }
                }
        }

        private void Final_Tick(object sender, EventArgs e)
        {
            if(!Settings.DontStop)
            {
                Final.Enabled = false;
                StartGame();
            }
        }

    }
}
