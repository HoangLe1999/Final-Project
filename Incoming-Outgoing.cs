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
    public partial class IncomingOutgoing : Form
    {
        public IncomingOutgoing()
        {
            InitializeComponent();
        }

        private void IncomingOutgoing_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=HOANG\SQLEXPRESS01;Initial Catalog=Goods;Integrated Security=True";
            conn.Open();
            String sSQL = "SELECT * FROM Goods";
            String sSQL1 = "SELECT * FROM GoodsDelivery";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView3.DataSource = dt;
                dataGridView4.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No data");
            }
            conn.Close();
        }
    }
}
