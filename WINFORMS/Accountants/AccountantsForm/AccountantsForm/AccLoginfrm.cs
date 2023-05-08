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
    public partial class AccLoginfrm : Form
    {
       
        public AccLoginfrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            String sql = "SELECT Username, Password FROM AccountantLogin WHERE Username = '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                Mainfrm f = new Mainfrm();
                f.Username = txtUsername.Text;
                this.Hide();
                f.ShowDialog();
                this.Close();
            } else
            {
                MessageBox.Show("Invalid username or password", "Alert", MessageBoxButtons.OK);
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}
