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
    public partial class AgentAccounts : Form
    {
        public AgentAccounts()
        {
            InitializeComponent();
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(txtAgentName.Text == "" || txtAgentAddress.Text == "" || txtAgentPhone.Text == "" || txtPassword.Text == "" || txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Please fill all the information.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            } else if(txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password and Confirm Password must be the same.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                DialogResult result = MessageBox.Show("Are you sure ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(Program.strConn);
                    conn.Open();
                    String sSQL = "INSERT INTO Agents (AgentID,AgentName, AgentAddress, AgentPhone) VALUES ('" + txtID.Text + "','" + txtAgentName.Text + "', '" + txtAgentAddress.Text + "', '" + txtAgentPhone.Text + "')";
                    SqlCommand cmd = new SqlCommand(sSQL, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    // Execute the SQL query
                    cmd.ExecuteNonQuery();
                    conn.Close();               
                    conn.Open();
                    sSQL = "INSERT INTO AgentsLogin (AgentID, Username, Password) VALUES ('" + txtID.Text + "','" + txtAgentName.Text + "', '" + txtConfirmPassword.Text + "')";
                    cmd = new SqlCommand(sSQL, conn);
                    adapter = new SqlDataAdapter(cmd);
                    // Execute the SQL query
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Account is created. Please view to check fully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtAgentName.Text = "";
            txtAgentAddress.Text = "";
            txtAgentPhone.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Mainfrm f = new Mainfrm();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            AgentsInformationfrm f = new AgentsInformationfrm();     
            f.ShowDialog();
           
        }
    }
}
