using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Atestat.Controls
{
    public partial class MediaControl : UserControl
    {
        enum CategoryInfo
        {
            Books = 1, TV_Series = 2, Movies = 3, None = 0
        }
        static CategoryInfo currentCategory = CategoryInfo.None;

        bool isExpanded = false;
        int targetHeight = 160;

        Action mediaAction;

        atestatDataSet.ItemsDataTable table = Adapters.ItemsData.GetData();
        public MediaControl()
        {
            InitializeComponent();

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            SortAuthorASC.FlatStyle = FlatStyle.Flat;
            SortAuthorASC.FlatAppearance.BorderSize = 0;
            SortAuthorDESC.FlatStyle = FlatStyle.Flat;
            SortAuthorDESC.FlatAppearance.BorderSize = 0;
            SortDateASC.FlatStyle = FlatStyle.Flat;
            SortDateASC.FlatAppearance.BorderSize = 0;
            SortDateDESC.FlatStyle = FlatStyle.Flat;
            SortDateDESC.FlatAppearance.BorderSize= 0;
            SortTitleASC.FlatStyle = FlatStyle.Flat;
            SortTitleASC.FlatAppearance.BorderSize = 0;
            SortTitleDESC.FlatStyle = FlatStyle.Flat;
            SortTitleDESC.FlatAppearance.BorderSize = 0;
            SortCategoryBook.FlatStyle = FlatStyle.Flat;
            SortCategoryBook.FlatAppearance.BorderSize = 0;
            SortCategoryTV.FlatStyle = FlatStyle.Flat;
            SortCategoryTV.FlatAppearance.BorderSize = 0;
            SortCategoryMovie.FlatStyle = FlatStyle.Flat;
            SortCategoryMovie.FlatAppearance.BorderSize = 0;

            panel1.Height = 30;
            flowLayoutPanel1.AutoScroll = true;

            LoadMedia();
        }

        private void LoadMedia()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (DataRowView rowView in table.DefaultView)
            {
                if (currentCategory == CategoryInfo.None || (int)rowView["category_id"] == (int)currentCategory)
                {
                    var row = (atestatDataSet.ItemsRow)rowView.Row;
                    var card = new MediaBlock(this);
                    card.MediaInfo = new MediaInformation
                    {
                        Id = row.Id,
                        Title = row.title,
                        Author = row.author,
                        Description = row.description,
                        Date = row.date.ToString("yyyy-MM-dd"),
                    };
                    card.Title = row.title;
                    card.Date = row.date.ToString("yyyy-MM-dd");

                    ///Rating 
                    double ratingtable = Convert.ToDouble(Adapters.RatingsData.GetAverageRating(row.Id));
                    card.Rating = ratingtable.ToString();


                    if (row.category_id == 1) card.Image = ProgramManager.m_BookImage;
                    else if (row.category_id == 2) card.Image = ProgramManager.m_SeriesImage;
                    else card.Image = ProgramManager.m_MovieImage;
                    flowLayoutPanel1.Controls.Add(card);
                }
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

        private void SortDateASC_Click(object sender, EventArgs e)
        {
            currentCategory = CategoryInfo.None;
            table.DefaultView.Sort = "date ASC";
            LoadMedia();
        }

        private void SortDateDESC_Click(object sender, EventArgs e)
        {
            currentCategory = CategoryInfo.None;
            table.DefaultView.Sort = "date DESC";
            LoadMedia();
        }

        private void SortTitleASC_Click(object sender, EventArgs e)
        {
            currentCategory = CategoryInfo.None;
            table.DefaultView.Sort = "title ASC";
            LoadMedia();
        }

        private void SortTitleDESC_Click(object sender, EventArgs e)
        {
            currentCategory = CategoryInfo.None;
            table.DefaultView.Sort = "title DESC";
            LoadMedia();
        }

        private void SortAuthorASC_Click(object sender, EventArgs e)
        {
            currentCategory = CategoryInfo.None;
            table.DefaultView.Sort = "author ASC";
            LoadMedia();
        }

        private void SortAuthorDESC_Click(object sender, EventArgs e)
        {
            currentCategory = CategoryInfo.None;
            table.DefaultView.Sort = "author DESC";
            LoadMedia();
        }

        private void SortCategoryBook_Click(object sender, EventArgs e)
        {
            currentCategory = CategoryInfo.Books;
            LoadMedia();
        }

        private void SortCategoryTV_Click(object sender, EventArgs e)
        {
            currentCategory = CategoryInfo.TV_Series;
            LoadMedia();
        }

        private void SortCategoryMovie_Click(object sender, EventArgs e)
        {
            currentCategory = CategoryInfo.Movies;
            LoadMedia();
        }
    }
}
