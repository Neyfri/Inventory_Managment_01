using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Inventory_managment_system
{
    public partial class CategoryModelForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Db_Scriqts\SQL Server VS studio\dbMS.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        public CategoryModelForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this Category?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO tb_category(name) VALUES(@name)", conn);
                    cmd.Parameters.AddWithValue("@name", txtCategoryName.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category has been successfully saved!");
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
            txtCategoryName.Clear();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Dispose(); btnSave.Enabled = true; btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this Category?", "Updating Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("UPDATE tb_category SET name = @name WHERE id LIKE '" + lblCid.Text + "' ", conn);
                    cmd.Parameters.AddWithValue("@name", txtCategoryName.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Category has been successfully updated!");
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
