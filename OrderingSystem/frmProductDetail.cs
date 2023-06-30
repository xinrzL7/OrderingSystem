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
    public partial class frmProductDetail : Form
    {

        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        string strImgDir = @"..\..\ProductImage"; //圖檔路徑

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
            scsb.InitialCatalog = "OnlineStore";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString;
            dgvShowtbProducts();
            showProductDetail();
        }
        void dgvShowtbProducts() 
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select ProductID as ID, ProductName as Name, UnitPrice as Price, ProductImage as image from tbProducts;";
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


        void showProductDetail()//資料右邊跑不出來
        {
            if (dgvProductAll.SelectedRows.Count > 0)
            {
                if (dgvProductAll.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvProductAll.SelectedRows[0];
                    selectID = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);
                    Console.WriteLine($"被選擇的ID為{selectID}");
                    SqlConnection con = new SqlConnection(strDBConnectionString);
                    con.Open();

                    string strSQL = "select * from tbProducts where ProductID = @SearchID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", selectID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtProductID.Text = reader["ProductID"].ToString();
                        txtProductName.Text = reader["ProductName"].ToString();
                        txtProductPrice.Text = reader["UnitPrice"].ToString();
                        string imageName = reader["ProductImage"].ToString();
                        if (!string.IsNullOrEmpty(imageName))
                        {
                            string imagePath = Path.Combine(strImgDir, imageName);
                            if (File.Exists(imagePath))
                            {
                                pboxProduct.Image = Image.FromFile(imagePath);
                            }
                        }
                        else
                        {
                            pboxProduct.Image = null;
                        }
                    }
                    reader.Close();
                    con.Close();
                }
            }

            //if (selectID > 0)
            //{
            //    SqlConnection con = new SqlConnection(strDBConnectionString);
            //    con.Open();

            //    string strSQL = "select * from products where id = @SearchID; ";
            //    SqlCommand cmd = new SqlCommand(strSQL, con);
            //    cmd.Parameters.AddWithValue("@SearchID", selectID);
            //    SqlDataReader reader = cmd.ExecuteReader();

            //    if (reader.Read())
            //    {
            //        txtProductID.Text = reader["ProductID"].ToString();
            //        txtProductName.Text = reader["ProductName"].ToString();
            //        txtProductPrice.Text = reader["UnitPrice"].ToString();
            //        imgEditName = reader["ProductImage"].ToString();
            //        string FullPicPath = Path.Combine(strImgDir, imgEditName);
            //        pboxProduct.Image = Image.FromFile(FullPicPath);
            //    }
            //    reader.Close();
            //    con.Close();
            //}
        }

    }
}
