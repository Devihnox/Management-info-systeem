﻿using System;
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

        List<PictureBox> list = new List<PictureBox>();


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
            foreach (PictureBox p in panel1.Controls)
            {
                p.Image = null;
            }
            Link conlink = new Link(pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            xpos = -1;
            ypos = 1;
            move();
        }

        private void rightbox_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.DoDragDrop(pb.Image, DragDropEffects.Copy);
        }

        private void rightbox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Bitmap)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Control[] Ray;
            for (int i = 0; i < 5; i++)
            {
                Ray = this.Controls.Find("Box" + i.ToString(), true);
                if (Ray.Length > 0 && Ray[0] is PictureBox)
                {
                    list.Add((PictureBox)Ray[0]);
                }
            }

            rightbox.AllowDrop = true;
            panel2.AllowDrop = true;


            leftbox.MouseDown += new MouseEventHandler(rightbox_MouseDown);
            upbox.MouseDown += new MouseEventHandler(rightbox_MouseDown);
            downbox.MouseDown += new MouseEventHandler(rightbox_MouseDown);
            panel2.DragEnter += new DragEventHandler(rightbox_DragEnter);
        }

        private void panel2_DragDrop(object sender, DragEventArgs e)
        { 
            for(int i = 0; i < 5; i++)
            {
                if(list[i].Image == null)
                {
                    list[i].Image = (Bitmap)e.Data.GetData(typeof(Bitmap));
                    break;
                }
                
            }
        }

    }
}

