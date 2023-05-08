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
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.goodsInformationToolStripMenuItem,
            this.stockReportToolStripMenuItem,
            this.revenueToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.accountManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestsellingProductsToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // bestsellingProductsToolStripMenuItem
            // 
            this.bestsellingProductsToolStripMenuItem.Name = "bestsellingProductsToolStripMenuItem";
            this.bestsellingProductsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bestsellingProductsToolStripMenuItem.Text = "Best-selling";
            this.bestsellingProductsToolStripMenuItem.Click += new System.EventHandler(this.bestsellingProductsToolStripMenuItem_Click);
            // 
            // goodsInformationToolStripMenuItem
            // 
            this.goodsInformationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
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
            this.goodsDeliveryToolStripMenuItem.Click += new System.EventHandler(this.goodsDeliveryToolStripMenuItem_Click);
            // 
            // stockReportToolStripMenuItem
            // 
            this.stockReportToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
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
            this.incomingoutgoingToolStripMenuItem.Click += new System.EventHandler(this.incomingoutgoingToolStripMenuItem_Click);
            // 
            // incomingoutgoingToolStripMenuItem1
            // 
            this.incomingoutgoingToolStripMenuItem1.Name = "incomingoutgoingToolStripMenuItem1";
            this.incomingoutgoingToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.incomingoutgoingToolStripMenuItem1.Text = "Outgoing";
            this.incomingoutgoingToolStripMenuItem1.Click += new System.EventHandler(this.incomingoutgoingToolStripMenuItem1_Click);
            // 
            // revenueToolStripMenuItem
            // 
            this.revenueToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
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
            this.reportMonthlyToolStripMenuItem.Click += new System.EventHandler(this.reportMonthlyToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ordersToolStripMenuItem.Text = "Orders";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // accountManagementToolStripMenuItem
            // 
            this.accountManagementToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
            this.accountManagementToolStripMenuItem.Name = "accountManagementToolStripMenuItem";
            this.accountManagementToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.accountManagementToolStripMenuItem.Text = "Account Management";
            this.accountManagementToolStripMenuItem.Click += new System.EventHandler(this.accountManagementToolStripMenuItem_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(713, 415);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelName.Font = new System.Drawing.Font("Verdana", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Maroon;
            this.labelName.Location = new System.Drawing.Point(161, 169);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(504, 59);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "WELCOME ADMIN";
            // 
            // Mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::AccountantsForm.Properties.Resources.mainfrmBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
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
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountManagementToolStripMenuItem;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label labelName;
    }
}