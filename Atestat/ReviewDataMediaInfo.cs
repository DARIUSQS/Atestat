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
        public ReviewDataMediaInfo(ReviewInformation reviewInfo, MediaInformation mediaInfo)
        {
            InitializeComponent();
            TitleBox.Text = reviewInfo.Title;
            DescriptionLabel.Text = reviewInfo.Text;
            UsernameLabel.Text = Login.CurrentUser.Username;

            MediaLabel.Text = mediaInfo.Title;
        }

        private void ReviewData_Load(object sender, EventArgs e)
        {
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
