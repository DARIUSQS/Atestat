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
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            mediaButton.FlatStyle = FlatStyle.Flat;
            mediaButton.FlatAppearance.BorderSize = 0;

            var card = new MediaBlock();
            flowLayoutPanel1.Controls.Add(card);
        }
    }
}
