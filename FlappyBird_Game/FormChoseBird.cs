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
    public partial class FormChoseBird : Form
    {
        FormBegin form1;

        public FormChoseBird(FormBegin f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            form1.ChangeCheck(1);

            var f2 = new FormPlay();
            f2.timerGame.Stop();
            MessageBox.Show("You chose bird 1");
        }

        public void pictureBox2_Click(object sender, EventArgs e)
        {
            form1.ChangeCheck(2);
            
            var f2 = new FormPlay();
            f2.timerGame.Stop();
            MessageBox.Show("You chose bird 2");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            form1.ChangeCheck(3);

            var f2 = new FormPlay();
            f2.timerGame.Stop();
            MessageBox.Show("You chose bird 3");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            form1.ChangeCheck(4);

            var f2 = new FormPlay();
            f2.timerGame.Stop();
            MessageBox.Show("You chose bird 4");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            form1.ChangeCheck(5);

            var f2 = new FormPlay();
            f2.timerGame.Stop();
            MessageBox.Show("You chose bird 5");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            form1.ChangeCheck(6);

            var f2 = new FormPlay();
            f2.timerGame.Stop();
            MessageBox.Show("You chose bird 6");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            form1.ChangeLevel(1);

            var f2 = new FormPlay();
            f2.timerGame.Stop();
            MessageBox.Show("You chose Easy Level");
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            form1.ChangeLevel(2);

            var f2 = new FormPlay();
            f2.timerGame.Stop();
            MessageBox.Show("You chose Medium Level");
        }

        private void btnDifficulty_Click(object sender, EventArgs e)
        {
            form1.ChangeLevel(3);

            var f2 = new FormPlay();
            f2.timerGame.Stop();
            MessageBox.Show("You chose Difficulty Level");
        }
    }
}
