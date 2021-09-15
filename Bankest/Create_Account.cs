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
    public partial class Create_Account : Form
    {
        Conta Account = new Conta();

        public Create_Account()
        {
            InitializeComponent();
        }

        private void Create_Account_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string FirstName = txtFirstName.Text;
            string LastName = txtLastName.Text;
            string BI = txtBiNumber.Text;
            string DateNasc = txtDateNasc.Text;
            string NContribuinte = txtContribuinteNumber.Text;
            string Morada = txtMorada.Text;
            string Trabalho = txtTrabalho.Text;
            string Phone = txtNumberPhone.Text;
            string Email = txtEmail.Text;

            string Result = Account.Create(FirstName, LastName, BI, DateNasc, NContribuinte, Morada, Trabalho, Phone, Email);

            lbResult.Text = Result;
        }
    }
}
