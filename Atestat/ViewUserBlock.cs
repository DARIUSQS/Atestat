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
    public partial class ViewUserBlock : UserControl
    {
        bool admin_status = false;
        User m_UserInfo;
        public ViewUserBlock(User UserInfo)
        {
            InitializeComponent();

            m_UserInfo = UserInfo;
            TitleBox.Text = UserInfo.Username;
            EmailBox.Text = UserInfo.Email;
            DateBox.Text = UserInfo.Date;

            if(UserInfo.Admin == 1)
            {
                AdminBox.Text = "Admin";
                admin_status = true;
            }
            else
            {
                AdminBox.Text = "User";
                admin_status = false;
            }

        }

        private void ViewUserBlock_Load(object sender, EventArgs e)
        {

        }

        private void TitleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void AdminBox_Click(object sender, EventArgs e)
        {
            if (admin_status == true)
            {
                Adapters.UserData.UpdateAdminStatus(0, m_UserInfo.Id);
                AdminBox.Text = "User";
            }
            else
            {
                 Adapters.UserData.UpdateAdminStatus(1, m_UserInfo.Id);
                 AdminBox.Text = "Admin";
            }
            admin_status = !admin_status;
        }
    }
}
