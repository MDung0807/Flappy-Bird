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
    public partial class FormBegin : Form
    {
        public int checkChoseBird { get; set; } = 1;
        bool ChoseBird = false;
        public int Level { get; set; } = 1;
        bool checkChoseLevel = false;
        public FormBegin()
        {
            InitializeComponent();
        }
        public void ChangeCheck(int check)
        {
            this.checkChoseBird = check;
            this.ChoseBird = true;
        }
        public void ChangeLevel (int check)
        {
            this.Level = check;
            this.checkChoseLevel = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            FormPlay f2 = new FormPlay();
            if (this.checkChoseBird == 1)
                f2.ptbBird.Image = Properties.Resources.bird;
            else if (this.checkChoseBird == 2)
                f2.ptbBird.Image = Properties.Resources.bird2;
            else if (this.checkChoseBird == 3)
                f2.ptbBird.Image = Properties.Resources.bird3;
            else if (this.checkChoseBird == 4)
                f2.ptbBird.Image = Properties.Resources.bird4;
            else if (this.checkChoseBird == 5)
                f2.ptbBird.Image = Properties.Resources.bird5;
            else if (this.checkChoseBird == 6)
                f2.ptbBird.Image = Properties.Resources.bird6;

            if (this.Level == 1)
            {
                f2.ChangeGravity(10);
                f2.ChangePipeSpeed(8);
            }    
            else if (this.Level == 2)
            {
                f2.ChangeGravity(12);
                f2.ChangePipeSpeed(10);
            }    
            else if (this.Level == 3)
            {
                f2.ChangeGravity(14);
                f2.ChangePipeSpeed(12);
            }    

            if (this.ChoseBird == true && this.checkChoseLevel == true)
                f2.ShowDialog();
            f2.timerGame.Start();
            f2.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnGuid_Click(object sender, EventArgs e)
        {
            FormGuid form = new FormGuid();
            form.ShowDialog();
        }

        private void btnChoseBird_Click(object sender, EventArgs e)
        {
            FormChoseBird form = new FormChoseBird(this);
            form.ShowDialog();
        }

        private void FormBegin_Load(object sender, EventArgs e)
        {

        }
    }
}
