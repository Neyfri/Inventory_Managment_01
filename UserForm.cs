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
    public partial class UserForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Db_Scriqts\SQL Server VS studio\dbMS.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public UserForm()
        {
            InitializeComponent();
            LoadUser();
        }

        public void LoadUser()
        {
            conn.Close();
            int i = 0;
            dgvUser.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tb_user", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                i++;
                dgvUser.Rows.Add(i,dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserModelForm userModel = new UserModelForm();
            userModel.btnSave.Enabled = true;
            userModel.btnUpdate.Enabled = false;
            userModel.ShowDialog();
            LoadUser();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvUser.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                UserModelForm userModel = new UserModelForm();
                userModel.txtMusername.Text = dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                userModel.txtFullname.Text = dgvUser.Rows[e.RowIndex].Cells[2].Value.ToString();
                userModel.txtMuserpassword.Text = dgvUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                userModel.txtMuserPhone.Text = dgvUser.Rows[e.RowIndex].Cells[4].Value.ToString();

                userModel.btnSave.Enabled = false;
                userModel.btnUpdate.Enabled = true;
                userModel.txtMusername.Enabled = false;
                userModel.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if(MessageBox.Show("Are you sure you want delete this user?","Delete Record",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cmd = new SqlCommand("DELETE FROM tb_user WHERE username LIKE '"+ dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString() + "' ", conn);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadUser();
        }
    }
}
