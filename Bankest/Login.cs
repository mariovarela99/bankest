using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankest
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void OpenHome(object sender, FormClosingEventArgs e)
        {
            Home_Page Home = new Home_Page();
            Home.Show();
        }
    }
}
