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
    public partial class ReviewDataMediaInfo : UserControl
    {
        ReviewInformation reviewData;
        Action act;
        bool EditStatus = false;
        public ReviewDataMediaInfo(ReviewInformation reviewData, Action Init)
        {
            InitializeComponent();
            DescriptionLabel.ReadOnly = true;
            this.reviewData = reviewData;
            act = Init;

            DescriptionLabel.ReadOnly = true;
            TitleBox.ReadOnly = true;
        }
        private void ReviewData_Load(object sender, EventArgs e)
        {
            TitleBox.Text = reviewData.Title;
            DescriptionLabel.Text = reviewData.Text;
            UsernameLabel.Text = reviewData.Author;
            MediaLabel.Text = reviewData.MediaTitle;
        }

        private void DescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void TitleBox_Click(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var adapter = new atestatDataSetTableAdapters.ReviewTableAdapter();
            adapter.DeleteQuery(reviewData.Id);
            //MessageBox.Show("Review Deleted: " + reviewData.Id, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            act();
        }

        private void EditButton_Click_1(object sender, EventArgs e)
        {
            if (EditStatus)
            {
                EditButton.Text = "Edit";
                Adapters.ReviewData.UpdateQuery(TitleBox.Text, DescriptionLabel.Text, reviewData.Id);
                DescriptionLabel.ReadOnly = true;
                TitleBox.ReadOnly = true;
                DescriptionLabel.BorderStyle = BorderStyle.None;
                TitleBox.BorderStyle = BorderStyle.None;
            }
            else
            {
                EditButton.Text = "Save";
                DescriptionLabel.ReadOnly = false;
                TitleBox.ReadOnly = false;
                DescriptionLabel.BorderStyle = BorderStyle.FixedSingle;
                TitleBox.BorderStyle = BorderStyle.FixedSingle;
            }
            EditStatus = !EditStatus;
        }
    }
}
