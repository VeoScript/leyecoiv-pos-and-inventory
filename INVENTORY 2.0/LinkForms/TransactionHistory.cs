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
    public partial class TransactionHistory : Form
    {
        public TransactionHistory()
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

        public void ClearAll()
        {
            lblPayable.Text = "0";
            lblTotalAmount.Text = "0";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbSearchEmployee.Text == "")
            {
                MessageBox.Show("Please select Employee first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSearchEmployee.Focus();
            }
            else
            {
                HistoryListLoader();
                try
                {
                    QuerySelect = "SELECT SUM(subtotal) AS 'Payable' FROM TransactionHistory WHERE employee='" + cmbSearchEmployee.SelectedItem + "' AND status='Loan' AND (date>='" + dtpFromDate.Text + "' AND date<='" + dtpToDate.Text + "')";

                    con.Open();
                    cmd = new SqlCommand(QuerySelect, con);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        lblPayable.Text = reader["Payable"].ToString();
                        reader.Close();
                    }
                    else
                    {
                        ClearAll();
                    }
                    con.Close();

                    QuerySelect = "SELECT SUM(subtotal) AS 'Cash' FROM TransactionHistory WHERE employee='" + cmbSearchEmployee.SelectedItem + "' AND status='Cash' AND (date>='" + dtpFromDate.Text + "' AND date<='" + dtpToDate.Text + "')";

                    con.Open();
                    cmd = new SqlCommand(QuerySelect, con);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        lblTotalAmount.Text = reader["Cash"].ToString();
                        reader.Close();
                    }
                    else
                    {
                        ClearAll();
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cmbSearchEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                QuerySelect = "SELECT lastname, firstname, middlename FROM Employees ORDER BY lastname ASC";

                con.Open();
                cmd = new SqlCommand(QuerySelect, con);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    cmbSearchEmployee.Items.Clear();
                    cmbSearchEmployee.Items.Add("CASH");
                    while (reader.Read())
                    {
                        string load = reader["lastname"].ToString() + ", " + reader["firstname"].ToString() + " " + reader["middlename"].ToString();
                        cmbSearchEmployee.Items.Add(load);
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void HistoryListLoader()
        {
            con.Close();
            con.Open();
            QuerySelect = "SELECT comodity AS 'Sequence No.', date AS 'Date', itemcode AS 'Item Code', itemdescription AS 'Item Description', quantity AS 'Quantity', price AS 'Price', subtotal AS 'Amount', status AS 'Status' FROM TransactionHistory WHERE employee='" + cmbSearchEmployee.Text + "' AND (date>='" + dtpFromDate.Text + "' AND date<='" + dtpToDate.Text + "') ORDER BY date ASC";
            cmd = new SqlCommand(QuerySelect, con);

            adapter = new SqlDataAdapter(cmd);
            con.Close();

            dt = new DataTable();
            adapter.Fill(dt);

            dgHistoryDetails.DataSource = dt;
            dgHistoryDetails.Refresh();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (cmbSearchEmployee.Text == "")
            {
                MessageBox.Show("Please select Employee first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSearchEmployee.Focus();
            }
            else
            {
                dgHistoryDetails.Refresh();
                ExportToExcel();
            }

        }

        private void ExportToExcel()
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];

            try
            {
                int StartCol = 1;
                int StartRow = 1;
                int j = 0, i = 0;

                //Write Headers
                for (j = 0; j < dgHistoryDetails.Columns.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                    Microsoft.Office.Interop.Excel.Range myRange1 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + 8];
                    Microsoft.Office.Interop.Excel.Range myRange2 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + 1, StartCol + 8];
                    myRange.Value2 = dgHistoryDetails.Columns[j].HeaderText;
                    myRange1.Value2 = label8.Text + " = " + lblPayable.Text;
                    myRange2.Value2 = label5.Text + " = " + lblTotalAmount.Text;
                }

                StartRow++;

                //Write datagridview content
                for (i = 0; i < dgHistoryDetails.Rows.Count; i++)
                {
                    for (j = 0; j < dgHistoryDetails.Columns.Count; j++)
                    {
                        try
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = dgHistoryDetails[j, i].Value == null ? "" : dgHistoryDetails[j, i].Value;
                        }
                        catch
                        {
                            ;
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }
    }
}
