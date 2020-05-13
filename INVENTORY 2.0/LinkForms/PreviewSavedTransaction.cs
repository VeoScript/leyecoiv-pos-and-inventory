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

namespace INVENTORY_2._0.LinkForms
{
    public partial class PreviewSavedTransaction : Form
    {
        public PreviewSavedTransaction()
        {
            InitializeComponent();
        }

        public static SqlConnection con = new SqlConnection(UCF.ConString);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataTable dt = new DataTable();
        public static string QuerySelect;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearchCommodityNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSearchCommodityNo.Text == "")
                {
                    MessageBox.Show("Empty Commodity Number! Enter first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSearchCommodityNo.Focus();
                }
                else
                {
                    QuerySelect = "SELECT itemcode AS 'Item Code', itemdescription AS 'Item Description', quantity AS 'Quantity', price AS 'Price' FROM transactionhistory WHERE comodity = '" + txtSearchCommodityNo.Text + "'";
                    string QuerySelect2 = "SELECT cashier, amountpay, totalamount, date, employee, status FROM transactionhistory WHERE comodity = '" + txtSearchCommodityNo.Text + "'";

                    con.Open();
                    cmd = new SqlCommand(QuerySelect, con);

                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adapter.Fill(dt);

                    listOfOrders.DataSource = dt;
                    listOfOrders.Refresh();
                    con.Close();

                    con.Open();
                    cmd = new SqlCommand(QuerySelect2, con);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        txtIssueBy.Text = reader["employee"].ToString();
                        txtAmountPay.Text = reader["amountpay"].ToString();
                        lblDateOfTransaction.Text = reader["date"].ToString();
                        lblStatus.Text = reader["status"].ToString();
                        txtTotalAmount.Text = reader["totalamount"].ToString();
                        lblCashier.Text = reader["cashier"].ToString();
                        reader.Close();
                    }
                    else
                    {
                        ClearAll();
                        MessageBox.Show("No Record Found! Try Again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSearchCommodityNo.Focus();
                    }
                    con.Close();
                }
            }
        }

        private void ClearAll()
        {
            txtSearchCommodityNo.Text = "";
            txtIssueBy.Text = "";
            txtTotalAmount.Text = "";
            txtAmountPay.Text = "";
            lblDateOfTransaction.Text = "-- -- --";
            lblStatus.Text = "-- -- --";
            lblCashier.Text = "-- -- --";
            txtSearchCommodityNo.Focus();
            listOfOrders.DataSource = "";
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            if (txtSearchCommodityNo.Text == "")
            {
                MessageBox.Show("Search Transaction/Recipt No. First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearchCommodityNo.Focus();
            }
            else if (txtIssueBy.Text == "")
            {
                MessageBox.Show("Search Transaction/Recipt No. First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearchCommodityNo.Focus();
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
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int y = 120;
            
            var format = new StringFormat() {Alignment = StringAlignment.Far};

            e.Graphics.DrawString("DATE : " + lblDateOfTransaction.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(5, 90));

            foreach (DataRow row in dt.Rows)
            {
                double qty = Convert.ToDouble(row["Quantity"]);
                double price = Convert.ToDouble(row["Price"]);
                double total = qty * price;

                e.Graphics.DrawString(row["Quantity"].ToString(), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(5, y));
                e.Graphics.DrawString(row["Price"].ToString(), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(40, y));
                e.Graphics.DrawString(row["Item Description"].ToString(), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(100, y));
                e.Graphics.DrawString(total.ToString("0.00"), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(350, y), format);
                y = y + 15;
            }

            e.Graphics.DrawString("------------------------------------------------------------------------", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, y));
            y = y + 15;
            e.Graphics.DrawString("TOTAL", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(5, y));
            e.Graphics.DrawString(txtTotalAmount.Text + ".00", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(350, y), format);
            y = y + 15;
            y = y + 20;
            e.Graphics.DrawString("CASHIER : " + lblCashier.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(5, y));
            y = y + 15;
            y = y + 10;
            e.Graphics.DrawString("Applied by : " + txtIssueBy.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(5, y));
        }
    }
}
