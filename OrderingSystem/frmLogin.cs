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


//todo 排版
namespace OrderingSystem
{
    public partial class frmLogin : Form
    {
       SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";

        frmHome home;
        public frmLogin(frmHome home)
        {
            InitializeComponent();
            this.home = home;
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "OnlineStore";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString;
        }


        //是否為管理員
        bool chkAdim(string adname, string adpassword) 
        { 
            SqlConnection con = new SqlConnection(strDBConnectionString);
            try
            {
                con.Open();
                string SQLselect = "select * from tbAdmin where  AdminName = @adname and Password = @adpassword;";
                SqlCommand cmdSelect = new SqlCommand(SQLselect, con);
                cmdSelect.Parameters.AddWithValue("@adname", adname);
                cmdSelect.Parameters.AddWithValue("@adpassword",adpassword);
                SqlDataReader reader = cmdSelect.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error"+ex);
                return false;
            }
            finally 
            { 
                con.Close(); 
            }
        } 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            try
            {
                con.Open();

                bool isAdmin = chkAdim(txtEmail.Text, txtPassword.Text);
                if (isAdmin)
                {
                    frmAdmin ad = new frmAdmin();
                    this.Hide();  // 隱藏 frmLogin 表單
                    ad.ShowDialog();
                }
                else
                {
                    string strSQL = "select * from tbMembers where Email = @email and Password = @password";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string memberName = reader.GetString(reader.GetOrdinal("Name"));
                        int memberID = reader.GetInt32(reader.GetOrdinal("memberID"));
                        reader.Close();

                        MessageBox.Show("Enjoy your shopping time!", "Successfully");
                        home.MemberName = memberName;
                        home.MemberID = memberID;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please enter the correct username or password.", "Error");
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
