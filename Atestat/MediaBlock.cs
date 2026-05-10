using Atestat.Controls;
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


    public partial class MediaBlock : UserControl
    {
        static bool isFormOpen = false;

        MediaInformation mediaInfo;
        MediaControl mediaControl;
        public MediaBlock(MediaControl mc)
        {
            InitializeComponent();

            mediaControl = mc;
            viewButton.FlatStyle = FlatStyle.Flat;
            viewButton.FlatAppearance.BorderSize = 0;
        }

        private void MediaBlock_Load(object sender, EventArgs e)
        {

        }
        public MediaInformation MediaInfo
        {
            get { return mediaInfo; }
            set { mediaInfo = value; }
        }
        public string Title
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public string Date
        {
            get { return datelabel.Text; }
            set { datelabel.Text = value; }
        }

        public string Rating
        {
            get { return ratinglabel.Text; }
            set { ratinglabel.Text = value; }
        }

        public int Id
        {
            get { return mediaInfo.Id; }
            set { mediaInfo.Id = value; }
        }

        public Image Image
        {
            set { pictureBox2.Image = value; }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            if (!isFormOpen)
            {
                MediaDetails mediaForm = new MediaDetails(mediaInfo);

                mediaForm.Show();
                isFormOpen = true;
                mediaForm.FormClosed += (s, args) =>
                {
                    isFormOpen = false;
                    double ratingtable = Convert.ToDouble(Adapters.RatingsData.GetAverageRating(mediaInfo.Id));
                    ratinglabel.Text = ratingtable.ToString();
                };
            }
        }
    }
}
