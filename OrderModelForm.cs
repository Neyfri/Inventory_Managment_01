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
        public OrderModelForm()
        {
            InitializeComponent();
            LoadCustomer();
            LoadProduct();
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
    }
}
