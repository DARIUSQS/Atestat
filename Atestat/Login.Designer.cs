namespace Atestat
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginText = new System.Windows.Forms.Label();
            this.UNText = new System.Windows.Forms.Label();
            this.PWText = new System.Windows.Forms.Label();
            this.UNBox = new System.Windows.Forms.TextBox();
            this.PWBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.signInLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // loginText
            // 
            this.loginText.AutoSize = true;
            this.loginText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(112)))));
            this.loginText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginText.ForeColor = System.Drawing.SystemColors.Control;
            this.loginText.Location = new System.Drawing.Point(133, 24);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(122, 30);
            this.loginText.TabIndex = 0;
            this.loginText.Text = "Login Page";
            this.loginText.Click += new System.EventHandler(this.loginText_Click);
            // 
            // UNText
            // 
            this.UNText.AutoSize = true;
            this.UNText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(112)))));
            this.UNText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.UNText.ForeColor = System.Drawing.SystemColors.Control;
            this.UNText.Location = new System.Drawing.Point(81, 83);
            this.UNText.Name = "UNText";
            this.UNText.Size = new System.Drawing.Size(87, 21);
            this.UNText.TabIndex = 1;
            this.UNText.Text = "Username";
            // 
            // PWText
            // 
            this.PWText.AutoSize = true;
            this.PWText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(112)))));
            this.PWText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.PWText.ForeColor = System.Drawing.SystemColors.Control;
            this.PWText.Location = new System.Drawing.Point(83, 130);
            this.PWText.Name = "PWText";
            this.PWText.Size = new System.Drawing.Size(82, 21);
            this.PWText.TabIndex = 2;
            this.PWText.Text = "Password";
            // 
            // UNBox
            // 
            this.UNBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UNBox.Location = new System.Drawing.Point(172, 83);
            this.UNBox.Name = "UNBox";
            this.UNBox.Size = new System.Drawing.Size(100, 26);
            this.UNBox.TabIndex = 3;
            // 
            // PWBox
            // 
            this.PWBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PWBox.Location = new System.Drawing.Point(171, 130);
            this.PWBox.Name = "PWBox";
            this.PWBox.Size = new System.Drawing.Size(100, 26);
            this.PWBox.TabIndex = 4;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(112)))));
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.Control;
            this.LoginButton.Location = new System.Drawing.Point(122, 191);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(134, 48);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // signInLabel
            // 
            this.signInLabel.AutoSize = true;
            this.signInLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(112)))));
            this.signInLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.signInLabel.LinkArea = new System.Windows.Forms.LinkArea(35, 7);
            this.signInLabel.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.signInLabel.Location = new System.Drawing.Point(86, 273);
            this.signInLabel.Name = "signInLabel";
            this.signInLabel.Size = new System.Drawing.Size(216, 20);
            this.signInLabel.TabIndex = 7;
            this.signInLabel.TabStop = true;
            this.signInLabel.Text = "In case you don\'t have an account, sign up";
            this.signInLabel.UseCompatibleTextRendering = true;
            this.signInLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signInLabel_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(112)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-10, 273);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 375);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(147, 343);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 88);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(377, 443);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.signInLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PWBox);
            this.Controls.Add(this.UNBox);
            this.Controls.Add(this.PWText);
            this.Controls.Add(this.UNText);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginText;
        private System.Windows.Forms.Label UNText;
        private System.Windows.Forms.Label PWText;
        private System.Windows.Forms.TextBox UNBox;
        private System.Windows.Forms.TextBox PWBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.LinkLabel signInLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

