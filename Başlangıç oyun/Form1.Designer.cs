﻿namespace Beskonačni_Toranj
{
    partial class Form1
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
            this.platformPictureBox_1 = new System.Windows.Forms.PictureBox();
            this.groundPictureBox = new System.Windows.Forms.PictureBox();
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.platformPictureBox_2 = new System.Windows.Forms.PictureBox();
            this.platformPictureBox_3 = new System.Windows.Forms.PictureBox();
            this.platformPictureBox_4 = new System.Windows.Forms.PictureBox();
            this.platformPictureBox_5 = new System.Windows.Forms.PictureBox();
            this.platformPictureBox_6 = new System.Windows.Forms.PictureBox();
            this.platformPictureBox_7 = new System.Windows.Forms.PictureBox();
            this.platformPictureBox_8 = new System.Windows.Forms.PictureBox();
            this.platformPictureBox_9 = new System.Windows.Forms.PictureBox();
            this.menuButton_1 = new System.Windows.Forms.PictureBox();
            this.menuButton_2 = new System.Windows.Forms.PictureBox();
            this.projectilPictureBox = new System.Windows.Forms.PictureBox();
            this.bossTickMovement = new System.Windows.Forms.Timer(this.components);
            this.bossPictureBox = new System.Windows.Forms.PictureBox();
            this.bossProjectilPictureBox = new System.Windows.Forms.PictureBox();
            this.bosscoinPictureBox = new System.Windows.Forms.PictureBox();
            this.enemyPictureBox = new System.Windows.Forms.PictureBox();
            this.enemycoinPictureBox = new System.Windows.Forms.PictureBox();
            this.menuButton_3 = new System.Windows.Forms.PictureBox();
            this.menuButton_4 = new System.Windows.Forms.PictureBox();
            this.highscoreUserControl = new Beskonačni_Toranj.HighscoreUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.platformPictureBox_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformPictureBox_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformPictureBox_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformPictureBox_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformPictureBox_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformPictureBox_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformPictureBox_7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformPictureBox_8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformPictureBox_9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectilPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossProjectilPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosscoinPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemycoinPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton_4)).BeginInit();
            this.SuspendLayout();
            // 
            // platformPictureBox_1
            // 
            this.platformPictureBox_1.Location = new System.Drawing.Point(276, 414);
            this.platformPictureBox_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.platformPictureBox_1.Name = "platformPictureBox_1";
            this.platformPictureBox_1.Size = new System.Drawing.Size(153, 64);
            this.platformPictureBox_1.TabIndex = 2;
            this.platformPictureBox_1.TabStop = false;
            this.platformPictureBox_1.Tag = "platform";
            // 
            // groundPictureBox
            // 
            this.groundPictureBox.Location = new System.Drawing.Point(-13, 594);
            this.groundPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groundPictureBox.Name = "groundPictureBox";
            this.groundPictureBox.Size = new System.Drawing.Size(1027, 89);
            this.groundPictureBox.TabIndex = 1;
            this.groundPictureBox.TabStop = false;
            this.groundPictureBox.Tag = "ground";
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.BackColor = System.Drawing.Color.Black;
            this.playerPictureBox.Location = new System.Drawing.Point(112, 490);
            this.playerPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new System.Drawing.Size(80, 112);
            this.playerPictureBox.TabIndex = 0;
            this.playerPictureBox.TabStop = false;
            this.playerPictureBox.Tag = "player";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTick);
            // 
            // platformPictureBox_2
            // 
            this.platformPictureBox_2.Location = new System.Drawing.Point(637, 314);
            this.platformPictureBox_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.platformPictureBox_2.Name = "platformPictureBox_2";
            this.platformPictureBox_2.Size = new System.Drawing.Size(153, 64);
            this.platformPictureBox_2.TabIndex = 3;
            this.platformPictureBox_2.TabStop = false;
            this.platformPictureBox_2.Tag = "platform";
            // 
            // platformPictureBox_3
            // 
            this.platformPictureBox_3.Location = new System.Drawing.Point(353, 208);
            this.platformPictureBox_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.platformPictureBox_3.Name = "platformPictureBox_3";
            this.platformPictureBox_3.Size = new System.Drawing.Size(153, 64);
            this.platformPictureBox_3.TabIndex = 4;
            this.platformPictureBox_3.TabStop = false;
            this.platformPictureBox_3.Tag = "platform";
            // 
            // platformPictureBox_4
            // 
            this.platformPictureBox_4.Location = new System.Drawing.Point(149, 47);
            this.platformPictureBox_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.platformPictureBox_4.Name = "platformPictureBox_4";
            this.platformPictureBox_4.Size = new System.Drawing.Size(153, 64);
            this.platformPictureBox_4.TabIndex = 5;
            this.platformPictureBox_4.TabStop = false;
            this.platformPictureBox_4.Tag = "platform";
            // 
            // platformPictureBox_5
            // 
            this.platformPictureBox_5.Location = new System.Drawing.Point(573, -38);
            this.platformPictureBox_5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.platformPictureBox_5.Name = "platformPictureBox_5";
            this.platformPictureBox_5.Size = new System.Drawing.Size(153, 64);
            this.platformPictureBox_5.TabIndex = 6;
            this.platformPictureBox_5.TabStop = false;
            this.platformPictureBox_5.Tag = "platform";
            // 
            // platformPictureBox_6
            // 
            this.platformPictureBox_6.Location = new System.Drawing.Point(205, 302);
            this.platformPictureBox_6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.platformPictureBox_6.Name = "platformPictureBox_6";
            this.platformPictureBox_6.Size = new System.Drawing.Size(153, 64);
            this.platformPictureBox_6.TabIndex = 7;
            this.platformPictureBox_6.TabStop = false;
            this.platformPictureBox_6.Tag = "platform";
            // 
            // platformPictureBox_7
            // 
            this.platformPictureBox_7.Location = new System.Drawing.Point(555, 126);
            this.platformPictureBox_7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.platformPictureBox_7.Name = "platformPictureBox_7";
            this.platformPictureBox_7.Size = new System.Drawing.Size(153, 64);
            this.platformPictureBox_7.TabIndex = 8;
            this.platformPictureBox_7.TabStop = false;
            this.platformPictureBox_7.Tag = "platform";
            // 
            // platformPictureBox_8
            // 
            this.platformPictureBox_8.Location = new System.Drawing.Point(248, 47);
            this.platformPictureBox_8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.platformPictureBox_8.Name = "platformPictureBox_8";
            this.platformPictureBox_8.Size = new System.Drawing.Size(153, 64);
            this.platformPictureBox_8.TabIndex = 9;
            this.platformPictureBox_8.TabStop = false;
            this.platformPictureBox_8.Tag = "platform";
            // 
            // platformPictureBox_9
            // 
            this.platformPictureBox_9.Location = new System.Drawing.Point(555, -9);
            this.platformPictureBox_9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.platformPictureBox_9.Name = "platformPictureBox_9";
            this.platformPictureBox_9.Size = new System.Drawing.Size(153, 64);
            this.platformPictureBox_9.TabIndex = 10;
            this.platformPictureBox_9.TabStop = false;
            this.platformPictureBox_9.Tag = "platform";
            // 
            // menuButton_1
            // 
            this.menuButton_1.Location = new System.Drawing.Point(39, 140);
            this.menuButton_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuButton_1.Name = "menuButton_1";
            this.menuButton_1.Size = new System.Drawing.Size(100, 50);
            this.menuButton_1.TabIndex = 11;
            this.menuButton_1.TabStop = false;
            this.menuButton_1.Tag = "button";
            this.menuButton_1.Click += new System.EventHandler(this.startClick);
            // 
            // menuButton_2
            // 
            this.menuButton_2.Location = new System.Drawing.Point(39, 373);
            this.menuButton_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuButton_2.Name = "menuButton_2";
            this.menuButton_2.Size = new System.Drawing.Size(100, 50);
            this.menuButton_2.TabIndex = 12;
            this.menuButton_2.TabStop = false;
            this.menuButton_2.Tag = "button";
            this.menuButton_2.Click += new System.EventHandler(this.quitClick);
            // 
            // projectilPictureBox
            // 
            this.projectilPictureBox.Location = new System.Drawing.Point(-133, -123);
            this.projectilPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.projectilPictureBox.Name = "projectilPictureBox";
            this.projectilPictureBox.Size = new System.Drawing.Size(60, 46);
            this.projectilPictureBox.TabIndex = 13;
            this.projectilPictureBox.TabStop = false;
            this.projectilPictureBox.Tag = "playerprojectil";
            // 
            // bossPictureBox
            // 
            this.bossPictureBox.Location = new System.Drawing.Point(728, 475);
            this.bossPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bossPictureBox.Name = "bossPictureBox";
            this.bossPictureBox.Size = new System.Drawing.Size(81, 114);
            this.bossPictureBox.TabIndex = 14;
            this.bossPictureBox.TabStop = false;
            this.bossPictureBox.Tag = "boss";
            // 
            // bossProjectilPictureBox
            // 
            this.bossProjectilPictureBox.Location = new System.Drawing.Point(-133, -123);
            this.bossProjectilPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bossProjectilPictureBox.Name = "bossProjectilPictureBox";
            this.bossProjectilPictureBox.Size = new System.Drawing.Size(44, 49);
            this.bossProjectilPictureBox.TabIndex = 15;
            this.bossProjectilPictureBox.TabStop = false;
            this.bossProjectilPictureBox.Tag = "bossprojectil";
            // 
            // bosscoinPictureBox
            // 
            this.bosscoinPictureBox.Location = new System.Drawing.Point(892, 594);
            this.bosscoinPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bosscoinPictureBox.Name = "bosscoinPictureBox";
            this.bosscoinPictureBox.Size = new System.Drawing.Size(80, 74);
            this.bosscoinPictureBox.TabIndex = 16;
            this.bosscoinPictureBox.TabStop = false;
            this.bosscoinPictureBox.Tag = "bosscoin";
            // 
            // enemyPictureBox
            // 
            this.enemyPictureBox.Location = new System.Drawing.Point(728, 475);
            this.enemyPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enemyPictureBox.Name = "enemyPictureBox";
            this.enemyPictureBox.Size = new System.Drawing.Size(81, 114);
            this.enemyPictureBox.TabIndex = 17;
            this.enemyPictureBox.TabStop = false;
            this.enemyPictureBox.Tag = "enemy";
            // 
            // enemycoinPictureBox
            // 
            this.enemycoinPictureBox.Location = new System.Drawing.Point(892, 594);
            this.enemycoinPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enemycoinPictureBox.Name = "enemycoinPictureBox";
            this.enemycoinPictureBox.Size = new System.Drawing.Size(80, 74);
            this.enemycoinPictureBox.TabIndex = 18;
            this.enemycoinPictureBox.TabStop = false;
            this.enemycoinPictureBox.Tag = "enemycoin";
            // 
            // menuButton_3
            // 
            this.menuButton_3.Location = new System.Drawing.Point(39, 222);
            this.menuButton_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuButton_3.Name = "menuButton_3";
            this.menuButton_3.Size = new System.Drawing.Size(100, 50);
            this.menuButton_3.TabIndex = 19;
            this.menuButton_3.TabStop = false;
            this.menuButton_3.Tag = "button";
            this.menuButton_3.Click += new System.EventHandler(this.playerClick);
            // 
            // menuButton_4
            // 
            this.menuButton_4.Location = new System.Drawing.Point(39, 302);
            this.menuButton_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuButton_4.Name = "menuButton_4";
            this.menuButton_4.Size = new System.Drawing.Size(100, 50);
            this.menuButton_4.TabIndex = 20;
            this.menuButton_4.TabStop = false;
            this.menuButton_4.Tag = "button";
            this.menuButton_4.Click += new System.EventHandler(this.highscoreClick);
            // 
            // highscoreUserControl
            // 
            this.highscoreUserControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.highscoreUserControl.Label1 = "label2";
            this.highscoreUserControl.Label10 = "label2";
            this.highscoreUserControl.Label2 = "label2";
            this.highscoreUserControl.Label3 = "label2";
            this.highscoreUserControl.Label4 = "label2";
            this.highscoreUserControl.Label5 = "label2";
            this.highscoreUserControl.Label6 = "label2";
            this.highscoreUserControl.Label7 = "label2";
            this.highscoreUserControl.Label8 = "label2";
            this.highscoreUserControl.Label9 = "label2";
            this.highscoreUserControl.Location = new System.Drawing.Point(539, 12);
            this.highscoreUserControl.Name = "highscoreUserControl";
            this.highscoreUserControl.Size = new System.Drawing.Size(340, 544);
            this.highscoreUserControl.TabIndex = 21;
            this.highscoreUserControl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 666);
            this.Controls.Add(this.highscoreUserControl);
            this.Controls.Add(this.menuButton_4);
            this.Controls.Add(this.menuButton_3);
            this.Controls.Add(this.bossProjectilPictureBox);
            this.Controls.Add(this.bossPictureBox);
            this.Controls.Add(this.projectilPictureBox);
            this.Controls.Add(this.menuButton_2);
            this.Controls.Add(this.menuButton_1);
            this.Controls.Add(this.platformPictureBox_9);
            this.Controls.Add(this.platformPictureBox_8);
            this.Controls.Add(this.platformPictureBox_7);
            this.Controls.Add(this.platformPictureBox_6);
            this.Controls.Add(this.platformPictureBox_5);
            this.Controls.Add(this.platformPictureBox_4);
            this.Controls.Add(this.platformPictureBox_3);
            this.Controls.Add(this.platformPictureBox_2);
            this.Controls.Add(this.platformPictureBox_1);
            this.Controls.Add(this.groundPictureBox);
            this.Controls.Add(this.playerPictureBox);
            this.Controls.Add(this.enemyPictureBox);
            this.Controls.Add(this.bosscoinPictureBox);
            this.Controls.Add(this.enemycoinPictureBox);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.platformPictureBox_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformPictureBox_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformPictureBox_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformPictureBox_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformPictureBox_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformPictureBox_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformPictureBox_7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformPictureBox_8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformPictureBox_9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectilPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossProjectilPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosscoinPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemycoinPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton_4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.PictureBox groundPictureBox;
        private System.Windows.Forms.PictureBox platformPictureBox_1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox platformPictureBox_2;
        private System.Windows.Forms.PictureBox platformPictureBox_3;
        private System.Windows.Forms.PictureBox platformPictureBox_4;
        private System.Windows.Forms.PictureBox platformPictureBox_5;
        private System.Windows.Forms.PictureBox platformPictureBox_6;
        private System.Windows.Forms.PictureBox platformPictureBox_7;
        private System.Windows.Forms.PictureBox platformPictureBox_8;
        private System.Windows.Forms.PictureBox platformPictureBox_9;
        private System.Windows.Forms.PictureBox menuButton_1;
        private System.Windows.Forms.PictureBox menuButton_2;
        private System.Windows.Forms.PictureBox projectilPictureBox;
        private System.Windows.Forms.Timer bossTickMovement;
        private System.Windows.Forms.PictureBox bossPictureBox;
        private System.Windows.Forms.PictureBox bossProjectilPictureBox;
        private System.Windows.Forms.PictureBox bosscoinPictureBox;
        private System.Windows.Forms.PictureBox enemyPictureBox;
        private System.Windows.Forms.PictureBox enemycoinPictureBox;
        private System.Windows.Forms.PictureBox menuButton_3;
        private System.Windows.Forms.PictureBox menuButton_4;
        private HighscoreUserControl highscoreUserControl;
    }
}

