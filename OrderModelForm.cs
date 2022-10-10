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
    public partial class OrderModelForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Db_Scriqts\SQL Server VS studio\dbMS.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        int qty = 0;
        public OrderModelForm()
        {
            InitializeComponent();
            LoadCustomer();
            LoadProduct();
            txtCtid.Enabled = false;
            txtCtName.Enabled = false;
            txtPid.Enabled = false;
            txtPName.Enabled = false;
            txtPrice.Enabled = false;
            txtTotal.Enabled = false;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void LoadCustomer()
        {
            int i = 0;
            dgvLoadC.Rows.Clear();
            cmd = new SqlCommand("SELECT id, name FROM tb_customer WHERE CONCAT(id, name) LIKE '%" + txtSearchCust.Text + "%'", conn);
            conn.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                i++;
                dgvLoadC.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            conn.Close();
        }
        public void LoadProduct()
        {
            ProductModelForm formModel = new ProductModelForm();
            int i = 0;
            dgvloadP.Rows.Clear();
            cmd = new SqlCommand("SELECT id, description, quantity, price, category_id FROM tb_product WHERE CONCAT(id, price, description, category_id) LIKE '%" + txtSearchProd.Text + "%'", conn);
            conn.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                i++;
                dgvloadP.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), formModel.ReturnNameCategory(int.Parse(dr[4].ToString())));
            }
            dr.Close();
            conn.Close();
        }

        private void txtSearchCust_TextChanged(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void txtSearchProd_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            GetQty();
            if (Convert.ToInt16(UDQty.Value) > qty)
            {
                MessageBox.Show("In Stock quantity is not enough", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UDQty.Value = UDQty.Value -1;
                return;
            }
            if (Convert.ToInt16(UDQty.Value) > 0)
            {
                int total = Convert.ToInt32(txtPrice.Text) * Convert.ToInt16(UDQty.Value);
                txtTotal.Text = total.ToString();
                return;
            }
        }

        private void dgvLoadC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCtid.Text = dgvLoadC.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCtName.Text = dgvLoadC.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dgvloadP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtPid.Text = dgvloadP.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPName.Text = dgvloadP.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPrice.Text = dgvloadP.Rows[e.RowIndex].Cells[4].Value.ToString();
            qty = Convert.ToInt32(dgvloadP.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCtid.Text == "")
                {
                    MessageBox.Show("Please Select a Customer?", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (txtPid.Text == "")
                {
                    MessageBox.Show("Please Select a Product?", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (MessageBox.Show("Are you sure you want to add this Order?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO tb_order(date, pid, ctid, qty, price, total) VALUES(@date, @pid, @ctid, @qty, @price, @total)", conn);
                    cmd.Parameters.AddWithValue("@date", dtOrder.Value);
                    cmd.Parameters.AddWithValue("@pid", Convert.ToInt16(txtPid.Text));
                    cmd.Parameters.AddWithValue("@ctid", Convert.ToInt16(txtCtid.Text));
                    cmd.Parameters.AddWithValue("@qty", Convert.ToInt16(UDQty.Value));
                    cmd.Parameters.AddWithValue("@price", Convert.ToInt32(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@total", Convert.ToInt32(txtTotal.Text));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Order has been successfully added!");
                    
                    cmd = new SqlCommand("UPDATE tb_product SET quantity = (quantity-@quantity) WHERE id LIKE '"+txtPid.Text+"' ", conn);
                    cmd.Parameters.AddWithValue("@quantity", Convert.ToInt16(UDQty.Value));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Clear();
                    LoadProduct();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Clear()
        {
            txtTotal.Clear();
            txtPName.Clear();
            txtCtid.Clear();
            txtCtName.Clear();
            txtPid.Clear();
            txtPrice.Clear();
            UDQty.Value = 1;
            dtOrder.Value = DateTime.Now;
        }
        public void GetQty()
        {
            cmd = new SqlCommand("SELECT quantity tb_product WHERE Id LIKE '" + txtPid.Text + "'", conn);
            conn.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                qty = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            conn.Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnInsert.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
