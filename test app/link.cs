using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace test_app
{


    public class Link
    {

        int xpos = Game.xpos;
        int ypos = Game.ypos;


        public Link(PictureBox box1, PictureBox box2, PictureBox box3, PictureBox box4, PictureBox box5, PictureBox box6, PictureBox box7, PictureBox box8, PictureBox box9, PictureBox box10, PictureBox box11, PictureBox box12, PictureBox box13, PictureBox box14, PictureBox box15, PictureBox box16, PictureBox box17, PictureBox box18, PictureBox box19, PictureBox box20, PictureBox box21, PictureBox box22, PictureBox box23, PictureBox box24, PictureBox box25, PictureBox box26, PictureBox box27, PictureBox box28, PictureBox box29, PictureBox box30, PictureBox box31, PictureBox box32, PictureBox box33, PictureBox box34, PictureBox box35, PictureBox box36, PictureBox box37, PictureBox box38, PictureBox box39, PictureBox box40, PictureBox box41, PictureBox box42, PictureBox box43, PictureBox box44, PictureBox box45, PictureBox box46, PictureBox box47, PictureBox box48, PictureBox box49, PictureBox box50, PictureBox box51, PictureBox box52, PictureBox box53, PictureBox box54, PictureBox box55, PictureBox box56, PictureBox box57, PictureBox box58, PictureBox box59, PictureBox box60, PictureBox box61, PictureBox box62, PictureBox box63, PictureBox box64, PictureBox box65, PictureBox box66, PictureBox box67, PictureBox box68, PictureBox box69, PictureBox box70, PictureBox box71, PictureBox box72, PictureBox box73, PictureBox box74, PictureBox box75, PictureBox box76, PictureBox box77, PictureBox box78, PictureBox box79, PictureBox box80, PictureBox box81, PictureBox box82, PictureBox box83, PictureBox box84, PictureBox box85, PictureBox box86, PictureBox box87, PictureBox box88, PictureBox box89, PictureBox box90, PictureBox box91, PictureBox box92, PictureBox box93, PictureBox box94, PictureBox box95, PictureBox box96, PictureBox box97, PictureBox box98, PictureBox box99, PictureBox box100, PictureBox box101, PictureBox box102, PictureBox box103, PictureBox box104, PictureBox box105, PictureBox box106, PictureBox box107, PictureBox box108, PictureBox box109, PictureBox box110, PictureBox box111, PictureBox box112, PictureBox box113, PictureBox box114, PictureBox box115, PictureBox box116, PictureBox box117, PictureBox box118, PictureBox box119, PictureBox box120, PictureBox box121, PictureBox box122, PictureBox box123, PictureBox box124, PictureBox box125, PictureBox box126, PictureBox box127, PictureBox box128, PictureBox box129, PictureBox box130, PictureBox box131, PictureBox box132, PictureBox box133, PictureBox box134, PictureBox box135, PictureBox box136, PictureBox box137, PictureBox box138, PictureBox box139, PictureBox box140, PictureBox box141, PictureBox box142, PictureBox box143, PictureBox box144)
            {

            if (xpos == 0)
            {
                if (ypos == 0)
                {
                    box1.Image = test_app.Properties.Resources.link;
                    box1.SizeMode = PictureBoxSizeMode.Zoom;

                }
                if (ypos == 1)
                {
                    box7.Image = test_app.Properties.Resources.link;
                    box7.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -1)
                {
                    box2.Image = test_app.Properties.Resources.link;
                    box2.SizeMode = PictureBoxSizeMode.Zoom;

                }
                if (ypos == 2)
                {
                    box22.Image = test_app.Properties.Resources.link;
                    box22.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 3)
                {
                    box23.Image = test_app.Properties.Resources.link;
                    box23.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 4)
                {
                    box24.Image = test_app.Properties.Resources.link;
                    box24.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 5)
                {
                    box25.Image = test_app.Properties.Resources.link;
                    box25.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -2)
                {
                    box26.Image = test_app.Properties.Resources.link;
                    box26.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -3)
                {
                    box27.Image = test_app.Properties.Resources.link;
                    box27.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -4)
                {
                    box28.Image = test_app.Properties.Resources.link;
                    box28.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -5)
                {
                    box29.Image = test_app.Properties.Resources.link;
                    box29.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -6)
                {
                    box30.Image = test_app.Properties.Resources.link;
                    box30.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

            if (xpos == 1)
            {
                if (ypos == 0)
                {
                    box9.Image = test_app.Properties.Resources.link;
                    box9.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 1)
                {
                    box6.Image = test_app.Properties.Resources.link;
                    box6.SizeMode = PictureBoxSizeMode.Zoom;

                }
                if (ypos == -1)
                {
                    box3.Image = test_app.Properties.Resources.link;
                    box3.SizeMode = PictureBoxSizeMode.Zoom;

                }
                if (ypos == 2)
                {
                    box22.Image = test_app.Properties.Resources.link;
                    box22.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 3)
                {
                    box23.Image = test_app.Properties.Resources.link;
                    box23.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 4)
                {
                    box24.Image = test_app.Properties.Resources.link;
                    box24.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 5)
                {
                    box25.Image = test_app.Properties.Resources.link;
                    box25.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -2)
                {
                    box26.Image = test_app.Properties.Resources.link;
                    box26.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -3)
                {
                    box27.Image = test_app.Properties.Resources.link;
                    box27.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -4)
                {
                    box28.Image = test_app.Properties.Resources.link;
                    box28.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -5)
                {
                    box29.Image = test_app.Properties.Resources.link;
                    box29.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -6)
                {
                    box30.Image = test_app.Properties.Resources.link;
                    box30.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

            if (xpos == 2)
            {
                if (ypos == 1)
                {
                    box10.Image = test_app.Properties.Resources.link;
                    box10.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 0)
                {
                    box11.Image = test_app.Properties.Resources.link;
                    box11.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -1)
                {
                    box11.Image = test_app.Properties.Resources.link;
                    box11.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 2)
                {
                    box22.Image = test_app.Properties.Resources.link;
                    box22.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 3)
                {
                    box23.Image = test_app.Properties.Resources.link;
                    box23.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 4)
                {
                    box24.Image = test_app.Properties.Resources.link;
                    box24.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 5)
                {
                    box25.Image = test_app.Properties.Resources.link;
                    box25.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -2)
                {
                    box26.Image = test_app.Properties.Resources.link;
                    box26.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -3)
                {
                    box27.Image = test_app.Properties.Resources.link;
                    box27.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -4)
                {
                    box28.Image = test_app.Properties.Resources.link;
                    box28.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -5)
                {
                    box29.Image = test_app.Properties.Resources.link;
                    box29.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -6)
                {
                    box30.Image = test_app.Properties.Resources.link;
                    box30.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

            if (xpos == 3)
            {
                if (ypos == 1)
                {
                    box13.Image = test_app.Properties.Resources.link;
                    box13.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 0)
                {
                    box14.Image = test_app.Properties.Resources.link;
                    box14.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -1)
                {
                    box15.Image = test_app.Properties.Resources.link;
                    box15.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 2)
                {
                    box22.Image = test_app.Properties.Resources.link;
                    box22.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 3)
                {
                    box23.Image = test_app.Properties.Resources.link;
                    box23.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 4)
                {
                    box24.Image = test_app.Properties.Resources.link;
                    box24.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 5)
                {
                    box25.Image = test_app.Properties.Resources.link;
                    box25.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -2)
                {
                    box26.Image = test_app.Properties.Resources.link;
                    box26.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -3)
                {
                    box27.Image = test_app.Properties.Resources.link;
                    box27.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -4)
                {
                    box28.Image = test_app.Properties.Resources.link;
                    box28.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -5)
                {
                    box29.Image = test_app.Properties.Resources.link;
                    box29.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -6)
                {
                    box30.Image = test_app.Properties.Resources.link;
                    box30.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

            if (xpos == 4)
            {
                if (ypos == 1)
                {
                    box16.Image = test_app.Properties.Resources.link;
                    box16.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 0)
                {
                    box17.Image = test_app.Properties.Resources.link;
                    box17.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -1)
                {
                    box18.Image = test_app.Properties.Resources.link;
                    box18.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 2)
                {
                    box22.Image = test_app.Properties.Resources.link;
                    box22.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 3)
                {
                    box23.Image = test_app.Properties.Resources.link;
                    box23.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 4)
                {
                    box24.Image = test_app.Properties.Resources.link;
                    box24.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 5)
                {
                    box25.Image = test_app.Properties.Resources.link;
                    box25.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -2)
                {
                    box26.Image = test_app.Properties.Resources.link;
                    box26.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -3)
                {
                    box27.Image = test_app.Properties.Resources.link;
                    box27.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -4)
                {
                    box28.Image = test_app.Properties.Resources.link;
                    box28.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -5)
                {
                    box29.Image = test_app.Properties.Resources.link;
                    box29.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -6)
                {
                    box30.Image = test_app.Properties.Resources.link;
                    box30.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

            if (xpos == 5)
            {
                if (ypos == 1)
                {
                    box19.Image = test_app.Properties.Resources.link;
                    box19.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 0)
                {
                    box20.Image = test_app.Properties.Resources.link;
                    box20.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -1)
                {
                    box21.Image = test_app.Properties.Resources.link;
                    box21.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 2)
                {
                    box22.Image = test_app.Properties.Resources.link;
                    box22.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 3)
                {
                    box23.Image = test_app.Properties.Resources.link;
                    box23.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 4)
                {
                    box24.Image = test_app.Properties.Resources.link;
                    box24.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 5)
                {
                    box25.Image = test_app.Properties.Resources.link;
                    box25.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -2)
                {
                    box26.Image = test_app.Properties.Resources.link;
                    box26.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -3)
                {
                    box27.Image = test_app.Properties.Resources.link;
                    box27.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -4)
                {
                    box28.Image = test_app.Properties.Resources.link;
                    box28.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -5)
                {
                    box29.Image = test_app.Properties.Resources.link;
                    box29.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -6)
                {
                    box30.Image = test_app.Properties.Resources.link;
                    box30.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

            if (xpos == 0)
            {
                if (ypos == 2)
                {
                    box22.Image = test_app.Properties.Resources.link;
                    box22.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 3)
                {
                    box23.Image = test_app.Properties.Resources.link;
                    box23.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 4)
                {
                    box24.Image = test_app.Properties.Resources.link;
                    box24.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 5)
                {
                    box25.Image = test_app.Properties.Resources.link;
                    box25.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -2)
                {
                    box26.Image = test_app.Properties.Resources.link;
                    box26.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -3)
                {
                    box27.Image = test_app.Properties.Resources.link;
                    box27.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -4)
                {
                    box28.Image = test_app.Properties.Resources.link;
                    box28.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -5)
                {
                    box29.Image = test_app.Properties.Resources.link;
                    box29.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -6)
                {
                    box30.Image = test_app.Properties.Resources.link;
                    box30.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

            if (xpos == -1)
            {
                if (ypos == 0)
                {
                    box4.Image = test_app.Properties.Resources.link;
                    box4.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -1)
                {
                    box5.Image = test_app.Properties.Resources.link;
                    box5.SizeMode = PictureBoxSizeMode.Zoom;

                }
                if (ypos == 1)
                {
                    box8.Image = test_app.Properties.Resources.link;
                    box8.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 2)
                {
                    box22.Image = test_app.Properties.Resources.link;
                    box22.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 3)
                {
                    box23.Image = test_app.Properties.Resources.link;
                    box23.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 4)
                {
                    box24.Image = test_app.Properties.Resources.link;
                    box24.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 5)
                {
                    box25.Image = test_app.Properties.Resources.link;
                    box25.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -2)
                {
                    box26.Image = test_app.Properties.Resources.link;
                    box26.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -3)
                {
                    box27.Image = test_app.Properties.Resources.link;
                    box27.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -4)
                {
                    box28.Image = test_app.Properties.Resources.link;
                    box28.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -5)
                {
                    box29.Image = test_app.Properties.Resources.link;
                    box29.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -6)
                {
                    box30.Image = test_app.Properties.Resources.link;
                    box30.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

            if (xpos == -2)
            {
                if (ypos == 0)
                {
                    box4.Image = test_app.Properties.Resources.link;
                    box4.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -1)
                {
                    box5.Image = test_app.Properties.Resources.link;
                    box5.SizeMode = PictureBoxSizeMode.Zoom;

                }
                if (ypos == 1)
                {
                    box8.Image = test_app.Properties.Resources.link;
                    box8.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 2)
                {
                    box22.Image = test_app.Properties.Resources.link;
                    box22.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 3)
                {
                    box23.Image = test_app.Properties.Resources.link;
                    box23.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 4)
                {
                    box24.Image = test_app.Properties.Resources.link;
                    box24.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 5)
                {
                    box25.Image = test_app.Properties.Resources.link;
                    box25.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -2)
                {
                    box26.Image = test_app.Properties.Resources.link;
                    box26.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -3)
                {
                    box27.Image = test_app.Properties.Resources.link;
                    box27.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -4)
                {
                    box28.Image = test_app.Properties.Resources.link;
                    box28.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -5)
                {
                    box29.Image = test_app.Properties.Resources.link;
                    box29.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -6)
                {
                    box30.Image = test_app.Properties.Resources.link;
                    box30.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

            if (xpos == -3)
            {
                if (ypos == 0)
                {
                    box4.Image = test_app.Properties.Resources.link;
                    box4.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -1)
                {
                    box5.Image = test_app.Properties.Resources.link;
                    box5.SizeMode = PictureBoxSizeMode.Zoom;

                }
                if (ypos == 1)
                {
                    box8.Image = test_app.Properties.Resources.link;
                    box8.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 2)
                {
                    box22.Image = test_app.Properties.Resources.link;
                    box22.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 3)
                {
                    box23.Image = test_app.Properties.Resources.link;
                    box23.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 4)
                {
                    box24.Image = test_app.Properties.Resources.link;
                    box24.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 5)
                {
                    box25.Image = test_app.Properties.Resources.link;
                    box25.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -2)
                {
                    box26.Image = test_app.Properties.Resources.link;
                    box26.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -3)
                {
                    box27.Image = test_app.Properties.Resources.link;
                    box27.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -4)
                {
                    box28.Image = test_app.Properties.Resources.link;
                    box28.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -5)
                {
                    box29.Image = test_app.Properties.Resources.link;
                    box29.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -6)
                {
                    box30.Image = test_app.Properties.Resources.link;
                    box30.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

            if (xpos == -4)
            {
                if (ypos == 0)
                {
                    box4.Image = test_app.Properties.Resources.link;
                    box4.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -1)
                {
                    box5.Image = test_app.Properties.Resources.link;
                    box5.SizeMode = PictureBoxSizeMode.Zoom;

                }
                if (ypos == 1)
                {
                    box8.Image = test_app.Properties.Resources.link;
                    box8.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 2)
                {
                    box22.Image = test_app.Properties.Resources.link;
                    box22.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 3)
                {
                    box23.Image = test_app.Properties.Resources.link;
                    box23.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 4)
                {
                    box24.Image = test_app.Properties.Resources.link;
                    box24.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 5)
                {
                    box25.Image = test_app.Properties.Resources.link;
                    box25.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -2)
                {
                    box26.Image = test_app.Properties.Resources.link;
                    box26.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -3)
                {
                    box27.Image = test_app.Properties.Resources.link;
                    box27.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -4)
                {
                    box28.Image = test_app.Properties.Resources.link;
                    box28.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -5)
                {
                    box29.Image = test_app.Properties.Resources.link;
                    box29.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -6)
                {
                    box30.Image = test_app.Properties.Resources.link;
                    box30.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

            if (xpos == -5)
            {
                if (ypos == 0)
                {
                    box4.Image = test_app.Properties.Resources.link;
                    box4.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -1)
                {
                    box5.Image = test_app.Properties.Resources.link;
                    box5.SizeMode = PictureBoxSizeMode.Zoom;

                }
                if (ypos == 1)
                {
                    box8.Image = test_app.Properties.Resources.link;
                    box8.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 2)
                {
                    box22.Image = test_app.Properties.Resources.link;
                    box22.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 3)
                {
                    box23.Image = test_app.Properties.Resources.link;
                    box23.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 4)
                {
                    box24.Image = test_app.Properties.Resources.link;
                    box24.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 5)
                {
                    box25.Image = test_app.Properties.Resources.link;
                    box25.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -2)
                {
                    box26.Image = test_app.Properties.Resources.link;
                    box26.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -3)
                {
                    box27.Image = test_app.Properties.Resources.link;
                    box27.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -4)
                {
                    box28.Image = test_app.Properties.Resources.link;
                    box28.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -5)
                {
                    box29.Image = test_app.Properties.Resources.link;
                    box29.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -6)
                {
                    box30.Image = test_app.Properties.Resources.link;
                    box30.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

            if (xpos == -6)
            {
                if (ypos == 0)
                {
                    box4.Image = test_app.Properties.Resources.link;
                    box4.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -1)
                {
                    box5.Image = test_app.Properties.Resources.link;
                    box5.SizeMode = PictureBoxSizeMode.Zoom;

                }
                if (ypos == 1)
                {
                    box8.Image = test_app.Properties.Resources.link;
                    box8.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 2)
                {
                    box22.Image = test_app.Properties.Resources.link;
                    box22.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 3)
                {
                    box23.Image = test_app.Properties.Resources.link;
                    box23.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 4)
                {
                    box24.Image = test_app.Properties.Resources.link;
                    box24.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 5)
                {
                    box25.Image = test_app.Properties.Resources.link;
                    box25.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -2)
                {
                    box26.Image = test_app.Properties.Resources.link;
                    box26.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -3)
                {
                    box27.Image = test_app.Properties.Resources.link;
                    box27.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -4)
                {
                    box28.Image = test_app.Properties.Resources.link;
                    box28.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -5)
                {
                    box29.Image = test_app.Properties.Resources.link;
                    box29.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -6)
                {
                    box30.Image = test_app.Properties.Resources.link;
                    box30.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }
    }
}