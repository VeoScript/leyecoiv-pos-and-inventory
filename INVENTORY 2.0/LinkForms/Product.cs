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
    public partial class Product : Form
    {
        public Product()
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

        public string getQty;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            txtDisplayDate.Text = string.Format("{0:M/d/yyyy}", date);
        }

        private void Product_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            ProductsListLoader();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearchProduct.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ADDPRODUCT();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UPDATEPRODUCT();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DELETEPRODUCT();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchProduct.Text == "")
            {
                ProductsListLoader();
            }
            else
            {
                con.Open();
                QuerySelect = "SELECT itemcode AS 'Item Code', itemdescription AS 'Item Description', quantity AS 'Quantity', price AS 'Price' FROM Product WHERE itemcode like'%" + txtSearchProduct.Text + "%' OR itemdescription like'" + txtSearchProduct.Text + "%' ORDER BY id DESC";
                cmd = new SqlCommand(QuerySelect, con);

                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);

                dgProductsList.DataSource = dt;
                dgProductsList.Refresh();

                con.Close();
            }
        }

        public void ClearAll()
        {
            txtItemCode.Text = "";
            txtItemDescription.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            lblResultQuantity.Text = "0";
            lblQuantity.Text = "0";

            txtItemCode.Focus();
        }

        public void ProductsListLoader()
        {
            con.Close();
            con.Open();
            QuerySelect = "SELECT itemcode AS 'Item Code', itemdescription AS 'Item Description', quantity AS 'Quantity', price AS 'Price' FROM Product ORDER BY id DESC";
            cmd = new SqlCommand(QuerySelect, con);

            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            dgProductsList.DataSource = dt;
            dgProductsList.Refresh();

            con.Close();
        }

        //CODE FOR ADDING PRODUCT TO THE DATABASE

        private void ADDPRODUCT()
        {
            if (txtItemCode.Text == "")
            {
                MessageBox.Show("Enter Item Code first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtItemCode.Focus();
            }
            else if (txtItemDescription.Text == "")
            {
                MessageBox.Show("Enter Item Description first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtItemDescription.Focus();
            }
            else if (txtQuantity.Text == "")
            {
                MessageBox.Show("Enter Quantity first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
            }
            else if (txtPrice.Text == "")
            {
                MessageBox.Show("Enter Item Price first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
            }
            else
            {
                try
                {
                    con.Close();
                    con.Open();
                    QuerySelect = "SELECT * FROM Product WHERE itemcode='" + txtItemCode.Text + "' OR itemdescription='" + txtItemDescription.Text + "'";
                    cmd = new SqlCommand(QuerySelect, con);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        getQty = reader["quantity"].ToString();
                        reader.Close();

                        con.Close();

                        int qty = Convert.ToInt32(getQty);
                        int newqty = Convert.ToInt32(txtQuantity.Text);
                        int result = newqty + qty;

                        QueryUpdate = "UPDATE Product SET quantity='" + result + "', price='" + txtPrice.Text + "' WHERE itemcode='" + txtItemCode.Text + "'";
                        con.Open();
                        cmd = new SqlCommand(QueryUpdate, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        ProductsListLoader();
                        InsertInventory();
                        ClearAll();
                        MessageBox.Show("Product Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        con.Close();
                        con.Open();
                        QueryInsert = "INSERT INTO Product(itemcode, itemdescription, quantity, price) VALUES('" + txtItemCode.Text + "', '" + txtItemDescription.Text + "', '" + txtQuantity.Text + "', '" + txtPrice.Text + "')";
                        cmd = new SqlCommand(QueryInsert, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        ProductsListLoader();
                        InsertInventory();
                        ClearAll();
                        MessageBox.Show("Product Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UPDATEPRODUCT()
        {
            if(txtItemCode.Text == "")
            {
                MessageBox.Show("Select product on the table list first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txtItemDescription.Text == "")
            {
                MessageBox.Show("Select product on the table list first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtQuantity.Text == "")
            {
                MessageBox.Show("Select product on the table list first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPrice.Text == "")
            {
                MessageBox.Show("Select product on the table list first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    con.Close();
                    con.Open();
                    QueryUpdate = "UPDATE Product SET itemcode='" + txtItemCode.Text + "', itemdescription='" + txtItemDescription.Text + "', quantity='" + txtQuantity.Text + "', price='" + txtPrice.Text + "' WHERE id='" + lblItemID.Text + "'";
                    cmd = new SqlCommand(QueryUpdate, con);
                    cmd.ExecuteNonQuery();
                    UpdateInventory();
                    ProductsListLoader();
                    ClearAll();
                    MessageBox.Show("Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    MessageBox.Show("This Product is already exist. Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DELETEPRODUCT()
        {
            if (txtItemCode.Text == "")
            {
                MessageBox.Show("Select product on the table list first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtItemDescription.Text == "")
            {
                MessageBox.Show("Select product on the table list first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtQuantity.Text == "")
            {
                MessageBox.Show("Select product on the table list first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPrice.Text == "")
            {
                MessageBox.Show("Select product on the table list first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    con.Close();
                    con.Open();
                    QueryDelete = "DELETE FROM Product WHERE id='" + lblItemID.Text + "'";
                    cmd = new SqlCommand(QueryDelete, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DeleteInventory();
                    ProductsListLoader();
                    ClearAll();
                    MessageBox.Show("Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //END PRODUCT CODE



        //CODE FOR ADDING INVENTORY TO THE DATABASE

        private void InsertInventory()
        {
            try
            {
                QueryInsert = "INSERT INTO Inventory(itemcode, itemdescription, price, quantity, onstock, date, status) VALUES('" + txtItemCode.Text + "', '" + txtItemDescription.Text + "', '" + txtPrice.Text + "', '" + txtQuantity.Text + "', '" + lblResultQuantity.Text + "', '" + txtDisplayDate.Text + "', 'ADD STOCK')";

                con.Close();
                con.Open();
                cmd = new SqlCommand(QueryInsert, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateInventory()
        {
            try
            {
                QueryUpdate = "UPDATE Inventory SET itemcode='" + txtItemCode.Text + "', itemdescription='" + txtItemDescription.Text + "', price='" + txtPrice.Text + "' WHERE itemcode='" + txtItemCode.Text + "'";

                con.Close();
                con.Open();
                cmd = new SqlCommand(QueryUpdate, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteInventory()
        {
            try
            {
                QueryDelete = "DELETE FROM Inventory WHERE itemcode='" + txtItemCode.Text + "'";

                con.Close();
                con.Open();
                cmd = new SqlCommand(QueryDelete, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //END INVENTORY CODE

        private void dgProductsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgProductsList.Rows[e.RowIndex];
                //Admin Form Control
                txtItemCode.Text = row.Cells[0].Value.ToString();
                txtItemDescription.Text = row.Cells[1].Value.ToString();
                txtQuantity.Text = row.Cells[2].Value.ToString();
                lblQuantity.Text = row.Cells[2].Value.ToString();
                txtPrice.Text = row.Cells[3].Value.ToString();

                con.Close();
                con.Open();
                QuerySelect = "SELECT id FROM Product WHERE itemcode='" + txtItemCode.Text + "'";
                cmd = new SqlCommand(QuerySelect, con);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    lblItemID.Text = reader["id"].ToString();
                    reader.Close();
                }
                con.Close();
            }

            try
            {
                int qty = Convert.ToInt32(txtQuantity.Text);
                int getqty = Convert.ToInt32(lblQuantity.Text);
                int resultqty = 0;

                resultqty = qty + getqty;

                lblResultQuantity.Text = resultqty.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtQuantity.Text == "")
                {
                    lblResultQuantity.Text = "0";
                }
                else
                {
                    int qty = Convert.ToInt32(txtQuantity.Text);
                    int getqty = Convert.ToInt32(lblQuantity.Text);
                    int resultqty = 0;

                    resultqty = qty + getqty;

                    lblResultQuantity.Text = resultqty.ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtItemCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtItemCode.Text == "")
                {
                    MessageBox.Show("Empty Item Code Fill Up First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtItemCode.Focus();
                    ClearAll();
                }
                else
                {
                    try
                    {
                        QuerySelect = "SELECT id, itemdescription, price, quantity FROM Product WHERE itemcode = '" + txtItemCode.Text + "'";

                        con.Close();
                        con.Open();
                        cmd = new SqlCommand(QuerySelect, con);
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Read();
                            lblItemID.Text = reader["id"].ToString();
                            txtItemDescription.Text = reader["itemdescription"].ToString();
                            txtQuantity.Text = reader["quantity"].ToString();
                            lblQuantity.Text = reader["quantity"].ToString();
                            txtPrice.Text = reader["price"].ToString();
                            reader.Close();
                        }
                        else
                        {
                            txtItemCode.Focus();
                            ClearAll();
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    try
                    {
                        int qty = Convert.ToInt32(txtQuantity.Text);
                        int getqty = Convert.ToInt32(lblQuantity.Text);
                        int resultqty = 0;

                        resultqty = qty + getqty;

                        lblResultQuantity.Text = resultqty.ToString();
                    }
                    catch (Exception ex)
                    {

                    }

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

        private void txtItemDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnAdd_Click((object)sender, (EventArgs)e);
            }
        }
    }
}
