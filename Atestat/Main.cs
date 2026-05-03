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
    public partial class Main : Form
    {

        enum PanelType
        {
            Media,
            Review,
            None
        }

        static PanelType panelType = PanelType.None;

        PanelType UserControlToType(UserControl control)
        {
            if (control is MediaControl)
                return PanelType.Media;
            else if (control is ReviewControl)
                return PanelType.Review;
            else
                throw new ArgumentException("Unknown control type");
        }

        void SwitchPanel(UserControl control)
        {
            if (panelType != UserControlToType(control))
            {
                mainPanel.Controls.Clear();
                control.Size = new Size(mainPanel.Width, mainPanel.Height);
                mainPanel.Controls.Add(control);
                panelType = UserControlToType(control);
            }
        }
        public Main()
        {
            InitializeComponent();

            /// Buttons
            mediaButton.FlatStyle = FlatStyle.Flat;
            mediaButton.FlatAppearance.BorderSize = 0;
            reviewButton.FlatStyle = FlatStyle.Flat;
            reviewButton.FlatAppearance.BorderSize = 0;
            LogOutButton.FlatStyle = FlatStyle.Flat;
            LogOutButton.FlatAppearance.BorderSize = 0;

            UsernameLabel.Text = Login.CurrentUser.Username;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            SwitchPanel(new MediaControl());
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reviewButton_Click(object sender, EventArgs e)
        {
            SwitchPanel(new ReviewControl());
        }

        private void mediaButton_Click(object sender, EventArgs e)
        {
            SwitchPanel(new MediaControl());
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            login.Show();
            this.Close();
            panelType = PanelType.None;
        }
    }
}
