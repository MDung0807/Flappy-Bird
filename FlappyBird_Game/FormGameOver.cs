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
    public partial class FormGameOver : Form
    {
        FormPlay form1;
        public FormGameOver(FormPlay f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            form1.ChangeCheckRestart(true);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form1.ChangeCheckEndGame(true);
            form1.Close();
            this.Close();
        }

        private void FormGameOver_Load(object sender, EventArgs e)
        {
            ptbBirdGameOver.Image = form1.ptbBird.Image;
            ptbBirdGameOver.BackgroundImage = Properties.Resources.gameover___Color;
            lblScore.Text = form1.score.ToString();
            lblBestScore.Text = form1.bestScore.ToString();
            if(form1.checkBestScore == true)
            {
                lblBestScoreText.Text = "New " + lblBestScoreText.Text;
            }
        }
    }
}
