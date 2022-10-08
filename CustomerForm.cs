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
    public partial class CustomerForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Db_Scriqts\SQL Server VS studio\dbMS.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public CustomerForm()
        {
            InitializeComponent();
            LoadCustomer();
        }

        public void LoadCustomer()
        {
            int i = 0;
            dgvCustomer.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tb_customer", conn);
            conn.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                i++;
                dgvCustomer.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustomerModelform mCustomer = new CustomerModelform();
            mCustomer.btnSave.Enabled = true;
            mCustomer.btnUpdate.Enabled = false;
            mCustomer.ShowDialog();
            LoadCustomer();
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCustomer.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                CustomerModelform customerModelform = new CustomerModelform();
                customerModelform.lblCid.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                customerModelform.txtCustomername.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                customerModelform.txtLastname.Text = dgvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                customerModelform.txtcustomerPhone.Text = dgvCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();

                customerModelform.btnSave.Enabled = false;
                customerModelform.btnUpdate.Enabled = true;
                customerModelform.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want delete this customer?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cmd = new SqlCommand("DELETE FROM tb_customer WHERE id LIKE '" + dgvCustomer.Rows[e.RowIndex].Cells[0].Value.ToString() + "' ", conn);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadCustomer();
        }
    }
}
