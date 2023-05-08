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
    public partial class OutgoingStockfrm : Form
    {
        public OutgoingStockfrm()
        {
            InitializeComponent();
        }
        private void OutgoingStockfrm_Load(object sender, EventArgs e)
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
                DateTime currentDateTime = DateTime.Now;
                string formattedDate = currentDateTime.ToString("yyyy-MM-dd"); // Format the date as a string in the format "yyyy-MM-dd"
                String sSQL = "SELECT name,quantity,date,price,total_price FROM outgoing_stock WHERE DATENAME(month, date) = '" + selectedMonth + "'";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewIncoming.DataSource = dt;
                }
                else
                {
                    dataGridViewIncoming.DataSource = "";
                }
                conn.Close();
            }
            else
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();
                String sSQL = "SELECT name,quantity,date,price,total_price FROM outgoing_stock";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewIncoming.DataSource = dt;
                }
                conn.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "SELECT name,quantity,date,price,total_price FROM outgoing_stock WHERE id LIKE '%" + txtID.Text + "%'";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {             
                // get the month from the first row of the DataTable
                DateTime date = Convert.ToDateTime(dt.Rows[0]["date"]);
                string month = date.ToString("MMMM");

                // set the text of comboBox1 to the month
                comboBox1.Text = month;
                dataGridViewIncoming.DataSource = dt;
            }
            else
            {
                MessageBox.Show(this, "StockID not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            conn.Close();

        }
    }
}
