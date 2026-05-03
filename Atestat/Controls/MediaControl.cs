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
        public MediaControl()
        {
            InitializeComponent();

            flowLayoutPanel1.AutoScroll = true;

            var adapter = new atestatDataSetTableAdapters.ItemsTableAdapter();
            var table = adapter.GetData();

            foreach (var row in table)
            {
                var card = new MediaBlock();
                card.MediaInfo = new MediaInformation
                {
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
