namespace FaceRecognition
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.bttnAddFace = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxBackColor1 = new FaceRecognition.GroupBoxBackColor();
            this.groupBoxBackColor2 = new FaceRecognition.GroupBoxBackColor();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnAddFace
            // 
            this.bttnAddFace.Location = new System.Drawing.Point(12, 526);
            this.bttnAddFace.Name = "bttnAddFace";
            this.bttnAddFace.Size = new System.Drawing.Size(121, 23);
            this.bttnAddFace.TabIndex = 1;
            this.bttnAddFace.Text = "Login";
            this.bttnAddFace.UseVisualStyleBackColor = true;
            this.bttnAddFace.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(634, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Powered By Emircan Kahveci";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FaceRecognition.Properties.Resources.FaceScan;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxBackColor1
            // 
            this.groupBoxBackColor1.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxBackColor1.BorderColor = System.Drawing.Color.Transparent;
            this.groupBoxBackColor1.Location = new System.Drawing.Point(12, 245);
            this.groupBoxBackColor1.Name = "groupBoxBackColor1";
            this.groupBoxBackColor1.Size = new System.Drawing.Size(109, 80);
            this.groupBoxBackColor1.TabIndex = 2;
            this.groupBoxBackColor1.TabStop = false;
            // 
            // groupBoxBackColor2
            // 
            this.groupBoxBackColor2.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxBackColor2.BorderColor = System.Drawing.Color.Transparent;
            this.groupBoxBackColor2.Location = new System.Drawing.Point(247, 0);
            this.groupBoxBackColor2.Name = "groupBoxBackColor2";
            this.groupBoxBackColor2.Size = new System.Drawing.Size(200, 15);
            this.groupBoxBackColor2.TabIndex = 2;
            this.groupBoxBackColor2.TabStop = false;
            this.groupBoxBackColor2.Text = "groupBoxBackColor2";
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::FaceRecognition.Properties.Resources.FaceScan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.bttnAddFace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxBackColor2);
            this.Controls.Add(this.groupBoxBackColor1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginScreen";
            this.Text = "Face Scan Application - Login Screen";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttnAddFace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private GroupBoxBackColor groupBoxBackColor1;
        private GroupBoxBackColor groupBoxBackColor2;
    }
}