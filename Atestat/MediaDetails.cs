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

            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.MaximizeBox = false;

            this.AutoScroll = true;

            TitleLabel.Text = medInf.Title;
            AuthorLabel.Text = "Author: " + medInf.Author;
            datelabel.Text = "Release Date: " + medInf.Date;
            DescriptionLabel.Text = medInf.Description;
            if(string.IsNullOrWhiteSpace(medInf.ImagePath) == false) ItemPhoto.Image = Image.FromFile(medInf.ImagePath);

            var table = Adapters.ReviewData.GetDataByMedia(medInf.Id);
            int status = (int)Adapters.RatingsData.IsRated(Login.CurrentUser.Id, medInf.Id);

            if (status == 0)
            {
                Adapters.RatingsData.InsertQuery(0, Login.CurrentUser.Id, medInf.Id);
            }

            int rating = (int)Adapters.RatingsData.GetSpecificRating(Login.CurrentUser.Id, medInf.Id);
            if(rating == 1) pictureBox1_Click(null, null);
            else if (rating == 2) pictureBox3_Click(null, null);
            else if (rating == 3) pictureBox4_Click(null, null);
            else if (rating == 4) pictureBox5_Click(null, null);
            else if (rating == 5) pictureBox6_Click(null, null);

            foreach (var row in table)
            {
                ReviewInformation ReviewDataInfo = new ReviewInformation
                {
                    Id = row.ReviewId,
                    MediaTitle = row.title,
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ProgramManager.m_FullStar;
            pictureBox2.Image = ProgramManager.m_EmptyStar;
            pictureBox3.Image = ProgramManager.m_EmptyStar;
            pictureBox4.Image = ProgramManager.m_EmptyStar;
            pictureBox5.Image = ProgramManager.m_EmptyStar;

            Adapters.RatingsData.UpdateQuery(1, Login.CurrentUser.Id, medInf.Id);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ProgramManager.m_FullStar;
            pictureBox2.Image = ProgramManager.m_FullStar;
            pictureBox3.Image = ProgramManager.m_EmptyStar;
            pictureBox4.Image = ProgramManager.m_EmptyStar;
            pictureBox5.Image = ProgramManager.m_EmptyStar;

            Adapters.RatingsData.UpdateQuery(2, Login.CurrentUser.Id, medInf.Id);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ProgramManager.m_FullStar;
            pictureBox2.Image = ProgramManager.m_FullStar;
            pictureBox3.Image = ProgramManager.m_FullStar;
            pictureBox4.Image = ProgramManager.m_EmptyStar;
            pictureBox5.Image = ProgramManager.m_EmptyStar;

            Adapters.RatingsData.UpdateQuery(3, Login.CurrentUser.Id, medInf.Id);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ProgramManager.m_FullStar;
            pictureBox2.Image = ProgramManager.m_FullStar;
            pictureBox3.Image = ProgramManager.m_FullStar;
            pictureBox4.Image = ProgramManager.m_FullStar;
            pictureBox5.Image = ProgramManager.m_EmptyStar;

            Adapters.RatingsData.UpdateQuery(4, Login.CurrentUser.Id, medInf.Id);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ProgramManager.m_FullStar;
            pictureBox2.Image = ProgramManager.m_FullStar;
            pictureBox3.Image = ProgramManager.m_FullStar;
            pictureBox4.Image = ProgramManager.m_FullStar;
            pictureBox5.Image = ProgramManager.m_FullStar;

            Adapters.RatingsData.UpdateQuery(5, Login.CurrentUser.Id, medInf.Id);
        }

        private void MediaDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
