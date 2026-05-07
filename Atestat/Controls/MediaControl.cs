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
    public partial class MediaControl : UserControl
    {
        bool isExpanded = false;
        int targetHeight = 150;
        public MediaControl()
        {
            InitializeComponent();

            panel1.Height = 30;

            flowLayoutPanel1.AutoScroll = true;

            var adapter = new atestatDataSetTableAdapters.ItemsTableAdapter();
            var table = adapter.GetData();

            foreach (var row in table)
            {
                var card = new MediaBlock();
                card.MediaInfo = new MediaInformation
                {
                    Id = row.Id,
                    Title = row.title,
                    Author = row.author,
                    Description = row.description
                };
                card.Title = row.title;
                if (row.category_id == 1) card.Image = ProgramManager.m_BookImage;
                else if(row.category_id == 2) card.Image = ProgramManager.m_SeriesImage;
                else card.Image = ProgramManager.m_MovieImage;
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (!isExpanded)
            {
                panel1.Height += 10;

                if (panel1.Height >= targetHeight)
                {
                    timer1.Stop();
                    isExpanded = true;
                }
            }
            else
            {
                panel1.Height -= 10;

                if (panel1.Height <= 30)
                {
                    timer1.Stop();
                    isExpanded = false;
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
