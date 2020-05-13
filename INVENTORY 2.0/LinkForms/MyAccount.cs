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
    public partial class MyAccount : Form
    {
        public MyAccount()
        {
            InitializeComponent();
        }

        public static SqlConnection con = new SqlConnection(UCF.ConString);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static string QueryUpdate;
        public static string QuerySelect;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtAccountName.Text == "")
            {
                //
            }
            else if (txtAccountUsername.Text == "")
            {
                //
            }
            else if (txtAccountPassword.Text == "")
            {
                //
            }
            else
            {
                try
                {
                    QueryUpdate = "UPDATE UserAccount SET name='" + txtAccountName.Text + "', username='" + txtAccountUsername.Text + "', password='" + txtAccountPassword.Text + "' WHERE id='" + lblID.Text + "'";

                    con.Open();
                    cmd = new SqlCommand(QueryUpdate, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblID.Text = Login.GetUserAccountID.ToString();
        }

        private void MyAccount_Load(object sender, EventArgs e)
        {
            try
            {
                QuerySelect = "SELECT * FROM UserAccount WHERE id='" + Login.GetUserAccountID.ToString() + "'";

                con.Open();
                cmd = new SqlCommand(QuerySelect, con);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    cmbAccountType.Text = reader["accounttype"].ToString();
                    txtAccountName.Text = reader["name"].ToString();
                    txtAccountUsername.Text = reader["username"].ToString();
                    txtAccountPassword.Text = reader["password"].ToString();
                    lblPassword.Text = reader["password"].ToString();
                    reader.Close();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            timer1.Enabled = true;
        }
    }
}
