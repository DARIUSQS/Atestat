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
        MediaInformation mediaInformation;
        public MediaDetails(MediaInformation mediaInformation)
        {
            Init(mediaInformation);
        }

        void Init(MediaInformation mediaInformation)
        {
            InitializeComponent();
            this.AutoScroll = true;
            this.mediaInformation = mediaInformation;

            TitleLabel.Text = mediaInformation.Title;
            AuthorLabel.Text = mediaInformation.Author;
            DescriptionLabel.Text = mediaInformation.Description;

            var adapter = new atestatDataSetTableAdapters.ReviewTableAdapter();
            var table = adapter.GetDataByMedia(mediaInformation.Id);

            foreach (var row in table)
            {
                var card = new ReviewData();
                card.ReviewDataInfo = new ReviewInformation
                {
                    Id = row.ItemId,
                    Title = row.ReviewTitle,
                    Author = row.name,
                    Text = row.text,
                    Date = row.ReviewDate.ToString("yyyy-MM-dd HH:mm:ss"),
                    UserId = row.UserId,
                    ItemId = row.ItemId
                };
                flowLayoutPanel1.Controls.Add(card);
            }
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

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            string review = ReviewBox.Text;
            string title = richTextBox1.Text;

            var adapter = new atestatDataSetTableAdapters.ReviewTableAdapter();
            adapter.InsertData(review, DateTime.Now.ToString(), Login.CurrentUser.Id, mediaInformation.Id, title);
            //MessageBox.Show("Media " + mediaInformation.Id + "; User: " + Login.CurrentUser.Id);
            this.Controls.Clear();
            Init(mediaInformation);
        }

        private void DescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void ReviewBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
