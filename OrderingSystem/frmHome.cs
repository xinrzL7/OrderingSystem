using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingSystem
{
    public partial class frmHome : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        string strImgDir = @"..\..\ProductImage"; //圖檔路徑

        //list
        List<string> listCategories = new List<string>();
        List<string> listProductName = new List<string>();
        List<int> listUnitPrice = new List<int>();
        List<int> listProductID = new List<int>();

        string selectedCategory = ""; 

        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            scsb.DataSource =  @".";
            scsb.InitialCatalog = "OnlineStore";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString;
            ReadProduct();
            ShowProducts();
        }
        void ReadProduct()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select * from tbProducts;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            int count = 0;
            //資料庫的資料傳到list裡
            while (reader.Read() == true)
            {
                listProductID.Add((int)reader["ProductID"]);
                listProductName.Add((string)reader["ProductName"]);
                listUnitPrice.Add((int)reader["UnitPrice"]);
                string ProductImgName = (string)reader["ProductImage"];
                string FullImgPath = Path.Combine(strImgDir, ProductImgName);   
                Image ProImg = Image.FromFile(FullImgPath);
                imglistTop.Images.Add(ProImg);
                count++;
            }
            reader.Close();
            con.Close();
            Console.WriteLine($"讀取{count}筆數");
        }
        void ShowProducts()
        {
            lvProducts.Clear(); 
            lvProducts.View = View.LargeIcon; 
            imglistTop.ImageSize = new Size(150, 150); 
            lvProducts.LargeImageList = imglistTop;
            lvProducts.SmallImageList = imglistTop;
            //商品資訊-用index
            for (int i = 0; i < imglistTop.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem(); // listview的顯示單元
                item.ImageIndex = i; //圖檔索引值對應
                item.Text = $"{listProductName[i]}\nNT {listUnitPrice[i]}"; //文字索引值對應
                item.Font = new Font("Century Gothic", 14, FontStyle.Regular);
                item.Tag = listProductID[i]; //Tag：不顯示但可保留(儲存資訊)－常用來藏id
                lvProducts.Items.Add(item);
            }
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCategory = listCategories[cboxCategories.SelectedIndex];
            lvProducts.Items.Clear();
        }
    }
}
