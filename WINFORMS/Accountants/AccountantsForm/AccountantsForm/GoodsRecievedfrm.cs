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
    public partial class GoodsRecievedfrm : Form
    {
        private List<String> list = new List<String>();
        private int i = 0;

        public GoodsRecievedfrm()
        {
            InitializeComponent();
        }

        private void GoodsRecievedfrm_Load(object sender, EventArgs e)
        {
           
            DateTime currentDateTime = DateTime.Now;
            txtDate.Text = currentDateTime.ToLongDateString();
            dataGridView1.Rows.Clear(); 
        }

        
        private void BtnOK_Click(object sender, EventArgs e)
        {           
            if (txtTrademark.Text == "" || txtCode.Text == "" || txtQuantity.Text == "" || txtUnitPrice.Text == "")
            {
                MessageBox.Show("Please fill product information fully!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTrademark.Focus();
            } else
            {
                if(validateProductInformation())
                {
                    dataGridView1.Rows.Add(dataGridView1.RowCount, txtTrademark.Text, "VND", txtCode.Text, txtQuantity.Text, Convert.ToInt32(txtUnitPrice.Text).ToString("N0"),
                    (Convert.ToInt32(txtQuantity.Text) * Convert.ToInt32(txtUnitPrice.Text)).ToString("N0"));
                    list.Add(txtDocument.Text);
                }           
            }          
        }

        public  bool validateProductInformation()
        {
            if(dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow dgv in dataGridView1.Rows)
                {
                    if (dgv.Cells[3].Value != null)
                    {
                        if (txtCode.Text == dgv.Cells[3].Value.ToString())
                        {
                            MessageBox.Show("Code product is available", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }                    
            }
            double number1;
            double number2;
            double number3;
            bool isNumber1 = double.TryParse(txtDocument.Text, out number1);
            bool isNumber2 = double.TryParse(txtQuantity.Text, out number2);
            bool isNumber3 = double.TryParse(txtUnitPrice.Text, out number3);
            if (!(isNumber1 && isNumber2 && isNumber3))
            {
                MessageBox.Show("Please enter numbers", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if ((number1 < 0 || number1 == 0) || (number2 < 0 || number2 == 0) || (number3 < 0 || number3 == 0))
            {
                MessageBox.Show("Number must be higher than 0", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (number2 > number1)
            {
                MessageBox.Show("Quantity actually should be lower than " + number1.ToString(), "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            return true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                BtnClear_Click(sender, e);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtTrademark.Text = "";
            txtCode.Text = "";
            txtQuantity.Text = "";
            txtDocument.Text = "";
            txtUnitPrice.Text = "";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtNameDeliverer.Text != "" && txtLocation.Text != "" && txtStock.Text != "" && dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result =  MessageBox.Show("Are you sure?", "Confirming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    MessageBox.Show("Your goods recieved note will be printed", "Print", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    GoodsRecievedNote r = new GoodsRecievedNote();

                    CrystalDecisions.CrystalReports.Engine.TextObject textDelivererName = (CrystalDecisions.CrystalReports.Engine.TextObject)r.ReportDefinition.ReportObjects["txtDelivererName"];
                    CrystalDecisions.CrystalReports.Engine.TextObject textLocation = (CrystalDecisions.CrystalReports.Engine.TextObject)r.ReportDefinition.ReportObjects["txtLocation"];
                    CrystalDecisions.CrystalReports.Engine.TextObject textStock = (CrystalDecisions.CrystalReports.Engine.TextObject)r.ReportDefinition.ReportObjects["txtStock"];
                    CrystalDecisions.CrystalReports.Engine.TextObject textNum = (CrystalDecisions.CrystalReports.Engine.TextObject)r.ReportDefinition.ReportObjects["txtNum"];
                    textDelivererName.Text = txtNameDeliverer.Text;
                    textLocation.Text = txtLocation.Text;
                    textStock.Text = txtStock.Text;
                    textNum.Text = txtNo.Text;


                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable();



                    dt.Columns.Add("Order", typeof(string));
                    dt.Columns.Add("Name of Trademark", typeof(string));
                    dt.Columns.Add("Unit", typeof(string));
                    dt.Columns.Add("Code", typeof(string));
                    dt.Columns.Add("Quantity (document)", typeof(string));
                    dt.Columns.Add("Quantity (actually)", typeof(string));
                    dt.Columns.Add("Unit Price", typeof(string));
                    dt.Columns.Add("Amount", typeof(string));
                  

                    int sum = 0;

                    int i = 0;
                    foreach (DataGridViewRow dgv in dataGridView1.Rows)
                    {
                        if (dgv.Cells[6].Value != null)
                        {
                            dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, list[i], dgv.Cells[4].Value, dgv.Cells[5].Value, dgv.Cells[6].Value);
                            sum += Convert.ToInt32(dgv.Cells[6].Value.ToString().Replace(",", ""));
                            SqlConnection conn = new SqlConnection(Program.strConn);
                            conn.Open();
                            DateTime currentDateTime = DateTime.Now;
                            string formattedDate = currentDateTime.ToString("yyyy-MM-dd"); // Format the date as a string in the format "yyyy-MM-dd"
                            String sSQL = "INSERT INTO incoming_stock (id, name, quantity, price, total_price, date) VALUES ('" + Convert.ToInt32(txtNo.Text) + "','" + dgv.Cells[1].Value + "', " + dgv.Cells[4].Value + ", " + Convert.ToInt32(dgv.Cells[5].Value.ToString().Replace(",", "")) + ", " + Convert.ToInt32(dgv.Cells[6].Value.ToString().Replace(",", "")) + ", '" + formattedDate + "')";
                            SqlCommand cmd = new SqlCommand(sSQL, conn);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            // Execute the SQL query
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            i++;
                        }


                    }



                    CrystalDecisions.CrystalReports.Engine.TextObject textSum = (CrystalDecisions.CrystalReports.Engine.TextObject)r.ReportDefinition.ReportObjects["txtSum"];
                    textSum.Text = sum.ToString("N0");

                    ds.Tables.Add(dt);
                    ds.WriteXmlSchema("applicant.xml");


                    goodsrecievedReport f = new goodsrecievedReport();
                    r.SetDataSource(ds);
                    f.crystalReportViewer1.ReportSource = r;                 
                    f.ShowDialog();
                }
                
            } else
            {
                MessageBox.Show("Please fill information fully!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                txtTrademark.Text = Convert.ToString(selectedRow.Cells[1].Value);
                txtCode.Text = Convert.ToString(selectedRow.Cells[3].Value);
                txtQuantity.Text = Convert.ToString(selectedRow.Cells[4].Value);
                decimal unitPrice = Convert.ToDecimal(selectedRow.Cells[5].Value);
                string unitPriceStr = unitPrice.ToString("");
                txtUnitPrice.Text = unitPriceStr;

            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                selectedRow.Cells[1].Value = txtTrademark.Text;
                selectedRow.Cells[3].Value = txtCode.Text;
                selectedRow.Cells[4].Value = txtQuantity.Text;
                selectedRow.Cells[5].Value = Convert.ToInt32(txtUnitPrice.Text).ToString("N0");
                selectedRow.Cells[6].Value = (Convert.ToInt32(txtQuantity.Text) * Convert.ToInt32(txtUnitPrice.Text)).ToString("N0");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Mainfrm f = new Mainfrm();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void BtnNewNote_Click(object sender, EventArgs e)
        {
            GoodsRecievedfrm f = new GoodsRecievedfrm();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

      
    }
}
