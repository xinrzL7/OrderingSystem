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
using System.Xml.Linq;

//todo 排版
namespace OrderingSystem
{
    public partial class frmMemberInfo : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        List<int> searchResultIDs = new List<int>();


        public frmMemberInfo()
        {
            InitializeComponent();
        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "OnlineStore";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString;

            
            cboxSearch.Items.Add("Name");
            cboxSearch.Items.Add("Phone");
            cboxSearch.Items.Add("Email");
            cboxSearch.Items.Add("Address");
            cboxSearch.SelectedIndex = 0;

            dgvMemberShow();

        }

        void dgvMemberShow()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select memberID, Name, Birth, Phone, Email, Password, Address from tbMembers;";
            SqlCommand cmd = new SqlCommand(@strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(reader); //把讀取到的資料丟到dt這個表
                dgvMemberAll.DataSource = dt; //控制相dgv的資料來源為dt
            }
            reader.Close();
            con.Close();
        }
        void ClearAll()
        {
            txtMemberID.Clear();
            txtMemberName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtPassword.Clear();
            dtpBirth.Value = DateTime.Now;
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select * from tbMembers;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string strMsg = "";
            int count = 0;
            while (reader.Read() == true)
            {
                int ID = Convert.ToInt32(reader["memberID"]);
                string Name = reader["Name"].ToString();
                DateTime Birth = Convert.ToDateTime(reader["Birth"]);
                string Phone = reader["Birth"].ToString();
                string Email = reader["Phone"].ToString();
                string Password = reader["Password"].ToString();
                string Address = reader["Email"].ToString();
                strMsg += $"{ID} , {Name}, {Birth}, {Phone}, {Email}, {Password}, {Address}\n";
                count++;
            }
            strMsg += $"Records：{count}";

            reader.Close();
            con.Close();
            MessageBox.Show(strMsg, "Records");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(txtMemberID.Text, out intID);
            if ((intID > 0) && (txtMemberName.Text != "") && (txtPhone.Text != "") && (txtPhone.Text.Length == 10))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = $"update tbMembers set Name = @updateName, Birth = @updateBD, Phone = @updatePhone, Email = @updateEmail, Password = @updatePW , Address = @updateAddress where memberID =@searchID; ";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@searchID", intID);
                cmd.Parameters.AddWithValue("@updateName", txtMemberName.Text);
                cmd.Parameters.AddWithValue("@updateBD", dtpBirth.Value);
                cmd.Parameters.AddWithValue("@updatePhone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@updateEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@updatePW", txtPassword.Text);
                cmd.Parameters.AddWithValue("@updateAddress", txtAddress.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"會員資料已修改，{rows}筆資料受影響");
                dgvMemberShow();
            }
            else
            {
                MessageBox.Show("請確認輸入正確的電話號碼（10碼）", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dgvMemberAll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) //列index 
            {
                string strSelectedID = dgvMemberAll.Rows[e.RowIndex].Cells[0].Value.ToString();
                int selectedID = 0;
                Int32.TryParse(strSelectedID, out selectedID);
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = $"select * from tbMembers where memberID = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", selectedID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtMemberID.Text = reader["memberID"].ToString();
                    txtMemberName.Text = reader["Name"].ToString();
                    dtpBirth.Value = Convert.ToDateTime(reader["Birth"]);
                    txtPhone.Text = reader["Phone"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    txtPassword.Text = reader["Password"].ToString();
                    txtAddress.Text = reader["Address"].ToString();
                }
                else
                {
                    MessageBox.Show("No such person.", "Try Again");
                    ClearAll();
                }
                reader.Close();
                con.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearAll();
            dgvMemberShow();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if ((txtMemberName.Text != "") && (txtPhone.Text != "") && (txtPassword.Text != "") && (txtEmail.Text != "") && (txtAddress.Text != ""))
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
                string birthdate = dtpBirth.Value.ToString("MMdd");
                string phoneLastFour = txtPhone.Text.Length >= 4 ? txtPhone.Text.Substring(txtPhone.Text.Length - 4) : "";
                string passwordCondition = birthdate + phoneLastFour;
                if (txtPassword.Text != passwordCondition)
                {
                    con.Close();
                    MessageBox.Show("密碼條件不符合，請依照生日日期後4碼+手機後4碼的格式輸入密碼","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                string strSQL = "insert into tbMembers values (@newName, @newBD, @newPhone, @newEmail, @newPassword, @newAddress);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@newName", txtMemberName.Text);
                cmd.Parameters.AddWithValue("@newBD", dtpBirth.Value);
                cmd.Parameters.AddWithValue("@newPhone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@newEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@newPassword", txtPassword.Text);
                cmd.Parameters.AddWithValue("@newAddress", txtAddress.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"會員資料新增成功，{rows}筆資料受影響");
                dgvMemberShow();
            }
            else
            {
                MessageBox.Show("姓名和電話必填！");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("確認刪除此筆資料？", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (R == DialogResult.Yes)
            {
                int intID = 0;
               
                if (Int32.TryParse(txtMemberID.Text, out intID) && intID > 0)
                {
                    SqlConnection con = new SqlConnection(strDBConnectionString);
                    con.Open();

                    // 刪除相關的訂單資料
                    string deleteOrdersSQL = "DELETE FROM tbOrders WHERE memberID = @MemberID";
                    SqlCommand deleteOrdersCmd = new SqlCommand(deleteOrdersSQL, con);
                    deleteOrdersCmd.Parameters.AddWithValue("@MemberID", intID);
                    deleteOrdersCmd.ExecuteNonQuery();

                    string strSQL = "delete from tbMembers where memberID = @DeleteID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@DeleteID", intID);
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();

                    ClearAll();
                    dgvMemberShow();
                    MessageBox.Show($"會員資料刪除成功，{rows}筆資料受影響");

                    
                }
                else
                {
                    MessageBox.Show("請輸入有效的會員ID！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void lboxResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxResult.SelectedIndex >= 0)
            {
                int selectedID = searchResultIDs[lboxResult.SelectedIndex];

                if (txtKeyword.Text != "")
                {
                    SqlConnection con = new SqlConnection(strDBConnectionString);
                    con.Open();
                    string strSQL = $"select * from tbMembers where memberID = @SearchID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", selectedID);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        txtMemberID.Text = reader["memberID"].ToString();
                        txtMemberName.Text = reader["Name"].ToString();
                        dtpBirth.Value = Convert.ToDateTime(reader["Birth"]);
                        txtPhone.Text = reader["Phone"].ToString();
                        txtEmail.Text = reader["Email"].ToString();
                        txtPassword.Text = reader["Password"].ToString();
                        txtAddress.Text = reader["Address"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("查無此人！","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        ClearAll();
                    }
                    reader.Close();
                    con.Close();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if ((txtKeyword.Text != "") || ((dtpBirthStart.Value != null) && (dtpBirthEnd.Value != null)))
            {
                lboxResult.Items.Clear();
                searchResultIDs.Clear();  
                string strCBOXsearch = cboxSearch.SelectedItem.ToString().ToLower();
                //string sqlSearchID = "select * from tbMembers where memberID = @searchID;";

                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();

                string strSQL = $"select * from tbMembers where (Birth between @BirthStart and @BirthEnd) and {strCBOXsearch} like @searchKeyword;";
                
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@searchKeyword", $"%{txtKeyword.Text}%");
                cmd.Parameters.AddWithValue("@BirthStart", dtpBirthStart.Value);
                cmd.Parameters.AddWithValue("@BirthEnd", dtpBirthEnd.Value);
                
                SqlDataReader reader = cmd.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    searchResultIDs.Add((int)reader["memberID"]);
                    lboxResult.Items.Add($"{reader["memberID"]}  {reader["Name"]}");
                    count++;
                }
                if (count == 0)
                    MessageBox.Show("查無此人！", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入其他搜尋條件！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}

