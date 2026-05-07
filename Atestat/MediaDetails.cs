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
        MediaInformation medInf;
        public MediaDetails(MediaInformation mediaInformation)
        {
            medInf = mediaInformation;
            Init();
        }

        void Init()
        {
            this.Controls.Clear();
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.AutoScroll = true;
            this.VerticalScroll.Visible = false;

            TitleLabel.Text = medInf.Title;
            AuthorLabel.Text = medInf.Author;
            DescriptionLabel.Text = medInf.Description;

            var adapter = new atestatDataSetTableAdapters.ReviewTableAdapter();
            var table = adapter.GetDataByMedia(medInf.Id);

            foreach (var row in table)
            {
                ReviewInformation ReviewDataInfo = new ReviewInformation
                {
                    Id = row.ReviewId,
                    Title = row.ReviewTitle,
                    Author = row.name,
                    Text = row.text,
                    Date = row.ReviewDate.ToString("yyyy-MM-dd HH:mm:ss"),
                    UserId = row.UserId,
                    ItemId = row.ItemId
                };
                var card = new ReviewData(ReviewDataInfo, Init);
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
            adapter.InsertData(review, DateTime.Now.ToString(), Login.CurrentUser.Id, medInf.Id, title);
            //MessageBox.Show("Media " + mediaInformation.Id + "; User: " + Login.CurrentUser.Id);
            Init();
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
