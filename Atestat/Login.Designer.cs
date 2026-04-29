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
            this.loginText = new System.Windows.Forms.Label();
            this.UNText = new System.Windows.Forms.Label();
            this.PWText = new System.Windows.Forms.Label();
            this.UNBox = new System.Windows.Forms.TextBox();
            this.PWBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.signInLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // loginText
            // 
            this.loginText.AutoSize = true;
            this.loginText.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginText.Location = new System.Drawing.Point(121, 9);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(75, 25);
            this.loginText.TabIndex = 0;
            this.loginText.Text = "Login:";
            this.loginText.Click += new System.EventHandler(this.loginText_Click);
            // 
            // UNText
            // 
            this.UNText.AutoSize = true;
            this.UNText.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UNText.Location = new System.Drawing.Point(69, 68);
            this.UNText.Name = "UNText";
            this.UNText.Size = new System.Drawing.Size(84, 18);
            this.UNText.TabIndex = 1;
            this.UNText.Text = "Username";
            // 
            // PWText
            // 
            this.PWText.AutoSize = true;
            this.PWText.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWText.Location = new System.Drawing.Point(71, 115);
            this.PWText.Name = "PWText";
            this.PWText.Size = new System.Drawing.Size(82, 18);
            this.PWText.TabIndex = 2;
            this.PWText.Text = "Password";
            // 
            // UNBox
            // 
            this.UNBox.Location = new System.Drawing.Point(160, 68);
            this.UNBox.Name = "UNBox";
            this.UNBox.Size = new System.Drawing.Size(100, 20);
            this.UNBox.TabIndex = 3;
            // 
            // PWBox
            // 
            this.PWBox.Location = new System.Drawing.Point(159, 115);
            this.PWBox.Name = "PWBox";
            this.PWBox.Size = new System.Drawing.Size(100, 20);
            this.PWBox.TabIndex = 4;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(110, 176);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(134, 48);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // signInLabel
            // 
            this.signInLabel.AutoSize = true;
            this.signInLabel.LinkArea = new System.Windows.Forms.LinkArea(35, 7);
            this.signInLabel.Location = new System.Drawing.Point(74, 258);
            this.signInLabel.Name = "signInLabel";
            this.signInLabel.Size = new System.Drawing.Size(218, 17);
            this.signInLabel.TabIndex = 7;
            this.signInLabel.TabStop = true;
            this.signInLabel.Text = "In case you don\'t have an account, sign up";
            this.signInLabel.UseCompatibleTextRendering = true;
            this.signInLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signInLabel_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 311);
            this.Controls.Add(this.signInLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PWBox);
            this.Controls.Add(this.UNBox);
            this.Controls.Add(this.PWText);
            this.Controls.Add(this.UNText);
            this.Controls.Add(this.loginText);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
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
    }
}

