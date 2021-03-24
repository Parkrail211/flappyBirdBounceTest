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
        int birdSpeed = -9;
        int pipeSpeed = -9;

        const int birdHeight = 25;
        const int birdWidth = 25;

        const int pipeHeight = 600;
        const int pipeWidth = 50;
        int tick = 0;

        bool jump = false;


        bool spaceDown = false;
        bool lastSpace;

        Random rand = new Random();
        List<int> pipeX = new List<int>();
        List<int> pipeY = new List<int>();

        SolidBrush birdBrush = new SolidBrush(Color.White);
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
            tick++;

            if (tick % 60 == 0)
            {
                pipeX.Add(800);
                pipeY.Add(rand.Next(50, 451));
            }

            for (int loop = 0; loop < pipeX.Count(); loop++)
            {
                if (pipeX[loop] < 0 - pipeWidth)
                {
                    pipeX.RemoveAt(loop);
                    pipeY.RemoveAt(loop);
                }
            }

            if (spaceDown && !lastSpace)
            {
                jump = true;
                birdSpeed = -9;
            }

            if (jump)
            {
                switch (birdSpeed)
                {
                    case -9:
                        birdSpeed = 9;
                        break;
                    case 9:
                        birdSpeed = 7;
                        break;
                    case 7:
                        birdSpeed = 5;
                        break;
                    case 5:
                        birdSpeed = 3;
                        break;
                    case 3:
                        birdSpeed = 1;
                        break;
                    case 1:
                        birdSpeed = 0;
                        break;
                    case 0:
                        birdSpeed = -1;
                        break;
                    case -1:
                        birdSpeed = -3;
                        break;
                    case -3:
                        birdSpeed = -5;
                        break;
                    case -5:
                        birdSpeed = -7;
                        break;
                    case -7:
                        birdSpeed = -9;
                        jump = false;
                        break;
                }

            }
            birdY -= birdSpeed;
            for (int loop = 0; loop < pipeX.Count(); loop++)
            {
                pipeX[loop] += pipeSpeed;
            }
            lastSpace = spaceDown;
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(birdBrush, birdX, birdY, birdWidth, birdHeight);




            for (int loop = 0; loop < pipeX.Count(); loop++)
            {
                e.Graphics.FillRectangle(birdBrush, pipeX[loop], pipeY[loop], pipeWidth, pipeHeight);
                e.Graphics.FillRectangle(birdBrush, pipeX[loop], pipeY[loop] - pipeHeight - 100, pipeWidth, pipeHeight);
            }

        }


    }
}
