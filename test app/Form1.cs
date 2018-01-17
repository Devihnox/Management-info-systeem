using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace test_app
{
    public partial class Game : Form
    {

        List<PictureBox> list = new List<PictureBox>();

        int test = 0;
        public static int ypos = 1;
        public static int xpos = -1;

        public Game()
        {
            InitializeComponent();

            foreach( PictureBox p in panel1.Controls)
            {
                test++;
            }

            move();
        }

        #region move and range
        public void range()
        {


            if (xpos > 5)
            {
                xpos = -1;
                ypos = 1;
                timer1.Stop();
                foreach (PictureBox p in panel2.Controls)
                {
                    p.Image = null;
                }
                move();
                i = 0;
            }
            if (xpos < -6)
            {
                xpos = -1;
                ypos = 1;
                timer1.Stop();
                foreach (PictureBox p in panel2.Controls)
                {
                    p.Image = null;
                }
                move();
                i = 0;
            }
            if (ypos > 5)
            {
                ypos = 1;
                xpos = -1;
                timer1.Stop();
                foreach (PictureBox p in panel2.Controls)
                {
                    p.Image = null;
                }
                move();
                i = 0;
            }
            if (ypos < -6)
            {
                ypos = 1;
                xpos = -1;
                timer1.Stop();
                foreach (PictureBox p in panel2.Controls)
                {
                    p.Image = null;
                }
                move();
                i = 0;
            }
        }

        private void move()
        {
            foreach (PictureBox p in panel1.Controls)
            {
                p.Image = null;
            }
            Link conlink = new Link(pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25, pictureBox26, pictureBox27, pictureBox28, pictureBox29, pictureBox30, pictureBox31, pictureBox32, pictureBox33, pictureBox34, pictureBox35, pictureBox36, pictureBox37, pictureBox38, pictureBox39, pictureBox40, pictureBox41, pictureBox42, pictureBox43, pictureBox44, pictureBox45, pictureBox46, pictureBox47, pictureBox48, pictureBox49, pictureBox50, pictureBox51, pictureBox52, pictureBox53, pictureBox54, pictureBox55, pictureBox56, pictureBox57, pictureBox58, pictureBox59, pictureBox60, pictureBox61, pictureBox62, pictureBox63, pictureBox64, pictureBox65, pictureBox66, pictureBox67, pictureBox68, pictureBox69, pictureBox70, pictureBox71, pictureBox72, pictureBox73, pictureBox74, pictureBox75, pictureBox76, pictureBox77, pictureBox78, pictureBox79, pictureBox80, pictureBox81, pictureBox82, pictureBox83, pictureBox84, pictureBox85, pictureBox86, pictureBox87, pictureBox88, pictureBox89, pictureBox90, pictureBox91, pictureBox92, pictureBox93, pictureBox94, pictureBox95, pictureBox96, pictureBox97, pictureBox98, pictureBox99, pictureBox100, pictureBox101, pictureBox102, pictureBox103, pictureBox104, pictureBox105, pictureBox106, pictureBox107, pictureBox108, pictureBox109, pictureBox110, pictureBox111, pictureBox112, pictureBox113, pictureBox114, pictureBox115, pictureBox116, pictureBox117, pictureBox118, pictureBox119, pictureBox120, pictureBox121, pictureBox122, pictureBox123, pictureBox124, pictureBox125, pictureBox126, pictureBox127, pictureBox128, pictureBox129, pictureBox130, pictureBox131, pictureBox132, pictureBox133, pictureBox134, pictureBox135, pictureBox136, pictureBox137, pictureBox138, pictureBox139, pictureBox140, pictureBox141, pictureBox142, pictureBox143, pictureBox144);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (i > list.Count - 1)
            {
                timer1.Stop();
                i = 0;
            }
            else if (list[i].Image == null)
            {
                timer1.Stop();
                i = 0;
            }


            else
            {
                if (list[i].Image == rightbox.Image)
                {
                    xpos++;
                }
                if (list[i].Image == leftbox.Image)
                {
                    xpos--;
                }
                if (list[i].Image == upbox.Image)
                {
                    ypos++;
                }
                if (list[i].Image == downbox.Image)
                {
                    ypos--;

                }
            }
            move();
            range();
            i++;

        }
        #endregion


        #region drag and drop
        private void rightbox_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.DoDragDrop(pb.Image, DragDropEffects.Copy);
        }
        private void upbox_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.DoDragDrop(pb.Image, DragDropEffects.Copy);
        }

        private void downbox_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.DoDragDrop(pb.Image, DragDropEffects.Copy);
        }

        private void leftbox_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.DoDragDrop(pb.Image, DragDropEffects.Copy);
        }
        public int x = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(PictureBox pb in panel2.Controls)
            {
                x++;
            }
            Control[] Ray;
            for (int i = 0; i < x; i++)
            {
                Ray = this.Controls.Find("Box" + i.ToString(), true);
                if (Ray.Length > 0 && Ray[0] is PictureBox)
                {
                    list.Add((PictureBox)Ray[0]);
                }
            }
            panel2.AllowDrop = true;

        }

        private void panel2_DragDrop(object sender, DragEventArgs e)
        {
            
            for (int i = 0; i < x; i++)
            {
                if (list[i].Image == null)
                {
                    list[i].Image = (Bitmap)e.Data.GetData(typeof(Bitmap));
                    break;
                }

            }
        }
        private void panel2_DragEnter(object sender, DragEventArgs e)
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
        #endregion

        #region buttons
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            foreach (PictureBox p in panel2.Controls)
            {
                p.Image = null;
            }
            xpos = -1;
            ypos = 1;
            move();
            i = 0;
        }
        int i = 0;
        #endregion

    }
}