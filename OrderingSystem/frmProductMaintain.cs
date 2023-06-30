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
    public partial class frmProductMaintain : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();

        List<int> listPid = new List<int>();
        List<string> listProductName = new List<string>();
        List<int> listPrice = new List<int>();

        string strDBConnectionString = "";
        string strImageDir = @"";

        public frmProductMaintain()
        {
            InitializeComponent();
        }

        private void frmProductMaintain_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "caneleos";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString;
        }

        void readProductDB()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select * from products;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            int count = 0;
            //資料庫的資料傳到list裡
            while (reader.Read() == true)
            {
                listPid.Add((int)reader["id"]);
                listProductName.Add((string)reader["pname"]);
                listPrice.Add((int)reader["price"]);
                string imageName = (string)reader["pimage"];
                string FullProPicPath = strImageDir + "\\" + imageName;       //路徑+檔名
                Image imgProduct = Image.FromFile(FullProPicPath);
                imglistProducts.Images.Add(imgProduct);
                count++;
            }
            reader.Close();
            con.Close();
            Console.WriteLine($"讀取{count}筆數");
        }

        void showProductPicrture()
        {
            lvShowProduct.Clear(); 
            lvShowProduct.View = View.LargeIcon; //LargeIcon(文字在圖下方), SmallIcon(文字在圖右方), List, 
            imglistProducts.ImageSize = new Size(200, 200); //最大為一開始設定的(256, 256)
            lvShowProduct.LargeImageList = imglistProducts;
            lvShowProduct.SmallImageList = imglistProducts;  //建議可用於商品數量多時(min: 30x30)
            //商品資訊-用index
            for (int i = 0; i < imglistProducts.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem(); // listview的顯示單元
                item.ImageIndex = i; //圖檔索引值對應
                item.Text = $"{listProductName[i]} {listPrice[i]}元"; //文字索引值對應
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Tag = listPid[i]; //Tag：不顯示但可保留(儲存資訊)－常用來藏id
                lvShowProduct.Items.Add(item);
            }
        }
        void showProductList()
        {
            lvShowProduct.Clear();
            lvShowProduct.LargeImageList = null;
            lvShowProduct.SmallImageList = null;
            lvShowProduct.View = View.Details;

            //顯示的欄位
            lvShowProduct.Columns.Add("id", 100);
            lvShowProduct.Columns.Add("商品名稱", 200);
            lvShowProduct.Columns.Add("商品價格", 100);
            lvShowProduct.GridLines = true; //分隔線
            lvShowProduct.FullRowSelect = true;

            for (int i = 0; i < listPid.Count; i++)  //可用其他list...，因為數量相對應 
            {
                ListViewItem listItem = new ListViewItem();
                listItem.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                listItem.Tag = listPid[i];
                listItem.Text = listPid[i].ToString(); //第一欄是text
                listItem.SubItems.Add(listProductName[i]);        //第二欄
                listItem.SubItems.Add(listPrice[i].ToString());
                listItem.ForeColor = Color.DarkBlue;
                listItem.BackColor = Color.DarkGray;

                lvShowProduct.Items.Add(listItem);
            }
        }

        private void btnPicMode_Click(object sender, EventArgs e)
        {
            showProductPicrture();
        }

        private void btnListMode_Click(object sender, EventArgs e)
        {
            showProductList();
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            frmProductDetail proDetail = new frmProductDetail();
            proDetail.ShowDialog();
        }
        void RefreshData()
        {
            //先把資料清空再重新讀取
            listPid.Clear();
            listProductName.Clear();
            listPrice.Clear();
            imglistProducts.Images.Clear();
            readProductDB();

            if (lvShowProduct.View == View.Details)
            {
                showProductList();
            }
            else
            {
                showProductPicrture();
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void lvShowProduct_ItemActivate(object sender, EventArgs e)
        {
            frmProductDetail proDetail = new frmProductDetail();
            proDetail.selectID = (int)lvShowProduct.SelectedItems[0].Tag; //因為先前已把id藏在Tag，型態是object所以要轉型
            proDetail.ShowDialog();
        }
    }
}
