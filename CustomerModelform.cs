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
using System.Data.SqlClient;

namespace Inventory_managment_system
{
    public partial class CustomerModelform : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Db_Scriqts\SQL Server VS studio\dbMS.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        public CustomerModelform()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this customer?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO tb_customer(name, lastname, phone) VALUES(@name, @lastname, @phone)", conn);
                    cmd.Parameters.AddWithValue("@name", txtCustomername.Text);
                    cmd.Parameters.AddWithValue("@lastname", txtLastname.Text);
                    cmd.Parameters.AddWithValue("@phone", txtcustomerPhone.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
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
            txtcustomerPhone.Clear();
            txtLastname.Clear();
            txtCustomername.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this Customer?", "Updating Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("UPDATE tb_customer SET name = @name, lastname = @lastname, phone = @phone WHERE id LIKE '" + lblCid.Text + "' ", conn);
                    //cmd.Parameters.AddWithValue("@username", txtMusername.Text);
                    cmd.Parameters.AddWithValue("@name", txtCustomername.Text);
                    cmd.Parameters.AddWithValue("@lastname", txtLastname.Text);
                    cmd.Parameters.AddWithValue("@phone", txtcustomerPhone.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Customer has been successfully updated!");
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
