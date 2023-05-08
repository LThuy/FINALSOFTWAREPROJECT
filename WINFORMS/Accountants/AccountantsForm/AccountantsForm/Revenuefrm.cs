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
    public partial class Revenuefrm : Form
    {
        public Revenuefrm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMonth = comboBox1.SelectedItem.ToString();
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            DateTime currentDateTime = DateTime.Now;
            string formattedDate = currentDateTime.ToString("yyyy-MM-dd"); // Format the date as a string in the format "yyyy-MM-dd"
            String sSQL = "SELECT name, quantity, price, total_price, date FROM outgoing_stock WHERE DATENAME(month, date) = '" + selectedMonth + "'";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewRevenue.DataSource = dt;
                int totalRevenue = 0;

                // Iterate over the rows of the DataGridView
                foreach (DataGridViewRow row in dataGridViewRevenue.Rows)
                {
                    // Get the value of the Revenue column for this row
                    int revenue = Convert.ToInt32(row.Cells["total_price"].Value);

                    // Add the revenue to the total
                    totalRevenue += revenue;
                }
                txtTotal.Text = totalRevenue.ToString("N0", new System.Globalization.CultureInfo("vi-VN")) + " VND";
            }
            else
            {
                dataGridViewRevenue.DataSource = "";
                txtTotal.Text = "0 VND";
            }
            conn.Close();
        }

        private void Revenuefrm_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                DateTime month = new DateTime(1, i, 1);
                string monthName = month.ToString("MMMM");
                comboBox1.Items.Add(monthName);
            }
            txtTotal.Text = "0 VND";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
