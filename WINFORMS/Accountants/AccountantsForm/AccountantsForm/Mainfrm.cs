﻿using System;
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
        public Mainfrm()
        {
            InitializeComponent();
        }

        private void Mainfrm_Load(object sender, EventArgs e)
        {

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
    }
}
