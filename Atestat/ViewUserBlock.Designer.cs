namespace Atestat
{
    partial class ViewUserBlock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUserBlock));
            this.ItemPhoto = new System.Windows.Forms.PictureBox();
            this.TitleBox = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.Label();
            this.AdminBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemPhoto
            // 
            this.ItemPhoto.Image = ((System.Drawing.Image)(resources.GetObject("ItemPhoto.Image")));
            this.ItemPhoto.Location = new System.Drawing.Point(0, 2);
            this.ItemPhoto.Name = "ItemPhoto";
            this.ItemPhoto.Size = new System.Drawing.Size(79, 55);
            this.ItemPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ItemPhoto.TabIndex = 6;
            this.ItemPhoto.TabStop = false;
            // 
            // TitleBox
            // 
            this.TitleBox.AutoSize = true;
            this.TitleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.TitleBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBox.ForeColor = System.Drawing.SystemColors.Control;
            this.TitleBox.Location = new System.Drawing.Point(85, 20);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(80, 20);
            this.TitleBox.TabIndex = 21;
            this.TitleBox.Text = "Username";
            // 
            // EmailBox
            // 
            this.EmailBox.AutoSize = true;
            this.EmailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.EmailBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.ForeColor = System.Drawing.SystemColors.Control;
            this.EmailBox.Location = new System.Drawing.Point(264, 20);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(80, 20);
            this.EmailBox.TabIndex = 22;
            this.EmailBox.Text = "Username";
            // 
            // DateBox
            // 
            this.DateBox.AutoSize = true;
            this.DateBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.DateBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateBox.ForeColor = System.Drawing.SystemColors.Control;
            this.DateBox.Location = new System.Drawing.Point(426, 20);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(80, 20);
            this.DateBox.TabIndex = 23;
            this.DateBox.Text = "Username";
            // 
            // AdminBox
            // 
            this.AdminBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.AdminBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminBox.ForeColor = System.Drawing.SystemColors.Control;
            this.AdminBox.Location = new System.Drawing.Point(786, 0);
            this.AdminBox.Name = "AdminBox";
            this.AdminBox.Size = new System.Drawing.Size(94, 57);
            this.AdminBox.TabIndex = 24;
            this.AdminBox.Text = "Username";
            this.AdminBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AdminBox.Click += new System.EventHandler(this.AdminBox_Click);
            // 
            // ViewUserBlock
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.AdminBox);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.ItemPhoto);
            this.Name = "ViewUserBlock";
            this.Size = new System.Drawing.Size(880, 60);
            this.Load += new System.EventHandler(this.ViewUserBlock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label ratinglabel;
        private System.Windows.Forms.PictureBox ItemPhoto;
        private System.Windows.Forms.Label TitleBox;
        private System.Windows.Forms.Label EmailBox;
        private System.Windows.Forms.Label DateBox;
        private System.Windows.Forms.Label AdminBox;
    }
}
