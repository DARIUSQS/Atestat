using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat
{
    public partial class ReviewData : UserControl
    {
        ReviewInformation reviewData;
        Action act;
        bool EditStatus = false;

        public ReviewData(ReviewInformation reviewData, Action Init)
        {
            InitializeComponent();

            DescriptionLabel.ReadOnly = true;
            TitleBox.ReadOnly = true;
            this.reviewData = reviewData;
            act = Init;
            RemoveButton.Visible = false;
            EditButton.Visible = false;

            if (Login.CurrentUser.Admin == 1)
            {
                RemoveButton.Visible = true;
            }
            if (reviewData.UserId == Login.CurrentUser.Id)
            {
                EditButton.Visible = true;
                RemoveButton.Visible = true;
            }
        }
        private void ReviewData_Load(object sender, EventArgs e)
        {
            TitleBox.Text = reviewData.Title;
            DescriptionLabel.Text = reviewData.Text;
            UsernameLabel.Text = reviewData.Author;
        }

        private void DescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void TitleBox_Click(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Adapters.ReviewData.DeleteQuery(reviewData.Id);
            //MessageBox.Show("Review Deleted: " + reviewData.Id, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            act();
        }

        private void DescriptionLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
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

        private void TitleBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
