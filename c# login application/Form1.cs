using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace c__login_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void buttonsignin_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(txtusername.Text) && String.IsNullOrEmpty(txtpassword.Text))|| String.IsNullOrEmpty(txtpassword.Text)|| String.IsNullOrEmpty(txtusername.Text)) {
                MessageBox.Show("Please fill the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0K8IABK\\SQLEXPRESS;Initial Catalog=Employee-details;Integrated Security=True");
                string query = "SELECT * FROM Tblloginnewversion WHERE Username = @Username and Password = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", txtusername.Text);
                cmd.Parameters.AddWithValue("@password", txtpassword.Text);
                DataTable db = new DataTable();
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.Hide();
                    Form2 form2 = new Form2();
                    form2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid login credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
