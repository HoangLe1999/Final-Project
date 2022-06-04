using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _517H0122_LeThanhHoang
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            frmLogin a = new frmLogin();
            a.ShowDialog();
        }

        private void goodsRecivedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoodRecived b = new GoodRecived();
            b.Show();
        }

        private void goodsDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoodsDelivery c = new GoodsDelivery();
            c.Show();
        }

        private void incomingOutgoingStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoodRecived b = new GoodRecived();
            b.Show();
            GoodsDelivery c = new GoodsDelivery();
            c.Show();
        }
    }
}
