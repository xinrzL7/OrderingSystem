using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OrderingSystem
{
    public partial class frmSignUp : Form
    {

        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        frmHome home;
        public frmSignUp(frmHome home)
        {
            InitializeComponent();
            this.home=home;
        }
        private void frmSignUp_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "OnlineStore";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString;
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            if ((txtMemberName.Text != "") && (txtEmail.Text != "") && (txtPhone.Text != "") && (txtAddress.Text != "") && (txtPassword.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();

                // 檢查是否有重複的 Email
                string SQLchkEmail = "select count(*) from tbMembers where Email = @newEmail;";
                SqlCommand cmdChkEmail = new SqlCommand(SQLchkEmail, con);
                cmdChkEmail.Parameters.AddWithValue("@newEmail", txtEmail.Text);
                int emailCount = (int)cmdChkEmail.ExecuteScalar();
                if (emailCount > 0)
                {
                    con.Close();
                    MessageBox.Show("該 Email 已被使用，請選擇其他 Email");
                    return;
                }

                // 檢查是否有重複的密碼
                string SQLchkPassword = "select count(*) from tbMembers where Password = @newPassword";
                SqlCommand cmdChkPassword = new SqlCommand(SQLchkPassword, con);
                cmdChkPassword.Parameters.AddWithValue("@newPassword", txtPassword.Text);
                int passwordCount = (int)cmdChkPassword.ExecuteScalar();
                if (passwordCount > 0)
                {
                    con.Close();
                    MessageBox.Show("該密碼已被使用，請選擇其他密碼");
                    return;
                }

                // 檢查密碼條件：生日日期4碼 + 手機後4碼
                string birthdate= dtpBirth.Value.ToString("MMdd");
                string phoneLastFour = txtPhone.Text.Length >= 4 ? txtPhone.Text.Substring(txtPhone.Text.Length - 4) : "";
                string passwordCondition = birthdate + phoneLastFour;
                if (txtPassword.Text != passwordCondition)
                {
                    con.Close();
                    MessageBox.Show("密碼條件不符合，請依照生日日期後4碼+手機後4碼的格式輸入密碼");
                    return;
                }
                string strSQL = "insert into tbMembers values (@newName, @newBirth, @newPhone, @newEmail, @newPassword,  @newAddress)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@newName", txtMemberName.Text);
                cmd.Parameters.AddWithValue("@newBirth", dtpBirth.Value);
                cmd.Parameters.AddWithValue("@newPhone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@newEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@newPassword", txtPassword.Text);
                cmd.Parameters.AddWithValue("@newAddress", txtAddress.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"會員資料新增成功");
                Console.WriteLine($"{rows}筆資料受影響");
            }
            else
            {
                MessageBox.Show("資料皆必填！");
            }
            home.Show();
            this.Close();
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
