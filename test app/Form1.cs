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
        int position = 1;
        public Form1()
        {
            InitializeComponent();

            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
        }

        private void down_Click(object sender, EventArgs e)
        {
            position++;
            coordinate();
        }

        private void up_Click(object sender, EventArgs e)
        {
            position--;
            coordinate();
            if (position == 0)
            {
                position = 1;
            }
        }
        private void coordinate()
        {
            if(position == 2)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }

            if(position ==1)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
        }

        
    }
}
