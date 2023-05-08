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
    public partial class BestSellingfrm : Form
    {
        public BestSellingfrm()
        {
            InitializeComponent();
        }

        private void BestSellingfrm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("All");
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
            if (comboBox1.Text != "All")
            {
                string selectedMonth = comboBox1.SelectedItem.ToString();
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();
                string sSQL = "SELECT TOP 5 name, quantity, price, total_price " +
                              "FROM outgoing_stock " +
                              "WHERE DATENAME(MONTH, date) ='" + selectedMonth + "' " +
                              "ORDER BY quantity DESC";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewBestSelling.DataSource = dt;
                }
                else
                {
                    dataGridViewBestSelling.DataSource = "";
                }
                conn.Close();
            }
            else
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();
                string sSQL = "SELECT TOP 5 name, quantity,  price, total_price " +
                              "FROM outgoing_stock " +
                              "ORDER BY quantity DESC;";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewBestSelling.DataSource = dt;
                }
                conn.Close();
            }
        }

      
    }
}
