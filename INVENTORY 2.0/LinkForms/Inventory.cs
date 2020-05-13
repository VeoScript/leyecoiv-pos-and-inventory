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
    public partial class Inventory : Form
    {
        public Inventory()
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

        private void txtSearchProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SEARCHPRODUCT();
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void SEARCHPRODUCT()
        {
            if (txtSearchProduct.Text == "")
            {
                dgProductsList.DataSource = "";
                txtItemDescription.Text = "";
                txtOnStock.Text = "";
                MessageBox.Show("Enter Product Item Code or Item Description first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    QuerySelect = "SELECT date AS 'DATE', transactionno AS 'Transaction Sequence No.', orderby AS 'Order By', itemcode AS 'Item Code', quantity AS 'Add/Minus Item Quantity', onstock AS 'On Stock', status AS 'Status' FROM Inventory WHERE itemcode = '" + txtSearchProduct.Text + "' OR itemdescription ='" + txtSearchProduct.Text + "' ORDER BY id ASC";

                    con.Close();
                    con.Open();
                    cmd = new SqlCommand(QuerySelect, con);

                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adapter.Fill(dt);

                    dgProductsList.DataSource = dt;
                    dgProductsList.Refresh();

                    con.Close();

                    string QuerySelect2 = "SELECT itemdescription FROM Product WHERE itemcode ='" + txtSearchProduct.Text + "' OR itemdescription ='" + txtSearchProduct.Text + "'";
                    con.Open();
                    cmd = new SqlCommand(QuerySelect2, con);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        txtItemDescription.Text = reader["itemdescription"].ToString();
                        reader.Close();
                    }
                    else
                    {
                        txtItemDescription.Clear();
                    }
                    con.Close();

                    string QuerySelect3 = "SELECT quantity FROM Product WHERE itemcode ='" + txtSearchProduct.Text + "' OR itemdescription ='" + txtSearchProduct.Text + "'";
                    con.Open();
                    cmd = new SqlCommand(QuerySelect3, con);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        txtOnStock.Text = reader["quantity"].ToString();
                        reader.Close();
                    }
                    else
                    {
                        txtOnStock.Clear();
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
                for (j = 0; j < dgProductsList.Columns.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dgProductsList.Columns[j].HeaderText;
                }

                StartRow++;

                //Write datagridview content
                for (i = 0; i < dgProductsList.Rows.Count; i++)
                {
                    for (j = 0; j < dgProductsList.Columns.Count; j++)
                    {
                        try
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = dgProductsList[j, i].Value == null ? "" : dgProductsList[j, i].Value;
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

        private void dgProductsList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int rowscount = dgProductsList.Rows.Count;

            for (int i = 0; i < rowscount; i++)
            {
                if ((dgProductsList.Rows[i].Cells["Status"].Value.ToString() == "ADD STOCK"))
                {
                    dgProductsList.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }

        private void ClearAll()
        {
            txtSearchProduct.Text = "";
            txtSearchProduct.Focus();
            txtItemDescription.Text = "";
            txtOnStock.Text = "";
            dgProductsList.DataSource = "";
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
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

                        if (!txtSearchProduct.Items.Contains(load))
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
    }
}
