using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace flappyBirdBounceTest
{
    public partial class Form1 : Form
    {
        int birdX = 400;
        int birdY = 250;
        int birdSpeed = -5;
        bool jump = false;

        bool spaceDown = false;
        bool lastSpace;
        SolidBrush birdBrush = new SolidBrush(Color.Black);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    spaceDown = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    spaceDown = false;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (spaceDown && !lastSpace)
            {
                jump = true;
                birdSpeed = -5;
            }

            if (jump)
            {
                switch (birdSpeed)
                {
                    case -5:
                        birdSpeed = 5;
                        break;
                    case 5:
                        birdSpeed = 4;
                        break;
                    case 4:
                        birdSpeed = 3;
                        break;
                    case 3:
                        birdSpeed = 2;
                        break;
                    case 2:
                        birdSpeed = 1;
                        break;
                    case 1:
                        birdSpeed = 0;
                        break;
                    case 0:
                        birdSpeed = -1;
                        break;
                    case -1:
                        birdSpeed = -2;
                        break;
                    case -2:
                        birdSpeed = -3;
                        break;
                    case -3:
                        birdSpeed = -4;
                        break;
                    case -4:
                        birdSpeed = -5;
                        jump = false;
                        break;    
                }

            }
            birdY -= birdSpeed;
                lastSpace = spaceDown;
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(birdBrush, birdX, birdY, 5, 5);
        }
    }
}
