
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
            this.lblScore.Location = new System.Drawing.Point(214, 624);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(128, 38);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score :";
            // 
            // ptbGround
            // 
            this.ptbGround.Image = global::FlappyBird_Game.Properties.Resources.ground;
            this.ptbGround.Location = new System.Drawing.Point(-24, 554);
            this.ptbGround.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbGround.Name = "ptbGround";
            this.ptbGround.Size = new System.Drawing.Size(1477, 212);
            this.ptbGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbGround.TabIndex = 5;
            this.ptbGround.TabStop = false;
            // 
            // ptbPipeBottom3
            // 
            this.ptbPipeBottom3.BackColor = System.Drawing.Color.Transparent;
            this.ptbPipeBottom3.Image = global::FlappyBird_Game.Properties.Resources.pipe;
            this.ptbPipeBottom3.Location = new System.Drawing.Point(1157, 368);
            this.ptbPipeBottom3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbPipeBottom3.Name = "ptbPipeBottom3";
            this.ptbPipeBottom3.Size = new System.Drawing.Size(133, 306);
            this.ptbPipeBottom3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPipeBottom3.TabIndex = 10;
            this.ptbPipeBottom3.TabStop = false;
            this.ptbPipeBottom3.WaitOnLoad = true;
            // 
            // ptbPipeTop3
            // 
            this.ptbPipeTop3.BackColor = System.Drawing.Color.Transparent;
            this.ptbPipeTop3.Image = global::FlappyBird_Game.Properties.Resources.pipedown;
            this.ptbPipeTop3.Location = new System.Drawing.Point(1157, -7);
            this.ptbPipeTop3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbPipeTop3.Name = "ptbPipeTop3";
            this.ptbPipeTop3.Size = new System.Drawing.Size(133, 225);
            this.ptbPipeTop3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPipeTop3.TabIndex = 9;
            this.ptbPipeTop3.TabStop = false;
            this.ptbPipeTop3.WaitOnLoad = true;
            // 
            // ptbPipeBottom2
            // 
            this.ptbPipeBottom2.BackColor = System.Drawing.Color.Transparent;
            this.ptbPipeBottom2.Image = global::FlappyBird_Game.Properties.Resources.pipe;
            this.ptbPipeBottom2.Location = new System.Drawing.Point(853, 409);
            this.ptbPipeBottom2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbPipeBottom2.Name = "ptbPipeBottom2";
            this.ptbPipeBottom2.Size = new System.Drawing.Size(133, 266);
            this.ptbPipeBottom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPipeBottom2.TabIndex = 8;
            this.ptbPipeBottom2.TabStop = false;
            this.ptbPipeBottom2.WaitOnLoad = true;
            // 
            // ptbPipeTop2
            // 
            this.ptbPipeTop2.BackColor = System.Drawing.Color.Transparent;
            this.ptbPipeTop2.Image = global::FlappyBird_Game.Properties.Resources.pipedown;
            this.ptbPipeTop2.Location = new System.Drawing.Point(853, -7);
            this.ptbPipeTop2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbPipeTop2.Name = "ptbPipeTop2";
            this.ptbPipeTop2.Size = new System.Drawing.Size(133, 249);
            this.ptbPipeTop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPipeTop2.TabIndex = 7;
            this.ptbPipeTop2.TabStop = false;
            this.ptbPipeTop2.WaitOnLoad = true;
            // 
            // ptbPipeBottom
            // 
            this.ptbPipeBottom.BackColor = System.Drawing.Color.Transparent;
            this.ptbPipeBottom.Image = global::FlappyBird_Game.Properties.Resources.pipe;
            this.ptbPipeBottom.Location = new System.Drawing.Point(599, 423);
            this.ptbPipeBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbPipeBottom.Name = "ptbPipeBottom";
            this.ptbPipeBottom.Size = new System.Drawing.Size(133, 250);
            this.ptbPipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPipeBottom.TabIndex = 3;
            this.ptbPipeBottom.TabStop = false;
            this.ptbPipeBottom.WaitOnLoad = true;
            // 
            // ptbPipeTop
            // 
            this.ptbPipeTop.BackColor = System.Drawing.Color.Transparent;
            this.ptbPipeTop.Image = global::FlappyBird_Game.Properties.Resources.pipedown;
            this.ptbPipeTop.Location = new System.Drawing.Point(599, -7);
            this.ptbPipeTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbPipeTop.Name = "ptbPipeTop";
            this.ptbPipeTop.Size = new System.Drawing.Size(133, 213);
            this.ptbPipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPipeTop.TabIndex = 1;
            this.ptbPipeTop.TabStop = false;
            this.ptbPipeTop.WaitOnLoad = true;
            // 
            // ptbBird
            // 
            this.ptbBird.BackColor = System.Drawing.Color.Transparent;
            this.ptbBird.Image = global::FlappyBird_Game.Properties.Resources.bird;
            this.ptbBird.Location = new System.Drawing.Point(133, 267);
            this.ptbBird.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbBird.Name = "ptbBird";
            this.ptbBird.Size = new System.Drawing.Size(67, 63);
            this.ptbBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbBird.TabIndex = 0;
            this.ptbBird.TabStop = false;
            this.ptbBird.WaitOnLoad = true;
            // 
            // ptbBackGround
            // 
            this.ptbBackGround.Location = new System.Drawing.Point(832, 320);
            this.ptbBackGround.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbBackGround.Name = "ptbBackGround";
            this.ptbBackGround.Size = new System.Drawing.Size(10, 10);
            this.ptbBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbBackGround.TabIndex = 6;
            this.ptbBackGround.TabStop = false;
            this.ptbBackGround.WaitOnLoad = true;
            // 
            // FormPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImage = global::FlappyBird_Game.Properties.Resources.nen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 686);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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

