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

            GlobalVar.pictureBox11.Click += new System.EventHandler(this.PictureBoxClick);
            GlobalVar.pictureBox12.Click += new System.EventHandler(this.PictureBoxClick);
            GlobalVar.pictureBox13.Click += new System.EventHandler(this.PictureBoxClick);
            GlobalVar.pictureBox14.Click += new System.EventHandler(this.PictureBoxClick);
            GlobalVar.pictureBox15.Click += new System.EventHandler(this.PictureBoxClick);
            GlobalVar.pictureBox16.Click += new System.EventHandler(this.PictureBoxClick);
            GlobalVar.pictureBox17.Click += new System.EventHandler(this.PictureBoxClick);
            GlobalVar.pictureBox18.Click += new System.EventHandler(this.PictureBoxClick);
            GlobalVar.pictureBox19.Click += new System.EventHandler(this.PictureBoxClick);
            GlobalVar.pictureBox20.Click += new System.EventHandler(this.PictureBoxClick);

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

            panel2.Controls.Add(GlobalVar.pictureBox11);
            panel2.Controls.Add(GlobalVar.pictureBox12);
            panel2.Controls.Add(GlobalVar.pictureBox13);
            panel2.Controls.Add(GlobalVar.pictureBox14);
            panel2.Controls.Add(GlobalVar.pictureBox15);
            panel2.Controls.Add(GlobalVar.pictureBox16);
            panel2.Controls.Add(GlobalVar.pictureBox17);
            panel2.Controls.Add(GlobalVar.pictureBox18);
            panel2.Controls.Add(GlobalVar.pictureBox19);
            panel2.Controls.Add(GlobalVar.pictureBox20);
            initGame();
        }

        private void PictureBoxClick(object sender, EventArgs e)
        {
            panel2.Controls.Remove((PictureBox)sender);
            switch (((PictureBox)sender).Name)
            {
                case "picturebox1":
                    GlobalVar.score += 5;
                    initSnowOne();
                    break;
                case "picturebox2":
                    GlobalVar.score += 5;
                    initSnowTwo();
                    break;
                case "picturebox3":
                    GlobalVar.score += 5;
                    initSnowThree();
                    break;
                case "picturebox4":
                    GlobalVar.score += 5;
                    initSnowFour();
                    break;
                case "picturebox5":
                    GlobalVar.score += 5;
                    initSnowFive();
                    break;
                case "picturebox6":
                    GlobalVar.score += 5;
                    initSnowSix();
                    break;
                case "picturebox7":
                    GlobalVar.score += 5;
                    initSnowSeven();
                    break;
                case "picturebox8":
                    GlobalVar.score += 5;
                    initSnowEight();
                    break;
                case "picturebox9":
                    GlobalVar.score += 5;
                    initSnowNine();
                    break;
                case "picturebox10":
                    GlobalVar.score += 5;
                    initSnowTen();
                    break;
                case "picturebox11":
                    GlobalVar.score++;
                    initLeafOne();
                    break;
                case "picturebox12":
                    GlobalVar.score++;
                    initLeafTwo();
                    break;
                case "picturebox13":
                    GlobalVar.score++;
                    initLeafThree();
                    break;
                case "picturebox14":
                    GlobalVar.score++;
                    initLeafFour();
                    break;
                case "picturebox15":
                    GlobalVar.score++;
                    initLeafFive();
                    break;
                case "picturebox16":
                    GlobalVar.score++;
                    initLeafSix();
                    break;
                case "picturebox17":
                    GlobalVar.score++;
                    initLeafSeven();
                    break;
                case "picturebox18":
                    GlobalVar.score++;
                    initLeafEight();
                    break;
                case "picturebox19":
                    GlobalVar.score++;
                    initLeafNine();
                    break;
                case "picturebox20":
                    GlobalVar.score++;
                    initLeafTen();
                    break;
                default:
                    break;
            }
            panel2.Controls.Add((PictureBox)sender);
            if (GlobalVar.score < 0)
            {
                DialogResult result;
                result = MessageBox.Show("Play Again?", "Game Over", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    initGame();
                }
                else
                {
                    Application.Exit();
                }
            }
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

            GlobalVar.lsdx = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.lsx += GlobalVar.lsdx;
            if (GlobalVar.lsx > panel2.Width - GlobalVar.pictureBox11.Width)
            {
                GlobalVar.lsx = 0;
            } // end if
            if (GlobalVar.lsx < 0)
            {
                GlobalVar.lsx = Convert.ToDouble(panel2.Width - GlobalVar.pictureBox11.Width);
            } // end if

            GlobalVar.lsy += GlobalVar.lsdy;
            if (GlobalVar.lsy > panel2.Height - GlobalVar.pictureBox11.Height)
            {
                GlobalVar.lsy = 0;
            } // end if 
            if (GlobalVar.lsy < 0)
            {
                GlobalVar.lsy = Convert.ToDouble(panel2.Height - GlobalVar.pictureBox11.Height);
            } // end if

            GlobalVar.pictureBox11.Location = new Point(Convert.ToInt32(GlobalVar.lsx), Convert.ToInt32(GlobalVar.lsy));

            GlobalVar.lsdx1 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.lsx1 += GlobalVar.rsdx9;
            if (GlobalVar.lsx1 > panel2.Width - GlobalVar.pictureBox12.Width)
            {
                GlobalVar.lsx1 = 0;
            } // end if
            if (GlobalVar.lsx1 < 0)
            {
                GlobalVar.lsx1 = Convert.ToDouble(panel2.Width - GlobalVar.pictureBox12.Width);
            } // end if

            GlobalVar.lsy1 += GlobalVar.rsdy9;
            if (GlobalVar.lsy1 > panel2.Height - GlobalVar.pictureBox12.Height)
            {
                GlobalVar.lsy1 = 0;
            } // end if 
            if (GlobalVar.lsy1 < 0)
            {
                GlobalVar.lsy1 = Convert.ToDouble(panel2.Height - GlobalVar.pictureBox12.Height);
            } // end if

            GlobalVar.pictureBox12.Location = new Point(Convert.ToInt32(GlobalVar.lsx1), Convert.ToInt32(GlobalVar.lsy1));

            GlobalVar.lsdx2 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.lsx2 += GlobalVar.rsdx9;
            if (GlobalVar.lsx2 > panel2.Width - GlobalVar.pictureBox13.Width)
            {
                GlobalVar.lsx2 = 0;
            } // end if
            if (GlobalVar.lsx2 < 0)
            {
                GlobalVar.lsx2 = Convert.ToDouble(panel2.Width - GlobalVar.pictureBox13.Width);
            } // end if

            GlobalVar.lsy2 += GlobalVar.rsdy9;
            if (GlobalVar.lsy2 > panel2.Height - GlobalVar.pictureBox13.Height)
            {
                GlobalVar.lsy2 = 0;
            } // end if 
            if (GlobalVar.lsy2 < 0)
            {
                GlobalVar.lsy2 = Convert.ToDouble(panel2.Height - GlobalVar.pictureBox13.Height);
            } // end if

            GlobalVar.pictureBox13.Location = new Point(Convert.ToInt32(GlobalVar.lsx2), Convert.ToInt32(GlobalVar.lsy2));

            GlobalVar.lsdx3 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.lsx3 += GlobalVar.lsdx3;
            if (GlobalVar.lsx3 > panel2.Width - GlobalVar.pictureBox14.Width)
            {
                GlobalVar.lsx3 = 0;
            } // end if
            if (GlobalVar.lsx3 < 0)
            {
                GlobalVar.lsx3 = Convert.ToDouble(panel2.Width - GlobalVar.pictureBox14.Width);
            } // end if

            GlobalVar.lsy3 += GlobalVar.lsdy3;
            if (GlobalVar.lsy3 > panel2.Height - GlobalVar.pictureBox14.Height)
            {
                GlobalVar.lsy3 = 0;
            } // end if 
            if (GlobalVar.lsy3 < 0)
            {
                GlobalVar.lsy3 = Convert.ToDouble(panel2.Height - GlobalVar.pictureBox14.Height);
            } // end if

            GlobalVar.pictureBox14.Location = new Point(Convert.ToInt32(GlobalVar.lsx3), Convert.ToInt32(GlobalVar.lsy3));

            GlobalVar.lsdx4 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.lsx4 += GlobalVar.rsdx9;
            if (GlobalVar.lsx4 > panel2.Width - GlobalVar.pictureBox15.Width)
            {
                GlobalVar.lsx4 = 0;
            } // end if
            if (GlobalVar.lsx4 < 0)
            {
                GlobalVar.lsx4 = Convert.ToDouble(panel2.Width - GlobalVar.pictureBox15.Width);
            } // end if

            GlobalVar.lsy4 += GlobalVar.lsdy4;
            if (GlobalVar.lsy4 > panel2.Height - GlobalVar.pictureBox15.Height)
            {
                GlobalVar.lsy4 = 0;
            } // end if 
            if (GlobalVar.lsy4 < 0)
            {
                GlobalVar.lsy4 = Convert.ToDouble(panel2.Height - GlobalVar.pictureBox15.Height);
            } // end if

            GlobalVar.pictureBox15.Location = new Point(Convert.ToInt32(GlobalVar.lsx4), Convert.ToInt32(GlobalVar.lsy4));

            GlobalVar.lsdx5 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.lsx5 += GlobalVar.lsdx5;
            if (GlobalVar.lsx5 > panel2.Width - GlobalVar.pictureBox16.Width)
            {
                GlobalVar.lsx5 = 0;
            } // end if
            if (GlobalVar.lsx5 < 0)
            {
                GlobalVar.lsx5 = Convert.ToDouble(panel2.Width - GlobalVar.pictureBox16.Width);
            } // end if

            GlobalVar.lsy5 += GlobalVar.lsdy5;
            if (GlobalVar.lsy5 > panel2.Height - GlobalVar.pictureBox16.Height)
            {
                GlobalVar.lsy5 = 0;
            } // end if 
            if (GlobalVar.lsy5 < 0)
            {
                GlobalVar.lsy5 = Convert.ToDouble(panel2.Height - GlobalVar.pictureBox16.Height);
            } // end if

            GlobalVar.pictureBox16.Location = new Point(Convert.ToInt32(GlobalVar.lsx5), Convert.ToInt32(GlobalVar.lsy5));

            GlobalVar.lsdx6 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.lsx6 += GlobalVar.rsdx9;
            if (GlobalVar.lsx6 > panel2.Width - GlobalVar.pictureBox17.Width)
            {
                GlobalVar.lsx6 = 0;
            } // end if
            if (GlobalVar.lsx6 < 0)
            {
                GlobalVar.lsx6 = Convert.ToDouble(panel2.Width - GlobalVar.pictureBox17.Width);
            } // end if

            GlobalVar.lsy6 += GlobalVar.lsdy6;
            if (GlobalVar.lsy6 > panel2.Height - GlobalVar.pictureBox17.Height)
            {
                GlobalVar.lsy6 = 0;
            } // end if 
            if (GlobalVar.lsy6 < 0)
            {
                GlobalVar.lsy6 = Convert.ToDouble(panel2.Height - GlobalVar.pictureBox17.Height);
            } // end if

            GlobalVar.pictureBox17.Location = new Point(Convert.ToInt32(GlobalVar.lsx6), Convert.ToInt32(GlobalVar.lsy6));

            GlobalVar.lsdx7 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.lsx7 += GlobalVar.lsdx7;
            if (GlobalVar.lsx7 > panel2.Width - GlobalVar.pictureBox18.Width)
            {
                GlobalVar.lsx7 = 0;
            } // end if
            if (GlobalVar.lsx7 < 0)
            {
                GlobalVar.lsx7 = Convert.ToDouble(panel2.Width - GlobalVar.pictureBox18.Width);
            } // end if

            GlobalVar.lsy7 += GlobalVar.lsdy7;
            if (GlobalVar.lsy7 > panel2.Height - GlobalVar.pictureBox18.Height)
            {
                GlobalVar.lsy7 = 0;
            } // end if 
            if (GlobalVar.lsy7 < 0)
            {
                GlobalVar.lsy7 = Convert.ToDouble(panel2.Height - GlobalVar.pictureBox18.Height);
            } // end if

            GlobalVar.pictureBox18.Location = new Point(Convert.ToInt32(GlobalVar.rsx7), Convert.ToInt32(GlobalVar.rsy7));

            GlobalVar.lsdx8 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.lsx8 += GlobalVar.lsdx8;
            if (GlobalVar.lsx8 > panel2.Width - GlobalVar.pictureBox19.Width)
            {
                GlobalVar.lsx8 = 0;
            } // end if
            if (GlobalVar.lsx8 < 0)
            {
                GlobalVar.lsx8 = Convert.ToDouble(panel2.Width - GlobalVar.pictureBox19.Width);
            } // end if

            GlobalVar.lsy8 += GlobalVar.lsdy8;
            if (GlobalVar.lsy8 > panel2.Height - GlobalVar.pictureBox19.Height)
            {
                GlobalVar.lsy8 = 0;
            } // end if 
            if (GlobalVar.lsy8 < 0)
            {
                GlobalVar.lsy8 = Convert.ToDouble(panel2.Height - GlobalVar.pictureBox19.Height);
            } // end if

            GlobalVar.pictureBox19.Location = new Point(Convert.ToInt32(GlobalVar.lsx8), Convert.ToInt32(GlobalVar.lsy8));

            GlobalVar.lsdx9 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.lsx9 += GlobalVar.lsdx9;
            if (GlobalVar.lsx9 > panel2.Width - GlobalVar.pictureBox20.Width)
            {
                GlobalVar.lsx9 = 0;
            } // end if
            if (GlobalVar.lsx9 < 0)
            {
                GlobalVar.lsx9 = Convert.ToDouble(panel2.Width - GlobalVar.pictureBox20.Width);
            } // end if

            GlobalVar.lsy9 += GlobalVar.lsdy9;
            if (GlobalVar.lsy9 > panel2.Height - GlobalVar.pictureBox20.Height)
            {
                GlobalVar.lsy9 = 0;
            } // end if 
            if (GlobalVar.lsy9 < 0)
            {
                GlobalVar.lsy9 = Convert.ToDouble(panel2.Height - GlobalVar.pictureBox20.Height);
            } // end if

            GlobalVar.pictureBox20.Location = new Point(Convert.ToInt32(GlobalVar.lsx9), Convert.ToInt32(GlobalVar.lsy9));
        }

        public void initGame()
        {
            switch (GlobalVar.level)
            {
                case 1:
                    initSnowOne();
                    initSnowTwo();
                    initSnowThree();
                    initSnowFour();
                    initSnowFive();
                    initSnowSix();
                    initSnowSeven();
                    initSnowEight();
                    initSnowNine();
                    initSnowTen();
                    initLeafOne();
                    initLeafTwo();
                    initLeafThree();
                    initLeafFour();
                    initLeafFive();
                    initLeafSix();
                    initLeafSeven();
                    initLeafEight();
                    initLeafNine();
                    initLeafTen();
                    break;
                default:
                    MessageBox.Show("Something have gone wrong. The application will close now.");
                    Application.Exit();
                    break;
            }
            timer1.Enabled = true;
        }

        public void initSnowOne()
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

        public void initSnowTwo()
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

        public void initSnowThree()
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

        public void initSnowFour()
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

        public void initSnowFive()
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

        public void initSnowSix()
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

        public void initSnowSeven()
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

        public void initSnowEight()
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

        public void initSnowNine()
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

        public void initSnowTen()
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

        public void initLeafOne()
        {
            Random roller = new Random();
            int speX9, speY9; // clicking object location points.

            GlobalVar.lsdy = Convert.ToDouble(roller.Next(5) + 1);
            GlobalVar.lsdx = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.lsx = Convert.ToDouble(roller.Next(panel2.Width - GlobalVar.pictureBox11.Width));
            GlobalVar.lsy = 0;
            speX9 = roller.Next(panel2.Width - GlobalVar.pictureBox11.Width);
            speY9 = roller.Next(panel2.Height - GlobalVar.pictureBox11.Height);
            GlobalVar.pictureBox11.BackgroundImage = imageList1.Images[1];
            GlobalVar.pictureBox11.BackgroundImageLayout = ImageLayout.Stretch;
            GlobalVar.pictureBox11.Size = new Size(15, 15);
            GlobalVar.pictureBox11.Location = new Point(speX9, 0);
            GlobalVar.pictureBox11.Name = "picturebox11";
            GlobalVar.pictureBox11.Visible = true;
        }

        public void initLeafTwo()
        {
            Random roller = new Random();
            int speX9, speY9; // clicking object location points.

            GlobalVar.lsdy1 = Convert.ToDouble(roller.Next(5) + 1);
            GlobalVar.lsdx1 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.lsx1 = Convert.ToDouble(roller.Next(panel2.Width - GlobalVar.pictureBox12.Width));
            GlobalVar.lsy1 = 0;
            speX9 = roller.Next(panel2.Width - GlobalVar.pictureBox12.Width);
            speY9 = roller.Next(panel2.Height - GlobalVar.pictureBox12.Height);
            GlobalVar.pictureBox12.BackgroundImage = imageList1.Images[1];
            GlobalVar.pictureBox12.BackgroundImageLayout = ImageLayout.Stretch;
            GlobalVar.pictureBox12.Size = new Size(15, 15);
            GlobalVar.pictureBox12.Location = new Point(speX9, 0);
            GlobalVar.pictureBox12.Name = "picturebox12";
            GlobalVar.pictureBox12.Visible = true;
        }

        public void initLeafThree()
        {
            Random roller = new Random();
            int speX9, speY9; // clicking object location points.

            GlobalVar.lsdy2 = Convert.ToDouble(roller.Next(5) + 1);
            GlobalVar.lsdx2 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.lsx2 = Convert.ToDouble(roller.Next(panel2.Width - GlobalVar.pictureBox13.Width));
            GlobalVar.lsy2 = 0;
            speX9 = roller.Next(panel2.Width - GlobalVar.pictureBox13.Width);
            speY9 = roller.Next(panel2.Height - GlobalVar.pictureBox13.Height);
            GlobalVar.pictureBox13.BackgroundImage = imageList1.Images[1];
            GlobalVar.pictureBox13.BackgroundImageLayout = ImageLayout.Stretch;
            GlobalVar.pictureBox13.Size = new Size(15, 15);
            GlobalVar.pictureBox13.Location = new Point(speX9, 0);
            GlobalVar.pictureBox13.Name = "picturebox13";
            GlobalVar.pictureBox13.Visible = true;
        }

        public void initLeafFour()
        {
            Random roller = new Random();
            int speX9, speY9; // clicking object location points.

            GlobalVar.lsdy3 = Convert.ToDouble(roller.Next(5) + 1);
            GlobalVar.lsdx3 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.lsx3 = Convert.ToDouble(roller.Next(panel2.Width - GlobalVar.pictureBox14.Width));
            GlobalVar.lsy3 = 0;
            speX9 = roller.Next(panel2.Width - GlobalVar.pictureBox14.Width);
            speY9 = roller.Next(panel2.Height - GlobalVar.pictureBox14.Height);
            GlobalVar.pictureBox14.BackgroundImage = imageList1.Images[1];
            GlobalVar.pictureBox14.BackgroundImageLayout = ImageLayout.Stretch;
            GlobalVar.pictureBox14.Size = new Size(15, 15);
            GlobalVar.pictureBox14.Location = new Point(speX9, 0);
            GlobalVar.pictureBox14.Name = "picturebox14";
            GlobalVar.pictureBox14.Visible = true;
        }

        public void initLeafFive()
        {
            Random roller = new Random();
            int speX9, speY9; // clicking object location points.

            GlobalVar.lsdy4 = Convert.ToDouble(roller.Next(5) + 1);
            GlobalVar.lsdx4 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.lsx4 = Convert.ToDouble(roller.Next(panel2.Width - GlobalVar.pictureBox15.Width));
            GlobalVar.lsy4 = 0;
            speX9 = roller.Next(panel2.Width - GlobalVar.pictureBox15.Width);
            speY9 = roller.Next(panel2.Height - GlobalVar.pictureBox15.Height);
            GlobalVar.pictureBox15.BackgroundImage = imageList1.Images[1];
            GlobalVar.pictureBox15.BackgroundImageLayout = ImageLayout.Stretch;
            GlobalVar.pictureBox15.Size = new Size(15, 15);
            GlobalVar.pictureBox15.Location = new Point(speX9, 0);
            GlobalVar.pictureBox15.Name = "picturebox15";
            GlobalVar.pictureBox15.Visible = true;
        }

        public void initLeafSix()
        {
            Random roller = new Random();
            int speX9, speY9; // clicking object location points.

            GlobalVar.lsdy5 = Convert.ToDouble(roller.Next(5) + 1);
            GlobalVar.lsdx5 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.lsx5 = Convert.ToDouble(roller.Next(panel2.Width - GlobalVar.pictureBox16.Width));
            GlobalVar.lsy5 = 0;
            speX9 = roller.Next(panel2.Width - GlobalVar.pictureBox16.Width);
            speY9 = roller.Next(panel2.Height - GlobalVar.pictureBox16.Height);
            GlobalVar.pictureBox16.BackgroundImage = imageList1.Images[1];
            GlobalVar.pictureBox16.BackgroundImageLayout = ImageLayout.Stretch;
            GlobalVar.pictureBox16.Size = new Size(15, 15);
            GlobalVar.pictureBox16.Location = new Point(speX9, 0);
            GlobalVar.pictureBox16.Name = "picturebox16";
            GlobalVar.pictureBox16.Visible = true;
        }

        public void initLeafSeven()
        {
            Random roller = new Random();
            int speX9, speY9; // clicking object location points.

            GlobalVar.lsdy6 = Convert.ToDouble(roller.Next(5) + 1);
            GlobalVar.lsdx6 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.lsx6 = Convert.ToDouble(roller.Next(panel2.Width - GlobalVar.pictureBox17.Width));
            GlobalVar.lsy6 = 0;
            speX9 = roller.Next(panel2.Width - GlobalVar.pictureBox17.Width);
            speY9 = roller.Next(panel2.Height - GlobalVar.pictureBox17.Height);
            GlobalVar.pictureBox17.BackgroundImage = imageList1.Images[1];
            GlobalVar.pictureBox17.BackgroundImageLayout = ImageLayout.Stretch;
            GlobalVar.pictureBox17.Size = new Size(15, 15);
            GlobalVar.pictureBox17.Location = new Point(speX9, 0);
            GlobalVar.pictureBox17.Name = "picturebox17";
            GlobalVar.pictureBox17.Visible = true;
        }

        public void initLeafEight()
        {
            Random roller = new Random();
            int speX9, speY9; // clicking object location points.

            GlobalVar.lsdy7 = Convert.ToDouble(roller.Next(5) + 1);
            GlobalVar.lsdx7 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.lsx7 = Convert.ToDouble(roller.Next(panel2.Width - GlobalVar.pictureBox18.Width));
            GlobalVar.lsy7 = 0;
            speX9 = roller.Next(panel2.Width - GlobalVar.pictureBox18.Width);
            speY9 = roller.Next(panel2.Height - GlobalVar.pictureBox18.Height);
            GlobalVar.pictureBox18.BackgroundImage = imageList1.Images[1];
            GlobalVar.pictureBox18.BackgroundImageLayout = ImageLayout.Stretch;
            GlobalVar.pictureBox18.Size = new Size(15, 15);
            GlobalVar.pictureBox18.Location = new Point(speX9, 0);
            GlobalVar.pictureBox18.Name = "picturebox18";
            GlobalVar.pictureBox18.Visible = true;
        }

        public void initLeafNine()
        {
            Random roller = new Random();
            int speX9, speY9; // clicking object location points.

            GlobalVar.lsdy8 = Convert.ToDouble(roller.Next(5) + 1);
            GlobalVar.lsdx8 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.lsx8 = Convert.ToDouble(roller.Next(panel2.Width - GlobalVar.pictureBox19.Width));
            GlobalVar.lsy8 = 0;
            speX9 = roller.Next(panel2.Width - GlobalVar.pictureBox19.Width);
            speY9 = roller.Next(panel2.Height - GlobalVar.pictureBox19.Height);
            GlobalVar.pictureBox19.BackgroundImage = imageList1.Images[1];
            GlobalVar.pictureBox19.BackgroundImageLayout = ImageLayout.Stretch;
            GlobalVar.pictureBox19.Size = new Size(15, 15);
            GlobalVar.pictureBox19.Location = new Point(speX9, 0);
            GlobalVar.pictureBox19.Name = "picturebox19";
            GlobalVar.pictureBox19.Visible = true;
        }

        public void initLeafTen()
        {
            Random roller = new Random();
            int speX9, speY9; // clicking object location points.

            GlobalVar.lsdy9 = Convert.ToDouble(roller.Next(5) + 1);
            GlobalVar.lsdx9 = Convert.ToDouble(roller.Next(5) - 2);

            GlobalVar.lsx9 = Convert.ToDouble(roller.Next(panel2.Width - GlobalVar.pictureBox20.Width));
            GlobalVar.lsy9 = 0;
            speX9 = roller.Next(panel2.Width - GlobalVar.pictureBox20.Width);
            speY9 = roller.Next(panel2.Height - GlobalVar.pictureBox20.Height);
            GlobalVar.pictureBox20.BackgroundImage = imageList1.Images[1];
            GlobalVar.pictureBox20.BackgroundImageLayout = ImageLayout.Stretch;
            GlobalVar.pictureBox20.Size = new Size(15, 15);
            GlobalVar.pictureBox20.Location = new Point(speX9, 0);
            GlobalVar.pictureBox20.Name = "picturebox20";
            GlobalVar.pictureBox20.Visible = true;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
