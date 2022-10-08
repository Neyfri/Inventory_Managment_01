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
    public partial class CategoryForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Db_Scriqts\SQL Server VS studio\dbMS.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public CategoryForm()
        {
            InitializeComponent();
            LoadCategory();
        }

        
        public void LoadCategory()
        {
            conn.Close();
            int i = 0;
            dgvCategory.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tb_category", conn);
            conn.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                i++;
                dgvCategory.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCategory.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                CategoryModelForm cModel = new CategoryModelForm();
                cModel.lblCid.Text = dgvCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
                cModel.txtCategoryName.Text = dgvCategory.Rows[e.RowIndex].Cells[2].Value.ToString();
                cModel.btnSave.Enabled = false;
                cModel.btnUpdate.Enabled = true;
                cModel.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want delete this Category?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cmd = new SqlCommand("DELETE FROM tb_category WHERE id LIKE '" + dgvCategory.Rows[e.RowIndex].Cells[1].Value.ToString() + "' ", conn);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadCategory();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CategoryModelForm mCategory = new CategoryModelForm();
            mCategory.btnSave.Enabled = true;
            mCategory.btnUpdate.Enabled = false;
            mCategory.ShowDialog();
            LoadCategory();
        }
    }
}
