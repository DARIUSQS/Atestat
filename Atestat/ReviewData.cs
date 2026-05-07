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
    public partial class ReviewData : UserControl
    {
        ReviewInformation reviewData;
        Action act;
        public ReviewData(ReviewInformation reviewData, Action Init)
        {
            InitializeComponent();
            this.reviewData = reviewData;
            act = Init;
            if(Login.CurrentUser.Admin == 0)
            {
                RemoveButton.Visible = false;
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
            var adapter = new atestatDataSetTableAdapters.ReviewTableAdapter();
            adapter.DeleteQuery(reviewData.Id);
            //MessageBox.Show("Review Deleted: " + reviewData.Id, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            act();
        }
    }
}
