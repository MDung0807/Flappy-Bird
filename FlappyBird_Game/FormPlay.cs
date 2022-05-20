using System;
using System.Drawing;
using System.Windows.Forms;
//using WMPLib;
using FlappyBird_Game.Properties;
using System.Media;
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

        private void DieSound()
        {
            SoundPlayer a = new SoundPlayer(Properties.Resources.gameover1);
            a.Play();
            ////WindowsMediaPlayer wplayer = new WindowsMediaPlayer();
            ////wplayer.URL = @"D:\Dowload\hit.mp3";
            ////wplayer.controls.play();
        }
        private void PointSound()
        {
            SoundPlayer a = new SoundPlayer(Properties.Resources.volo);
            a.Play();
            ////WindowsMediaPlayer wplayer = new WindowsMediaPlayer();
            ////wplayer.URL = @"D:\Dowload\point.mp3";
            ////wplayer.controls.play();
        }
        private void WingSound()
        {
            SoundPlayer a = new SoundPlayer(Properties.Resources.punto);
            a.Play();
            ////WindowsMediaPlayer wplayer = new WindowsMediaPlayer();
            ////wplayer.URL = @"D:\Dowload\wing.mp3";
            ////wplayer.controls.play();
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {

            ptbBird.Top += y;
            ptbPipeTop.Left -= pipeSpeed;
            ptbPipeBottom.Left -= pipeSpeed;
            ptbPipeTop2.Left -= pipeSpeed;
            ptbPipeBottom2.Left -= pipeSpeed;
            ptbPipeTop3.Left -= pipeSpeed;
            ptbPipeBottom3.Left -= pipeSpeed;

            lblScore.Text = "Score: " + this.score;


            if (ptbPipeTop.Left < -50)
            {
                ptbPipeTop.Left = 600;
                ptbPipeBottom.Left = 600;
                Random rd = new Random();
                int height = rd.Next(150, 200);
                ptbPipeTop.Size = new Size(100, height);
                ptbPipeBottom.Size = new Size(100, height);
                ptbPipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
                PointSound();
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
                ptbPipeBottom2.SizeMode = PictureBoxSizeMode.StretchImage;
                PointSound();
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
                ptbPipeBottom3.SizeMode = PictureBoxSizeMode.StretchImage;
                PointSound();
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
                        WingSound();
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
                DieSound();
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
            ptbPipeBottom2.Location = new Point(854, 328);

            ptbPipeTop3.Location = new Point(1046, -7);
            ptbPipeBottom3.Location = new Point(1046, 290);

            timerGame.Enabled = true;
            this.y = gravity;
            this.checkRestart = false;
            this.checkEndGame = false;
            this.checkBestScore = false;
            this.score = 0;
        }

    }
}
