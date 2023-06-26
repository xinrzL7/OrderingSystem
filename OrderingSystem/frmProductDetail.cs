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

namespace OrderingSystem
{
    public partial class frmProductDetail : Form
    {

        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        string strImageDir = @"";

        public int selectID = 0;
        string imgEditName = "";
        bool isEditImage = false;
        public frmProductDetail()
        {
            InitializeComponent();
        }

        private void frmProductDetail_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "caneleos";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString;
            if (selectID == 0) //新增模式
            {
                gboxProductNew.Visible = true;
                gboxProductEdit.Visible = false;
            }
            else //修改模式
            {
                gboxProductNew.Visible = false;
                gboxProductEdit.Visible = true;
            }

        }
        void showProductDetail ()
        {
            if (selectID > 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from products where id = @SearchID; ";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", selectID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    txtProductID.Text = reader["id"].ToString();
                    txtProductName.Text = reader["pname"].ToString();
                    txtProductPrice.Text = reader["price"].ToString();
                    txtProductCaption.Text = reader["pdesc"].ToString();
                    imgEditName = reader["pimage"].ToString();
                    string FullPicPath = strImageDir + "\\" + imgEditName;
                    pboxProduct.Image = Image.FromFile(FullPicPath);
                }
                reader.Close();
                con.Close();
            }
        }

    }
}
