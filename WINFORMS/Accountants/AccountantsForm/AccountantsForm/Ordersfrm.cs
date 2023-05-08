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
    public partial class Ordersfrm : Form
    {
        public Ordersfrm()
        {
            InitializeComponent();
        }

        private void Ordersfrm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Pending");
            comboBox1.Items.Add("Shipped");
            comboBox1.Items.Add("Delivered");
            comboBox1.Items.Add("Cancelled");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = comboBox1.SelectedItem.ToString();
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            DateTime currentDateTime = DateTime.Now;
            string formattedDate = currentDateTime.ToString("yyyy-MM-dd"); // Format the date as a string in the format "yyyy-MM-dd"
            String sSQL = "SELECT name_agent, date, status, total FROM orders WHERE status = '" + selectedType + "'";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewOrders.DataSource = dt;
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "SELECT name_agent, date, status, total FROM orders WHERE id LIKE '%" + txtOrdersID.Text + "%'";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                comboBox1.Text = dt.Rows[0]["status"].ToString();
                dataGridViewOrders.DataSource = dt;
            }
            conn.Close();
        }
    }
}
