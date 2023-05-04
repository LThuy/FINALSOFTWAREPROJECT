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

namespace AccountantsForm
{
    public partial class IncomingStockfrm : Form
    {
        public IncomingStockfrm()
        {
            InitializeComponent();
        }

        private void IncomingStockfrm_Load(object sender, EventArgs e)
        {
            // Add months to combo box
            for (int i = 1; i <= 12; i++)
            {
                DateTime month = new DateTime(1, i, 1);
                string monthName = month.ToString("MMMM");
                comboBox1.Items.Add(monthName);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMonth = comboBox1.SelectedItem.ToString();
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            DateTime currentDateTime = DateTime.Now;
            string formattedDate = currentDateTime.ToString("yyyy-MM-dd"); // Format the date as a string in the format "yyyy-MM-dd"
            String sSQL = "SELECT name,quantity,price,total_price FROM incoming_stock WHERE DATENAME(month, date) = '" + selectedMonth + "'";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewIncoming.DataSource = dt;
            } else
            {
                dataGridViewIncoming.DataSource = "";
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mainfrm f = new Mainfrm();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
