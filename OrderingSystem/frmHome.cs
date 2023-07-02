using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Image = System.Drawing.Image;
using View = System.Windows.Forms.View;



//todo 排版
namespace OrderingSystem
{
    public partial class frmHome : Form
    {

        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        string strImgDir = @"..\..\ProductImage"; //圖檔路徑
        private DataTable dtCart = new DataTable();  //購物車資料表

        //顯示商品用
        List<int> listProductID = new List<int>();
        List<string> listProductName = new List<string>();
        List<int> listUnitPrice = new List<int>();
        //訂單
        List<string> listItem = new List<string>();

        int selectedQuantity = 0;
        int selectedUnitPrice = 0;
        int ODTotalPrice = 0;
        int OrderTotalPrice = 0;
        string seletedItem = "";
        bool isShipping = false;
        bool isShop = false;
        bool isFirstEvent = false;
        int intDelivery = 0;
        public string MemberName { get; set; }
        public int MemberID { get; set; }


        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "OnlineStore";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString;
            ReadProduct();
            ShowProducts();
            lvProducts.SelectedIndexChanged += lvProducts_SelectedIndexChanged;
            rbtnShop.Checked = true;
            isShop = true;  
            rbtnShipping.Checked = false;
            isShipping = false;
            //lblmemberName.Text = $"Hi,\n{MemberName} !";

            //購物車資料表
            dtCart = new DataTable();
            dtCart.Columns.Add("ProductID", typeof(int));
            dtCart.Columns.Add("ProductName", typeof(string));
            dtCart.Columns.Add("UnitPrice", typeof(int));
            dtCart.Columns.Add("Quantity", typeof(int));
            //dtCart.Columns.Add("odTotalPrice", typeof(int));
            //調整欄寬
            dgvCart.AutoResizeColumns();
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.DataSource = dtCart;
            //lblmemberName.Text = $"Hi,\n{MemberName}";
            calOrderTotalPrice();
        }

