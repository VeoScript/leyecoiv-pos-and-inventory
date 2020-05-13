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
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }

        public static SqlConnection con = new SqlConnection(UCF.ConString);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static string QueryInsert;
        public static string QuerySelect;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbAccountType.SelectedIndex < 0)
            {
                MessageBox.Show("Select Account Type First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbAccountType.Focus();
            }
            else if (txtAccountName.Text == "")
            {
                MessageBox.Show("Enter Account Name First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAccountName.Focus();
            }
            else if (txtAccountUsername.Text == "")
            {
                MessageBox.Show("Enter Username Name First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAccountUsername.Focus();
            }
            else if (txtAccountPassword.Text == "")
            {
                MessageBox.Show("Enter Password First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAccountPassword.Focus();
            }
            else if (txtAccountPassword.Text != txtRePassword.Text)
            {
                MessageBox.Show("The Password that you does not match! Try again...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAccountPassword.Focus();
                txtAccountPassword.Text = "";
                txtRePassword.Text = "";
            }
            else
            {
                try
                {
                    QuerySelect = "SELECT * FROM UserAccount WHERE name='" + txtAccountName.Text + "' OR username='" + txtAccountUsername.Text + "'";

                    con.Open();
                    cmd = new SqlCommand(QuerySelect, con);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("This Account is already registered!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ClearAll();
                    }
                    else
                    {
                        con.Close();

                        QueryInsert = "INSERT INTO UserAccount(name, accounttype, username, password) VALUES ('" + txtAccountName.Text + "', '" + cmbAccountType.SelectedItem + "', '" + txtAccountUsername.Text + "', '" + txtAccountPassword.Text + "')";

                        con.Open();
                        cmd = new SqlCommand(QueryInsert, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Account Registered Successully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ClearAll()
        {
            cmbAccountType.SelectedIndex = -1;
            txtAccountName.Text = "";
            txtAccountUsername.Text = "";
            txtAccountPassword.Text = "";
            txtRePassword.Text = "";
            txtAccountName.Focus();
        }
    }
}
