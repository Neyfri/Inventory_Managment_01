using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_managment_system
{
    public partial class UserModelForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Db_Scriqts\SQL Server VS studio\dbMS.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();

        //UserForm userForm = new UserForm();
        public UserModelForm()
        {
            InitializeComponent();
            //userForm.LoadUser();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMuserpassword.Text != txtRepass.Text)
                {
                    MessageBox.Show("Password did not Match","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to save this user?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO tb_user(username, fullname, password, phone) VALUES(@username, @fullname, @password, @phone)", conn);
                    cmd.Parameters.AddWithValue("@username", txtMusername.Text);
                    cmd.Parameters.AddWithValue("@fullname", txtFullname.Text);
                    cmd.Parameters.AddWithValue("@password", txtMuserpassword.Text);
                    cmd.Parameters.AddWithValue("@phone", txtMuserPhone.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("User has been successfully saved!");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clear()
        {
            txtRepass.Clear();
            txtMuserPhone.Clear();
            txtFullname.Clear();
            txtMusername.Clear();
            txtMuserpassword.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            Clear();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMuserpassword.Text != txtRepass.Text)
                {
                    MessageBox.Show("Password did not Match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to update this user?", "Updating Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("UPDATE tb_user SET fullname = @fullname, password = @password, phone = @phone WHERE username LIKE '"+txtMusername.Text+"' ", conn);
                    //cmd.Parameters.AddWithValue("@username", txtMusername.Text);
                    cmd.Parameters.AddWithValue("@fullname", txtFullname.Text);
                    cmd.Parameters.AddWithValue("@password", txtMuserpassword.Text);
                    cmd.Parameters.AddWithValue("@phone", txtMuserPhone.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("User has been successfully updated!");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
