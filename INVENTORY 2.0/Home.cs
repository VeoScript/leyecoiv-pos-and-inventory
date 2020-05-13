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

namespace INVENTORY_2._0
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        public static SqlConnection con = new SqlConnection(UCF.ConString);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataTable dt = new DataTable();
        public static string QueryInsert;
        public static string QuerySelect;
        public static string QueryUpdate;
        public static string QueryDelete;

        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            ColumnsLoader();
            listOfOrders.Columns[5].Visible = false;

            if (cmbEmployee.Text == "CASH")
            {
                cmbTransactionStatus.Items.Clear();
                cmbTransactionStatus.Items.Add("Cash");
            }
            else
            {

                cmbTransactionStatus.Items.Clear();
                cmbTransactionStatus.Items.Add("Cash");
                cmbTransactionStatus.Items.Add("Loan");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            txtDisplayDate.Text = string.Format("{0:M/d/yyyy}", date);
            lblGetAccountType.Text = Login.GetUserAccountType.ToString();
            lblCashier.Text = Login.GetUserAccountName.ToString();

            if (lblGetAccountType.Text == "USER")
            {
                btnAddAccount.Enabled = false;
            }
            else
            {
                btnAddAccount.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            LinkForms.Product p = new LinkForms.Product();
            p.ShowDialog();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            LinkForms.Inventory i = new LinkForms.Inventory();
            i.ShowDialog();
        }

        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            LinkForms.TransactionHistory th = new LinkForms.TransactionHistory();
            th.ShowDialog();
        }

        private void btnPreviewSavedTransaction_Click(object sender, EventArgs e)
        {
            LinkForms.PreviewSavedTransaction pst = new LinkForms.PreviewSavedTransaction();
            pst.ShowDialog();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            LinkForms.AddEmployee ae = new LinkForms.AddEmployee();
            ae.ShowDialog();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            LinkForms.AddAccount aa = new LinkForms.AddAccount();
            aa.ShowDialog();
        }

        private void btnMyAccount_Click(object sender, EventArgs e)
        {
            LinkForms.MyAccount ma = new LinkForms.MyAccount();
            ma.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            LinkForms.AboutSystem asys = new LinkForms.AboutSystem();
            asys.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt.Columns.Clear();
            Close();

            Login l = new Login();
            l.Show();
        }

        public void EmployeeLoader()
        {
            try
            {
                QuerySelect = "SELECT lastname, firstname, middlename FROM Employees ORDER BY lastname ASC";

                con.Open();
                cmd = new SqlCommand(QuerySelect, con);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    cmbEmployee.Items.Clear();
                    cmbEmployee.Items.Add("CASH");
                    while (reader.Read())
                    {
                        string load = reader["lastname"].ToString() + ", " + reader["firstname"].ToString() + " " + reader["middlename"].ToString();
                        cmbEmployee.Items.Add(load);
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ProdcutsLoader()
        {
            try
            {
                QuerySelect = "SELECT itemdescription FROM Product WHERE itemdescription LIKE '%" + txtSearchProduct.Text + "%' ORDER BY id ASC";

                con.Open();
                cmd = new SqlCommand(QuerySelect, con);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string load = reader["itemdescription"].ToString();
                        
                        if(!txtSearchProduct.Items.Contains(load))
                        {
                            txtSearchProduct.Items.Add(load);
                        }
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ColumnsLoader()
        {
            dt.Rows.Clear();
            //Code ni para sa pag Load ug Columns sa DataGrid(Table)
            dt.Columns.Add("Item Code", typeof(string)).ReadOnly = true;
            dt.Columns.Add("Item Description", typeof(string)).ReadOnly = true;
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Price", typeof(float)).ReadOnly = true;
            dt.Columns.Add("Sub Total", typeof(float));
            dt.Columns.Add("Remaining Quantity", typeof(int));

            listOfOrders.DataSource = dt;
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchProduct.Text == "")
            {
                txtDisplayItemCode.Text = "";
                txtDisplayItemDescription.Text = "";
                lblInStocks.Text = "0";
                txtDisplayPrice.Text = "";
                txtSearchProduct.Items.Clear();
            }
            else
            {
                ProdcutsLoader();
                try
                {
                    con.Close();
                    con.Open();
                    QuerySelect = "SELECT itemcode, itemdescription, quantity, price FROM Product WHERE itemcode ='" + txtSearchProduct.Text + "' OR itemdescription LIKE'%" + txtSearchProduct.Text + "%'";
                    cmd = new SqlCommand(QuerySelect, con);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        txtDisplayItemCode.Text = reader["itemcode"].ToString();
                        txtDisplayItemDescription.Text = reader["itemdescription"].ToString();
                        lblInStocks.Text = reader["quantity"].ToString();
                        txtDisplayPrice.Text = reader["price"].ToString();
                        reader.Close();
                    }
                    else
                    {
                        txtDisplayItemCode.Text = "";
                        txtDisplayItemDescription.Text = "";
                        lblInStocks.Text = "0";
                        txtDisplayPrice.Text = "";
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDisplayItemCode.Text == "")
                {
                    MessageBox.Show("Please Seacrh Product First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSearchProduct.Focus();
                }
                else if (txtDisplayItemDescription.Text == "")
                {
                    MessageBox.Show("Please Seacrh Product First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSearchProduct.Focus();
                }
                else if (txtDisplayQuantity.Text == "")
                {
                    txtDisplayQuantity.Text = "1";
                    MessageBox.Show("Invalid Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtDisplayPrice.Text == "")
                {
                    MessageBox.Show("Please Seacrh Product First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSearchProduct.Focus();
                }
                else if (System.Text.RegularExpressions.Regex.IsMatch(txtDisplayQuantity.Text, "[^0-9]"))
                {
                    txtDisplayQuantity.Text = "1";
                    MessageBox.Show("Invalid Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    DataRow[] rows = dt.Select(string.Format("[item code]='{0}'", txtDisplayItemCode.Text));
                    DataRow item;

                    int qty = Convert.ToInt32(txtDisplayQuantity.Text);
                    double price = Convert.ToDouble(txtDisplayPrice.Text);
                    double instock = Convert.ToInt32(lblInStocks.Text);
                    int result = 0;
                    double remainingqty = 0;

                    if (rows.Count() > 0)
                    {
                        item = rows[0];
                        int orderqty = Convert.ToInt32(item["quantity"]);
                        result = orderqty + qty;
                    }

                    if (result > instock)
                    {
                        MessageBox.Show("You reached the limit of quantity of this product, Try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtAmountPay.Text = "";
                        txtChanged.Text = "";
                    }
                    else if (qty > instock)
                    {
                        MessageBox.Show("You reached the limit of quantity of this product, Try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtAmountPay.Text = "";
                        txtChanged.Text = "";
                    }
                    else
                    {
                        if (rows.Count() > 0)
                        {
                            item = rows[0];
                            int eqty = Convert.ToInt32(item["quantity"]);
                            double remaining = Convert.ToInt32(item["remaining quantity"]);
                            eqty = eqty + qty;
                            remaining = instock - eqty;
                            item["quantity"] = eqty;
                            item["sub total"] = eqty * price;
                            item["remaining quantity"] = remaining;
                            dt.AcceptChanges();
                        }
                        else
                        {
                            if (txtDisplayItemDescription.Text.Length > 13)
                            {
                                item = dt.NewRow();
                                item["item code"] = txtDisplayItemCode.Text;
                                item["item description"] = txtDisplayItemDescription.Text.Substring(0, 13);
                                item["quantity"] = txtDisplayQuantity.Text;
                                item["price"] = price.ToString("#,0.00");
                                item["sub total"] = qty * price;
                                item["remaining quantity"] = instock - qty;
                                dt.Rows.Add(item);
                            }
                            else
                            {
                                item = dt.NewRow();
                                item["item code"] = txtDisplayItemCode.Text;
                                item["item description"] = txtDisplayItemDescription.Text;
                                item["quantity"] = txtDisplayQuantity.Text;
                                item["price"] = price.ToString("#,0.00");
                                item["sub total"] = qty * price;
                                item["remaining quantity"] = instock - qty;
                                dt.Rows.Add(item);
                            }
                        }

                        double totalamount = 0;
                        totalamount = Convert.ToDouble(dt.Compute("sum([sub total])", ""));
                        lblTotalAmount.Text = "P" + totalamount.ToString("#,0.00");
                        lblOverAllPayment.Text = totalamount.ToString("0.00");
                    }

                    txtSearchProduct.Focus();
                    txtDisplayItemCode.Text = "";
                    txtDisplayItemDescription.Text = "";
                    txtDisplayQuantity.Text = "1";
                    lblInStocks.Text = "0";
                    txtDisplayPrice.Text = "";

                    lblCountItems.Text = listOfOrders.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearchProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSearchProduct.Text == "")
                {
                    MessageBox.Show("Search Product First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtDisplayItemCode.Text = "";
                    txtDisplayItemDescription.Text = "";
                    lblInStocks.Text = "0";
                    txtDisplayPrice.Text = "";
                }
                else
                {
                    btnAdd_Click((object)sender, (EventArgs)e);
                    txtSearchProduct.Text = ""; txtDisplayItemCode.Text = "";
                    txtDisplayItemDescription.Text = "";
                    lblInStocks.Text = "0";
                    txtDisplayPrice.Text = "";
                }
            }
        }

        private void txtDisplayQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click((object)sender, (EventArgs)e);
            }
        }

        private void listOfOrders_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int qty = Convert.ToInt32(listOfOrders[e.ColumnIndex, e.RowIndex].Value.ToString());
            double instock = Convert.ToInt32(lblInStocks.Text);

            if (qty > instock)
            {
                txtAmountPay.Text = "";
                txtChanged.Text = "";
                MessageBox.Show("You reached the limit of quantity of this product, Try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listOfOrders[e.ColumnIndex, e.RowIndex].Value = 1;

                if (e.RowIndex > -1)
                {
                    DataGridViewRow row = listOfOrders.Rows[e.RowIndex];
                    int quantity = int.Parse(row.Cells[2].Value.ToString());
                    double price = double.Parse(row.Cells[3].Value.ToString());
                    double result;
                    row.Cells[4].Value = quantity * price;
                    row.Cells[5].Value = instock;
                }

                int totalamount = 0;
                for (int i = 0; i < listOfOrders.Rows.Count; ++i)
                {
                    totalamount += Convert.ToInt32(listOfOrders.Rows[i].Cells[4].Value);
                }

                lblTotalAmount.Text = "P" + totalamount.ToString("#,0.00");
                lblOverAllPayment.Text = totalamount.ToString("0.00");
                txtAmountPay.Text = "";
                txtChanged.Text = "";
            }
            else
            {
                if (e.RowIndex > -1)
                {
                    DataGridViewRow row = listOfOrders.Rows[e.RowIndex];
                    int quantity = int.Parse(row.Cells[2].Value.ToString());
                    double price = double.Parse(row.Cells[3].Value.ToString());
                    double result;
                    row.Cells[4].Value = quantity * price;
                    row.Cells[5].Value = instock - qty;
                }

                int totalamount = 0;
                for (int i = 0; i < listOfOrders.Rows.Count; ++i)
                {
                    totalamount += Convert.ToInt32(listOfOrders.Rows[i].Cells[4].Value);
                }

                lblTotalAmount.Text = "P" + totalamount.ToString("#,0.00");
                lblOverAllPayment.Text = totalamount.ToString("0.00");
                txtAmountPay.Text = "";
                txtChanged.Text = "";
            }
        }

        private void listOfOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row;
                row = listOfOrders.Rows[e.RowIndex];

                txtDisplayItemCode.Text = row.Cells["Item Code"].Value.ToString();
                txtDisplayItemDescription.Text = row.Cells["Item Description"].Value.ToString();
                txtDisplayPrice.Text = row.Cells["Price"].Value.ToString();
            }

            try
            {
                con.Open();
                QuerySelect = "SELECT quantity FROM Product WHERE itemcode='" + txtDisplayItemCode.Text + "'";
                cmd = new SqlCommand(QuerySelect, con);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    lblInStocks.Text = reader["quantity"].ToString();
                    reader.Close();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in listOfOrders.SelectedCells)
            {
                if (oneCell.Selected)
                    listOfOrders.Refresh();
                listOfOrders.Rows.RemoveAt(oneCell.RowIndex);
                dt.AcceptChanges();
            }

            int totalamount = 0;
            for (int i = 0; i < listOfOrders.Rows.Count; ++i)
            {
                totalamount += Convert.ToInt32(listOfOrders.Rows[i].Cells[4].Value);
            }

            lblTotalAmount.Text = "P" + totalamount.ToString() + "." + "00";

            lblOverAllPayment.Text = totalamount.ToString();
            txtAmountPay.Text = "";
            txtChanged.Text = "";
            txtSearchProduct.Focus();
            lblCountItems.Text = listOfOrders.Rows.Count.ToString();
            listOfOrders.Refresh();
        }

        private void txtAmountPay_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (lblOverAllPayment.Text == "Your Payment")
                {
                    MessageBox.Show("Empty Order, Try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAmountPay.Focus();
                }
                else if (txtAmountPay.Text == "")
                {
                    MessageBox.Show("Please enter Amount Pay first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAmountPay.Focus();
                }
                else
                {
                    try
                    {
                        double totalamount = Convert.ToDouble(lblOverAllPayment.Text);
                        double amountpay = Convert.ToDouble(txtAmountPay.Text);
                        double changed = 0;

                        changed = amountpay - totalamount;

                        if (amountpay < totalamount)
                        {
                            MessageBox.Show("Not enough Amounts Pay. Try Again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtAmountPay.Focus();
                            txtAmountPay.Text = "";
                        }
                        else
                        {
                            txtChanged.Text = changed.ToString("#,0.00");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnPrintSaveTransaction_Click(object sender, EventArgs e)
        {
            listOfOrders.Refresh();

            if (cmbTransactionStatus.SelectedItem == "Loan")
            {
                if (cmbEmployee.Text == "")
                {
                    MessageBox.Show("Please select Employee first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbEmployee.Focus();
                }
                else if (lblOverAllPayment.Text == "Your Payment" || lblTotalAmount.Text == "P0.00")
                {
                    MessageBox.Show("Can't Save Please Complete Transaction First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDisplayItemCode.Focus();
                }
                else if (cmbTransactionStatus.SelectedIndex < 0)
                {
                    MessageBox.Show("Select Transaction Status First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbTransactionStatus.Focus();
                }
                else if (txtCommodity.Text == "")
                {
                    MessageBox.Show("Enter Commodity or DCR Number first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbTransactionStatus.Focus();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Print a receipt?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        printDialog1.Document = printDocument1;

                        try
                        {
                            printDocument1.Print();

                            QuerySelect = "SELECT * FROM TransactionHistory WHERE comodity='" + txtCommodity.Text + "'";

                            con.Close();
                            con.Open();
                            cmd = new SqlCommand(QuerySelect, con);
                            reader = cmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                MessageBox.Show("This transaction has already saved! Try again!", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                DialogResult result2 = MessageBox.Show("Do you want Save this Transaction?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                if (result2 == DialogResult.OK)
                                {
                                    for (int i = 0; i < listOfOrders.Rows.Count; i++)
                                    {
                                        listOfOrders.Refresh();

                                        con.Close();

                                        QueryInsert = "INSERT INTO TransactionHistory(comodity, employee, date, amountpay, totalamount, itemcode, itemdescription, quantity, getquantity, price, subtotal, status, cashier) VALUES('" + txtCommodity.Text + "', '" + cmbEmployee.Text + "', '" + txtDisplayDate.Text + "', '" + txtAmountPay.Text + "', '" + lblOverAllPayment.Text + "', '" + listOfOrders.Rows[i].Cells["Item Code"].Value + "', '" + listOfOrders.Rows[i].Cells["Item Description"].Value + "', '" + listOfOrders.Rows[i].Cells["Quantity"].Value + "', '" + listOfOrders.Rows[i].Cells["Remaining Quantity"].Value + "', '" + listOfOrders.Rows[i].Cells["Price"].Value + "', '" + listOfOrders.Rows[i].Cells["Sub Total"].Value + "', '" + cmbTransactionStatus.SelectedItem + "', '" + lblCashier.Text + "')";

                                        con.Open();
                                        cmd = new SqlCommand(QueryInsert, con);
                                        cmd.ExecuteNonQuery();
                                    }

                                    for (int i = 0; i < listOfOrders.Rows.Count; i++)
                                    {
                                        listOfOrders.Refresh();

                                        con.Close();

                                        QueryInsert = "INSERT INTO Inventory(transactionno, orderby, date, itemcode, itemdescription, price, onstock, quantity, status) VALUES('" + txtCommodity.Text + "', '" + cmbEmployee.Text + "', '" + txtDisplayDate.Text + "', '" + listOfOrders.Rows[i].Cells["Item Code"].Value + "', '" + listOfOrders.Rows[i].Cells["Item Description"].Value + "', '" + listOfOrders.Rows[i].Cells["Price"].Value + "', '" + listOfOrders.Rows[i].Cells["Remaining Quantity"].Value + "', '" + listOfOrders.Rows[i].Cells["Quantity"].Value + "', 'TRANSACT')";
                                        con.Open();
                                        cmd = new SqlCommand(QueryInsert, con);
                                        cmd.ExecuteNonQuery();
                                    }

                                    con.Close();
                                    UpdateInventoryStocks();
                                    txtSearchProduct.Focus();
                                    ClearAll();
                                }
                            }
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {

                    }
                }
            }
            else
            {
                if (cmbEmployee.Text == "")
                {
                    MessageBox.Show("Please select Employee first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbEmployee.Focus();
                }
                else if (txtAmountPay.Text == "")
                {
                    MessageBox.Show("Enter Amount Pay First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAmountPay.Focus();
                }
                else if (lblOverAllPayment.Text == "Your Payment" || lblTotalAmount.Text == "P0.00")
                {
                    MessageBox.Show("Can't Save Please Complete Transaction First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDisplayItemCode.Focus();
                }
                else if (cmbTransactionStatus.SelectedIndex < 0)
                {
                    MessageBox.Show("Select Transaction Status First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbTransactionStatus.Focus();
                }
                else if (txtCommodity.Text == "")
                {
                    MessageBox.Show("Enter Commodity or DCR Number first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbTransactionStatus.Focus();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Print a receipt", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        printDialog1.Document = printDocument1;

                        try
                        {
                            printDocument1.Print();

                            QuerySelect = "SELECT * FROM TransactionHistory WHERE comodity='" + txtCommodity.Text + "'";

                            con.Close();
                            con.Open();
                            cmd = new SqlCommand(QuerySelect, con);
                            reader = cmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                MessageBox.Show("This transaction has already saved! Try again!", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                //ClearAll();
                            }
                            else
                            {
                                DialogResult result2 = MessageBox.Show("Do you want Save this Transaction?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                if (result2 == DialogResult.OK)
                                {
                                    for (int i = 0; i < listOfOrders.Rows.Count; i++)
                                    {
                                        listOfOrders.Refresh();

                                        con.Close();

                                        QueryInsert = "INSERT INTO TransactionHistory(comodity, employee, date, amountpay, totalamount, itemcode, itemdescription, quantity, getquantity, price, subtotal, status, cashier) VALUES('" + txtCommodity.Text + "', '" + cmbEmployee.Text + "', '" + txtDisplayDate.Text + "', '" + txtAmountPay.Text + "', '" + lblOverAllPayment.Text + "', '" + listOfOrders.Rows[i].Cells["Item Code"].Value + "', '" + listOfOrders.Rows[i].Cells["Item Description"].Value + "', '" + listOfOrders.Rows[i].Cells["Quantity"].Value + "', '" + listOfOrders.Rows[i].Cells["Remaining Quantity"].Value + "', '" + listOfOrders.Rows[i].Cells["Price"].Value + "', '" + listOfOrders.Rows[i].Cells["Sub Total"].Value + "',  '" + cmbTransactionStatus.SelectedItem + "', '" + lblCashier.Text + "')";
                                        con.Open();
                                        cmd = new SqlCommand(QueryInsert, con);
                                        cmd.ExecuteNonQuery();
                                    }

                                    for (int i = 0; i < listOfOrders.Rows.Count; i++)
                                    {
                                        listOfOrders.Refresh();

                                        con.Close();

                                        QueryInsert = "INSERT INTO Inventory(transactionno, orderby, date, itemcode, itemdescription, price, onstock, quantity, status) VALUES('" + txtCommodity.Text + "', '" + cmbEmployee.Text + "', '" + txtDisplayDate.Text + "', '" + listOfOrders.Rows[i].Cells["Item Code"].Value + "', '" + listOfOrders.Rows[i].Cells["Item Description"].Value + "', '" + listOfOrders.Rows[i].Cells["Price"].Value + "', '" + listOfOrders.Rows[i].Cells["Remaining Quantity"].Value + "', '" + listOfOrders.Rows[i].Cells["Quantity"].Value + "', 'TRANSACT')";
                                        con.Open();
                                        cmd = new SqlCommand(QueryInsert, con);
                                        cmd.ExecuteNonQuery();
                                    }
                                    con.Close();
                                    UpdateInventoryStocks();
                                    txtSearchProduct.Focus();
                                    ClearAll();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {

                    }
                }
            }
        }

        private void cmbEmployee_Click(object sender, EventArgs e)
        {
            EmployeeLoader();

            cmbTransactionStatus.SelectedIndex = -1;

            if (cmbEmployee.Text == "CASH")
            {
                cmbTransactionStatus.Items.Clear();
                cmbTransactionStatus.Items.Add("Cash");
            }
            else
            {

                cmbTransactionStatus.Items.Clear();
                cmbTransactionStatus.Items.Add("Cash");
                cmbTransactionStatus.Items.Add("Loan");
            }
        }

        public void ClearAll()
        {
            txtSearchProduct.Text = "";
            txtDisplayItemCode.Text = "";
            txtDisplayItemDescription.Text = "";
            txtDisplayQuantity.Text = "1";
            txtDisplayPrice.Text = "";
            lblInStocks.Text = "0";
            cmbTransactionStatus.SelectedIndex = -1; txtAmountPay.Text = "";
            txtChanged.Text = "";
            cmbEmployee.Text = "CASH";
            lblTotalAmount.Text = "P0.00";
            txtCommodity.Text = "";
            lblCountItems.Text = "0";
            dt.Clear();
        }

        private void UpdateInventoryStocks()
        {

            try
            {
                for (int i = 0; i < listOfOrders.Rows.Count; i++)
                {
                    con.Close();
                    QueryUpdate = "UPDATE Product SET quantity='" + listOfOrders.Rows[i].Cells["Remaining Quantity"].Value + "' WHERE itemcode='" + listOfOrders.Rows[i].Cells["Item Code"].Value + "'";
                    con.Open();
                    cmd = new SqlCommand(QueryUpdate, con);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int y = 120;

            var format = new StringFormat() {Alignment = StringAlignment.Far};

            e.Graphics.DrawString("DATE : " + txtDisplayDate.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(5, 90));

            foreach (DataRow row in dt.Rows)
            {
                double qty = Convert.ToDouble(row["Quantity"]);
                double price = Convert.ToDouble(row["Price"]);
                double total = qty * price;

                e.Graphics.DrawString(row["Quantity"].ToString(), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(5, y));
                e.Graphics.DrawString(row["Price"].ToString(), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(40, y));
                e.Graphics.DrawString(row["Item Description"].ToString(), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(100, y));
                e.Graphics.DrawString(total.ToString("0.00"), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(350, y), format);
                y = y + 18;
            }

            e.Graphics.DrawString("------------------------------------------------------------------------", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, y));
            y = y + 15;
            e.Graphics.DrawString("TOTAL", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(5, y));
            e.Graphics.DrawString(lblTotalAmount.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(350, y), format);
            y = y + 15;
            y = y + 20;
            e.Graphics.DrawString("CASHIER : " + lblCashier.Text, new Font("Aria", 11, FontStyle.Regular), Brushes.Black, new Point(5, y));
            y = y + 15;
            y = y + 10;
            e.Graphics.DrawString("Applied by : " + cmbEmployee.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(5, y));
        }

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmployee.Text == "CASH")
            {
                cmbTransactionStatus.Items.Clear();
                cmbTransactionStatus.Items.Add("Cash");
            }
            else
            {

                cmbTransactionStatus.Items.Clear();
                cmbTransactionStatus.Items.Add("Cash");
                cmbTransactionStatus.Items.Add("Loan");
            }
        }

        private void btnCancelTransaction_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
