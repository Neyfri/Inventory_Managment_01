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
    public partial class ProductForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Db_Scriqts\SQL Server VS studio\dbMS.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public ProductForm()
        {
            InitializeComponent();
            LoadProduct(); 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductModelForm modelForm = new ProductModelForm();
            modelForm.btnSave.Enabled = true;
            modelForm.btnUpdate.Enabled = false;
            modelForm.ShowDialog();
            LoadProduct();
        }

        public void LoadProduct()
        {
            ProductModelForm formModel = new ProductModelForm();
            int i = 0;
            dgvProduct.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tb_product WHERE CONCAT(id, name, price, description, category_id) LIKE '%"+txtSearch.Text+"%'", conn);
            conn.Open();
            dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    i++;
                    dgvProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), formModel.ReturnNameCategory(int.Parse(dr[5].ToString())));
                }
            dr.Close();
            conn.Close();
        }
        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProduct.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                ProductModelForm formModel = new ProductModelForm();
                formModel.productid.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                formModel.txtPName.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                formModel.txtQuantity.Text = dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                formModel.txtPrice.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                formModel.txtDescription.Text = dgvProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                formModel.cboxCategory.Text = dgvProduct.Rows[e.RowIndex].Cells[6].Value.ToString();

                formModel.btnSave.Enabled = false;
                formModel.btnUpdate.Enabled = true;
                formModel.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want delete this Product?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cmd = new SqlCommand("DELETE FROM tb_product WHERE id LIKE '" + dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString() + "' ", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            LoadProduct();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}
