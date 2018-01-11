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
            link();   
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

        

        }
    }
}
