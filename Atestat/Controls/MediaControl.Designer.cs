namespace Atestat.Controls
{
    partial class MediaControl
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SortCategoryMovie = new System.Windows.Forms.Button();
            this.SortCategoryTV = new System.Windows.Forms.Button();
            this.SortCategoryBook = new System.Windows.Forms.Button();
            this.SortCategoryLabel = new System.Windows.Forms.Label();
            this.SortAuthorDESC = new System.Windows.Forms.Button();
            this.SortAuthorASC = new System.Windows.Forms.Button();
            this.SortAuthorLabel = new System.Windows.Forms.Label();
            this.SortTitleDESC = new System.Windows.Forms.Button();
            this.SortTitleASC = new System.Windows.Forms.Button();
            this.SortTitleLabel = new System.Windows.Forms.Label();
            this.SortDateDESC = new System.Windows.Forms.Button();
            this.SortDateASC = new System.Windows.Forms.Button();
            this.UIdate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 160);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(906, 320);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.SortCategoryMovie);
            this.panel1.Controls.Add(this.SortCategoryTV);
            this.panel1.Controls.Add(this.SortCategoryBook);
            this.panel1.Controls.Add(this.SortCategoryLabel);
            this.panel1.Controls.Add(this.SortAuthorDESC);
            this.panel1.Controls.Add(this.SortAuthorASC);
            this.panel1.Controls.Add(this.SortAuthorLabel);
            this.panel1.Controls.Add(this.SortTitleDESC);
            this.panel1.Controls.Add(this.SortTitleASC);
            this.panel1.Controls.Add(this.SortTitleLabel);
            this.panel1.Controls.Add(this.SortDateDESC);
            this.panel1.Controls.Add(this.SortDateASC);
            this.panel1.Controls.Add(this.UIdate);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 160);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SortCategoryMovie
            // 
            this.SortCategoryMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.SortCategoryMovie.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.SortCategoryMovie.ForeColor = System.Drawing.SystemColors.Control;
            this.SortCategoryMovie.Location = new System.Drawing.Point(543, 117);
            this.SortCategoryMovie.Name = "SortCategoryMovie";
            this.SortCategoryMovie.Size = new System.Drawing.Size(122, 34);
            this.SortCategoryMovie.TabIndex = 13;
            this.SortCategoryMovie.Text = "Movies";
            this.SortCategoryMovie.UseVisualStyleBackColor = false;
            this.SortCategoryMovie.Click += new System.EventHandler(this.SortCategoryMovie_Click);
            // 
            // SortCategoryTV
            // 
            this.SortCategoryTV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.SortCategoryTV.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.SortCategoryTV.ForeColor = System.Drawing.SystemColors.Control;
            this.SortCategoryTV.Location = new System.Drawing.Point(543, 85);
            this.SortCategoryTV.Name = "SortCategoryTV";
            this.SortCategoryTV.Size = new System.Drawing.Size(122, 34);
            this.SortCategoryTV.TabIndex = 12;
            this.SortCategoryTV.Text = "Tv Shows";
            this.SortCategoryTV.UseVisualStyleBackColor = false;
            this.SortCategoryTV.Click += new System.EventHandler(this.SortCategoryTV_Click);
            // 
            // SortCategoryBook
            // 
            this.SortCategoryBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.SortCategoryBook.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.SortCategoryBook.ForeColor = System.Drawing.SystemColors.Control;
            this.SortCategoryBook.Location = new System.Drawing.Point(543, 55);
            this.SortCategoryBook.Name = "SortCategoryBook";
            this.SortCategoryBook.Size = new System.Drawing.Size(122, 34);
            this.SortCategoryBook.TabIndex = 11;
            this.SortCategoryBook.Text = "Books";
            this.SortCategoryBook.UseVisualStyleBackColor = false;
            this.SortCategoryBook.Click += new System.EventHandler(this.SortCategoryBook_Click);
            // 
            // SortCategoryLabel
            // 
            this.SortCategoryLabel.AutoSize = true;
            this.SortCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.SortCategoryLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.SortCategoryLabel.Location = new System.Drawing.Point(561, 31);
            this.SortCategoryLabel.Name = "SortCategoryLabel";
            this.SortCategoryLabel.Size = new System.Drawing.Size(81, 20);
            this.SortCategoryLabel.TabIndex = 10;
            this.SortCategoryLabel.Text = "Category";
            // 
            // SortAuthorDESC
            // 
            this.SortAuthorDESC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.SortAuthorDESC.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.SortAuthorDESC.ForeColor = System.Drawing.SystemColors.Control;
            this.SortAuthorDESC.Location = new System.Drawing.Point(415, 85);
            this.SortAuthorDESC.Name = "SortAuthorDESC";
            this.SortAuthorDESC.Size = new System.Drawing.Size(122, 34);
            this.SortAuthorDESC.TabIndex = 9;
            this.SortAuthorDESC.Text = "Descending";
            this.SortAuthorDESC.UseVisualStyleBackColor = false;
            this.SortAuthorDESC.Click += new System.EventHandler(this.SortAuthorDESC_Click);
            // 
            // SortAuthorASC
            // 
            this.SortAuthorASC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.SortAuthorASC.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.SortAuthorASC.ForeColor = System.Drawing.SystemColors.Control;
            this.SortAuthorASC.Location = new System.Drawing.Point(415, 55);
            this.SortAuthorASC.Name = "SortAuthorASC";
            this.SortAuthorASC.Size = new System.Drawing.Size(122, 34);
            this.SortAuthorASC.TabIndex = 8;
            this.SortAuthorASC.Text = "Ascending";
            this.SortAuthorASC.UseVisualStyleBackColor = false;
            this.SortAuthorASC.Click += new System.EventHandler(this.SortAuthorASC_Click);
            // 
            // SortAuthorLabel
            // 
            this.SortAuthorLabel.AutoSize = true;
            this.SortAuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.SortAuthorLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.SortAuthorLabel.Location = new System.Drawing.Point(443, 31);
            this.SortAuthorLabel.Name = "SortAuthorLabel";
            this.SortAuthorLabel.Size = new System.Drawing.Size(63, 20);
            this.SortAuthorLabel.TabIndex = 7;
            this.SortAuthorLabel.Text = "Author";
            // 
            // SortTitleDESC
            // 
            this.SortTitleDESC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.SortTitleDESC.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.SortTitleDESC.ForeColor = System.Drawing.SystemColors.Control;
            this.SortTitleDESC.Location = new System.Drawing.Point(287, 85);
            this.SortTitleDESC.Name = "SortTitleDESC";
            this.SortTitleDESC.Size = new System.Drawing.Size(122, 34);
            this.SortTitleDESC.TabIndex = 6;
            this.SortTitleDESC.Text = "Descending";
            this.SortTitleDESC.UseVisualStyleBackColor = false;
            this.SortTitleDESC.Click += new System.EventHandler(this.SortTitleDESC_Click);
            // 
            // SortTitleASC
            // 
            this.SortTitleASC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.SortTitleASC.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.SortTitleASC.ForeColor = System.Drawing.SystemColors.Control;
            this.SortTitleASC.Location = new System.Drawing.Point(287, 55);
            this.SortTitleASC.Name = "SortTitleASC";
            this.SortTitleASC.Size = new System.Drawing.Size(122, 34);
            this.SortTitleASC.TabIndex = 5;
            this.SortTitleASC.Text = "Ascending";
            this.SortTitleASC.UseVisualStyleBackColor = false;
            this.SortTitleASC.Click += new System.EventHandler(this.SortTitleASC_Click);
            // 
            // SortTitleLabel
            // 
            this.SortTitleLabel.AutoSize = true;
            this.SortTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.SortTitleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.SortTitleLabel.Location = new System.Drawing.Point(326, 31);
            this.SortTitleLabel.Name = "SortTitleLabel";
            this.SortTitleLabel.Size = new System.Drawing.Size(43, 20);
            this.SortTitleLabel.TabIndex = 4;
            this.SortTitleLabel.Text = "Title";
            // 
            // SortDateDESC
            // 
            this.SortDateDESC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.SortDateDESC.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.SortDateDESC.ForeColor = System.Drawing.SystemColors.Control;
            this.SortDateDESC.Location = new System.Drawing.Point(159, 85);
            this.SortDateDESC.Name = "SortDateDESC";
            this.SortDateDESC.Size = new System.Drawing.Size(122, 34);
            this.SortDateDESC.TabIndex = 3;
            this.SortDateDESC.Text = "Descending";
            this.SortDateDESC.UseVisualStyleBackColor = false;
            this.SortDateDESC.Click += new System.EventHandler(this.SortDateDESC_Click);
            // 
            // SortDateASC
            // 
            this.SortDateASC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.SortDateASC.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.SortDateASC.ForeColor = System.Drawing.SystemColors.Control;
            this.SortDateASC.Location = new System.Drawing.Point(159, 55);
            this.SortDateASC.Name = "SortDateASC";
            this.SortDateASC.Size = new System.Drawing.Size(122, 34);
            this.SortDateASC.TabIndex = 2;
            this.SortDateASC.Text = "Ascending";
            this.SortDateASC.UseVisualStyleBackColor = false;
            this.SortDateASC.Click += new System.EventHandler(this.SortDateASC_Click);
            // 
            // UIdate
            // 
            this.UIdate.AutoSize = true;
            this.UIdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.UIdate.ForeColor = System.Drawing.SystemColors.Control;
            this.UIdate.Location = new System.Drawing.Point(198, 31);
            this.UIdate.Name = "UIdate";
            this.UIdate.Size = new System.Drawing.Size(48, 20);
            this.UIdate.TabIndex = 1;
            this.UIdate.Text = "Date";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(738, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // MediaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "MediaControl";
            this.Size = new System.Drawing.Size(906, 480);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label UIdate;
        private System.Windows.Forms.Button SortAuthorDESC;
        private System.Windows.Forms.Button SortAuthorASC;
        private System.Windows.Forms.Label SortAuthorLabel;
        private System.Windows.Forms.Button SortTitleDESC;
        private System.Windows.Forms.Button SortTitleASC;
        private System.Windows.Forms.Label SortTitleLabel;
        private System.Windows.Forms.Button SortDateDESC;
        private System.Windows.Forms.Button SortDateASC;
        private System.Windows.Forms.Button SortCategoryMovie;
        private System.Windows.Forms.Button SortCategoryTV;
        private System.Windows.Forms.Button SortCategoryBook;
        private System.Windows.Forms.Label SortCategoryLabel;
    }
}
