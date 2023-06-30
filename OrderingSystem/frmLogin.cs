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

namespace OrderingSystem
{
    public partial class frmLogin : Form
    {
       SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";

        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "OnlineStore";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString;

        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            try
            {
                con.Open();
                string strSQL = "select * from tbMembers where Email = @email and Password = @password";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@email", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Enjoy your shopping time!");
                    frmHome home = new frmHome();
                    string memberName = reader.GetString(reader.GetOrdinal("Name"));
                    int memberID = reader.GetInt32(reader.GetOrdinal("memberID"));
                    home.MemberName = memberName;
                    home.MemberID = memberID;

                    reader.Close();
                    home.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please enter the correct username or password.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
            finally
            {
                if(con != null)
                { 
                    con.Close(); 
                }
                this.Close();
            }
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            //會員表單
        }
    }
}
