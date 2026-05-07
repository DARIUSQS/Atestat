using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat
{
    internal static class Core
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
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
    }

    public struct User
    {
        public int Id;
        public string Username;
        public string Password;
    };

    public struct MediaInformation
    {
        public int Id;
        public string Title;
        public string Author;
        public string Description;
    };

    public struct ReviewInformation
    {
        public int Id;
        public string Title;
        public string Author;
        public string Text;
        public string Date;
        public int UserId;
        public int ItemId;
    };
}
