using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace test_app
{


    public class Link
    {
        List<PictureBox> list = Form1.listlink;
        int xpos = Form1.xpos;
        int ypos = Form1.ypos;
        bool right = Form1.right;
        bool left = Form1.left;
        bool up = Form1.up;
        bool down = Form1.down;
        bool staan = Form1.staan;
        public static int box = 73;
        int x = Form1.movement;



        public Link(PictureBox box1, PictureBox box2, PictureBox box3, PictureBox box4, PictureBox box5, PictureBox box6, PictureBox box7, PictureBox box8, PictureBox box9, PictureBox box10, PictureBox box11, PictureBox box12, PictureBox box13, PictureBox box14, PictureBox box15, PictureBox box16, PictureBox box17, PictureBox box18, PictureBox box19, PictureBox box20, PictureBox box21, PictureBox box22, PictureBox box23, PictureBox box24, PictureBox box25, PictureBox box26, PictureBox box27, PictureBox box28, PictureBox box29, PictureBox box30, PictureBox box31, PictureBox box32, PictureBox box33, PictureBox box34, PictureBox box35, PictureBox box36, PictureBox box37, PictureBox box38, PictureBox box39, PictureBox box40, PictureBox box41, PictureBox box42, PictureBox box43, PictureBox box44, PictureBox box45, PictureBox box46, PictureBox box47, PictureBox box48, PictureBox box49, PictureBox box50, PictureBox box51, PictureBox box52, PictureBox box53, PictureBox box54, PictureBox box55, PictureBox box56, PictureBox box57, PictureBox box58, PictureBox box59, PictureBox box60, PictureBox box61, PictureBox box62, PictureBox box63, PictureBox box64, PictureBox box65, PictureBox box66, PictureBox box67, PictureBox box68, PictureBox box69, PictureBox box70, PictureBox box71, PictureBox box72, PictureBox box73, PictureBox box74, PictureBox box75, PictureBox box76, PictureBox box77, PictureBox box78, PictureBox box79, PictureBox box80, PictureBox box81, PictureBox box82, PictureBox box83, PictureBox box84, PictureBox box85, PictureBox box86, PictureBox box87, PictureBox box88, PictureBox box89, PictureBox box90, PictureBox box91, PictureBox box92, PictureBox box93, PictureBox box94, PictureBox box95, PictureBox box96, PictureBox box97, PictureBox box98, PictureBox box99, PictureBox box100, PictureBox box101, PictureBox box102, PictureBox box103, PictureBox box104, PictureBox box105, PictureBox box106, PictureBox box107, PictureBox box108, PictureBox box109, PictureBox box110, PictureBox box111, PictureBox box112, PictureBox box113, PictureBox box114, PictureBox box115, PictureBox box116, PictureBox box117, PictureBox box118, PictureBox box119, PictureBox box120, PictureBox box121, PictureBox box122, PictureBox box123, PictureBox box124, PictureBox box125, PictureBox box126, PictureBox box127, PictureBox box128, PictureBox box129, PictureBox box130, PictureBox box131, PictureBox box132, PictureBox box133, PictureBox box134, PictureBox box135, PictureBox box136, PictureBox box137, PictureBox box138, PictureBox box139, PictureBox box140, PictureBox box141, PictureBox box142, PictureBox box143, PictureBox box144)
        {
            list[box].Image = null;

            if (xpos == 0)
            {
                if (ypos == 0)
                {
                    box = 0;
                    animation();
                    box1.SizeMode = PictureBoxSizeMode.Zoom;

                }
                if (ypos == 1)
                {
                    box = 6;
                    animation();
                    box7.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -1)
                {
                    box = 1;
                    animation();
                    box2.SizeMode = PictureBoxSizeMode.Zoom;

                }
                if (ypos == 2)
                {
                    box = 68;
                    animation();
                    box69.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 3)
                {
                    box = 67;
                    animation();
                    box68.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 4)
                {
                    box = 66;
                    animation();
                    box67.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 5)
                {

                    box = 65;
                    animation();
                    box66.SizeMode = PictureBoxSizeMode.Zoom;

                }
                if (ypos == -2)
                {
                    box = 103;
                    animation();
                    box104.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -3)
                {
                    box = 102;
                    animation();
                    box103.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -4)
                {
                    box = 101;
                    animation();
                    box102.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -5)
                {
                    box = 100;
                    animation();
                    box101.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -6)
                {
                    box = 99;
                    animation();
                    box100.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
      
            else if (xpos == 1)
            {
                if (ypos == 0)
                {
                    box = 8;
                    animation();
                    box9.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 1)
                {
                    box = 5;
                    animation();
                    box6.SizeMode = PictureBoxSizeMode.Zoom;

                }
                if (ypos == -1)
                {
                    box = 2;
                    animation();
                    box3.SizeMode = PictureBoxSizeMode.Zoom;

                }
                if (ypos == 2)
                {
                    box = 72;
                    animation();
                    box73.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 3)
                {
                    box = 71;
                    animation();
                    box72.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 4)
                {
                    box = 70;
                    animation();
                    box71.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 5)
                {
                    box = 69;
                    animation();
                    box70.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -2)
                {
                    box = 108;
                    animation();
                    box109.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -3)
                {
                    box = 107;
                    animation();
                    box108.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -4)
                {
                    box = 106;
                    animation();
                    box107.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -5)
                {
                    box = 105;
                    animation();
                    box106.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -6)
                {
                    box = 104;
                    animation();
                    box105.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

            else if (xpos == 2)
            {
                if (ypos == 1)
                {
                    box = 9;
                    animation();
                    box10.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 0)
                {
                    box = 10;
                    animation();
                    box11.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -1)
                {
                    box = 11;
                    animation();
                    box12.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 2)
                {
                    box = 48;
                    animation();
                    box49.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 3)
                {
                    box = 49;
                    animation();
                    box50.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 4)
                {
                    box = 50;
                    animation();
                    box51.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 5)
                {
                    box = 51;
                    animation();
                    box52.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -2)
                {
                    box = 52;
                    animation();
                    box53.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -3)
                {
                    box = 53;
                    animation();
                    box54.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -4)
                {
                    box = 54;
                    animation();
                    box55.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -5)
                {
                    box = 55;
                    animation();
                    box56.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -6)
                {
                    box = 56;
                    animation();
                    box57.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

            else if (xpos == 3)
            {
                if (ypos == 1)
                {
                    box = 12;
                    animation();
                    box13.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 0)
                {
                    box = 13;
                    animation();
                    box14.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -1)
                {
                    box = 14;
                    animation();
                    box15.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 2)
                {
                    box = 39;
                    animation();
                    box40.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 3)
                {
                    box = 40;
                    animation();
                    box41.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 4)
                {
                    box = 41;
                    animation();
                    box42.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 5)
                {
                    box = 42;
                    animation();
                    box43.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -2)
                {
                    box = 43;
                    animation();
                    box44.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -3)
                {
                    box = 44;
                    animation();
                    box45.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -4)
                {
                    box = 45;
                    animation();
                    box46.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -5)
                {
                    box = 46;
                    animation();
                    box47.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -6)
                {
                    box = 47;
                    animation();
                    box48.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

            else if (xpos == 4)
            {
                if (ypos == 1)
                {
                    box = 15;
                    animation();
                    box16.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 0)
                {
                    box = 16;
                    animation();
                    box17.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -1)
                {
                    box = 17;
                    animation();
                    box18.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 2)
                {
                    box = 30;
                    animation();
                    box31.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 3)
                {
                    box = 31;
                    animation();
                    box32.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 4)
                {
                    box = 32;
                    animation();
                    box33.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 5)
                {
                    box = 33;
                    animation();
                    box34.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -2)
                {
                    box = 34;
                    animation();
                    box35.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -3)
                {
                    box = 35;
                    animation();
                    box36.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -4)
                {
                    box = 36;
                    animation();
                    box37.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -5)
                {
                    box = 37;
                    animation();
                    box38.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -6)
                {
                    box = 38;
                    animation();
                    box39.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

            else if (xpos == 5)
            {
                if (ypos == 1)
                {
                    box = 18;
                    animation();
                    box19.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 0)
                {
                    box = 19;
                    animation();
                    box20.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -1)
                {
                    box = 20;
                    animation();
                    box21.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 2)
                {
                    box = 21;
                    animation();
                    box22.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 3)
                {
                    box = 22;
                    animation();
                    box23.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 4)
                {
                    box = 23;
                    animation();
                    box24.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 5)
                {
                    box = 24;
                    animation();
                    box25.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -2)
                {
                    box = 25;
                    animation();
                    box26.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -3)
                {
                    box = 26;
                    animation();
                    box27.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -4)
                {
                    box = 27;
                    animation();
                    box28.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -5)
                {
                    box = 28;
                    animation();
                    box29.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -6)
                {
                    box = 29;
                    animation();
                    box30.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

            else if (xpos == -1)
            {
                if (ypos == 0)
                {
                    box = 3;
                    animation();
                    box4.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -1)
                {
                    box = 4;
                    animation();
                    box5.SizeMode = PictureBoxSizeMode.Zoom;

                }
                if (ypos == 1)
                {
                    box = 7;
                    animation();
                    box8.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 2)
                {
                    box = 64;
                    animation();
                    box65.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 3)
                {
                    box = 63;
                    animation();
                    box64.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 4)
                {
                    box = 62;
                    animation();
                    box63.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 5)
                {
                    box = 61;
                    animation();
                    box62.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -2)
                {
                    box = 98;
                    animation();
                    box99.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -3)
                {
                    box = 97;
                    animation();
                    box98.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -4)
                {
                    box = 96;
                    animation();
                    box97.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -5)
                {
                    box = 95;
                    animation();
                    box96.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -6)
                {
                    box = 94;
                    animation();
                    box95.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

            else if (xpos == -2)
            {
                if (ypos == 0)
                {
                    box = 130;
                    animation();
                    box131.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -1)
                {
                    box = 129;
                    animation();
                    box130.SizeMode = PictureBoxSizeMode.Zoom;

                }
                if (ypos == 1)
                {
                    box = 131;
                    animation();
                    box132.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 2)
                {
                    box = 60;
                    animation();
                    box61.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 3)
                {
                    box = 59;
                    animation();
                    box60.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 4)
                {
                    box = 58;
                    animation();
                    box59.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 5)
                {
                    box = 57;
                    animation();
                    box58.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -2)
                {
                    box = 93;
                    animation();
                    box94.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -3)
                {
                    box = 92;
                    animation();
                    box93.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -4)
                {
                    box = 91;
                    animation();
                    box92.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -5)
                {
                    box = 90;
                    animation();
                    box91.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -6)
                {
                    box = 89;
                    animation();
                    box90.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

            else if (xpos == -3)
            {
                if (ypos == 0)
                {
                    box = 133;
                    animation();
                    box134.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -1)
                {
                    box = 132;
                    animation();
                    box133.SizeMode = PictureBoxSizeMode.Zoom;

                }
                if (ypos == 1)
                {
                    box = 134;
                    animation();
                    box135.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 2)
                {
                    box = 88;
                    animation();
                    box89.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 3)
                {
                    box = 87;
                    animation();
                    box88.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 4)
                {
                    box = 86;
                    animation();
                    box87.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 5)
                {
                    box = 85;
                    animation();
                    box86.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -2)
                {
                    box = 128;
                    animation();
                    box129.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -3)
                {
                    box = 127;
                    animation();
                    box128.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -4)
                {
                    box = 126;
                    animation();
                    box127.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -5)
                {
                    box = 125;
                    animation();
                    box126.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -6)
                {
                    box = 124;
                    animation();
                    box125.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

            else if (xpos == -4)
            {
                if (ypos == 0)
                {
                    box = 143;
                    animation();
                    box144.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -1)
                {
                    box = 140;
                    animation();
                    box141.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 1)
                {
                    box = 137;
                    animation();
                    box138.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 2)
                {
                    box = 84;
                    animation();
                    box85.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 3)
                {
                    box = 83;
                    animation();
                    box84.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 4)
                {
                    box = 82;
                    animation();
                    box83.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 5)
                {
                    box = 81;
                    animation();
                    box82.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -2)
                {
                    box = 123;
                    animation();
                    box124.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -3)
                {
                    box = 122;
                    animation();
                    box123.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -4)
                {
                    box = 121;
                    animation();
                    box122.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -5)
                {
                    box = 120;
                    animation();
                    box121.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -6)
                {
                    box = 119;
                    animation();
                    box120.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

            else if (xpos == -5)
            {
                if (ypos == 0)
                {
                    box = 142;
                    animation();
                    box143.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -1)
                {
                    box = 141;
                    animation();
                    box142.SizeMode = PictureBoxSizeMode.Zoom;

                }
                if (ypos == 1)
                {
                    box = 136;
                    animation();
                    box137.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 2)
                {
                    box = 80;
                    animation();
                    box81.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 3)
                {
                    box = 79;
                    animation();
                    box80.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 4)
                {
                    box = 78;
                    animation();
                    box79.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 5)
                {
                    box = 77;
                    animation();
                    box78.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -2)
                {
                    box = 118;
                    animation();
                    box119.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -3)
                {
                    box = 117;
                    animation();
                    box118.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -4)
                {
                    box = 116;
                    animation();
                    box117.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -5)
                {
                    box = 115;
                    animation();
                    box116.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -6)
                {
                    box = 114;
                    animation();
                    box115.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

            else if (xpos == -6)
            {
                if (ypos == 0)
                {
                    box = 139;
                    animation();
                    box140.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -1)
                {
                    box = 138;
                    animation();
                    box139.SizeMode = PictureBoxSizeMode.Zoom;

                }
                if (ypos == 1)
                {
                    box = 135;
                    animation();
                    box136.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 2)
                {
                    box = 76;
                    animation();
                    box77.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 3)
                {
                    box = 75;
                    animation();
                    box76.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 4)
                {
                    box = 74;
                    animation();
                    box75.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == 5)
                {
                    box = 73;
                    animation();
                    box74.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -2)
                {
                    box = 113;
                    animation();
                    box114.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -3)
                {
                    box = 112;
                    animation();
                    box113.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -4)
                {
                    box = 111;
                    animation();
                    box112.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -5)
                {
                    box = 110;
                    animation();
                    box111.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (ypos == -6)
                {
                    box = 109;
                    animation();
                    box110.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        public void animation()
        {
            if (right == true)
            {
                if (x == 0)
                {
                    list[box].Image = test_app.Properties.Resources.right1;
                }
                else
                {
                    list[box].Image = test_app.Properties.Resources.right2;
                }
            }
            if (left == true)
            {
                if (x == 0)
                {
                    list[box].Image = test_app.Properties.Resources.left1;
                }
                else
                {
                    list[box].Image = test_app.Properties.Resources.left2;
                }
            }
            if (up == true)
            {
                if (x == 0)
                {
                    list[box].Image = test_app.Properties.Resources.up1;
                }
                else
                {
                    list[box].Image = test_app.Properties.Resources.up2;
                }
            }
            if (down == true)
            {
                if (x == 0)
                {
                    list[box].Image = test_app.Properties.Resources.down1;
                }
                else
                {
                    list[box].Image = test_app.Properties.Resources.down2;
                }
            }
            if (staan == true)
            {
                list[box].Image = test_app.Properties.Resources.staan;
            }
        }
    }
}