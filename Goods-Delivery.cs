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
using System.Data.OleDb;
using System.Configuration;


namespace _517H0122_LeThanhHoang
{
    public partial class GoodsDelivery : Form
    {
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataTable dt;
        public GoodsDelivery()
        {
            InitializeComponent();
        }

        private void GoodsDelivery_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=HOANG\SQLEXPRESS01;Initial Catalog=Goods;Integrated Security=True";
            conn.Open();
            String sSQL = "SELECT * FROM GoodsDelivery";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView2.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No data");
            }
            conn.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dataGridView2.EndEdit();
            try
            {
                da.Update(dt);
                MessageBox.Show("updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
