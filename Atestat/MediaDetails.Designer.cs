namespace Atestat
{
    partial class MediaDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaDetails));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.UNText = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReviewBox = new System.Windows.Forms.RichTextBox();
            this.LogOutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(237, 289);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // UNText
            // 
            this.UNText.AutoSize = true;
            this.UNText.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UNText.ForeColor = System.Drawing.SystemColors.Control;
            this.UNText.Location = new System.Drawing.Point(291, 24);
            this.UNText.Name = "UNText";
            this.UNText.Size = new System.Drawing.Size(129, 65);
            this.UNText.TabIndex = 9;
            this.UNText.Text = "Title";
            this.UNText.Click += new System.EventHandler(this.UNText_Click);
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.AuthorLabel.Location = new System.Drawing.Point(297, 89);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(80, 30);
            this.AuthorLabel.TabIndex = 10;
            this.AuthorLabel.Text = "Author";
            this.AuthorLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.DescriptionLabel.Location = new System.Drawing.Point(298, 138);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(377, 164);
            this.DescriptionLabel.TabIndex = 11;
            this.DescriptionLabel.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(278, 617);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Author";
            // 
            // ReviewBox
            // 
            this.ReviewBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
            this.ReviewBox.ForeColor = System.Drawing.SystemColors.Control;
            this.ReviewBox.Location = new System.Drawing.Point(12, 305);
            this.ReviewBox.Name = "ReviewBox";
            this.ReviewBox.Size = new System.Drawing.Size(663, 138);
            this.ReviewBox.TabIndex = 13;
            this.ReviewBox.Text = "";
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.LogOutButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.ForeColor = System.Drawing.SystemColors.Control;
            this.LogOutButton.Location = new System.Drawing.Point(529, 449);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(146, 55);
            this.LogOutButton.TabIndex = 14;
            this.LogOutButton.Text = "Post Review";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // MediaDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(687, 549);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.ReviewBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.UNText);
            this.Controls.Add(this.pictureBox2);
            this.Name = "MediaDetails";
            this.Text = "MediaDetails";
            this.Load += new System.EventHandler(this.MediaDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label UNText;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ReviewBox;
        private System.Windows.Forms.Button LogOutButton;
    }
}