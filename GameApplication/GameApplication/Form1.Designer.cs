
namespace GameApplication
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
            this.lblScore = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.gameMessage = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.policeOfficer = new System.Windows.Forms.PictureBox();
            this.burglar2 = new System.Windows.Forms.PictureBox();
            this.ordinaryMan = new System.Windows.Forms.PictureBox();
            this.burglar1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeOfficer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.burglar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordinaryMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.burglar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Navy;
            this.lblScore.Location = new System.Drawing.Point(3, 604);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(70, 20);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Points: 0";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.Navy;
            this.lblLevel.Location = new System.Drawing.Point(325, 604);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(63, 20);
            this.lblLevel.TabIndex = 8;
            this.lblLevel.Text = "Level: 1";
            // 
            // gameMessage
            // 
            this.gameMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameMessage.ForeColor = System.Drawing.Color.Navy;
            this.gameMessage.Location = new System.Drawing.Point(-7, 249);
            this.gameMessage.Name = "gameMessage";
            this.gameMessage.Size = new System.Drawing.Size(412, 115);
            this.gameMessage.TabIndex = 9;
            this.gameMessage.Text = "LEVEL UP";
            this.gameMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.BackColor = System.Drawing.SystemColors.Window;
            this.btnPlayGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayGame.ForeColor = System.Drawing.Color.Firebrick;
            this.btnPlayGame.Location = new System.Drawing.Point(144, 133);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Padding = new System.Windows.Forms.Padding(5);
            this.btnPlayGame.Size = new System.Drawing.Size(116, 38);
            this.btnPlayGame.TabIndex = 10;
            this.btnPlayGame.Text = "Play Game";
            this.btnPlayGame.UseVisualStyleBackColor = false;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.Image = global::GameApplication.Properties.Resources.police_car_76;
            this.pictureBoxCar.Location = new System.Drawing.Point(-9, -1);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(414, 637);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCar.TabIndex = 11;
            this.pictureBoxCar.TabStop = false;
            // 
            // bullet
            // 
            this.bullet.Image = global::GameApplication.Properties.Resources.bulletImage__1_;
            this.bullet.Location = new System.Drawing.Point(181, 446);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(22, 32);
            this.bullet.TabIndex = 5;
            this.bullet.TabStop = false;
            // 
            // policeOfficer
            // 
            this.policeOfficer.Image = global::GameApplication.Properties.Resources.pic41;
            this.policeOfficer.Location = new System.Drawing.Point(144, 497);
            this.policeOfficer.Name = "policeOfficer";
            this.policeOfficer.Size = new System.Drawing.Size(89, 100);
            this.policeOfficer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.policeOfficer.TabIndex = 4;
            this.policeOfficer.TabStop = false;
            // 
            // burglar2
            // 
            this.burglar2.Image = global::GameApplication.Properties.Resources.pic11;
            this.burglar2.Location = new System.Drawing.Point(164, 23);
            this.burglar2.Name = "burglar2";
            this.burglar2.Size = new System.Drawing.Size(80, 80);
            this.burglar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.burglar2.TabIndex = 2;
            this.burglar2.TabStop = false;
            // 
            // ordinaryMan
            // 
            this.ordinaryMan.Image = global::GameApplication.Properties.Resources._764584__1_;
            this.ordinaryMan.Location = new System.Drawing.Point(318, 23);
            this.ordinaryMan.Name = "ordinaryMan";
            this.ordinaryMan.Size = new System.Drawing.Size(46, 100);
            this.ordinaryMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ordinaryMan.TabIndex = 1;
            this.ordinaryMan.TabStop = false;
            this.ordinaryMan.Click += new System.EventHandler(this.ordinaryMan_Click);
            // 
            // burglar1
            // 
            this.burglar1.Image = global::GameApplication.Properties.Resources.PngItem_91940__1_;
            this.burglar1.Location = new System.Drawing.Point(33, 12);
            this.burglar1.Name = "burglar1";
            this.burglar1.Size = new System.Drawing.Size(61, 100);
            this.burglar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.burglar1.TabIndex = 0;
            this.burglar1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTitle.Location = new System.Drawing.Point(55, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 65);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Cops VS Robbers";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 637);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(398, 632);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnPlayGame);
            this.Controls.Add(this.pictureBoxCar);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.policeOfficer);
            this.Controls.Add(this.burglar2);
            this.Controls.Add(this.ordinaryMan);
            this.Controls.Add(this.burglar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gameMessage);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "CopsVsRobbers";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeOfficer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.burglar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordinaryMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.burglar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox burglar1;
        private System.Windows.Forms.PictureBox ordinaryMan;
        private System.Windows.Forms.PictureBox burglar2;
        private System.Windows.Forms.PictureBox policeOfficer;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label gameMessage;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button btnPlayGame;
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

