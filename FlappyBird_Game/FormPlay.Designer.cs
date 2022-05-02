
namespace FlappyBird_Game
{
    partial class FormPlay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.ptbGround = new System.Windows.Forms.PictureBox();
            this.ptbPipeBottom3 = new System.Windows.Forms.PictureBox();
            this.ptbPipeTop3 = new System.Windows.Forms.PictureBox();
            this.ptbPipeBottom2 = new System.Windows.Forms.PictureBox();
            this.ptbPipeTop2 = new System.Windows.Forms.PictureBox();
            this.ptbPipeBottom = new System.Windows.Forms.PictureBox();
            this.ptbPipeTop = new System.Windows.Forms.PictureBox();
            this.ptbBird = new System.Windows.Forms.PictureBox();
            this.ptbBackGround = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPipeBottom3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPipeTop3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPipeBottom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPipeTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBackGround)).BeginInit();
            this.SuspendLayout();
            // 
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Interval = 40;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.BurlyWood;
            this.lblScore.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(168, 519);
            this.lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(109, 32);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score :";
            // 
            // ptbGround
            // 
            this.ptbGround.Image = global::FlappyBird_Game.Properties.Resources.ground;
            this.ptbGround.Location = new System.Drawing.Point(-18, 492);
            this.ptbGround.Margin = new System.Windows.Forms.Padding(2);
            this.ptbGround.Name = "ptbGround";
            this.ptbGround.Size = new System.Drawing.Size(1108, 130);
            this.ptbGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbGround.TabIndex = 5;
            this.ptbGround.TabStop = false;
            // 
            // ptbPipeBottom3
            // 
            this.ptbPipeBottom3.BackColor = System.Drawing.Color.Black;
            this.ptbPipeBottom3.Image = global::FlappyBird_Game.Properties.Resources.pipe;
            this.ptbPipeBottom3.Location = new System.Drawing.Point(868, 299);
            this.ptbPipeBottom3.Margin = new System.Windows.Forms.Padding(2);
            this.ptbPipeBottom3.Name = "ptbPipeBottom3";
            this.ptbPipeBottom3.Size = new System.Drawing.Size(100, 249);
            this.ptbPipeBottom3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPipeBottom3.TabIndex = 10;
            this.ptbPipeBottom3.TabStop = false;
            // 
            // ptbPipeTop3
            // 
            this.ptbPipeTop3.BackColor = System.Drawing.Color.Black;
            this.ptbPipeTop3.Image = global::FlappyBird_Game.Properties.Resources.pipedown;
            this.ptbPipeTop3.Location = new System.Drawing.Point(868, -6);
            this.ptbPipeTop3.Margin = new System.Windows.Forms.Padding(2);
            this.ptbPipeTop3.Name = "ptbPipeTop3";
            this.ptbPipeTop3.Size = new System.Drawing.Size(100, 183);
            this.ptbPipeTop3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPipeTop3.TabIndex = 9;
            this.ptbPipeTop3.TabStop = false;
            // 
            // ptbPipeBottom2
            // 
            this.ptbPipeBottom2.BackColor = System.Drawing.Color.Black;
            this.ptbPipeBottom2.Image = global::FlappyBird_Game.Properties.Resources.pipe;
            this.ptbPipeBottom2.Location = new System.Drawing.Point(640, 332);
            this.ptbPipeBottom2.Margin = new System.Windows.Forms.Padding(2);
            this.ptbPipeBottom2.Name = "ptbPipeBottom2";
            this.ptbPipeBottom2.Size = new System.Drawing.Size(100, 216);
            this.ptbPipeBottom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPipeBottom2.TabIndex = 8;
            this.ptbPipeBottom2.TabStop = false;
            // 
            // ptbPipeTop2
            // 
            this.ptbPipeTop2.BackColor = System.Drawing.Color.Black;
            this.ptbPipeTop2.Image = global::FlappyBird_Game.Properties.Resources.pipedown;
            this.ptbPipeTop2.Location = new System.Drawing.Point(640, -6);
            this.ptbPipeTop2.Margin = new System.Windows.Forms.Padding(2);
            this.ptbPipeTop2.Name = "ptbPipeTop2";
            this.ptbPipeTop2.Size = new System.Drawing.Size(100, 202);
            this.ptbPipeTop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPipeTop2.TabIndex = 7;
            this.ptbPipeTop2.TabStop = false;
            // 
            // ptbPipeBottom
            // 
            this.ptbPipeBottom.BackColor = System.Drawing.Color.Black;
            this.ptbPipeBottom.BackgroundImage = global::FlappyBird_Game.Properties.Resources.Trời_tối;
            this.ptbPipeBottom.Image = global::FlappyBird_Game.Properties.Resources.pipe;
            this.ptbPipeBottom.Location = new System.Drawing.Point(449, 344);
            this.ptbPipeBottom.Margin = new System.Windows.Forms.Padding(2);
            this.ptbPipeBottom.Name = "ptbPipeBottom";
            this.ptbPipeBottom.Size = new System.Drawing.Size(100, 203);
            this.ptbPipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPipeBottom.TabIndex = 3;
            this.ptbPipeBottom.TabStop = false;
            // 
            // ptbPipeTop
            // 
            this.ptbPipeTop.BackColor = System.Drawing.Color.Black;
            this.ptbPipeTop.BackgroundImage = global::FlappyBird_Game.Properties.Resources.Trời_tối;
            this.ptbPipeTop.Image = global::FlappyBird_Game.Properties.Resources.pipedown;
            this.ptbPipeTop.Location = new System.Drawing.Point(449, -6);
            this.ptbPipeTop.Margin = new System.Windows.Forms.Padding(2);
            this.ptbPipeTop.Name = "ptbPipeTop";
            this.ptbPipeTop.Size = new System.Drawing.Size(100, 173);
            this.ptbPipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPipeTop.TabIndex = 1;
            this.ptbPipeTop.TabStop = false;
            // 
            // ptbBird
            // 
            this.ptbBird.BackColor = System.Drawing.Color.Black;
            this.ptbBird.BackgroundImage = global::FlappyBird_Game.Properties.Resources.Trời_tối;
            this.ptbBird.Image = global::FlappyBird_Game.Properties.Resources.bird;
            this.ptbBird.Location = new System.Drawing.Point(100, 217);
            this.ptbBird.Margin = new System.Windows.Forms.Padding(2);
            this.ptbBird.Name = "ptbBird";
            this.ptbBird.Size = new System.Drawing.Size(50, 51);
            this.ptbBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBird.TabIndex = 0;
            this.ptbBird.TabStop = false;
            // 
            // ptbBackGround
            // 
            this.ptbBackGround.BackgroundImage = global::FlappyBird_Game.Properties.Resources.Trời_tối;
            this.ptbBackGround.Image = global::FlappyBird_Game.Properties.Resources.Trời_tối;
            this.ptbBackGround.Location = new System.Drawing.Point(-5, -6);
            this.ptbBackGround.Margin = new System.Windows.Forms.Padding(2);
            this.ptbBackGround.Name = "ptbBackGround";
            this.ptbBackGround.Size = new System.Drawing.Size(612, 505);
            this.ptbBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBackGround.TabIndex = 6;
            this.ptbBackGround.TabStop = false;
            // 
            // FormPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(588, 557);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.ptbGround);
            this.Controls.Add(this.ptbPipeBottom3);
            this.Controls.Add(this.ptbPipeTop3);
            this.Controls.Add(this.ptbPipeBottom2);
            this.Controls.Add(this.ptbPipeTop2);
            this.Controls.Add(this.ptbPipeBottom);
            this.Controls.Add(this.ptbPipeTop);
            this.Controls.Add(this.ptbBird);
            this.Controls.Add(this.ptbBackGround);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formFlappyBird_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.formFlappyBird_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ptbGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPipeBottom3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPipeTop3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPipeBottom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPipeTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBackGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ptbPipeTop;
        private System.Windows.Forms.PictureBox ptbPipeBottom;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox ptbGround;
        private System.Windows.Forms.PictureBox ptbBackGround;
        private System.Windows.Forms.PictureBox ptbPipeTop2;
        private System.Windows.Forms.PictureBox ptbPipeBottom2;
        private System.Windows.Forms.PictureBox ptbPipeTop3;
        private System.Windows.Forms.PictureBox ptbPipeBottom3;
        public System.Windows.Forms.PictureBox ptbBird;
        public System.Windows.Forms.Timer timerGame;
    }
}

