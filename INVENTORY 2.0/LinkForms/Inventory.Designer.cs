namespace INVENTORY_2._0.LinkForms
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.panelFormContainer = new System.Windows.Forms.Panel();
            this.btnExcel = new Bunifu.Framework.UI.BunifuImageButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOnStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelListContainer = new System.Windows.Forms.Panel();
            this.dgProductsList = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtSearchProduct = new System.Windows.Forms.ComboBox();
            this.panelFormContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panelListContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFormContainer
            // 
            this.panelFormContainer.BackColor = System.Drawing.Color.White;
            this.panelFormContainer.Controls.Add(this.txtSearchProduct);
            this.panelFormContainer.Controls.Add(this.btnExcel);
            this.panelFormContainer.Controls.Add(this.label5);
            this.panelFormContainer.Controls.Add(this.txtOnStock);
            this.panelFormContainer.Controls.Add(this.label2);
            this.panelFormContainer.Controls.Add(this.txtItemDescription);
            this.panelFormContainer.Controls.Add(this.label8);
            this.panelFormContainer.Controls.Add(this.btnClose);
            this.panelFormContainer.Controls.Add(this.panelListContainer);
            this.panelFormContainer.Controls.Add(this.label4);
            this.panelFormContainer.Controls.Add(this.label1);
            this.panelFormContainer.Controls.Add(this.btnClearSearch);
            this.panelFormContainer.Controls.Add(this.label3);
            this.panelFormContainer.Location = new System.Drawing.Point(2, 2);
            this.panelFormContainer.Name = "panelFormContainer";
            this.panelFormContainer.Size = new System.Drawing.Size(973, 499);
            this.panelFormContainer.TabIndex = 1;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageActive = null;
            this.btnExcel.Location = new System.Drawing.Point(889, 68);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(53, 48);
            this.btnExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExcel.TabIndex = 18;
            this.btnExcel.TabStop = false;
            this.toolTip1.SetToolTip(this.btnExcel, "Export to Excel");
            this.btnExcel.Zoom = 10;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(877, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 14);
            this.label5.TabIndex = 17;
            this.label5.Text = "Export to Excel";
            // 
            // txtOnStock
            // 
            this.txtOnStock.Enabled = false;
            this.txtOnStock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOnStock.Location = new System.Drawing.Point(740, 108);
            this.txtOnStock.Name = "txtOnStock";
            this.txtOnStock.Size = new System.Drawing.Size(116, 27);
            this.txtOnStock.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(740, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "On Stock";
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Enabled = false;
            this.txtItemDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemDescription.Location = new System.Drawing.Point(453, 108);
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(281, 27);
            this.txtItemDescription.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(450, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 14);
            this.label8.TabIndex = 12;
            this.label8.Text = "Item Description";
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
            this.panelListContainer.Controls.Add(this.dgProductsList);
            this.panelListContainer.Controls.Add(this.label6);
            this.panelListContainer.Location = new System.Drawing.Point(10, 141);
            this.panelListContainer.Name = "panelListContainer";
            this.panelListContainer.Size = new System.Drawing.Size(953, 345);
            this.panelListContainer.TabIndex = 8;
            // 
            // dgProductsList
            // 
            this.dgProductsList.AllowUserToAddRows = false;
            this.dgProductsList.AllowUserToDeleteRows = false;
            this.dgProductsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProductsList.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgProductsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgProductsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProductsList.Location = new System.Drawing.Point(0, 46);
            this.dgProductsList.Name = "dgProductsList";
            this.dgProductsList.ReadOnly = true;
            this.dgProductsList.Size = new System.Drawing.Size(953, 299);
            this.dgProductsList.TabIndex = 1;
            this.dgProductsList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgProductsList_CellFormatting);
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
            this.label6.Text = "Inventory List";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(34, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ON STOCK AVAILABLE IN STORE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "INVENTORY";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnClearSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnClearSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnClearSearch.Image")));
            this.btnClearSearch.ImageActive = null;
            this.btnClearSearch.Location = new System.Drawing.Point(326, 107);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(34, 31);
            this.btnClearSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClearSearch.TabIndex = 4;
            this.btnClearSearch.TabStop = false;
            this.btnClearSearch.Zoom = 10;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(17, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Search Product Item Code / Description";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelFormContainer;
            this.bunifuDragControl1.Vertical = true;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearchProduct.DropDownHeight = 120;
            this.txtSearchProduct.DropDownWidth = 130;
            this.txtSearchProduct.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProduct.IntegralHeight = false;
            this.txtSearchProduct.ItemHeight = 23;
            this.txtSearchProduct.Location = new System.Drawing.Point(20, 107);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(307, 31);
            this.txtSearchProduct.Sorted = true;
            this.txtSearchProduct.TabIndex = 19;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            this.txtSearchProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchProduct_KeyDown);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(977, 503);
            this.Controls.Add(this.panelFormContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.panelFormContainer.ResumeLayout(false);
            this.panelFormContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panelListContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormContainer;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Panel panelListContainer;
        private System.Windows.Forms.DataGridView dgProductsList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnClearSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOnStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuImageButton btnExcel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtSearchProduct;
    }
}