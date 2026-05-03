using Atestat.atestatDataSetTableAdapters;
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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();

            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.FlatAppearance.BorderSize = 0;
        }

        private void loginLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Location = this.Location; 

            login.Show();
            this.Close();
        }

        private void loginText_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UNBox.Text;
            string email = EmailBox.Text;
            string password = PWBox.Text;
            string bday = DateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");

            if (string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var adapter = new atestatDataSetTableAdapters.UserTableAdapter();
                adapter.AddUser(username, email, bday, password);
                MessageBox.Show("User Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch( Exception ex)
            {
                MessageBox.Show("An error occurred while signing in: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void UNText_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Location = this.Location;

            login.Show();
            this.Close();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
