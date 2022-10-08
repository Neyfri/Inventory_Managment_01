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
    public partial class ProductModelForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Db_Scriqts\SQL Server VS studio\dbMS.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public ProductModelForm()
        {
            InitializeComponent();
            LoadCategory();
        }

        public void LoadCategory()
        {
            cboxCategory.Items.Clear();
            cmd = new SqlCommand("SELECT name FROM tb_category", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cboxCategory.Items.Add(dr[0].ToString());
            }
            dr.Close();
            conn.Close();
        }
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public int ReturnIdCategory(string name)
        {
            int value;
            cmd = new SqlCommand("SELECT id FROM tb_category WHERE name LIKE '"+name+"'", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                value = int.Parse(dr["id"].ToString());
                conn.Close();
                return value;
            }
            
            dr.Close();
            conn.Close();

            return -1;
        }
        public string ReturnNameCategory(int id)
        {
            conn.Close();
            string value;
            cmd = new SqlCommand("SELECT name FROM tb_category WHERE id LIKE '" + id + "'", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                value = dr["name"].ToString();
                conn.Close();
                return value;
            }

            dr.Close();
            conn.Close();

            return "Error";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (MessageBox.Show("Are you sure you want to save this Product?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int cateid = ReturnIdCategory(cboxCategory.Text);
                    cmd = new SqlCommand("INSERT INTO tb_product(name, quantity, price, description, category_id) VALUES(@name, @quantity, @price, @description, @category_id)", conn);
                    cmd.Parameters.AddWithValue("@name", txtPName.Text);
                    cmd.Parameters.AddWithValue("@quantity", Convert.ToInt16(txtQuantity.Text));
                    cmd.Parameters.AddWithValue("@price", Convert.ToDouble(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@category_id", cateid);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Product has been successfully saved!");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            txtPrice.Clear();
            txtQuantity.Clear();
            txtDescription.Clear();
            txtPName.Clear();
            cboxCategory.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this Product?", "Updating Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int cateid = ReturnIdCategory(cboxCategory.Text);
                    cmd = new SqlCommand("UPDATE tb_product SET name=@name, quantity=@quantity, price=@price, description=@description, category_id=@category WHERE id LIKE '" + productid.Text + "' ", conn);
                    cmd.Parameters.AddWithValue("@name", txtPName.Text);
                    cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                    cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@category", cateid);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Product has been successfully updated!");
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
