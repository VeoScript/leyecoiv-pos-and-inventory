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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static SqlConnection con = new SqlConnection(UCF.ConString);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static string QueryInsert;
        public static string QuerySelect;
        public static string GetUserAccountID;
        public static string GetUserAccountType;
        public static string GetUserAccountName;
        public static string GetUserAccountUsername;

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearAll()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void linkAboutDeveloper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkForms.AboutSystem asys = new LinkForms.AboutSystem();
            asys.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            lblTime.Text = time.ToString("h:mm:ss tt");

            DateTime date = DateTime.Now;
            lblDate.Text = string.Format("{0:D}", date);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Enter your Username first", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Enter your Password first", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
            }
            else
            {
                try
                {
                    QuerySelect = "SELECT * FROM UserAccount WHERE username='" + txtUsername.Text + "' AND password='" + txtPassword.Text + "'";
                    con.Close();
                    con.Open();
                    cmd = new SqlCommand(QuerySelect, con);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        GetUserAccountID = reader["id"].ToString();
                        GetUserAccountType = reader["accounttype"].ToString();
                        GetUserAccountName = reader["name"].ToString();
                        GetUserAccountUsername = reader["username"].ToString();
                        Home h = new Home();
                        h.Show();
                        ClearAll();
                        reader.Close();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Account! Try Again...", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click((object)sender, (EventArgs)e);
            }
        }
    }
}
