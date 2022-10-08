using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_managment_system
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void checkBoxpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxpass.Checked == false)
                txtpass.UseSystemPasswordChar = true;
            else
                txtpass.UseSystemPasswordChar = false;
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtuser.Clear();
            txtpass.Clear();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you really want to exit","Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            if (1 + 1 == 2)
            {
                main.Show();
            }
        }
    }
}
