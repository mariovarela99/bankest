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
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login LoginForm = new Login();
            LoginForm.Show();
            this.Hide();
        }

        private void Home_Page_Load(object sender, EventArgs e)
        {

        }

        private void linkCadastrar_Click(object sender, EventArgs e)
        {
            Create_Account CadastrarForm = new Create_Account();
            CadastrarForm.Show();
            this.Hide();
        }
    }
}
