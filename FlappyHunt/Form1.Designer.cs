namespace FlappyHunt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblScore = new System.Windows.Forms.Label();
            this.picHunter = new System.Windows.Forms.PictureBox();
            this.picDog = new System.Windows.Forms.PictureBox();
            this.picHive = new System.Windows.Forms.PictureBox();
            this.picGround = new System.Windows.Forms.PictureBox();
            this.huntTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picHunter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGround)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Elephant", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(364, 777);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(159, 41);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score: 0";
            // 
            // picHunter
            // 
            this.picHunter.Image = global::FlappyHunt.Properties.Resources.hunterBlue_removebg_preview;
            this.picHunter.Location = new System.Drawing.Point(226, 319);
            this.picHunter.Name = "picHunter";
            this.picHunter.Size = new System.Drawing.Size(150, 82);
            this.picHunter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHunter.TabIndex = 1;
            this.picHunter.TabStop = false;
            // 
            // picDog
            // 
            this.picDog.Image = global::FlappyHunt.Properties.Resources.hellhound_removebg_preview;
            this.picDog.Location = new System.Drawing.Point(693, -38);
            this.picDog.Name = "picDog";
            this.picDog.Size = new System.Drawing.Size(150, 252);
            this.picDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDog.TabIndex = 2;
            this.picDog.TabStop = false;
            this.picDog.Click += new System.EventHandler(this.picDog_Click);
            // 
            // picHive
            // 
            this.picHive.Image = global::FlappyHunt.Properties.Resources.Hive_removebg_preview;
            this.picHive.Location = new System.Drawing.Point(546, 516);
            this.picHive.Name = "picHive";
            this.picHive.Size = new System.Drawing.Size(150, 267);
            this.picHive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHive.TabIndex = 3;
            this.picHive.TabStop = false;
            this.picHive.Click += new System.EventHandler(this.picHive_Click);
            // 
            // picGround
            // 
            this.picGround.Image = global::FlappyHunt.Properties.Resources.ground;
            this.picGround.Location = new System.Drawing.Point(-18, 757);
            this.picGround.Name = "picGround";
            this.picGround.Size = new System.Drawing.Size(1043, 75);
            this.picGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGround.TabIndex = 4;
            this.picGround.TabStop = false;
            // 
            // huntTimer
            // 
            this.huntTimer.Enabled = true;
            this.huntTimer.Interval = 20;
            this.huntTimer.Tick += new System.EventHandler(this.huntTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(986, 844);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picGround);
            this.Controls.Add(this.picHive);
            this.Controls.Add(this.picDog);
            this.Controls.Add(this.picHunter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picHunter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox picHunter;
        private System.Windows.Forms.PictureBox picDog;
        private System.Windows.Forms.PictureBox picHive;
        private System.Windows.Forms.PictureBox picGround;
        private System.Windows.Forms.Timer huntTimer;
    }
}

