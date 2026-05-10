using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Forms;

namespace Atestat
{
    internal static class Core
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }

    class ProgramManager
    {
        public static Image m_MovieImage = Image.FromFile("../../Assets/movieicon.png");
        public static Image m_BookImage = Image.FromFile("../../Assets/bookicon.png");
        public static Image m_SeriesImage = Image.FromFile("../../Assets/tvshowicon.png");
        public static Image m_EmptyStar = Image.FromFile("../../Assets/StarEmpty.png");
        public static Image m_FullStar = Image.FromFile("../../Assets/StarFull.png");
    }

    class Adapters
    {
        public static atestatDataSetTableAdapters.ReviewTableAdapter ReviewData = new atestatDataSetTableAdapters.ReviewTableAdapter();
        public static atestatDataSetTableAdapters.ItemsTableAdapter ItemsData = new atestatDataSetTableAdapters.ItemsTableAdapter();
        public static atestatDataSetTableAdapters.UserTableAdapter UserData = new atestatDataSetTableAdapters.UserTableAdapter();
        public static atestatDataSetTableAdapters.CategoriesTableAdapter CategoriesData = new atestatDataSetTableAdapters.CategoriesTableAdapter();
        public static atestatDataSetTableAdapters.RatingsTableAdapter RatingsData = new atestatDataSetTableAdapters.RatingsTableAdapter();
    }

    public struct User
    {
        public int Id;
        public string Username;
        public string Password;
        public string Email;
        public string Date;
        public int Admin;
    };

    public struct MediaInformation
    {
        public int Id;
        public string Title;
        public string Author;
        public string Description;
        public string Date;
    };

    public struct ReviewInformation
    {
        public int Id;
        public string Title;
        public string MediaTitle;
        public string Author;
        public string Text;
        public string Date;
        public int UserId;
        public int ItemId;
    };
}
