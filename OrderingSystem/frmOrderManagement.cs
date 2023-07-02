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
    public partial class frmOrderManagement : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        List<int> searchResultIDs = new List<int>();
        string sqltbOrders = "select * from tbOrders;";
        int selectedQuantity = 0;
        int ODTotalPrice = 0;
        int selectedUnitPrice = 0;

        public frmOrderManagement()
        {
            InitializeComponent();
        }
        private void frmOrderManagement_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "OnlineStore";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString;

            dgvShow();

        }


        void dgvShow()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select * from tbOrders;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader); 
                dgvOrders.DataSource = dt; 
            }
            reader.Close();
            con.Close();
        }

        void ClearAll()
        {
            txtOrderID.Clear();
            txtMemberID.Clear();
            txtTotalPrice.Clear();
            txtReceiver.Clear();
            txtShipAddress.Clear();
            chkboxShipping.Checked = false;
            dtpOrder.Value = DateTime.Now;
        }




        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("確認刪除此筆資料？", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (R == DialogResult.Yes)
            {
                int intOID = 0;
                Int32.TryParse(txtOrderID.Text, out intOID);
                if (intOID > 0)
                {
                    SqlConnection con = new SqlConnection(strDBConnectionString);
                    con.Open();
                    string sqlOdelete = "delete from tbOrders where OrderID = @DeleteID;";
                    SqlCommand cmd1 = new SqlCommand(sqlOdelete, con);
                    cmd1.Parameters.AddWithValue("@DeleteID", intOID);

                    int rows = cmd1.ExecuteNonQuery();

                    if (txtODID.Text != "")
                    {
                        string sqlODdelete = "delete from tbOrderDetail where OrderID = @DeleteID;";
                        SqlCommand cmd2 = new SqlCommand(sqlODdelete, con);
                        cmd2.Parameters.AddWithValue("@DeleteID", intOID);
                        int rows2 = cmd2.ExecuteNonQuery();
                        MessageBox.Show($"訂單明細刪除成功，{rows2}筆資料受影響");
                    }

                    con.Close();
                    ClearAll();
                    dgvShow();
                    MessageBox.Show($"訂單刪除成功，{rows}筆資料受影響");

                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                string strSelectedID = dgvOrders.Rows[e.RowIndex].Cells[0].Value.ToString();
                int selectedID = 0;
                Int32.TryParse(strSelectedID, out selectedID);
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = $"select * from tbOrders where OrderID = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", selectedID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtOrderID.Text = reader["OrderID"].ToString();
                    txtMemberID.Text = reader["memberID"].ToString();
                    txtTotalPrice.Text = reader["totalPrice"].ToString();
                    dtpOrder.Value = Convert.ToDateTime(reader["OrderDate"]);
                    chkboxShipping.Checked = Convert.ToBoolean(reader["shipvia"]);
                    txtReceiver.Text = reader["shipName"].ToString();
                    txtShipAddress.Text = reader["shipAddress"].ToString();

                    Int32.TryParse(strSelectedID, out selectedID);
                    SqlConnection conOD = new SqlConnection(strDBConnectionString);
                    conOD.Open();
                    string sqltbOD = "select * from tbOrderDetail where OrderID = @SearchID;";
                    SqlCommand cmdOD = new SqlCommand(sqltbOD, conOD);
                    cmdOD.Parameters.AddWithValue("@SearchID", selectedID);
                    SqlDataReader readerOD = cmdOD.ExecuteReader();
                    if (readerOD.HasRows)
                    {
                        DataTable dtOD = new DataTable();
                        dtOD.Load(readerOD);
                        dgvOD.DataSource = dtOD;
                    }
                    else
                    {
                        MessageBox.Show("No order details found.", "Try Again");
                        dgvOD.DataSource = null;
                    }
                    readerOD.Close();
                    conOD.Close();
                    
                }
                else
                {
                    MessageBox.Show("No order record.", "Try Again");
                    ClearAll();
                }
                reader.Close();
                con.Close();
            }
        }
        private void dgvOD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string strSelectedID = dgvOD.Rows[e.RowIndex].Cells[0].Value.ToString();
                int selectedID = 0;
                Int32.TryParse(strSelectedID, out selectedID);
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = $"select * from tbOrderDetail where OrderDetailID = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", selectedID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtODID.Text = reader["OrderDetailID"].ToString();
                    txtOrderIDod.Text = reader["OrderID"].ToString();
                    txtProductID.Text = reader["ProductID"].ToString();
                    txtProductName.Text = reader["ProductName"].ToString();
                    txtUnitPrice.Text = reader["UnitPrice"].ToString();
                    txtQuantity.Text = reader["Quantity"].ToString();
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


        private void btnEdit_Click(object sender, EventArgs e)
        {
            int intOID = 0;
            Int32.TryParse(txtOrderID.Text, out intOID);
            int intMID = 0;
            Int32.TryParse(txtMemberID.Text, out intMID);

            if ((intOID > 0) && (intMID > 0) && (txtReceiver.Text != "") && (txtShipAddress.Text != "") && (txtTotalPrice.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = $"update tbOrders set totalPrice = @updateTP, OrderDate = @updateOrderdate, shipvia = @updateShip, shipName = @updateSN, shipAddress = @updateSAddress  where OrderID = @searchOID and memberID =@searchMID; ";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@searchOID", intOID);
                cmd.Parameters.AddWithValue("@searchMID", intMID);
                cmd.Parameters.AddWithValue("@updateTP", txtTotalPrice.Text);
                cmd.Parameters.AddWithValue("@updateOrderdate", dtpOrder.Value);
                cmd.Parameters.AddWithValue("@updateShip", chkboxShipping.Checked);
                cmd.Parameters.AddWithValue("@updateSN", txtReceiver.Text);
                cmd.Parameters.AddWithValue("@updateSAddress", txtShipAddress.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"訂單資料已修改，{rows}筆資料受影響");
                dgvShow();
            }
        }

       
    }
}
