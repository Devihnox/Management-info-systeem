using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace test_app
{
    

    public class Link {


        int xpos = Position.x;
        int ypos = Position.y;
        List<PictureBox> list = Position.boxlist;
        public void link()
        {

            List<PictureBox> boxlist = new List<PictureBox>();
            if (xpos == 0 && ypos == 0)
            {
                list[0].Image = test_app.Properties.Resources.link;
                this.list[0].SizeMode = PictureBoxSizeMode.Zoom;

                if (boxlist.Count == 0)
                {
                    boxlist.Add(list[0]);
                }
                else
                {
                    boxlist[0].Image = null;
                    boxlist.Remove(boxlist[0]);
                    boxlist.Add(list[0]);
                }
            }
            if (xpos == 1 && ypos == 0)
            {
                list[1].Image = test_app.Properties.Resources.link;
                this.list[1].SizeMode = PictureBoxSizeMode.Zoom;
                if (boxlist.Count == 0)
                {
                    boxlist.Add(list[1]);
                }
                else
                {
                    boxlist[0].Image = null;
                    boxlist.Remove(boxlist[1]);
                    boxlist.Add(list[1]);
                }
            }
            if (xpos == 1 && ypos == 1)
            {
                list[2].Image = test_app.Properties.Resources.link;
                this.list[2].SizeMode = PictureBoxSizeMode.Zoom;
                if (boxlist.Count == 0)
                {
                    boxlist.Add(list[2]);
                }
                else
                {
                    boxlist[0].Image = null;
                    boxlist.Remove(boxlist[0]);
                    boxlist.Add(list[2]);
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
                    boxlist.Add(pictureBox2);
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
  
