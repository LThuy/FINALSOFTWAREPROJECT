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
    public partial class AgentsInformationfrm : Form
    {
        public AgentsInformationfrm()
        {
            InitializeComponent();
        }

        private void AgentsInformationfrm_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();   
            String sSQL = "SELECT AgentName, AgentAddress, AgentPhone FROM Agents";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewInfo.DataSource = dt;
            }
            conn.Close();
            conn.Open();
            sSQL = "SELECT Username, Password FROM AgentsLogin";
            cmd = new SqlCommand(sSQL, conn);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewAccount.DataSource = dt;
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {         
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "SELECT AgentName, AgentAddress, AgentPhone FROM Agents WHERE AgentName LIKE '%" + txtAgentName.Text + "%'";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewInfo.DataSource = dt;
            }
            conn.Close();
            conn.Open();
            sSQL = "SELECT Username, Password FROM AgentsLogin  WHERE Username LIKE '%" + txtAgentName.Text + "%'";
            cmd = new SqlCommand(sSQL, conn);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewAccount.DataSource = dt;
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "SELECT AgentName, AgentAddress, AgentPhone FROM Agents";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewInfo.DataSource = dt;
            }
            conn.Close();
            conn.Open();
            sSQL = "SELECT Username, Password FROM AgentsLogin";
            cmd = new SqlCommand(sSQL, conn);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewAccount.DataSource = dt;
            }
            conn.Close();
        }
    }
}
