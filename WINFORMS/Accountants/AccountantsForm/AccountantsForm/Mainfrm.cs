using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountantsForm
{
    public partial class Mainfrm : Form
    {
        public string Username { get; set; }
        public Mainfrm()
        {
            InitializeComponent();
        }

        private void Mainfrm_Load(object sender, EventArgs e)
        {
            AccLoginfrm f = new AccLoginfrm();
            labelName.Text = "Welcome " + Username;
        }

        private void goodsReceivedToolStripMenuItem_Click(object sender, EventArgs e)
        {

            GoodsRecievedfrm f = new GoodsRecievedfrm();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void goodsDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoodsExportfrm f = new GoodsExportfrm();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void incomingoutgoingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncomingStockfrm f = new IncomingStockfrm();
            f.ShowDialog();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Ordersfrm f = new Ordersfrm();
            f.ShowDialog();
        }

        private void accountManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
           AgentAccounts f = new AgentAccounts();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void reportMonthlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Revenuefrm f = new Revenuefrm();         
            f.ShowDialog();
        }

        private void incomingoutgoingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OutgoingStockfrm f = new OutgoingStockfrm();
            f.ShowDialog();
        }

        private void bestsellingProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BestSellingfrm f = new BestSellingfrm();
            f.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to log out ?", "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                AccLoginfrm f = new AccLoginfrm();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
        }
    }
}
