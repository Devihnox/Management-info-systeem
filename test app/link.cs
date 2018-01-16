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


        public Link(PictureBox box1, PictureBox box2, PictureBox box3, PictureBox box4, PictureBox box5, PictureBox box6, PictureBox box7, PictureBox box8, PictureBox box9)
        {

           
            if (xpos == 0 && ypos == 0)
            {
                box1.Image = test_app.Properties.Resources.link;
                box1.SizeMode = PictureBoxSizeMode.Zoom;

            }
            if (xpos == 1 && ypos == 0)
            {
                box9.Image = test_app.Properties.Resources.link;
                box9.SizeMode = PictureBoxSizeMode.Zoom;
            }
            if (xpos == 1 && ypos == 1)
            {
                box6.Image = test_app.Properties.Resources.link;
                box6.SizeMode = PictureBoxSizeMode.Zoom;

            }
            if (xpos == 0 && ypos == 1)
            {
                box7.Image = test_app.Properties.Resources.link;
                box7.SizeMode = PictureBoxSizeMode.Zoom;
            }
            if (xpos == -1 && ypos == 0)
            {
                box4.Image = test_app.Properties.Resources.link;
                box4.SizeMode = PictureBoxSizeMode.Zoom;
            }

                if (xpos == 0 && ypos == -1)
                {
                    box2.Image = test_app.Properties.Resources.link;
                    box2.SizeMode = PictureBoxSizeMode.Zoom;

                }
                if (xpos == -1 && ypos == -1)
                {
                    box5.Image = test_app.Properties.Resources.link;
                    box5.SizeMode = PictureBoxSizeMode.Zoom;

                }
                if (xpos == 1 && ypos == -1)
                {
                    box3.Image = test_app.Properties.Resources.link;
                    box3.SizeMode = PictureBoxSizeMode.Zoom;

                }
                if (xpos == -1 && ypos == 1)
                {
                    box8.Image = test_app.Properties.Resources.link;
                    box8.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }
    }