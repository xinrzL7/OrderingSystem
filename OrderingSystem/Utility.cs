using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingSystem
{
    internal class Utility
    { }
    public class MemberService
    {
        // 驗證會員是否存在的方法
        public bool ValidateMember(string email, string password)
        {
            // 使用ADO.NET進行資料庫查詢，檢查會員資料表是否存在該用戶名和密碼的記錄
            // 假設資料庫連接字串存儲在App.config或Web.config檔案中
            string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string strSQL = "SELECT COUNT(*) FROM tbMembers WHERE Email = @Email  AND Password = @Password";
                SqlCommand command = new SqlCommand(strSQL, con);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                int count = (int)command.ExecuteScalar();

                // 如果記錄數大於0，表示驗證成功
                return count > 0;
            }
        }
    }

}
