using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_managment_system
{
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Db_Scriqts\SQL Server VS studio\dbMS.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
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
            try
            {
                cmd = new SqlCommand("SELECT * FROM tb_user WHERE username=@name AND password=@pass", conn);
                cmd.Parameters.AddWithValue("@name", txtuser.Text);
                cmd.Parameters.AddWithValue("@pass", txtpass.Text);
                conn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("welcome " + dr["fullname"].ToString() + " | ","ACCESS GRANTED",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    MainForm mainForm = new MainForm();
                    this.Hide();
                    mainForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!","Access Denited",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
