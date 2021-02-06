using Domofon_ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domofon_WinForms
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == Admin.Login && txt_password.Text == Admin.Password)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Niepoprawny login lub hasło", "Brak dostępu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
