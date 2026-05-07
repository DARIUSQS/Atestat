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
        public ReviewData()
        {
            InitializeComponent();
        }

        public ReviewInformation ReviewDataInfo
        {
            get { return reviewData; }
            set { reviewData = value; }
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

        }
    }
}
