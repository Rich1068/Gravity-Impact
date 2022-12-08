namespace Gravity_Impact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.lblhighScore = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblscore_value = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Instructions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Gravity_Impact.Properties.Resources.download;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-28, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(873, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Gravity_Impact.Properties.Resources.download;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-28, 377);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(873, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.ForeColor = System.Drawing.Color.Transparent;
            this.lblScore.Location = new System.Drawing.Point(27, 18);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(56, 21);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score:";
            // 
            // lblhighScore
            // 
            this.lblhighScore.AutoSize = true;
            this.lblhighScore.BackColor = System.Drawing.Color.Transparent;
            this.lblhighScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblhighScore.ForeColor = System.Drawing.Color.Transparent;
            this.lblhighScore.Location = new System.Drawing.Point(27, 395);
            this.lblhighScore.Name = "lblhighScore";
            this.lblhighScore.Size = new System.Drawing.Size(93, 21);
            this.lblhighScore.TabIndex = 3;
            this.lblhighScore.Text = "HighScore:";
            // 
            // player
            // 
            this.player.Image = global::Gravity_Impact.Properties.Resources.catto;
            this.player.Location = new System.Drawing.Point(132, 303);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(67, 80);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Gravity_Impact.Properties.Resources.chinese_tom;
            this.pictureBox4.Location = new System.Drawing.Point(424, 39);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(67, 80);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "obstacle";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Gravity_Impact.Properties.Resources.chinese_tom;
            this.pictureBox5.Location = new System.Drawing.Point(633, 303);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(67, 80);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "obstacle";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Gravity_Impact.Properties.Resources.cowJAM;
            this.pictureBox3.Location = new System.Drawing.Point(548, 189);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "coin";
            // 
            // lblscore_value
            // 
            this.lblscore_value.AutoSize = true;
            this.lblscore_value.BackColor = System.Drawing.Color.Transparent;
            this.lblscore_value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblscore_value.ForeColor = System.Drawing.Color.Transparent;
            this.lblscore_value.Location = new System.Drawing.Point(130, 395);
            this.lblscore_value.Name = "lblscore_value";
            this.lblscore_value.Size = new System.Drawing.Size(19, 21);
            this.lblscore_value.TabIndex = 8;
            this.lblscore_value.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(325, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 9;
            // 
            // Instructions
            // 
            this.Instructions.AutoSize = true;
            this.Instructions.BackColor = System.Drawing.Color.Transparent;
            this.Instructions.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Instructions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Instructions.Location = new System.Drawing.Point(268, 139);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(338, 47);
            this.Instructions.TabIndex = 10;
            this.Instructions.Text = "Press Enter to Start";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gravity_Impact.Properties.Resources.bef05f3bc48d34bd386b521e970dd801_1822064499909099042;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 425);
            this.Controls.Add(this.Instructions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblscore_value);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblhighScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer gameTimer;
        private Label lblScore;
        private Label lblhighScore;
        private PictureBox player;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private Label lblscore_value;
        private Label label1;
        private Label Instructions;
    }
}