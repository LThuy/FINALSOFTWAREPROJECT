namespace AccountantsForm
{
    partial class Mainfrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestsellingProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsReceivedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsDeliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incomingoutgoingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incomingoutgoingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportMonthlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.goodsInformationToolStripMenuItem,
            this.stockReportToolStripMenuItem,
            this.revenueToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestsellingProductsToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // bestsellingProductsToolStripMenuItem
            // 
            this.bestsellingProductsToolStripMenuItem.Name = "bestsellingProductsToolStripMenuItem";
            this.bestsellingProductsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.bestsellingProductsToolStripMenuItem.Text = "Best-selling";
            // 
            // goodsInformationToolStripMenuItem
            // 
            this.goodsInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goodsReceivedToolStripMenuItem,
            this.goodsDeliveryToolStripMenuItem});
            this.goodsInformationToolStripMenuItem.Name = "goodsInformationToolStripMenuItem";
            this.goodsInformationToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.goodsInformationToolStripMenuItem.Text = "Goods Information";
            // 
            // goodsReceivedToolStripMenuItem
            // 
            this.goodsReceivedToolStripMenuItem.Name = "goodsReceivedToolStripMenuItem";
            this.goodsReceivedToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.goodsReceivedToolStripMenuItem.Text = "Goods Received Note";
            this.goodsReceivedToolStripMenuItem.Click += new System.EventHandler(this.goodsReceivedToolStripMenuItem_Click);
            // 
            // goodsDeliveryToolStripMenuItem
            // 
            this.goodsDeliveryToolStripMenuItem.Name = "goodsDeliveryToolStripMenuItem";
            this.goodsDeliveryToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.goodsDeliveryToolStripMenuItem.Text = "Goods Delivery Note";
            // 
            // stockReportToolStripMenuItem
            // 
            this.stockReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incomingoutgoingToolStripMenuItem,
            this.incomingoutgoingToolStripMenuItem1});
            this.stockReportToolStripMenuItem.Name = "stockReportToolStripMenuItem";
            this.stockReportToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.stockReportToolStripMenuItem.Text = "Stock Report";
            // 
            // incomingoutgoingToolStripMenuItem
            // 
            this.incomingoutgoingToolStripMenuItem.Name = "incomingoutgoingToolStripMenuItem";
            this.incomingoutgoingToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.incomingoutgoingToolStripMenuItem.Text = "Incoming";
            // 
            // incomingoutgoingToolStripMenuItem1
            // 
            this.incomingoutgoingToolStripMenuItem1.Name = "incomingoutgoingToolStripMenuItem1";
            this.incomingoutgoingToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.incomingoutgoingToolStripMenuItem1.Text = "Outgoing";
            // 
            // revenueToolStripMenuItem
            // 
            this.revenueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportMonthlyToolStripMenuItem});
            this.revenueToolStripMenuItem.Name = "revenueToolStripMenuItem";
            this.revenueToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.revenueToolStripMenuItem.Text = "Revenue";
            // 
            // reportMonthlyToolStripMenuItem
            // 
            this.reportMonthlyToolStripMenuItem.Name = "reportMonthlyToolStripMenuItem";
            this.reportMonthlyToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.reportMonthlyToolStripMenuItem.Text = "Report monthly";
            // 
            // Mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AccountantsForm.Properties.Resources.mainfrmBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mainfrm";
            this.Text = "Management";
            this.Load += new System.EventHandler(this.Mainfrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodsInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodsReceivedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodsDeliveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incomingoutgoingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incomingoutgoingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bestsellingProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revenueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportMonthlyToolStripMenuItem;
    }
}