﻿using System;
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
    public partial class frmProductDetail : Form
    {

        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        string strImgDir = @"..\..\ProductImage"; //圖檔路徑

        int selectID = 0;
        string imgEditName = "";
        bool isEditImage = false;


        public frmProductDetail()
        {
            InitializeComponent();
        }

        private void frmProductDetail_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "OnlineStore";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString;
            dgvShowtbProducts();
            dgvProductAll.CellClick += dgvProductAll_CellClick;
        }

        //讀取商品資訊並顯示在dgv
        void dgvShowtbProducts() 
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select ProductID as ID, ProductName as Name, UnitPrice as Price, ProductImage as Image from tbProducts;";
            SqlCommand cmd = new SqlCommand(strSQL, con);  
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows) 
            {
                DataTable dtProducts = new DataTable();
                dtProducts.Load(reader);
                dgvProductAll.DataSource = dtProducts;
            }
            reader.Close();
            con.Close();
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //dgv儲存格被選取時顯示商品資訊
        private void UpdateProductDetails(DataGridViewRow row)
        {
            txtProductID.Text = row.Cells["ID"].Value.ToString();
            txtProductName.Text = row.Cells["Name"].Value.ToString();
            txtProductPrice.Text = row.Cells["Price"].Value.ToString();

            string imageName = row.Cells["Image"].Value.ToString();
            string imagePath = Path.Combine(strImgDir, imageName);

            if (File.Exists(imagePath))
            {
                pboxProduct.Image = Image.FromFile(imagePath);
            }
            else
            {
                pboxProduct.Image = null;
            }
        }

        private void dgvProductAll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProductAll.Rows[e.RowIndex];
                UpdateProductDetails(row);
            }
        }

        //商品名稱重複
        private bool IsPNameExists(string PName)
        {
            bool exists = false;
            SqlConnection con = new SqlConnection(strDBConnectionString);
             con.Open();
            string SQLSelect = "SELECT COUNT(*) FROM tbProducts WHERE ProductName = @productName";
            SqlCommand cmdSelect = new SqlCommand(SQLSelect, con);
            cmdSelect.Parameters.AddWithValue("@productName", PName);
            int count = (int)cmdSelect.ExecuteScalar();
            exists = count > 0;
            return exists;
        }
        //偵測商品名稱重複->無法新增也不會重複存取的情況
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtProductName.Text != "") && (txtProductPrice.Text != "") && (pboxProduct.Image != null))
                {
                    if (IsPNameExists(txtProductName.Text))
                    {
                        MessageBox.Show("商品名稱重複！","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        txtProductName.Clear();
                        return;
                    }
                    SqlConnection con = new SqlConnection(strDBConnectionString);
                    con.Open();

                    string SQLInsert = "insert into tbProducts values (@insertName,@insertPrice, @insertImg);";

                    SqlCommand cmdInsert = new SqlCommand(SQLInsert, con);
                    cmdInsert.Parameters.AddWithValue("@insertName", txtProductName.Text);
                    int insertPrice = 0;
                    if (int.TryParse(txtProductPrice.Text, out insertPrice))
                    {
                        cmdInsert.Parameters.AddWithValue("@insertPrice", insertPrice);
                    }
                    else
                        MessageBox.Show("請輸入整數！");
                    cmdInsert.Parameters.AddWithValue("@insertImg", imgEditName);
                    int rows = cmdInsert.ExecuteNonQuery();
                    con.Close();

                    if (isEditImage)
                    {
                        string imagePath = Path.Combine(strImgDir, imgEditName);
                        pboxProduct.Image.Save(imagePath);
                        isEditImage = false;
                    }
                    MessageBox.Show($"新增成功，{rows}筆資料受影響");
                    ClearTextBox();
                    dgvShowtbProducts();
                }
                else
                {
                    MessageBox.Show("所有欄位必填！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
        void ChooseImage()
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "檔案類型(*.jpg, *.jpeg, *.png)|*.jpeg; *.jpg; *.png";
            DialogResult R = f.ShowDialog();
            if (R == DialogResult.OK)
            {
                pboxProduct.Image = Image.FromFile(f.FileName);
                string fExtension = System.IO.Path.GetExtension(f.SafeFileName).ToLower();
                Random myRnd = new Random();
                imgEditName = DateTime.Now.ToString("yyMMddHHmmss") + myRnd.Next(1000, 10000).ToString() + fExtension;
                isEditImage = true;
                Console.WriteLine(imgEditName); 
            }
        }
        private void btnImage_Click(object sender, EventArgs e)
        {
            ChooseImage();
        }

        //名稱或價格是否有異動->沒有就顯示無資料異動
        private bool IsPDetailChanged(string PName, int PPrice)
        {
            bool PDchanged = false;
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string SQLSelect = "SELECT COUNT(*) FROM tbProducts WHERE ProductName = @productName AND UnitPrice = @price;";
            SqlCommand cmdSelect = new SqlCommand(SQLSelect, con);
            cmdSelect.Parameters.AddWithValue("@productName", PName);
            Int32.TryParse(txtProductPrice.Text, out PPrice);
            cmdSelect.Parameters.AddWithValue("@price", PPrice);

            int count = (int)cmdSelect.ExecuteScalar();
            PDchanged = count > 0;
            return PDchanged;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtProductName.Text != "") && (txtProductPrice.Text != ""))
                {
                    int uPrice = 0;
                    Int32.TryParse(txtProductPrice.Text, out uPrice);
                    if (IsPDetailChanged(txtProductName.Text, uPrice))
                    {
                        MessageBox.Show("商品資訊未更改！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    SqlConnection con = new SqlConnection(strDBConnectionString);
                    con.Open();

                    bool isImageUpdate = isEditImage;

                    string SQLUpdate = "update tbProducts set ProductName = @updateName, UnitPrice = @updatePrice";
                    if (isImageUpdate)
                    {
                        SQLUpdate += " , ProductImage = @updateImg";
                    }
                    SQLUpdate += " where ProductID = @searchID";

                    SqlCommand cmdUpdate = new SqlCommand(SQLUpdate, con);
                    if (int.TryParse(txtProductID.Text, out selectID))
                    {
                        cmdUpdate.Parameters.AddWithValue("@searchID", selectID);
                        cmdUpdate.Parameters.AddWithValue("@updateName", txtProductName.Text);
                        int updatePrice = 0;
                        if (int.TryParse(txtProductPrice.Text, out updatePrice))
                        {
                            cmdUpdate.Parameters.AddWithValue("@updatePrice", updatePrice);
                            if (isImageUpdate)
                            {
                                cmdUpdate.Parameters.AddWithValue("@updateImg", imgEditName);
                            }
                            int rows = cmdUpdate.ExecuteNonQuery();
                            con.Close();

                            if (isImageUpdate)
                            {
                                string imagePath = Path.Combine(strImgDir, imgEditName);
                                pboxProduct.Image.Save(imagePath);
                                isEditImage = false;
                            }
                            MessageBox.Show($"異動成功，{rows}筆資料受影響");
                            ClearTextBox();
                            dgvShowtbProducts();
                        }
                        else
                        {
                            MessageBox.Show("請輸入價錢！");
                        }
                    }
                    else
                    {
                        MessageBox.Show("所有欄位必填！");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        
        void ClearTextBox() 
        {
            txtProductID.Clear();
            txtProductName.Clear();
            txtProductPrice.Clear();
            pboxProduct.Image = null;
        }

        //從資料庫或從程式異動資料重整後皆可更新內容
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            dgvShowtbProducts();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult R = MessageBox.Show("確認刪除此筆資料？","刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(strDBConnectionString);
                    con.Open();

                    string SQLDelete = "delete from tbProducts where ProductID = @selectID;";
                    SqlCommand cmdDelete = new SqlCommand(SQLDelete, con);

                    if (int.TryParse(txtProductID.Text, out selectID) && selectID > 0)
                    {
                        cmdDelete.Parameters.AddWithValue("@selectID", selectID);
                        int rows = cmdDelete.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show($"刪除成功，{rows}筆資料受影響");
                        //重整
                        ClearTextBox();
                        dgvShowtbProducts();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
