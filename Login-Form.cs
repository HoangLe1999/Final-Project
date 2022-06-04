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

namespace _517H0122_LeThanhHoang
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("click ok to exit");
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=HOANG\SQLEXPRESS01;Initial Catalog=SE.Login;Integrated Security=True";
            conn.Open();
            String sSQL = "SELECT UserID, Password FROM tblUsers WHERE " +
                          "UserID='" + txtUserName.Text + "' and Password='" + txtPassword.Text + "'";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Successful");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
            conn.Close();
        }
    }
}
