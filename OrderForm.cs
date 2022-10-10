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
    public partial class OrderForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Db_Scriqts\SQL Server VS studio\dbMS.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public OrderForm()
        {
            InitializeComponent();
            LoadOrder();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OrderModelForm orderModelForm = new OrderModelForm();
            orderModelForm.btnInsert.Enabled = true;
            orderModelForm.ShowDialog();
        }

        public void LoadOrder()
        {
            double total = 0;
            int i = 0;
            dgvOrder.Rows.Clear();
            cmd = new SqlCommand("SELECT O.id, O.   date, O.pid, P.name, C.id, C.name, qty, O.price, total FROM tb_order AS O JOIN tb_customer AS C ON O.id=C.id JOIN tb_product AS P ON O.pid=P.id WHERE CONCAT (O.id, date, O.pid, O.ctid, O.qty, O.price) LIKE '%"+txtSearchIn.Text+"%'", conn);
            conn.Open();
                dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvOrder.Rows.Add(i, dr[0].ToString(), Convert.ToDateTime(dr[1].ToString()).ToString("dddd/MM/yyyy"), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
                total += double.Parse(dr[8].ToString());
            }
            dr.Close();
            conn.Close();

            lblQty.Text = i.ToString();
            lbltotal.Text = total.ToString();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvOrder.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want delete this user?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cmd = new SqlCommand("DELETE FROM tb_order WHERE id LIKE '" + dgvOrder.Rows[e.RowIndex].Cells[1].Value.ToString() + "' ", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record has been successfully");

                    cmd = new SqlCommand("UPDATE tb_product SET quantity = (quantity+@quantity) WHERE id LIKE '" + dgvOrder.Rows[e.RowIndex].Cells[3].Value.ToString() + "' ", conn);
                    cmd.Parameters.AddWithValue("@quantity", Convert.ToInt16(dgvOrder.Rows[e.RowIndex].Cells[5].Value.ToString()));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            LoadOrder();
        }
    }
}