        //讀取所有商品資料
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
                Image imgProduct = Image.FromFile(FullImgPath);
                imglistProducts.Images.Add(imgProduct);
                count++;
            }
            reader.Close();
            con.Close();
            Console.WriteLine($"讀取{count}筆數");
        }


        //顯示商品
        void ShowProducts()
        {
            lvProducts.Clear();
            lvProducts.View = View.List;
            imglistProducts.ImageSize = new Size(200, 200); //最大為一開始設定的(256, 256)
            lvProducts.LargeImageList = imglistProducts;
            lvProducts.SmallImageList = imglistProducts;
            //商品資訊-用index
            for (int i = 0; i < listProductID.Count; i++)
            {
                ListViewItem item = new ListViewItem(); // listview的顯示單元
                item.ImageIndex = i; //圖檔索引值對應
                item.Text = $"{listProductName[i]}\nNT{listUnitPrice[i]}"; //文字索引值對應
                item.Font = new Font("Century Gothic", 14, FontStyle.Regular);
                item.Tag = listProductID[i]; //Tag：不顯示但可保留(儲存資訊)－常用來藏id
                lvProducts.Items.Add(item);
            }
            lvProducts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        void calculateTotalPrice()
        {
            if (lvProducts.SelectedItems.Count > 0)
            {
                ODTotalPrice = selectedUnitPrice * selectedQuantity;
            }
            lbODlTotalPrice.Text = $"NT {ODTotalPrice}";
        }

        //全部訂單明細的加總
        void calOrderTotalPrice() 
        {
            if (dgvCart.Rows.Count > 0)
            {
                OrderTotalPrice += ODTotalPrice;
            }
            lblOrderTotalPrice.Text = $"NT {OrderTotalPrice}";
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin(this);
            login.ShowDialog();
            if (!string.IsNullOrEmpty(MemberName))
            {
                btnLogin.Visible = false;
                btnSignup.Visible = false;
                btnSignout.Visible = true;
                lblmemberName.Text = $"Hi,\n{MemberName}";
            }
        }
        private void btnSignout_Click(object sender, EventArgs e)
        {
            lblmemberName.Text = "";
            MemberName = "";
            MemberID = 0;
            btnLogin.Visible = true;
            btnSignup.Visible = true;
            btnSignout.Visible = false;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            selectedQuantity++;
            txtQuantity.Text = selectedQuantity.ToString();
            calculateTotalPrice();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (selectedQuantity > 1)
            {
                selectedQuantity--;
                txtQuantity.Text = selectedQuantity.ToString();
                calculateTotalPrice();
            }
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvProducts.SelectedItems[0];
                int selectedIndex = selectedItem.Index;

                //string productName = listProductName[selectedIndex];
                selectedUnitPrice = listUnitPrice[selectedIndex];
                lblPrice.Text = $"NT {selectedUnitPrice}";
                selectedQuantity = 1;
                txtQuantity.Text = selectedQuantity.ToString();
                calculateTotalPrice();
                // 使用取得的單價和品名稱進行後續處理
                // Console.WriteLine($"選取的商品：{productName}，單價：{unitPrice}");

                // 或將單價和品名稱存儲在全域變量中供其他方法使用
                //selectedUnitPrice = unitPrice;
                // seletedItem = productName;
            }
        }

        private void rbtnShipping_CheckedChanged(object sender, EventArgs e)
        {
            //+60運費
            if (rbtnShipping.Checked && !isShipping)
            {
                OrderTotalPrice += 60;
                lblOrderTotalPrice.Text = $"NT {OrderTotalPrice}";
                isShipping = true;
                isShop = false;
            }
        }
        private void rbtnShop_CheckedChanged(object sender, EventArgs e)
        {
            //不用運費
            if (rbtnShop.Checked && !isShop && isShipping)
            {
                OrderTotalPrice -= 60;
                lblOrderTotalPrice.Text = $"NT {OrderTotalPrice}";
                isShop = true; 
                isShipping = false;
            }
        }
        private void btnCart_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvProducts.SelectedItems[0];
                int selectedIndex = selectedItem.Index;

                int productID = listProductID[selectedIndex];
                string productName = listProductName[selectedIndex];
                int unitPrice = listUnitPrice[selectedIndex];

                // 檢查購物車中是否已經存在相同的品項
                DataRow existingItem = dtCart.AsEnumerable().FirstOrDefault(row => (int)row["ProductID"] == productID);
                if (existingItem != null)
                {
                    // 若存在相同的品項，則增加數量和總價
                    existingItem["Quantity"] = (int)existingItem["Quantity"] + selectedQuantity;
                    //existingItem["odTotalPrice"] = (int)existingItem["odTotalPrice"] + (unitPrice * selectedQuantity);
                }
                else
                {
                    // 若不存在相同的品項，則新增一列
                    DataRow newRow = dtCart.NewRow();
                    newRow["ProductID"] = productID;
                    newRow["ProductName"] = productName;
                    newRow["UnitPrice"] = unitPrice;
                    newRow["Quantity"] = selectedQuantity;
                    dtCart.Rows.Add(newRow);
                }

                // 清空左邊選擇的品項數量和價錢
                lvProducts.SelectedItems.Clear();
                selectedQuantity = 1;
                txtQuantity.Text = selectedQuantity.ToString();
                calOrderTotalPrice();
            }
        }
        private void btnDeleteCart_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvCart.SelectedRows[0].Index;
                dtCart.Rows.RemoveAt(selectedIndex);
                if (isShipping)
                {
                    OrderTotalPrice = 60; // 如果选择了宅配，则运费为60
                }
                else if (isShop)
                {
                    OrderTotalPrice = 0; // 如果选择了店取，则运费为0
                }
                calOrderTotalPrice();
            }
        }

       


        private void btnPurchase_Click(object sender, EventArgs e)
        {
            //有登入才能購買否則被遣返
            if (MemberName != null)
            {
                if ((txtshipName.Text != "") && (txtShipAddr.Text != "") && (dtCart.Rows.Count > 0))
                {
                    //購物車第一筆：新增訂單
                    SqlConnection con = new SqlConnection(strDBConnectionString);
                    con.Open();

                    string sqlOrder = "insert into tbOrders values (@oMemberID, @oTotalPrice, @oOrderDate, @oShipVia, @oShipName, @oAddress);";
                    SqlCommand cmdInsertOrder = new SqlCommand(sqlOrder, con);

                    cmdInsertOrder.Parameters.AddWithValue("@oMemberID", MemberID);
                    int totalPrice = 0;
                    foreach (DataRow row in dtCart.Rows)
                    {
                        int unitPrice = Convert.ToInt32(row["UnitPrice"]);
                        int quantity = Convert.ToInt32(row["Quantity"]);
                        int subTotal = unitPrice * quantity;

                        totalPrice += subTotal;
                    }
                    if (isShipping)  //加運費
                    {
                        totalPrice += 60;
                    }

                    cmdInsertOrder.Parameters.AddWithValue("@oTotalPrice", totalPrice);
                    cmdInsertOrder.Parameters.AddWithValue("@oOrderDate", DateTime.Now);
                    if (isShipping)
                    {
                        cmdInsertOrder.Parameters.AddWithValue("@oShipVia", rbtnShipping.Checked);
                    }
                    else
                    {
                        cmdInsertOrder.Parameters.AddWithValue("@oShipVia", rbtnShop.Checked);
                    }
                    cmdInsertOrder.Parameters.AddWithValue("@oShipName", txtshipName.Text);
                    cmdInsertOrder.Parameters.AddWithValue("@oAddress", txtShipAddr.Text);
                    int rowsInsertOrder= cmdInsertOrder.ExecuteNonQuery();
                    int newOrderID = 0;
                    if (rowsInsertOrder >0) 
                    {
                        //string sqlGetOrderID = "SELECT SCOPE_IDENTITY() From tbOrders;";
                        string sqlGetOrderID = "SELECT MAX(OrderID) FROM tbOrders;";
                        SqlCommand cmdGetOrderID = new SqlCommand(sqlGetOrderID, con);
                        newOrderID = Convert.ToInt32(cmdGetOrderID.ExecuteScalar());
                    }

                    MessageBox.Show($"Thank for your purchase!", "Successfully");
                    Console.WriteLine($"{rowsInsertOrder}筆資料受影響");


                    //新增訂單明細內容
                    string sqlOD = "insert into tbOrderDetail values (@OrderID, @ProductID, @ProductName, @UnitPrice, @Quantity);";
                    SqlCommand cmdInsertOD = new SqlCommand(sqlOD, con);

                    foreach (DataRow row in dtCart.Rows)
                    {
                        int productId = Convert.ToInt32(row["ProductID"]);
                        string productName = Convert.ToString(row["ProductName"]);
                        int unitPrice = Convert.ToInt32(row["UnitPrice"]);
                        int quantity = Convert.ToInt32(row["Quantity"]);

                        cmdInsertOD.Parameters.Clear();
                        cmdInsertOD.Parameters.AddWithValue("@OrderID", newOrderID);
                        cmdInsertOD.Parameters.AddWithValue("@ProductID", productId);
                        cmdInsertOD.Parameters.AddWithValue("@ProductName", productName);
                        cmdInsertOD.Parameters.AddWithValue("@UnitPrice", unitPrice);
                        cmdInsertOD.Parameters.AddWithValue("@Quantity", quantity);

                        int rows2 = cmdInsertOD.ExecuteNonQuery();
                        Console.WriteLine($"訂單明細新增成功，{rows2}筆資料受影響");
                    }
                    con.Close();
                    //清空購物車的 DataTable
                    dtCart.Rows.Clear();
                    OrderTotalPrice = 0;
                    lblOrderTotalPrice.Text = $"NT {OrderTotalPrice}";

                }
                else
                {
                    MessageBox.Show("請確認購物車有內容物且收件人已填妥", "Error");
                }
            }
            else 
            {
                MessageBox.Show("Please log in or sign up.");
                //frmLogin login = new frmLogin(this);    
                //login.ShowDialog();
                //if (!string.IsNullOrEmpty(MemberName))
                //if (MemberName != "")
                //{
                //    btnLogin.Visible = false;
                //    btnSignout.Visible = true;
                //    lblmemberName.Text = $"Hi,\n{MemberName}";
                //}
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            frmSignUp signup= new frmSignUp(this);
            signup.ShowDialog();
        }
    }
}
