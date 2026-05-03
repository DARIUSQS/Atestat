using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat
{
    public partial class MediaDetails : Form
    {
        public MediaDetails()
        {
            InitializeComponent();
            this.AutoScroll = true;
        }

        private void UNText_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MediaDetails_Load(object sender, EventArgs e)
        {

        }

        public string Title
        {
            get { return UNText.Text; }
            set { UNText.Text = value; }
        }

        public string Author
        {
            get { return AuthorLabel.Text; }
            set { AuthorLabel.Text = value; }
        }

        public string Description
        {
            get { return DescriptionLabel.Text; }
            set { DescriptionLabel.Text = value; }
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            string review = ReviewBox.Text;

            var adapter = new atestatDataSetTableAdapters.ReviewTableAdapter();
            adapter.InsertReview(review, DateTime.Now.ToString(), Login.CurrentUser.Id, 1); 

        }
    }
}
