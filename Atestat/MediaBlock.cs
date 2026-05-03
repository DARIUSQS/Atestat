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
    public struct MediaInformation
    {
        public int Id;
        public string Title;
        public string Author;
        public string Description;
    };

    public partial class MediaBlock : UserControl
    {
        static bool isFormOpen = false;

        MediaInformation mediaInfo;

        public MediaBlock()
        {
            InitializeComponent();

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
                MediaDetails mediaForm = new MediaDetails();

                //mediaForm.Id = mediaInfo.Id;
                mediaForm.Title = mediaInfo.Title;
                mediaForm.Author = mediaInfo.Author;
                mediaForm.Description = mediaInfo.Description;

                mediaForm.Show();
                isFormOpen = true;
                mediaForm.FormClosed += (s, args) => isFormOpen = false;
            }
        }
    }
}
