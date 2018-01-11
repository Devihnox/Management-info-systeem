using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_app
{
    public partial class Form1 : Form
    {
        int xpos = -1;
        int ypos = 1;
        List<PictureBox> boxlist = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
<<<<<<< HEAD
            link();
<<<<<<< HEAD
=======
            link();      

>>>>>>> parent of ad2a993... Merge branch 'master' of https://github.com/Devihnox/Management-info-systeem
=======
            axWindowsMediaPlayer1.URL = "stormy";
            axWindowsMediaPlayer1.Ctlcontrols.play();

>>>>>>> parent of b80b9fd... muziek update
        }

        private void up_Click(object sender, EventArgs e)
        {
            ypos++;
            range();
            link();
            

        }

        private void down_Click(object sender, EventArgs e)
        {
            ypos--;
            range();
            link();
            
        }

        private void left_Click(object sender, EventArgs e)
        {
            xpos--;
            range();
            link();
            
        }

        private void right_Click(object sender, EventArgs e)
        {
            xpos++;
            range();
            link();
            
        }
        public void range()
        {
            if (xpos > 1)
            {
                xpos = -1;
                ypos = 1;
            }
            if (xpos < -1)
            {
                xpos = -1;
                ypos = 1;
            }
            if (ypos > 1)
            {
                ypos = 1;
                xpos = -1;
            }
            if (ypos < -1)
            {
                ypos = 1;
                xpos = -1;
            }
        }

        public void link()
        {
            if(xpos == 0 && ypos == 0)
            {
                pictureBox1.Image = test_app.Properties.Resources.link;
                this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                if (boxlist.Count == 0)
                {
                    boxlist.Add(pictureBox1);
                }
                else
                {
                    boxlist[0].Image = null;
                    boxlist.Remove(boxlist[0]);
                    boxlist.Add(pictureBox1);
                }
            }
            if (xpos == 1 && ypos == 0)
            {
                pictureBox9.Image = test_app.Properties.Resources.link;
                this.pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
                if (boxlist.Count == 0)
                {
                    boxlist.Add(pictureBox9);
                }
                else
                {
                    boxlist[0].Image = null;
                    boxlist.Remove(boxlist[0]);
                    boxlist.Add(pictureBox9);
                }
            }
            if (xpos == 1 && ypos == 1)
            {
                pictureBox6.Image = test_app.Properties.Resources.link;
                this.pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
                if (boxlist.Count == 0)
                {
                    boxlist.Add(pictureBox6);
                }
                else
                {
                    boxlist[0].Image = null;
                    boxlist.Remove(boxlist[0]);
                    boxlist.Add(pictureBox6);
                }
            }
            if (xpos == 0 && ypos == 1)
            {
                pictureBox7.Image = test_app.Properties.Resources.link;
                this.pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
                if (boxlist.Count == 0)
                {
                    boxlist.Add(pictureBox7);
                }
                else
                {
                    boxlist[0].Image = null;
                    boxlist.Remove(boxlist[0]);
                    boxlist.Add(pictureBox7);
                }
            }
            if (xpos == -1 && ypos == 0)
            {
                pictureBox4.Image = test_app.Properties.Resources.link;
                this.pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
                if (boxlist.Count == 0)
                {
                    boxlist.Add(pictureBox4);
                }
                else
                {
                    boxlist[0].Image = null;
                    boxlist.Remove(boxlist[0]);
                    boxlist.Add(pictureBox4);
                }
            }
            if (xpos == 0 && ypos == -1)
            {
                pictureBox2.Image = test_app.Properties.Resources.link;
                this.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                if (boxlist.Count == 0)
                {
                    boxlist.Add( pictureBox2);
                }
                else
                {
                    boxlist[0].Image = null;
                    boxlist.Remove(boxlist[0]);
                    boxlist.Add(pictureBox2);
                }
            }
            if (xpos == -1 && ypos == -1)
            {
                pictureBox5.Image = test_app.Properties.Resources.link;
                this.pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
                if (boxlist.Count == 0)
                {
                    boxlist.Add(pictureBox5);
                }
                else
                {
                    boxlist[0].Image = null;
                    boxlist.Remove(boxlist[0]);
                    boxlist.Add(pictureBox5);
                }
            }
            if (xpos == 1 && ypos == -1)
            {
                pictureBox3.Image = test_app.Properties.Resources.link;
                this.pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                if (boxlist.Count == 0)
                {
                    boxlist.Add(pictureBox3);
                }
                else
                {
                    boxlist[0].Image = null;
                    boxlist.Remove(boxlist[0]);
                    boxlist.Add(pictureBox3);
                }
            }
            if (xpos == -1 && ypos == 1)
            {
                pictureBox8.Image = test_app.Properties.Resources.link;
                this.pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
                if (boxlist.Count == 0)
                {
                    boxlist.Add(pictureBox8);
                }
                else
                {
                    boxlist[0].Image = null;
                    boxlist.Remove(boxlist[0]);
                    boxlist.Add(pictureBox8);
                }
            }


        }
    }
}
