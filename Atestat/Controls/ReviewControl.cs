using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat.Controls
{
    public partial class ReviewControl : UserControl
    {
        public ReviewControl()
        {
            InitializeComponent();

            flowLayoutPanel1.AutoScroll = true;

            var adapter = new atestatDataSetTableAdapters.ReviewTableAdapter();
            var table = adapter.GetDataByUserReviews(Login.CurrentUser.Id);

            foreach (var row in table)
            {
                MediaInformation MediaInfo = new MediaInformation
                {
                    Id = row.ItemId,
                    Title = row.title,
                    Author = row.author,
                    Description = row.description
                };

                ReviewInformation ReviewInfo = new ReviewInformation
                {
                    Id = row.ReviewId,
                    Title = row.ReviewTitle,
                    MediaTitle = row.title,
                    Author = row.name,
                    Text = row.text,
                    Date = row.ReviewDate.ToString("yyyy-MM-dd HH:mm:ss"),
                    UserId = row.UserId,
                    ItemId = row.ItemId
                };

                var card = new ReviewDataMediaInfo(ReviewInfo, Init);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void Init()
        {

        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
