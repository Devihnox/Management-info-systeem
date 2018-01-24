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
        public static Game Gamevar;
        List<PictureBox> list = new List<PictureBox>();
        List<PictureBox> List2 = new List<PictureBox>();
        public static List<PictureBox> listlink = new List<PictureBox>();
        public static bool right = false;
        public static bool left = false;
        public static bool up = false;
        public static bool down = false;
        public static bool staan = true;
        public static int movement = 0;
        int i2 = 0;
        public int xpos;
        public int ypos;

        public Game()
        {
            InitializeComponent();
            Gamevar = this;
            xpos = -6;
            ypos = 4;
        }

         #region move and range
        public void range()
        {
            if (xpos < -6 || xpos > 5 || ypos >5 || ypos < -6)
            {
                staan = true;
                xpos = -6;
                ypos = 5;
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
            
            Link conlink = new Link(pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25, pictureBox26, pictureBox27, pictureBox28, pictureBox29, pictureBox30, pictureBox31, pictureBox32, pictureBox33, pictureBox34, pictureBox35, pictureBox36, pictureBox37, pictureBox38, pictureBox39, pictureBox40, pictureBox41, pictureBox42, pictureBox43, pictureBox44, pictureBox45, pictureBox46, pictureBox47, pictureBox48, pictureBox49, pictureBox50, pictureBox51, pictureBox52, pictureBox53, pictureBox54, pictureBox55, picturebox56, pictureBox57, pictureBox58, pictureBox59, pictureBox60, pictureBox61, pictureBox62, pictureBox63, pictureBox64, pictureBox65, pictureBox66, pictureBox67, pictureBox68, pictureBox69, pictureBox70, pictureBox71, pictureBox72, pictureBox73, pictureBox74, pictureBox75, pictureBox76, pictureBox77, pictureBox78, pictureBox79, pictureBox80, pictureBox81, pictureBox82, pictureBox83, pictureBox84, pictureBox85, pictureBox86, pictureBox87, pictureBox88, pictureBox89, pictureBox90, pictureBox91, pictureBox92, pictureBox93, pictureBox94, pictureBox95, pictureBox96, pictureBox97, pictureBox98, pictureBox99, pictureBox100, pictureBox101, pictureBox102, pictureBox103, pictureBox104, pictureBox105, pictureBox106, pictureBox107, pictureBox108, pictureBox109, pictureBox110, pictureBox111, pictureBox112, pictureBox113, pictureBox114, pictureBox115, pictureBox116, pictureBox117, pictureBox118, pictureBox119, pictureBox120, pictureBox121, pictureBox122, pictureBox123, pictureBox124, pictureBox125, pictureBox126, pictureBox127, pictureBox128, pictureBox129, pictureBox130, pictureBox131, pictureBox132, pictureBox133, pictureBox134, pictureBox135, pictureBox136, pictureBox137, pictureBox138, pictureBox139, pictureBox140, pictureBox141, pictureBox142, pictureBox143, pictureBox144,label1);
            if (movement == 0)
            {
                movement = 1;
            }
            else
            {
                movement = 0;
            }


            if (list[i] != null)
            {
                right = false;
                left = false;
                down = false;
                up = false;
                staan = false;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 300;

            if (i > list.Count - 1)
            {
                timer1.Stop();
                i = 0;
                staan = true;
                start_button.Enabled = true;
                
                foreach (PictureBox p in panel2.Controls)
                {
                    p.Image = null;
                }
                foreach (PictureBox p in panel3.Controls)
                {
                    p.Image = null;
                }
            }
            else if (list[i].Image == null)
            {
                timer1.Stop();
                i = 0;
                staan = true;
                
                start_button.Enabled = true;
                foreach (PictureBox p in panel2.Controls)
                {
                    p.Image = null;
                }
                foreach (PictureBox p in panel3.Controls)
                {
                    p.Image = null;
                }
            }
            else
            {
                if (list[i].Image == loopbox.Image)
                {
                    i2 = 0;
                    timer2.Start();
                    timer1.Stop();
                    timer2.Interval = 1;
                }
                if (list[i].Image == rightbox.Image)
                {
                    xpos++;
                    right = true;
                }
                if (list[i].Image == leftbox.Image)
                {
                    xpos--;
                    left = true;
                }
                if (list[i].Image == upbox.Image)
                {
                    ypos++;
                    up = true;
                }
                if (list[i].Image == downbox.Image)
                {
                    ypos--;
                    down = true;
                }
            }
            move();
            if(label1.Text == "You cant go here")
            {

                timer1.Stop();
                i = 0;
                staan = true;
                start_button.Enabled = true;
                move();
                foreach (PictureBox p in panel2.Controls)
                {
                    p.Image = null;
                }
                foreach (PictureBox p in panel3.Controls)
                {
                    p.Image = null;
                }
            }
            range();
            i++;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 300;

            if (i2 > List2.Count - 1)
            {
                timer1.Interval = 1;
                timer1.Start();
                timer2.Stop();
            }
            else if (List2[i2].Image == null)
            {
                timer1.Interval = 1;
                timer1.Start();
                timer2.Stop();
            }
            else
            {
                if (List2[i2].Image == rightbox.Image)
                {
                    xpos++;
                    right = true;
                }
                if (List2[i2].Image == leftbox.Image)
                {
                    xpos--;
                    left = true;
                }
                if (List2[i2].Image == upbox.Image)
                {
                    ypos++;
                    up = true;
                }
                if (List2[i2].Image == downbox.Image)
                {
                    ypos--;
                    down = true;
                }
            }
            move();
            range();
            i2++;
        }
        #endregion


        #region drag and drop
        private void rightbox_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.DoDragDrop(pb.Image, DragDropEffects.Copy);
        }

        private void panel2_DragDrop(object sender, DragEventArgs e)
        {
            for (int i = 0; i < list.Count ; i++)
            {
                if (list[i].Image == null)
                {
                    list[i].Image = (Bitmap)e.Data.GetData(typeof(Bitmap));
                    break;
                }
            }
        }
        private void panel3_DragDrop(object sender, DragEventArgs e)
        {
            for (int b = 0; b < List2.Count; b++)
            {
                if (List2[b].Image == null)
                {
                    List2[b].Image = (Bitmap)e.Data.GetData(typeof(Bitmap));
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
            label1.Text = " ";
            start_button.Enabled = false;
            i = 0;
            i2 = 0;
            timer1.Start();
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
            start_button.Enabled = true;
            timer1.Stop();
            timer2.Stop();
            staan = true;
            foreach (PictureBox p in panel2.Controls)
            {
                p.Image = null;
            }
            foreach ( PictureBox p in panel3.Controls)
            {
                p.Image = null;
            }
            foreach( PictureBox p in panel1.Controls)
            {
                p.Image = null;
            }
            xpos = -6;
            ypos = 4;
            move();
            i = 0;
            i2 = 0;
        }
        int i = 0;



        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = " ";
            Control[] Ray;
            for (int b = 1; b < 145; b++)
            {
                Ray = this.Controls.Find("picturebox" + b.ToString(), true);
                if (Ray.Length > 0 && Ray[0] is PictureBox)
                {
                    listlink.Add((PictureBox)Ray[0]);
                }
            }
            for (int b = 0; b < 9; b++)
            {
                Ray = this.Controls.Find("loopbox" + b.ToString(), true);
                if (Ray.Length > 0 && Ray[0] is PictureBox)
                {
                    List2.Add((PictureBox)Ray[0]);
                }
            }
            for (int i = 0; i < 11; i++)
            {
                Ray = this.Controls.Find("Box" + i.ToString(), true);
                if (Ray.Length > 0 && Ray[0] is PictureBox)
                {
                    list.Add((PictureBox)Ray[0]);
                }
            }
            foreach (PictureBox bp in panel1.Controls)
            {
                bp.BackColor = Color.Transparent;
            }
            upbox.MouseDown += new MouseEventHandler(rightbox_MouseDown);
            downbox.MouseDown += new MouseEventHandler(rightbox_MouseDown);
            leftbox.MouseDown += new MouseEventHandler(rightbox_MouseDown);
            loopbox.MouseDown += new MouseEventHandler(rightbox_MouseDown);
            panel2.AllowDrop = true;
            panel3.AllowDrop = true;
            panel3.DragEnter += new DragEventHandler(panel2_DragEnter);
            move();
        }
    }

}