using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird_Game
{
    public partial class FormPlay : Form
    {
        int y;
        bool checkPause = false;
        public int score { get; set; } = 0;
        public int bestScore { get; set; } = 0;

        public bool checkRestart { get; set; }

        public bool checkEndGame { get; set; }
        public bool checkBestScore { get; set; }
        
        public int gravity { get; set; }
        public int pipeSpeed { get; set; }


        Bitmap myImage;
        public FormPlay()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        public void ChangeGravity(int x)
        {
            gravity = x;
            this.y = gravity;
        }

        public void ChangePipeSpeed( int x)
        {
            pipeSpeed = x;
        }

        public void ChangeCheckRestart(bool check)
        {
            this.checkRestart = check;
        }
        public void ChangeCheckEndGame(bool check)
        {
            this.checkEndGame = check;
        }
       

        private void timerGame_Tick(object sender, EventArgs e)
        {

            if (this.score == 0)
            {
                this.myImage = new Bitmap(Properties.Resources.tuyetroi);
                ptbBackGround.Image = (Image)myImage;
            }
            else if (this.score == 10)
            {
                this.myImage = new Bitmap(Properties.Resources.tuyetroi2);
                ptbBackGround.Image = (Image)myImage;
            }


            ptbBird.Top += y;
            ptbPipeTop.Left -= pipeSpeed;
            ptbPipeBottom.Left -= pipeSpeed;
            ptbPipeTop2.Left -= pipeSpeed;
            ptbPipeBottom2.Left -= pipeSpeed;
            ptbPipeTop3.Left -= pipeSpeed;
            ptbPipeBottom3.Left -= pipeSpeed;

            lblScore.Text = "Score: " + this.score;

            if(ptbPipeTop.Left < -50)
            {
                ptbPipeTop.Left = 600;
                ptbPipeBottom.Left = 600;
                Random rd = new Random();
                int height = rd.Next(150, 200);
                ptbPipeTop.Size = new Size(100, height);
                ptbPipeBottom.Size = new Size(100, height);
                this.score++;
            }

            if (ptbPipeTop2.Left < -50)
            {
                ptbPipeTop2.Left = 600;
                ptbPipeBottom2.Left = 600;
                Random rd = new Random();
                int height = rd.Next(150, 200);
                ptbPipeTop2.Size = new Size(100, height);
                ptbPipeBottom2.Size = new Size(100, height + 50);
                this.score++;
            }

            if (ptbPipeTop3.Left < -50)
            {
                ptbPipeTop3.Left = 600;
                ptbPipeBottom3.Left = 600;
                Random rd = new Random();
                int height = rd.Next(150, 200);
                ptbPipeTop3.Size = new Size(100, height);
                ptbPipeBottom3.Size = new Size(100, height + 100);
                this.score++;
            }

            if (ptbBird.Bounds.IntersectsWith(ptbPipeTop.Bounds) ||
                ptbBird.Bounds.IntersectsWith(ptbPipeBottom.Bounds) ||
                ptbBird.Bounds.IntersectsWith(ptbPipeTop2.Bounds) ||
                ptbBird.Bounds.IntersectsWith(ptbPipeBottom2.Bounds) ||
                ptbBird.Bounds.IntersectsWith(ptbPipeTop3.Bounds) ||
                ptbBird.Bounds.IntersectsWith(ptbPipeBottom3.Bounds) ||
                ptbBird.Bounds.IntersectsWith(ptbGround.Bounds) ||
                ptbBird.Top < -10)
            {
                if(this.score > this.bestScore)
                {
                    this.checkBestScore = true;
                    this.bestScore = this.score;
                }
                EndGame();
            }

            if (checkRestart)
            {
                Restart();
            }

        }

        private void formFlappyBird_KeyDown(object sender, KeyEventArgs e)
        {

            //if (e.KeyCode == Keys.Space)
            //{
            //    this.gravity = -10;
            //}

             if (checkEndGame == false)
            {
                if (e.KeyCode == Keys.Space)
                {
                    if (this.checkPause == true)
                    {
                        this.checkPause = false;
                        this.timerGame.Start();
                    }
                    else if (this.checkPause == false)
                    {
                        this.checkPause = true;
                        this.timerGame.Stop();
                    }
                }
                else if (e.KeyCode == Keys.Up)
                {
                    if (this.checkPause == false)
                    {
                        this.y = -gravity;
                    }
                }
            }
        }

        private void formFlappyBird_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.y = gravity;
            }
        }

        private void EndGame()
        {
            if(this.checkEndGame != true)
            {
                timerGame.Stop();
                FormGameOver form = new FormGameOver(this);
                form.ShowDialog();
            }
            else
            {
                this.Close();
            }
        }

        public void Restart()
        {
            ptbBird.Location = new Point(76, 229);

            ptbPipeTop.Location = new Point(628, -7);
            ptbPipeBottom.Location = new Point(628, 340);

            ptbPipeTop2.Location = new Point(854, -7);
            ptbPipeBottom2.Location = new Point(854, 408);

            ptbPipeTop3.Location = new Point(1046, -7);
            ptbPipeBottom3.Location = new Point(1046, 378);

            timerGame.Enabled = true;
            this.checkRestart = false;
            this.checkEndGame = false;
            this.checkBestScore = false;
            this.score = 0;
        }

    }
}
