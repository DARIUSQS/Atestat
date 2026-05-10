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
    public partial class ViewUserControl : UserControl
    {
        public ViewUserControl()
        {
            InitializeComponent();

            flowLayoutPanel1.AutoScroll = true;

            var table = Adapters.UserData.GetData();

            foreach (var row in table)
            {
                User userInfo = new User
                {
                    Id = row.Id,
                    Username = row.name,
                    Password = row.password,
                    Email = row.email,
                    Date = row.age.ToString("yyyy-MM-dd"),
                    Admin = row.admin
                };

                var card = new ViewUserBlock(userInfo);
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
