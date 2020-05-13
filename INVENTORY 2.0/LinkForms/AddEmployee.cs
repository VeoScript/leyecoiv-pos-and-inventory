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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            EmployeesListLoader();
        }

        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchEmployee.Text == "")
            {
                EmployeesListLoader();
            }
            else
            {
                con.Open();
                QuerySelect = "SELECT lastname AS 'Last Name', firstname AS 'First Name', middlename AS 'Middle Name'FROM Employees WHERE lastname LIKE '" + txtSearchEmployee.Text + "%' ORDER BY id DESC";
                cmd = new SqlCommand(QuerySelect, con);

                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);

                dgEmployeeList.DataSource = dt;
                dgEmployeeList.Refresh();

                con.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtLastname.Text == "")
            {
                MessageBox.Show("Please enter Last Name first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastname.Focus();
            }
            else if (txtFirstname.Text == "")
            {
                MessageBox.Show("Please enter First Name first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstname.Focus();
            }
            else
            {
                try
                {
                    QuerySelect = "SELECT * FROM Employees WHERE lastname='" + txtLastname.Text + "' AND firstname='" + txtFirstname.Text + "' AND middlename='" + txtMiddlename.Text + "'";

                    con.Close();
                    con.Open();
                    cmd = new SqlCommand(QuerySelect, con);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("This Employee has already registered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtLastname.Focus();
                        ClearAll();
                    }
                    else
                    {
                        con.Close();

                        QueryInsert = "INSERT INTO Employees(lastname, firstname, middlename) VALUES('" + txtLastname.Text + "', '" + txtFirstname.Text + "', '" + txtMiddlename.Text + "')";

                        con.Open();
                        cmd = new SqlCommand(QueryInsert, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Registered Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtLastname.Focus();
                        ClearAll();
                        EmployeesListLoader();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtLastname.Text == "")
            {
                MessageBox.Show("Select employee on the table list first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtFirstname.Text == "")
            {
                MessageBox.Show("Select employee on the table list first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    con.Close();
                    con.Open();
                    QueryUpdate = "UPDATE Employees SET lastname='" + txtLastname.Text + "', firstname='" + txtFirstname.Text + "', middlename='" + txtMiddlename.Text + "' WHERE id='" + lblItemID.Text + "'";
                    cmd = new SqlCommand(QueryUpdate, con);
                    cmd.ExecuteNonQuery();
                    ClearAll();
                    EmployeesListLoader();
                    MessageBox.Show("Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    MessageBox.Show("This Employee is already exist. Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtLastname.Text == "")
            {
                MessageBox.Show("Select employee on the table list first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtLastname.Text == "")
            {
                MessageBox.Show("Select employee on the table list first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    con.Open();
                    QueryDelete = "DELETE FROM Employees WHERE id='" + lblItemID.Text + "'";
                    cmd = new SqlCommand(QueryDelete, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    ClearAll();
                    EmployeesListLoader();
                    MessageBox.Show("Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void ClearAll()
        {
            txtLastname.Text = "";
            txtFirstname.Text = "";
            txtMiddlename.Text = "";
            txtLastname.Focus();
        }

        public void EmployeesListLoader()
        {
            con.Close();
            con.Open();
            QuerySelect = "SELECT lastname AS 'Last Name', firstname AS 'First Name', middlename AS 'Middle Name'FROM Employees ORDER BY id DESC";
            cmd = new SqlCommand(QuerySelect, con);

            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            dgEmployeeList.DataSource = dt;
            dgEmployeeList.Refresh();

            con.Close();
        }

        private void dgEmployeeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgEmployeeList.Rows[e.RowIndex];
                //Admin Form Control
                txtLastname.Text = row.Cells[0].Value.ToString();
                txtFirstname.Text = row.Cells[1].Value.ToString();
                txtMiddlename.Text = row.Cells[2].Value.ToString();

                con.Close();
                con.Open();
                QuerySelect = "SELECT id FROM Employees WHERE lastname='" + txtLastname.Text + "'";
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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearchEmployee.Clear();
        }

        private void txtLastname_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnAdd_Click((object)sender, (EventArgs)e);
            }
        }
    }
}
