//Parker Railton
//Mr.T
//This is a clone of Flappy Bird


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace flappyBirdBounceTest
{

    public partial class Form1 : Form
    {
        //starting values
        int birdX = 100;
        int birdY = 250;
        int birdSpeed = -9;
        int pipeSpeed = -9;
        int score = 0;

        const int birdHeight = 25;
        const int birdWidth = 35;

        const int pipeHeight = 600;
        const int pipeWidth = 50;
        const int gapHeight = 100;

        int tick = 0;

        bool jump = false;


        bool jumpToStart = false;
        bool spaceDown = false;

        bool lastSpace = false;

        bool check = true;

        Random rand = new Random();
        //pipe locations
        List<int> pipeX = new List<int>();
        List<int> pipeY = new List<int>();
        //score board lists
        List<string> scoreBoardName = new List<string>();
        List<int> scoreBoardValue = new List<int>();

        // textures
        Image pipe = Properties.Resources.New_Project__5_;
        Image pipeTop = Properties.Resources.New_Project_oij;
        Image bird = Properties.Resources.birb;

        //sounds
        System.Windows.Media.MediaPlayer hit = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer fall = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer point = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer flap = new System.Windows.Media.MediaPlayer();



      

        public Form1()
        {
            InitializeComponent();


            //sound set up
            hit.Open(new Uri(Application.StartupPath + "/Resources/sfx_hit.wav"));
            fall.Open(new Uri(Application.StartupPath + "/Resources/sfx_die.wav"));
            point.Open(new Uri(Application.StartupPath + "/Resources/sfx_point.wav"));
            flap.Open(new Uri(Application.StartupPath + "/Resources/sfx_wing.wav"));
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //checks if space is pushed, and if you have to press space to start the game
            switch (e.KeyCode)
            {
                case Keys.Space:
                    spaceDown = true;
                    if (jumpToStart)
                    {
                        timer1.Enabled = true;
                        jumpToStart = false;
                        spaceLabel.Visible = false;
                    }
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //checks if space has been released
                case Keys.Space:
                    spaceDown = false;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //creates a new pipe every 60 ticks
            tick++;

            if (tick % 60 == 0)
            {

                pipeX.Add(800);
                pipeY.Add(rand.Next(gapHeight, 451));
            }
               // removes pipes when they go off screen.
            for (int loop = 0; loop < pipeX.Count(); loop++)
            {
                if (pipeX[loop] < 0 - pipeWidth)
                {
                    pipeX.RemoveAt(loop);
                    pipeY.RemoveAt(loop);

                    check = true;
                }
            }
            //edge detection for space
            if (spaceDown && !lastSpace)
            {
                flap.Stop();
                flap.Play();
                jump = true;
                birdSpeed = -9;
            }
            //jump hieghts
            if (jump)
            {
                switch (birdSpeed)
                {
                    case -9:
                        birdSpeed = 10;
                        break;
                    case 10:
                        birdSpeed = 8;
                        break;
                    case 8:
                        birdSpeed = 6;
                        break;
                    case 6:
                        birdSpeed = 4;
                        break;
                    case 4:
                        birdSpeed = 2;
                        break;
                    case 2:
                        birdSpeed = 0;
                        break;
                    case 0:
                        birdSpeed = -2;
                        break;
                    case -2:
                        birdSpeed = -4;
                        break;
                    case -4:
                        birdSpeed = -6;
                        break;
                    case -6:
                        birdSpeed = -8;
                        break;
                    case -8:
                        birdSpeed = -9;
                        jump = false;
                        break;
                }


            }

            // stops bird from going above the screen
            if (birdY < 0)
            {
                birdY = 0;
            }


            // moves bird
            birdY -= birdSpeed;
            //moves pipes
            for (int loop = 0; loop < pipeX.Count(); loop++)
            {
                pipeX[loop] += pipeSpeed;
            }

            
// hit box set up
            Rectangle birdRec = new Rectangle(birdX, birdY, birdWidth, birdHeight);
            for (int loop = 0; loop < pipeX.Count(); loop++)
            {
                Rectangle bPipeRec = new Rectangle(pipeX[loop], pipeY[loop], pipeWidth, pipeHeight);
                Rectangle tPipeRec = new Rectangle(pipeX[loop], pipeY[loop] - pipeHeight - gapHeight, pipeWidth, pipeHeight);
                Rectangle bottom = new Rectangle(0, this.Height, this.Width, 1000);

                //collision detection
                if (birdRec.IntersectsWith(bPipeRec) || birdRec.IntersectsWith(tPipeRec) || birdRec.IntersectsWith(bottom))
                {
                    if (birdRec.IntersectsWith(bottom))
                    {
                        fall.Stop();
                        fall.Play();
                    }
                    else
                    {
                        hit.Stop();
                        hit.Play();
                    }
                    nameBox.Text = "";
                    timer1.Enabled = false;
                    nameBox.Visible = true;
                    nameButton.Visible = true;
                    titleLabel.Visible = true;
                    titleLabel.Text = $"Final Score: {score}";
                }

            }
            try
            {
                //gives a point for passing through pipes
                if (birdX > pipeX[0] + pipeWidth && check)
                {
                    point.Stop();
                    point.Play();
                    score++;
                    check = false;
                }
            }
            catch
            {

            }
            Refresh();
            lastSpace = spaceDown;

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            //draws pipes and bird

            e.Graphics.DrawImage(bird, birdX, birdY, birdWidth, birdHeight);

            for (int loop = 0; loop < pipeX.Count(); loop++)
            {
                e.Graphics.DrawImage(pipeTop, pipeX[loop], pipeY[loop] - pipeHeight - gapHeight, pipeWidth, pipeHeight);
                e.Graphics.DrawImage(pipe, pipeX[loop], pipeY[loop], pipeWidth, pipeHeight);

            }

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            closeMenu();
            spaceLabel.Visible = true;

        }
        //menu functions
        private void closeMenu()
        {
            titleLabel.Visible = false;
            startButton.Visible = false;
            closeButton.Visible = false;
            scoreButton.Visible = false;
            startButton.Enabled = false;
            closeButton.Enabled = false;
            scoreButton.Enabled = false;
            scoreOutput.Visible = false;
            score = 0;
            jumpToStart = true;
        }

        private void openMenu(string text1, string text2)
        {
            titleLabel.Visible = true;
            startButton.Visible = true;
            closeButton.Visible = true;
            scoreButton.Visible = true;
            startButton.Enabled = true;
            closeButton.Enabled = true;
            scoreButton.Enabled = true;
            nameBox.Visible = false;
            nameButton.Visible = false;
            timer1.Enabled = false;
            button1.Visible = false;
            scoreOutput.Visible = false;
            titleLabel.Text = text1;
            startButton.Text = text2;
            pipeX.Clear();
            pipeY.Clear();
            birdX = 100;
            birdY = 250;
        }

        private void openScore()
        {

            startButton.Visible = false;
            closeButton.Visible = false;
            scoreButton.Visible = false;
            startButton.Enabled = false;
            closeButton.Enabled = false;
            scoreButton.Enabled = false;
            timer1.Enabled = false;
            scoreOutput.Visible = true;
            titleLabel.Visible = true;
            button1.Visible = true;
            titleLabel.Text = "Score Board";
            nameBox.Visible = false;
            nameButton.Visible = false;
            //draws scores onto score board in correct order
            if (scoreBoardValue.Count() > 0)
            {
                scoreOutput.Text = "";
                for (int loop = 0; loop < scoreBoardValue.Count() - 1; loop++)
                {
                    if (scoreOutput.Text == "")
                    {
                        scoreOutput.Text = $"{scoreBoardName[loop]}: ";
                    }
                    else
                    {
                        scoreOutput.Text += $"\n{scoreBoardName[loop]}: ";
                    }
                    scoreOutput.Text += $"{scoreBoardValue[loop]}";

                }
            }
            else
            {
                scoreOutput.Text = "No Scores Yet.";
            }




        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void scoreOutput_Click(object sender, EventArgs e)
        {

            openScore();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            //places scores in correct position
            string name = nameBox.Text;
            errorLabel.Visible = false;

            if (name != "")
            {
                if (scoreBoardValue.Count() == 0)
                {
                    scoreBoardName.Add(name);
                    scoreBoardValue.Add(score);
                    scoreBoardName.Add("NULL");
                    scoreBoardValue.Add(-1);
                    openMenu($"Final Score: {score}", "Restart Game");
                }

                else
                {
                    for (int loop = 0; loop < scoreBoardValue.Count(); loop++)
                    {
                        if (score > scoreBoardValue[loop])
                        {
                            scoreBoardValue.Insert(loop, score);

                            scoreBoardName.Insert(loop, name);

                            openMenu($"Final Score: {score}", "Restart Game");
                            break;
                        }
                    }
                }
            }

            else
            {
                errorLabel.Visible = true;
            }

            openMenu($"Final Score: {score}", "Restart Game");
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            openScore();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openMenu("Flappy Bird", "Start");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
