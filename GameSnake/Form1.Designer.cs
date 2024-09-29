
namespace GameSnake
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
            System.Windows.Forms.PictureBox pbLogoGame;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblContacts = new System.Windows.Forms.Label();
            this.pbLinkedin = new System.Windows.Forms.PictureBox();
            this.pbGitHub = new System.Windows.Forms.PictureBox();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.pbVolume = new System.Windows.Forms.PictureBox();
            this.pbStart = new System.Windows.Forms.PictureBox();
            this.pbSettings = new System.Windows.Forms.PictureBox();
            this.lblFrameColor = new System.Windows.Forms.Label();
            this.lblBackgroundColor = new System.Windows.Forms.Label();
            this.lblSnakeColor = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lblGameName = new System.Windows.Forms.Label();
            this.cmdExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            pbLogoGame = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pbLogoGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinkedin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogoGame
            // 
            pbLogoGame.BackColor = System.Drawing.Color.Transparent;
            pbLogoGame.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoGame.Image")));
            pbLogoGame.InitialImage = null;
            pbLogoGame.Location = new System.Drawing.Point(606, 322);
            pbLogoGame.Name = "pbLogoGame";
            pbLogoGame.Size = new System.Drawing.Size(202, 238);
            pbLogoGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbLogoGame.TabIndex = 22;
            pbLogoGame.TabStop = false;
            pbLogoGame.Visible = false;
            // 
            // lblContacts
            // 
            this.lblContacts.AutoSize = true;
            this.lblContacts.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblContacts.Location = new System.Drawing.Point(218, 492);
            this.lblContacts.Name = "lblContacts";
            this.lblContacts.Size = new System.Drawing.Size(90, 23);
            this.lblContacts.TabIndex = 29;
            this.lblContacts.Text = "Contacts:";
            // 
            // pbLinkedin
            // 
            this.pbLinkedin.BackColor = System.Drawing.Color.White;
            this.pbLinkedin.Image = ((System.Drawing.Image)(resources.GetObject("pbLinkedin.Image")));
            this.pbLinkedin.Location = new System.Drawing.Point(401, 479);
            this.pbLinkedin.Name = "pbLinkedin";
            this.pbLinkedin.Size = new System.Drawing.Size(50, 47);
            this.pbLinkedin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLinkedin.TabIndex = 28;
            this.pbLinkedin.TabStop = false;
            // 
            // pbGitHub
            // 
            this.pbGitHub.Image = ((System.Drawing.Image)(resources.GetObject("pbGitHub.Image")));
            this.pbGitHub.Location = new System.Drawing.Point(326, 479);
            this.pbGitHub.Name = "pbGitHub";
            this.pbGitHub.Size = new System.Drawing.Size(54, 47);
            this.pbGitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGitHub.TabIndex = 27;
            this.pbGitHub.TabStop = false;
            // 
            // pbHome
            // 
            this.pbHome.Image = ((System.Drawing.Image)(resources.GetObject("pbHome.Image")));
            this.pbHome.Location = new System.Drawing.Point(17, 407);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(107, 97);
            this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHome.TabIndex = 26;
            this.pbHome.TabStop = false;
            // 
            // pbVolume
            // 
            this.pbVolume.BackColor = System.Drawing.Color.Transparent;
            this.pbVolume.Image = ((System.Drawing.Image)(resources.GetObject("pbVolume.Image")));
            this.pbVolume.Location = new System.Drawing.Point(739, 56);
            this.pbVolume.Name = "pbVolume";
            this.pbVolume.Size = new System.Drawing.Size(48, 44);
            this.pbVolume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVolume.TabIndex = 25;
            this.pbVolume.TabStop = false;
            this.pbVolume.Click += new System.EventHandler(this.pbVolume_Click);
            // 
            // pbStart
            // 
            this.pbStart.BackColor = System.Drawing.Color.Transparent;
            this.pbStart.Image = ((System.Drawing.Image)(resources.GetObject("pbStart.Image")));
            this.pbStart.Location = new System.Drawing.Point(309, 172);
            this.pbStart.Name = "pbStart";
            this.pbStart.Size = new System.Drawing.Size(184, 80);
            this.pbStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStart.TabIndex = 24;
            this.pbStart.TabStop = false;
            // 
            // pbSettings
            // 
            this.pbSettings.BackColor = System.Drawing.Color.Transparent;
            this.pbSettings.Image = ((System.Drawing.Image)(resources.GetObject("pbSettings.Image")));
            this.pbSettings.Location = new System.Drawing.Point(309, 289);
            this.pbSettings.Name = "pbSettings";
            this.pbSettings.Size = new System.Drawing.Size(184, 85);
            this.pbSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSettings.TabIndex = 23;
            this.pbSettings.TabStop = false;
            // 
            // lblFrameColor
            // 
            this.lblFrameColor.AutoSize = true;
            this.lblFrameColor.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblFrameColor.Location = new System.Drawing.Point(12, 271);
            this.lblFrameColor.Name = "lblFrameColor";
            this.lblFrameColor.Size = new System.Drawing.Size(137, 26);
            this.lblFrameColor.TabIndex = 21;
            this.lblFrameColor.Text = "Frame Color";
            this.lblFrameColor.Visible = false;
            this.lblFrameColor.Click += new System.EventHandler(this.lblFrameColor_Click);
            // 
            // lblBackgroundColor
            // 
            this.lblBackgroundColor.AutoSize = true;
            this.lblBackgroundColor.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblBackgroundColor.Location = new System.Drawing.Point(12, 211);
            this.lblBackgroundColor.Name = "lblBackgroundColor";
            this.lblBackgroundColor.Size = new System.Drawing.Size(198, 26);
            this.lblBackgroundColor.TabIndex = 20;
            this.lblBackgroundColor.Text = "Background Color";
            this.lblBackgroundColor.Visible = false;
            this.lblBackgroundColor.Click += new System.EventHandler(this.lblBackgroundColor_Click);
            // 
            // lblSnakeColor
            // 
            this.lblSnakeColor.AutoSize = true;
            this.lblSnakeColor.BackColor = System.Drawing.Color.Transparent;
            this.lblSnakeColor.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblSnakeColor.Location = new System.Drawing.Point(12, 157);
            this.lblSnakeColor.Name = "lblSnakeColor";
            this.lblSnakeColor.Size = new System.Drawing.Size(137, 26);
            this.lblSnakeColor.TabIndex = 19;
            this.lblSnakeColor.Text = "Snake Color";
            this.lblSnakeColor.Visible = false;
            this.lblSnakeColor.Click += new System.EventHandler(this.lblSnakeColor_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(783, -77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 29);
            this.button3.TabIndex = 18;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.BackColor = System.Drawing.Color.Transparent;
            this.lblGameName.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Italic);
            this.lblGameName.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblGameName.Location = new System.Drawing.Point(224, 9);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(341, 119);
            this.lblGameName.TabIndex = 17;
            this.lblGameName.Text = "SNAKE";
            // 
            // cmdExit
            // 
            this.cmdExit.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Location = new System.Drawing.Point(804, 9);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(30, 29);
            this.cmdExit.TabIndex = 30;
            this.cmdExit.Text = "X";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(832, 584);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.lblContacts);
            this.Controls.Add(this.pbLinkedin);
            this.Controls.Add(this.pbGitHub);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.pbVolume);
            this.Controls.Add(this.pbStart);
            this.Controls.Add(this.pbSettings);
            this.Controls.Add(pbLogoGame);
            this.Controls.Add(this.lblFrameColor);
            this.Controls.Add(this.lblBackgroundColor);
            this.Controls.Add(this.lblSnakeColor);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblGameName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(pbLogoGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinkedin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContacts;
        private System.Windows.Forms.Label lblFrameColor;
        private System.Windows.Forms.Label lblBackgroundColor;
        private System.Windows.Forms.Label lblSnakeColor;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Button cmdExit;
        public System.Windows.Forms.PictureBox pbStart;
        public System.Windows.Forms.PictureBox pbSettings;
        public System.Windows.Forms.PictureBox pbHome;
        public System.Windows.Forms.PictureBox pbLinkedin;
        public System.Windows.Forms.PictureBox pbGitHub;
        public System.Windows.Forms.PictureBox pbVolume;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

