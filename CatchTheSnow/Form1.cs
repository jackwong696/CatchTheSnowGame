using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickingGames
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GlobalVar.pictureBox1.Click += new System.EventHandler(this.PictureBoxClick);
            GlobalVar.pictureBox2.Click += new System.EventHandler(this.PictureBoxClick);
            GlobalVar.pictureBox3.Click += new System.EventHandler(this.PictureBoxClick);
            GlobalVar.pictureBox4.Click += new System.EventHandler(this.PictureBoxClick);
            GlobalVar.pictureBox5.Click += new System.EventHandler(this.PictureBoxClick);
            GlobalVar.pictureBox6.Click += new System.EventHandler(this.PictureBoxClick);
            GlobalVar.pictureBox7.Click += new System.EventHandler(this.PictureBoxClick);
            GlobalVar.pictureBox8.Click += new System.EventHandler(this.PictureBoxClick);
            GlobalVar.pictureBox9.Click += new System.EventHandler(this.PictureBoxClick);
            GlobalVar.pictureBox10.Click += new System.EventHandler(this.PictureBoxClick);
            panel2.Controls.Add(GlobalVar.pictureBox1);
            panel2.Controls.Add(GlobalVar.pictureBox2);
            panel2.Controls.Add(GlobalVar.pictureBox3);
            panel2.Controls.Add(GlobalVar.pictureBox4);
            panel2.Controls.Add(GlobalVar.pictureBox5);
            panel2.Controls.Add(GlobalVar.pictureBox6);
            panel2.Controls.Add(GlobalVar.pictureBox7);
            panel2.Controls.Add(GlobalVar.pictureBox8);
            panel2.Controls.Add(GlobalVar.pictureBox9);
            panel2.Controls.Add(GlobalVar.pictureBox10);
            initGame();
        }

        private void PictureBoxClick(object sender, EventArgs e)
        {
            GlobalVar.score++;
            panel2.Controls.Remove((PictureBox)sender);
            switch (((PictureBox)sender).Name)
            {
                case "picturebox1":
                    initLvlOne();
                    break;
                case "picturebox2":
                    initLvlTwo();
                    break;
                case "picturebox3":
                    initLvlThree();
                    break;
                case "picturebox4":
                    initLvlFour();
                    break;
                case "picturebox5":
                    initLvlFive();
                    break;
                case "picturebox6":
                    initLvlSix();
                    break;
                case "picturebox7":
                    initLvlSeven();
                    break;
                case "picturebox8":
                    initLvlEight();
                    break;
                case "picturebox9":
                    initLvlNine();
                    break;
                case "picturebox10":
                    initLvlTen();
                    break;
                default:
                    break;
            }
            panel2.Controls.Add((PictureBox)sender);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (GlobalVar.level)
            {
                case 1:
                    moveObstacle();
                    break;
                default:
                    MessageBox.Show("Something have gone wrong. The application will close now.");
                    Application.Exit();
                    break;
            }
            showState();
        }

        private void showState()
        {
            label1.Text = "Score : " + GlobalVar.score;
        }

        private void moveObstacle()
        {
            Random roller = new Random();

            GlobalVar.rsdx = Convert.ToDouble(roller.Next(5) - 2) / 2;

            GlobalVar.rsx += GlobalVar.rsdx;
            if (GlobalVar.rsx > panel2.Width - GlobalVar.pictureBox1.Width)
            {
                GlobalVar.rsx = 0;
            } // end if
            if (GlobalVar.rsx < 0)
            {
                GlobalVar.rsx = Convert.ToDouble(panel2.Width - GlobalVar.pictureBox1.Width);
            } // end if

            GlobalVar.rsy += GlobalVar.rsdy;
            if (GlobalVar.rsy > this.Height - GlobalVar.pictureBox1.Height)
            {
                GlobalVar.rsy = 0;
            } // end if 
            if (GlobalVar.rsy < 0)
            {
                GlobalVar.rsy = Convert.ToDouble(panel2.Height - GlobalVar.pictureBox1.Height);
            } // end if

            GlobalVar.pictureBox1.Location = new Point(Convert.ToInt32(GlobalVar.rsx), Convert.ToInt32(GlobalVar.rsy));

            GlobalVar.rsdx1 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.rsx1 += GlobalVar.rsdx1;
            if (GlobalVar.rsx1 > panel2.Width - GlobalVar.pictureBox2.Width)
            {
                GlobalVar.rsx1 = 0;
            } // end if
            if (GlobalVar.rsx1 < 0)
            {
                GlobalVar.rsx1 = Convert.ToDouble(panel2.Width - GlobalVar.pictureBox2.Width);
            } // end if

            GlobalVar.rsy1 += GlobalVar.rsdy1;
            if (GlobalVar.rsy1 > panel2.Height - GlobalVar.pictureBox2.Height)
            {
                GlobalVar.rsy1 = 0;
            } // end if 
            if (GlobalVar.rsy1 < 0)
            {
                GlobalVar.rsy1 = Convert.ToDouble(panel2.Height - GlobalVar.pictureBox2.Height);
            } // end if

            GlobalVar.pictureBox2.Location = new Point(Convert.ToInt32(GlobalVar.rsx1), Convert.ToInt32(GlobalVar.rsy1));

            GlobalVar.rsdx2 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.rsx2 += GlobalVar.rsdx2;
            if (GlobalVar.rsx2 > panel2.Width - GlobalVar.pictureBox3.Width)
            {
                GlobalVar.rsx2 = 0;
            } // end if
            if (GlobalVar.rsx2 < 0)
            {
                GlobalVar.rsx2 = Convert.ToDouble(panel2.Width - GlobalVar.pictureBox3.Width);
            } // end if

            GlobalVar.rsy2 += GlobalVar.rsdy2;
            if (GlobalVar.rsy2 > panel2.Height - GlobalVar.pictureBox3.Height)
            {
                GlobalVar.rsy2 = 0;
            } // end if 
            if (GlobalVar.rsy2 < 0)
            {
                GlobalVar.rsy2 = Convert.ToDouble(panel2.Height - GlobalVar.pictureBox3.Height);
            } // end if

            GlobalVar.pictureBox3.Location = new Point(Convert.ToInt32(GlobalVar.rsx2), Convert.ToInt32(GlobalVar.rsy2));

            GlobalVar.rsdx3 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.rsx3 += GlobalVar.rsdx3;
            if (GlobalVar.rsx3 > panel2.Width - GlobalVar.pictureBox4.Width)
            {
                GlobalVar.rsx3 = 0;
            } // end if
            if (GlobalVar.rsx3 < 0)
            {
                GlobalVar.rsx3 = Convert.ToDouble(panel2.Width - GlobalVar.pictureBox4.Width);
            } // end if

            GlobalVar.rsy3 += GlobalVar.rsdy3;
            if (GlobalVar.rsy3 > panel2.Height - GlobalVar.pictureBox4.Height)
            {
                GlobalVar.rsy3 = 0;
            } // end if 
            if (GlobalVar.rsy3 < 0)
            {
                GlobalVar.rsy3 = Convert.ToDouble(panel2.Height - GlobalVar.pictureBox4.Height);
            } // end if

            GlobalVar.pictureBox4.Location = new Point(Convert.ToInt32(GlobalVar.rsx3), Convert.ToInt32(GlobalVar.rsy3));

            GlobalVar.rsdx4 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.rsx4 += GlobalVar.rsdx4;
            if (GlobalVar.rsx4 > panel2.Width - GlobalVar.pictureBox5.Width)
            {
                GlobalVar.rsx4 = 0;
            } // end if
            if (GlobalVar.rsx4 < 0)
            {
                GlobalVar.rsx4 = Convert.ToDouble(panel1.Width - GlobalVar.pictureBox5.Width);
            } // end if

            GlobalVar.rsy4 += GlobalVar.rsdy4;
            if (GlobalVar.rsy4 > panel2.Height - GlobalVar.pictureBox5.Height)
            {
                GlobalVar.rsy4 = 0;
            } // end if 
            if (GlobalVar.rsy4 < 0)
            {
                GlobalVar.rsy4 = Convert.ToDouble(panel2.Height - GlobalVar.pictureBox5.Height);
            } // end if

            GlobalVar.pictureBox5.Location = new Point(Convert.ToInt32(GlobalVar.rsx4), Convert.ToInt32(GlobalVar.rsy4));

            GlobalVar.rsdx5 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.rsx5 += GlobalVar.rsdx5;
            if (GlobalVar.rsx5 > panel2.Width - GlobalVar.pictureBox6.Width)
            {
                GlobalVar.rsx5 = 0;
            } // end if
            if (GlobalVar.rsx5 < 0)
            {
                GlobalVar.rsx5 = Convert.ToDouble(panel2.Width - GlobalVar.pictureBox6.Width);
            } // end if

            GlobalVar.rsy5 += GlobalVar.rsdy5;
            if (GlobalVar.rsy5 > panel2.Height - GlobalVar.pictureBox6.Height)
            {
                GlobalVar.rsy5 = 0;
            } // end if 
            if (GlobalVar.rsy5 < 0)
            {
                GlobalVar.rsy5 = Convert.ToDouble(panel2.Height - GlobalVar.pictureBox6.Height);
            } // end if

            GlobalVar.pictureBox6.Location = new Point(Convert.ToInt32(GlobalVar.rsx5), Convert.ToInt32(GlobalVar.rsy5));

            GlobalVar.rsdx6 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.rsx6 += GlobalVar.rsdx6;
            if (GlobalVar.rsx6 > panel2.Width - GlobalVar.pictureBox7.Width)
            {
                GlobalVar.rsx6 = 0;
            } // end if
            if (GlobalVar.rsx6 < 0)
            {
                GlobalVar.rsx6 = Convert.ToDouble(panel2.Width - GlobalVar.pictureBox7.Width);
            } // end if

            GlobalVar.rsy6 += GlobalVar.rsdy6;
            if (GlobalVar.rsy6 > panel2.Height - GlobalVar.pictureBox7.Height)
            {
                GlobalVar.rsy6 = 0;
            } // end if 
            if (GlobalVar.rsy6 < 0)
            {
                GlobalVar.rsy6 = Convert.ToDouble(panel2.Height - GlobalVar.pictureBox7.Height);
            } // end if

            GlobalVar.pictureBox7.Location = new Point(Convert.ToInt32(GlobalVar.rsx6), Convert.ToInt32(GlobalVar.rsy6));

            GlobalVar.rsdx7 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.rsx7 += GlobalVar.rsdx7;
            if (GlobalVar.rsx7 > panel2.Width - GlobalVar.pictureBox8.Width)
            {
                GlobalVar.rsx7 = 0;
            } // end if
            if (GlobalVar.rsx7 < 0)
            {
                GlobalVar.rsx7 = Convert.ToDouble(panel2.Width - GlobalVar.pictureBox8.Width);
            } // end if

            GlobalVar.rsy7 += GlobalVar.rsdy7;
            if (GlobalVar.rsy7 > panel2.Height - GlobalVar.pictureBox8.Height)
            {
                GlobalVar.rsy7 = 0;
            } // end if 
            if (GlobalVar.rsy7 < 0)
            {
                GlobalVar.rsy7 = Convert.ToDouble(panel2.Height - GlobalVar.pictureBox8.Height);
            } // end if

            GlobalVar.pictureBox8.Location = new Point(Convert.ToInt32(GlobalVar.rsx7), Convert.ToInt32(GlobalVar.rsy7));

            GlobalVar.rsdx8 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.rsx8 += GlobalVar.rsdx8;
            if (GlobalVar.rsx8 > panel2.Width - GlobalVar.pictureBox9.Width)
            {
                GlobalVar.rsx8 = 0;
            } // end if
            if (GlobalVar.rsx8 < 0)
            {
                GlobalVar.rsx8 = Convert.ToDouble(panel2.Width - GlobalVar.pictureBox9.Width);
            } // end if

            GlobalVar.rsy8 += GlobalVar.rsdy8;
            if (GlobalVar.rsy8 > panel2.Height - GlobalVar.pictureBox9.Height)
            {
                GlobalVar.rsy8 = 0;
            } // end if 
            if (GlobalVar.rsy8 < 0)
            {
                GlobalVar.rsy8 = Convert.ToDouble(panel2.Height - GlobalVar.pictureBox9.Height);
            } // end if

            GlobalVar.pictureBox9.Location = new Point(Convert.ToInt32(GlobalVar.rsx8), Convert.ToInt32(GlobalVar.rsy8));

            GlobalVar.rsdx9 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.rsx9 += GlobalVar.rsdx9;
            if (GlobalVar.rsx9 > panel2.Width - GlobalVar.pictureBox10.Width)
            {
                GlobalVar.rsx9 = 0;
            } // end if
            if (GlobalVar.rsx9 < 0)
            {
                GlobalVar.rsx9 = Convert.ToDouble(panel2.Width - GlobalVar.pictureBox10.Width);
            } // end if

            GlobalVar.rsy9 += GlobalVar.rsdy9;
            if (GlobalVar.rsy9 > panel2.Height - GlobalVar.pictureBox10.Height)
            {
                GlobalVar.rsy9 = 0;
            } // end if 
            if (GlobalVar.rsy9 < 0)
            {
                GlobalVar.rsy9 = Convert.ToDouble(panel2.Height - GlobalVar.pictureBox10.Height);
            } // end if

            GlobalVar.pictureBox10.Location = new Point(Convert.ToInt32(GlobalVar.rsx9), Convert.ToInt32(GlobalVar.rsy9));
        }

        public void initGame()
        {
            switch (GlobalVar.level)
            {
                case 1:
                    initLvlOne();
                    initLvlTwo();
                    initLvlThree();
                    initLvlFour();
                    initLvlFive();
                    initLvlSix();
                    initLvlSeven();
                    initLvlEight();
                    initLvlNine();
                    initLvlTen();
                    break;
                default:
                    MessageBox.Show("Something have gone wrong. The application will close now.");
                    Application.Exit();
                    break;
            }
            timer1.Enabled = true;
        }

        public void initLvlOne()
        {
            Random roller = new Random();
            int speX, speY; // clicking object location points.
            
            GlobalVar.rsdy = Convert.ToDouble(roller.Next(5) + 1);
            GlobalVar.rsdx = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.rsx = Convert.ToDouble(roller.Next(panel2.Width - GlobalVar.pictureBox1.Width));
            GlobalVar.rsy = Convert.ToDouble(roller.Next(panel2.Height - GlobalVar.pictureBox1.Height));
            speX = roller.Next(panel2.Width - GlobalVar.pictureBox1.Width);
            speY = roller.Next(panel2.Height - GlobalVar.pictureBox1.Height);
            GlobalVar.pictureBox1.BackgroundImage = imageList1.Images[0];
            GlobalVar.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            GlobalVar.pictureBox1.Size = new Size(10, 10);
            GlobalVar.pictureBox1.Location = new Point(speX, 0);
            GlobalVar.pictureBox1.Name = "picturebox1";
            GlobalVar.pictureBox1.Visible = true;
        }

        public void initLvlTwo()
        {
            Random roller = new Random();
            int speX, speY; // clicking object location points.

            GlobalVar.rsdy1 = Convert.ToDouble(roller.Next(5) + 1);
            GlobalVar.rsdx1 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.rsx1 = Convert.ToDouble(roller.Next(panel2.Width - GlobalVar.pictureBox2.Width));
            //GlobalVar.rsy1 = Convert.ToDouble(roller.Next(panel2.Height - GlobalVar.pictureBox2.Height));
            GlobalVar.rsy1 = 0;
            speX = roller.Next(panel2.Width - GlobalVar.pictureBox2.Width);
            speY = roller.Next(panel2.Height - GlobalVar.pictureBox2.Height);
            GlobalVar.pictureBox2.BackgroundImage = imageList1.Images[0];
            GlobalVar.pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            GlobalVar.pictureBox2.Size = new Size(10, 10);
            GlobalVar.pictureBox2.Location = new Point(speX, 0);
            GlobalVar.pictureBox2.Name = "picturebox2"; 
            GlobalVar.pictureBox2.Visible = true;
        }

        public void initLvlThree()
        {
            Random roller = new Random();
            int speX2, speY2; // clicking object location points.
            
            GlobalVar.rsdy2 = Convert.ToDouble(roller.Next(5) + 1);
            GlobalVar.rsdx2 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.rsx2 = Convert.ToDouble(roller.Next(panel2.Width - GlobalVar.pictureBox3.Width));
            //GlobalVar.rsy2 = Convert.ToDouble(roller.Next(panel2.Height - GlobalVar.pictureBox3.Height));
            GlobalVar.rsy2 = 0;
            speX2 = roller.Next(panel2.Width - GlobalVar.pictureBox3.Width);
            speY2 = roller.Next(panel2.Height - GlobalVar.pictureBox3.Height);
            GlobalVar.pictureBox3.BackgroundImage = imageList1.Images[0];
            GlobalVar.pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            GlobalVar.pictureBox3.Size = new Size(10, 10);
            GlobalVar.pictureBox3.Location = new Point(speX2, 0);
            GlobalVar.pictureBox3.Name = "picturebox3";
            GlobalVar.pictureBox3.Visible = true;
        }

        public void initLvlFour()
        {
            Random roller = new Random();
            int speX3, speY3; // clicking object location points.

            GlobalVar.rsdy3 = Convert.ToDouble(roller.Next(5) + 1);
            GlobalVar.rsdx3 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.rsx4 = Convert.ToDouble(roller.Next(panel2.Width - GlobalVar.pictureBox4.Width));
            //GlobalVar.rsy4 = Convert.ToDouble(roller.Next(panel2.Height - GlobalVar.pictureBox4.Height));
            GlobalVar.rsy4 = 0;
            speX3 = roller.Next(panel2.Width - GlobalVar.pictureBox4.Width);
            speY3 = roller.Next(panel2.Height - GlobalVar.pictureBox4.Height);
            GlobalVar.pictureBox4.BackgroundImage = imageList1.Images[0];
            GlobalVar.pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            GlobalVar.pictureBox4.Size = new Size(10, 10);
            GlobalVar.pictureBox4.Location = new Point(speX3, 0);
            GlobalVar.pictureBox4.Name = "picturebox4";
            GlobalVar.pictureBox4.Visible = true;
        }

        public void initLvlFive()
        {
            Random roller = new Random();
            int speX4, speY4; // clicking object location points.

            GlobalVar.rsdy4 = Convert.ToDouble(roller.Next(5) + 1);
            GlobalVar.rsdx4 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.rsx4 = Convert.ToDouble(roller.Next(panel2.Width - GlobalVar.pictureBox5.Width));
            //GlobalVar.rsy4 = Convert.ToDouble(roller.Next(panel2.Height - GlobalVar.pictureBox5.Height));
            GlobalVar.rsy4 = 0;
            speX4 = roller.Next(panel2.Width - GlobalVar.pictureBox5.Width);
            speY4 = roller.Next(panel2.Height - GlobalVar.pictureBox5.Height);
            GlobalVar.pictureBox5.BackgroundImage = imageList1.Images[0];
            GlobalVar.pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            GlobalVar.pictureBox5.Size = new Size(10, 10);
            GlobalVar.pictureBox5.Location = new Point(speX4, 0);
            GlobalVar.pictureBox5.Name = "picturebox5";
            GlobalVar.pictureBox5.Visible = true;
        }

        public void initLvlSix()
        {
            Random roller = new Random();
            int speX5, speY5; // clicking object location points.

            GlobalVar.rsdy5 = Convert.ToDouble(roller.Next(5) + 1);
            GlobalVar.rsdx5 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.rsx5 = Convert.ToDouble(roller.Next(panel2.Width - GlobalVar.pictureBox6.Width));
            //GlobalVar.rsy5 = Convert.ToDouble(roller.Next(panel2.Height - GlobalVar.pictureBox6.Height));
            GlobalVar.rsy5 = 0;
            speX5 = roller.Next(panel2.Width - GlobalVar.pictureBox6.Width);
            speY5 = roller.Next(panel2.Height - GlobalVar.pictureBox6.Height);
            GlobalVar.pictureBox6.BackgroundImage = imageList1.Images[0];
            GlobalVar.pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            GlobalVar.pictureBox6.Size = new Size(10, 10);
            GlobalVar.pictureBox6.Location = new Point(speX5, 0);
            GlobalVar.pictureBox6.Name = "picturebox6";
            GlobalVar.pictureBox6.Visible = true;
        }

        public void initLvlSeven()
        {
            Random roller = new Random();
            int speX6, speY6; // clicking object location points.

            GlobalVar.rsdy6 = Convert.ToDouble(roller.Next(5) + 1);
            GlobalVar.rsdx6 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.rsx6 = Convert.ToDouble(roller.Next(panel2.Width - GlobalVar.pictureBox7.Width));
            //GlobalVar.rsy6 = Convert.ToDouble(roller.Next(panel2.Height - GlobalVar.pictureBox7.Height));
            GlobalVar.rsy6 = 0;
            speX6 = roller.Next(panel2.Width - GlobalVar.pictureBox7.Width);
            speY6 = roller.Next(panel2.Height - GlobalVar.pictureBox7.Height);
            GlobalVar.pictureBox7.BackgroundImage = imageList1.Images[0];
            GlobalVar.pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            GlobalVar.pictureBox7.Size = new Size(10, 10);
            GlobalVar.pictureBox7.Location = new Point(speX6, 0);
            GlobalVar.pictureBox7.Name = "picturebox7";
            GlobalVar.pictureBox7.Visible = true;
        }

        public void initLvlEight()
        {
            Random roller = new Random();
            int speX7, speY7; // clicking object location points.
            
            GlobalVar.rsdy7 = Convert.ToDouble(roller.Next(5) + 1);
            GlobalVar.rsdx7 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.rsx7 = Convert.ToDouble(roller.Next(panel2.Width - GlobalVar.pictureBox8.Width));
            //GlobalVar.rsy7 = Convert.ToDouble(roller.Next(panel2.Height - GlobalVar.pictureBox8.Height));
            GlobalVar.rsy7 = 0;
            speX7 = roller.Next(panel2.Width - GlobalVar.pictureBox8.Width);
            speY7 = roller.Next(panel2.Height - GlobalVar.pictureBox8.Height);
            GlobalVar.pictureBox8.BackgroundImage = imageList1.Images[0];
            GlobalVar.pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
            GlobalVar.pictureBox8.Size = new Size(10, 10);
            GlobalVar.pictureBox8.Location = new Point(speX7, 0);
            GlobalVar.pictureBox8.Name = "picturebox8";
            GlobalVar.pictureBox8.Visible = true;
        }

        public void initLvlNine()
        {
            Random roller = new Random();
            int speX8, speY8; // clicking object location points.
                        
            GlobalVar.rsdy8 = Convert.ToDouble(roller.Next(5) + 1);
            GlobalVar.rsdx8 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.rsx8 = Convert.ToDouble(roller.Next(panel2.Width - GlobalVar.pictureBox9.Width));
            //GlobalVar.rsy8 = Convert.ToDouble(roller.Next(panel2.Height - GlobalVar.pictureBox9.Height));
            GlobalVar.rsy8 = 0;
            speX8 = roller.Next(panel2.Width - GlobalVar.pictureBox9.Width);
            speY8 = roller.Next(panel2.Height - GlobalVar.pictureBox9.Height);
            GlobalVar.pictureBox9.BackgroundImage = imageList1.Images[0];
            GlobalVar.pictureBox9.BackgroundImageLayout = ImageLayout.Stretch;
            GlobalVar.pictureBox9.Size = new Size(10, 10);
            GlobalVar.pictureBox9.Location = new Point(speX8, 0);
            GlobalVar.pictureBox9.Name = "picturebox9";
            GlobalVar.pictureBox9.Visible = true;
        }

        public void initLvlTen()
        {
            Random roller = new Random();
            int speX9, speY9; // clicking object location points.

            GlobalVar.rsdy9 = Convert.ToDouble(roller.Next(5) + 1);
            GlobalVar.rsdx9 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.rsx9 = Convert.ToDouble(roller.Next(panel2.Width - GlobalVar.pictureBox10.Width));
            //GlobalVar.rsy9 = Convert.ToDouble(roller.Next(panel2.Height - GlobalVar.pictureBox10.Height));
            GlobalVar.rsy9 = 0;
            speX9 = roller.Next(panel2.Width - GlobalVar.pictureBox10.Width);
            speY9 = roller.Next(panel2.Height - GlobalVar.pictureBox10.Height);
            GlobalVar.pictureBox10.BackgroundImage = imageList1.Images[0];
            GlobalVar.pictureBox10.BackgroundImageLayout = ImageLayout.Stretch;
            GlobalVar.pictureBox10.Size = new Size(10, 10);
            GlobalVar.pictureBox10.Location = new Point(speX9, 0);
            GlobalVar.pictureBox10.Name = "picturebox10";
            GlobalVar.pictureBox10.Visible = true;
        }
    }
}
