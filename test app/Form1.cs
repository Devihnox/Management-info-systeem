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


        List<PictureBox> list = Position.boxlist;
        public static int ypos = 1;
        public static int xpos = -1;
        
        public Form1()
        {
            InitializeComponent();
            foreach(PictureBox p in panel1.Controls)
            {
                list.Add(p);
            }
            Link conlink = new Link();

        }

        private void up_Click(object sender, EventArgs e)
        {
            ypos++;
            range();
            Link conlink = new Link();


        }

        private void down_Click(object sender, EventArgs e)
        {
            ypos--;
            range();
            Link conlink = new Link();

        }

        private void left_Click(object sender, EventArgs e)
        {
            xpos--;
            range();
            Link conlink = new Link();

        }

        private void right_Click(object sender, EventArgs e)
        {
            xpos++;
            range();
            Link conlink = new Link();

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
    }
}
