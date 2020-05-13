namespace INVENTORY_2._0.LinkForms
{
    partial class TransactionHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionHistory));
            this.panelFormContainer = new System.Windows.Forms.Panel();
            this.lblTotalAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPayable = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExcel = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.cmbSearchEmployee = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelListContainer = new System.Windows.Forms.Panel();
            this.dgHistoryDetails = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelFormContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panelListContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistoryDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFormContainer
            // 
            this.panelFormContainer.BackColor = System.Drawing.Color.White;
            this.panelFormContainer.Controls.Add(this.lblTotalAmount);
            this.panelFormContainer.Controls.Add(this.label5);
            this.panelFormContainer.Controls.Add(this.lblPayable);
            this.panelFormContainer.Controls.Add(this.label8);
            this.panelFormContainer.Controls.Add(this.btnExcel);
            this.panelFormContainer.Controls.Add(this.btnSearch);
            this.panelFormContainer.Controls.Add(this.dtpToDate);
            this.panelFormContainer.Controls.Add(this.dtpFromDate);
            this.panelFormContainer.Controls.Add(this.cmbSearchEmployee);
            this.panelFormContainer.Controls.Add(this.label7);
            this.panelFormContainer.Controls.Add(this.label3);
            this.panelFormContainer.Controls.Add(this.label2);
            this.panelFormContainer.Controls.Add(this.label15);
            this.panelFormContainer.Controls.Add(this.btnClose);
            this.panelFormContainer.Controls.Add(this.panelListContainer);
            this.panelFormContainer.Controls.Add(this.label4);
            this.panelFormContainer.Controls.Add(this.label1);
            this.panelFormContainer.Location = new System.Drawing.Point(2, 2);
            this.panelFormContainer.Name = "panelFormContainer";
            this.panelFormContainer.Size = new System.Drawing.Size(973, 499);
            this.panelFormContainer.TabIndex = 2;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Enabled = false;
            this.lblTotalAmount.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTotalAmount.Location = new System.Drawing.Point(759, 105);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(107, 30);
            this.lblTotalAmount.TabIndex = 19;
            this.lblTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(759, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 14);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cash";
            // 
            // lblPayable
            // 
            this.lblPayable.Enabled = false;
            this.lblPayable.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayable.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblPayable.Location = new System.Drawing.Point(637, 105);
            this.lblPayable.Name = "lblPayable";
            this.lblPayable.Size = new System.Drawing.Size(116, 30);
            this.lblPayable.TabIndex = 20;
            this.lblPayable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(634, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 14);
            this.label8.TabIndex = 18;
            this.label8.Text = "Loan Balance / Payable";
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageActive = null;
            this.btnExcel.Location = new System.Drawing.Point(895, 70);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(53, 48);
            this.btnExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExcel.TabIndex = 16;
            this.btnExcel.TabStop = false;
            this.toolTip1.SetToolTip(this.btnExcel, "Export to Excel");
            this.btnExcel.Zoom = 10;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(50)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(50)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(159)))), ((int)(((byte)(58)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(554, 109);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 27);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(428, 109);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(120, 27);
            this.dtpToDate.TabIndex = 14;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(302, 109);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(120, 27);
            this.dtpFromDate.TabIndex = 14;
            // 
            // cmbSearchEmployee
            // 
            this.cmbSearchEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSearchEmployee.DropDownHeight = 100;
            this.cmbSearchEmployee.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchEmployee.FormattingEnabled = true;
            this.cmbSearchEmployee.IntegralHeight = false;
            this.cmbSearchEmployee.Location = new System.Drawing.Point(38, 109);
            this.cmbSearchEmployee.Name = "cmbSearchEmployee";
            this.cmbSearchEmployee.Size = new System.Drawing.Size(258, 27);
            this.cmbSearchEmployee.TabIndex = 13;
            this.cmbSearchEmployee.Click += new System.EventHandler(this.cmbSearchEmployee_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(425, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 14);
            this.label7.TabIndex = 12;
            this.label7.Text = "To Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(883, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "Export to Excel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(299, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "From Date";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(35, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 14);
            this.label15.TabIndex = 12;
            this.label15.Text = "Issued By";
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
            // panelListContainer
            // 
            this.panelListContainer.Controls.Add(this.dgHistoryDetails);
            this.panelListContainer.Controls.Add(this.label6);
            this.panelListContainer.Location = new System.Drawing.Point(10, 141);
            this.panelListContainer.Name = "panelListContainer";
            this.panelListContainer.Size = new System.Drawing.Size(953, 345);
            this.panelListContainer.TabIndex = 8;
            // 
            // dgHistoryDetails
            // 
            this.dgHistoryDetails.AllowUserToAddRows = false;
            this.dgHistoryDetails.AllowUserToDeleteRows = false;
            this.dgHistoryDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgHistoryDetails.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgHistoryDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgHistoryDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHistoryDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgHistoryDetails.Location = new System.Drawing.Point(0, 46);
            this.dgHistoryDetails.Name = "dgHistoryDetails";
            this.dgHistoryDetails.ReadOnly = true;
            this.dgHistoryDetails.Size = new System.Drawing.Size(953, 299);
            this.dgHistoryDetails.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(953, 46);
            this.label6.TabIndex = 0;
            this.label6.Text = "History List";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(37, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(374, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ALL TRANSACTION OF DAILY CASH AND EMPLOYEES COMMODITY BALANCE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "TRANSACTION HISTORY";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelFormContainer;
            this.bunifuDragControl1.Vertical = true;
            // 
            // TransactionHistory
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(977, 503);
            this.Controls.Add(this.panelFormContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransactionHistory";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransactionHistory";
            this.panelFormContainer.ResumeLayout(false);
            this.panelFormContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panelListContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgHistoryDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormContainer;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Panel panelListContainer;
        private System.Windows.Forms.DataGridView dgHistoryDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.ComboBox cmbSearchEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnSearch;
        private Bunifu.Framework.UI.BunifuImageButton btnExcel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lblTotalAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lblPayable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label7;
    }
}