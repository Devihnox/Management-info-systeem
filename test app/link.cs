using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace test_app
{


    public class Link
    {

        int xpos = Form1.xpos;
        int ypos = Form1.ypos;
        List<PictureBox> list = Position.boxlist;

        public Link()
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
                list[8].Image = test_app.Properties.Resources.link;
                this.list[8].SizeMode = PictureBoxSizeMode.Zoom;
                if (boxlist.Count == 0)
                {
                    boxlist.Add(list[8]);
                }
                else
                {
                    boxlist[0].Image = null;
                    boxlist.Remove(boxlist[0]);
                    boxlist.Add(list[8]);
                }
            }
            if (xpos == 1 && ypos == 1)
            {
                list[5].Image = test_app.Properties.Resources.link;
                this.list[5].SizeMode = PictureBoxSizeMode.Zoom;
                if (boxlist.Count == 0)
                {
                    boxlist.Add(list[5]);
                }
                else
                {
                    boxlist[0].Image = null;
                    boxlist.Remove(boxlist[0]);
                    boxlist.Add(list[5]);
                }
            }
            if (xpos == 0 && ypos == 1)
            {
                list[6].Image = test_app.Properties.Resources.link;
                this.list[6].SizeMode = PictureBoxSizeMode.Zoom;
                if (boxlist.Count == 0)
                {
                    boxlist.Add(list[6]);
                }
                else
                {
                    boxlist[0].Image = null;
                    boxlist.Remove(boxlist[0]);
                    boxlist.Add(list[6]);
                }
            }
            if (xpos == -1 && ypos == 0)
            {
                list[3].Image = test_app.Properties.Resources.link;
                this.list[3].SizeMode = PictureBoxSizeMode.Zoom;
                if (boxlist.Count == 0)
                {
                    boxlist.Add(list[3]);
                }
                else
                {
                    boxlist[0].Image = null;
                    boxlist.Remove(boxlist[0]);
                    boxlist.Add(list[3]);
                }
            }
            if (xpos == 0 && ypos == -1)
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
                    boxlist.Remove(boxlist[0]);
                    boxlist.Add(list[1]);
                }
            }
            if (xpos == -1 && ypos == -1)
            {
                list[4].Image = test_app.Properties.Resources.link;
                this.list[4].SizeMode = PictureBoxSizeMode.Zoom;
                if (boxlist.Count == 0)
                {
                    boxlist.Add(list[4]);
                }
                else
                {
                    boxlist[0].Image = null;
                    boxlist.Remove(boxlist[0]);
                    boxlist.Add(list[4]);
                }
            }
            if (xpos == 1 && ypos == -1)
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
            if (xpos == -1 && ypos == 1)
            {
                list[7].Image = test_app.Properties.Resources.link;
                this.list[7].SizeMode = PictureBoxSizeMode.Zoom;
                if (boxlist.Count == 0)
                {
                    boxlist.Add(list[7]);
                }
                else
                {

                    boxlist[0].Image = null;
                    boxlist.Remove(boxlist[0]);
                    boxlist.Add(list[7]);
                }
            }
        }
    }
}

