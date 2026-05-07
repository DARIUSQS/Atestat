using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Atestat
{
    
    
    public partial class Login : Form
    { 
        public static User CurrentUser;
        public Login()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.FlatAppearance.BorderSize = 0;
        }

        private void loginText_Click(object sender, EventArgs e)
        {

        }

        private void signInLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignIn signIn = new SignIn();

            signIn.Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UNBox.Text;
            string password = PWBox.Text;

            if (string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var adapter = new atestatDataSetTableAdapters.UserTableAdapter();
                int result = (int)adapter.CheckLogin(username, password);

                var userData = adapter.GetDataByNameAndPassword(username, password);

                if (result == 1)
                {
                    CurrentUser.Id = userData[0].Id;
                    CurrentUser.Username = userData[0].name;
                    CurrentUser.Password = userData[0].password;
                    CurrentUser.Admin = userData[0].admin;

                    Main MainForm = new Main();
                    MainForm.Show();
                    this.Hide();

                    return;
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while signing in: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
    }
}
