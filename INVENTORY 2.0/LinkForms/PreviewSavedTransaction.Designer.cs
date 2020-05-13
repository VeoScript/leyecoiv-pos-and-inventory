namespace INVENTORY_2._0.LinkForms
{
    partial class PreviewSavedTransaction
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewSavedTransaction));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPrintReceipt = new Bunifu.Framework.UI.BunifuImageButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panelListContainer = new System.Windows.Forms.Panel();
            this.listOfOrders = new System.Windows.Forms.DataGridView();
            this.panelFormContainer = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCashier = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDateOfTransaction = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtIssueBy = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtAmountPay = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtSearchCommodityNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrintReceipt)).BeginInit();
            this.panelListContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfOrders)).BeginInit();
            this.panelFormContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(946, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(17, 17);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 11;
            this.btnClose.TabStop = false;
            this.toolTip1.SetToolTip(this.btnClose, "Close");
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintReceipt.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintReceipt.Image")));
            this.btnPrintReceipt.ImageActive = null;
            this.btnPrintReceipt.Location = new System.Drawing.Point(916, 90);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(47, 45);
            this.btnPrintReceipt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPrintReceipt.TabIndex = 14;
            this.btnPrintReceipt.TabStop = false;
            this.toolTip1.SetToolTip(this.btnPrintReceipt, "Print Receipt");
            this.btnPrintReceipt.Zoom = 10;
            this.btnPrintReceipt.Click += new System.EventHandler(this.btnPrintReceipt_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(945, 46);
            this.label6.TabIndex = 0;
            this.label6.Text = "List Of Orders";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelListContainer
            // 
            this.panelListContainer.Controls.Add(this.listOfOrders);
            this.panelListContainer.Controls.Add(this.label6);
            this.panelListContainer.Location = new System.Drawing.Point(18, 150);
            this.panelListContainer.Name = "panelListContainer";
            this.panelListContainer.Size = new System.Drawing.Size(945, 336);
            this.panelListContainer.TabIndex = 8;
            // 
            // listOfOrders
            // 
            this.listOfOrders.AllowUserToAddRows = false;
            this.listOfOrders.AllowUserToDeleteRows = false;
            this.listOfOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listOfOrders.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.listOfOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listOfOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listOfOrders.Location = new System.Drawing.Point(0, 46);
            this.listOfOrders.Name = "listOfOrders";
            this.listOfOrders.ReadOnly = true;
            this.listOfOrders.Size = new System.Drawing.Size(945, 290);
            this.listOfOrders.TabIndex = 1;
            // 
            // panelFormContainer
            // 
            this.panelFormContainer.BackColor = System.Drawing.Color.White;
            this.panelFormContainer.Controls.Add(this.lblStatus);
            this.panelFormContainer.Controls.Add(this.label5);
            this.panelFormContainer.Controls.Add(this.lblCashier);
            this.panelFormContainer.Controls.Add(this.label7);
            this.panelFormContainer.Controls.Add(this.lblDateOfTransaction);
            this.panelFormContainer.Controls.Add(this.label19);
            this.panelFormContainer.Controls.Add(this.label2);
            this.panelFormContainer.Controls.Add(this.label17);
            this.panelFormContainer.Controls.Add(this.txtIssueBy);
            this.panelFormContainer.Controls.Add(this.txtTotalAmount);
            this.panelFormContainer.Controls.Add(this.txtAmountPay);
            this.panelFormContainer.Controls.Add(this.label15);
            this.panelFormContainer.Controls.Add(this.btnPrintReceipt);
            this.panelFormContainer.Controls.Add(this.btnClose);
            this.panelFormContainer.Controls.Add(this.panelListContainer);
            this.panelFormContainer.Controls.Add(this.label4);
            this.panelFormContainer.Controls.Add(this.label1);
            this.panelFormContainer.Controls.Add(this.btnClearSearch);
            this.panelFormContainer.Controls.Add(this.txtSearchCommodityNo);
            this.panelFormContainer.Controls.Add(this.label3);
            this.panelFormContainer.Location = new System.Drawing.Point(2, 2);
            this.panelFormContainer.Name = "panelFormContainer";
            this.panelFormContainer.Size = new System.Drawing.Size(973, 499);
            this.panelFormContainer.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.DimGray;
            this.lblStatus.Location = new System.Drawing.Point(773, 22);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(81, 17);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "-- -- --";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(775, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 14);
            this.label5.TabIndex = 20;
            this.label5.Text = "Status";
            // 
            // lblCashier
            // 
            this.lblCashier.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashier.ForeColor = System.Drawing.Color.DimGray;
            this.lblCashier.Location = new System.Drawing.Point(363, 22);
            this.lblCashier.Name = "lblCashier";
            this.lblCashier.Size = new System.Drawing.Size(290, 17);
            this.lblCashier.TabIndex = 19;
            this.lblCashier.Text = "-- -- --";
            this.lblCashier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(605, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 14);
            this.label7.TabIndex = 20;
            this.label7.Text = "Cashier";
            // 
            // lblDateOfTransaction
            // 
            this.lblDateOfTransaction.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfTransaction.ForeColor = System.Drawing.Color.DimGray;
            this.lblDateOfTransaction.Location = new System.Drawing.Point(662, 22);
            this.lblDateOfTransaction.Name = "lblDateOfTransaction";
            this.lblDateOfTransaction.Size = new System.Drawing.Size(81, 17);
            this.lblDateOfTransaction.TabIndex = 19;
            this.lblDateOfTransaction.Text = "-- -- --";
            this.lblDateOfTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DimGray;
            this.label19.Location = new System.Drawing.Point(662, 40);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 14);
            this.label19.TabIndex = 20;
            this.label19.Text = "Date of Transaction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(391, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 14);
            this.label2.TabIndex = 18;
            this.label2.Text = "Total Amount";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DimGray;
            this.label17.Location = new System.Drawing.Point(527, 91);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 14);
            this.label17.TabIndex = 18;
            this.label17.Text = "Amount Pay";
            // 
            // txtIssueBy
            // 
            this.txtIssueBy.Enabled = false;
            this.txtIssueBy.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssueBy.Location = new System.Drawing.Point(666, 108);
            this.txtIssueBy.Name = "txtIssueBy";
            this.txtIssueBy.Size = new System.Drawing.Size(244, 27);
            this.txtIssueBy.TabIndex = 17;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(394, 108);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(130, 27);
            this.txtTotalAmount.TabIndex = 17;
            // 
            // txtAmountPay
            // 
            this.txtAmountPay.Enabled = false;
            this.txtAmountPay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountPay.Location = new System.Drawing.Point(530, 108);
            this.txtAmountPay.Name = "txtAmountPay";
            this.txtAmountPay.Size = new System.Drawing.Size(130, 27);
            this.txtAmountPay.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(663, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 14);
            this.label15.TabIndex = 15;
            this.label15.Text = "Issue By";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(36, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "VIEW OR REPRINT THE RECEIPT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "PREVIEW SAVED TRANSACTION";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnClearSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnClearSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnClearSearch.Image")));
            this.btnClearSearch.ImageActive = null;
            this.btnClearSearch.Location = new System.Drawing.Point(328, 108);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(34, 27);
            this.btnClearSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClearSearch.TabIndex = 4;
            this.btnClearSearch.TabStop = false;
            this.btnClearSearch.Zoom = 10;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // txtSearchCommodityNo
            // 
            this.txtSearchCommodityNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCommodityNo.Location = new System.Drawing.Point(18, 108);
            this.txtSearchCommodityNo.Name = "txtSearchCommodityNo";
            this.txtSearchCommodityNo.Size = new System.Drawing.Size(311, 27);
            this.txtSearchCommodityNo.TabIndex = 6;
            this.txtSearchCommodityNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchCommodityNo_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(17, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Search DCR / Commodity No.";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelFormContainer;
            this.bunifuDragControl1.Vertical = true;
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // PreviewSavedTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(977, 503);
            this.Controls.Add(this.panelFormContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PreviewSavedTransaction";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PreviewSavedTransaction";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrintReceipt)).EndInit();
            this.panelListContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listOfOrders)).EndInit();
            this.panelFormContainer.ResumeLayout(false);
            this.panelFormContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelListContainer;
        private System.Windows.Forms.DataGridView listOfOrders;
        private System.Windows.Forms.Panel panelFormContainer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnClearSearch;
        private System.Windows.Forms.TextBox txtSearchCommodityNo;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton btnPrintReceipt;
        private System.Windows.Forms.TextBox txtAmountPay;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtIssueBy;
        private System.Windows.Forms.Label lblDateOfTransaction;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCashier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}