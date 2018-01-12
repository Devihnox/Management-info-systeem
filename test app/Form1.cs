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



        public static int ypos = 1;
        public static int xpos = -1;

        public Form1()
        {
            InitializeComponent();

            move();

        }

        private void up_Click(object sender, EventArgs e)
        {
            ypos++;
            range();
            move();

        }

        private void down_Click(object sender, EventArgs e)
        {
            ypos--;
            range();
            move();


        }

        private void left_Click(object sender, EventArgs e)
        {
            xpos--;
            range();
            move();

        }

        private void right_Click(object sender, EventArgs e)
        {
            xpos++;
            range();
            move();


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

        private void move()
        {
            foreach(PictureBox p in panel1.Controls)
            {
                p.Image = null;
            }
            Link conlink = new Link(pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9);
        }
    }
}
