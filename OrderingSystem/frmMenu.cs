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
using System.Xml;

namespace OrderingSystem
{
    public partial class frmMenu : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";

        List<string> listOriginalItem = new List<string>();
        List<int> listOriginalPrice = new List<int>();
        List<string> listOtherItem = new List<string>();
        List<int> listOtherPrice = new List<int>();
        List<string> listFlavor = new List<string>();
        int selectedAmount = 0;
        int selectedPrice = 0;
        int TotalPrice = 0;
        string selectedFlavor = "";
        string selectedItem = "";
        bool isIce = false;
        bool isShipping = false;
        int intDelivery = 0;
        DataTable dtCart;
        public frmMenu()
        {
            InitializeComponent();
            //todo 簡化
            dtCart = new DataTable();
            dtCart.Columns.Add("訂購項目", typeof(string));
            dtCart.Columns.Add("單價", typeof(int));
            dtCart.Columns.Add("盒數", typeof(int));
            dtCart.Columns.Add("保冷劑", typeof(bool));
            dtCart.Columns.Add("宅配", typeof(bool));
            dtCart.Columns.Add("總價", typeof(int));
            dgvCart.DataSource = dtCart;
            //btnCancelCart.Click += btnCancelCart_Click;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "caneleos";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString;

            //原味key
            listOriginalItem.Add("一般大小 5入");
            listOriginalItem.Add("一般大小 10入");
            listOriginalItem.Add("迷你尺寸 10入");
            listOriginalItem.Add("迷你尺寸 15入");
            //原味value
            listOriginalPrice.Add(400);
            listOriginalPrice.Add(750);
            listOriginalPrice.Add(300);
            listOriginalPrice.Add(450);
            //其他口味key
            listOtherItem.Add("一般大小 5入");
            listOtherItem.Add("一般大小 10入");
            listOtherItem.Add("迷你尺寸 10入");
            listOtherItem.Add("迷你尺寸 15入");
            //其他口味value
            listOtherPrice.Add(450);
            listOtherPrice.Add(800);
            listOtherPrice.Add(350);
            listOtherPrice.Add(500);
            //口味cbox
            listFlavor.Add("原味");
            listFlavor.Add("奶茶");
            listFlavor.Add("抹茶");
            listFlavor.Add("紅茶");
            listFlavor.Add("巧克力");
            listFlavor.Add("綜合");

            foreach (string item in listFlavor)
            {
                cboxFlavor.Items.Add(item);
            }
            cboxFlavor.SelectedIndexChanged += cboxFlavor_SelectedIndexChanged;

            //todo 口味選擇要預設成index=0?
            selectedFlavor = listFlavor[0];
            txtAmount.Text = "1";
            selectedAmount = 1;
            chkboxIce.Checked = false;
            isIce = false;
            rbtnPickup.Checked = true; //0
            rbtnShipping.Checked = false; //1
            isShipping = false;
            
        }


        void dgvCartShow() 
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select flavor + itemname as 訂購項目, price as 單價, amount as 數量, ice, shipping as 宅配, totalprice as 總價 from caneleOrder where (buyer = @newBuyer) and (receiver = @newReceiver) ;";
            SqlCommand cmd = new SqlCommand(@strSQL,con);
            cmd.Parameters.AddWithValue("@newBuyer", txtBuyer.Text);
            cmd.Parameters.AddWithValue("@newReceiver", txtReceiver.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows==true) 
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvCart.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }
        void calculateTotalPrice() 
        {
            if (lboxIItems.SelectedIndex >= 0) 
            {
                TotalPrice = selectedPrice * selectedAmount;

                if (isIce)
                    TotalPrice += 10;
                
                if (isShipping && selectedAmount < 5) //五盒以上免運
                    TotalPrice += 150;
                
                if (selectedAmount >= 3)  //三盒以上95折
                    TotalPrice = (int)(TotalPrice * 0.95);

                lblTotalPrice.Text = $"{TotalPrice}元" ;
            }
        }

        private void cboxFlavor_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFlavor = listFlavor[cboxFlavor.SelectedIndex];
            lboxIItems.Items.Clear();
            if (cboxFlavor.SelectedIndex == 0)
            {
                for (int i = 0; i < listOriginalItem.Count; i++)
                {
                    string strItem = $"{listOriginalItem[i]} {listOriginalPrice[i]}元";
                    lboxIItems.Items.Add(strItem);
                }
            }
            else 
            {
                for (int i =0; i<listOtherItem.Count; i++)
                {
                    string strItem = $"{listOtherItem[i]} {listOtherPrice[i]}元";
                    lboxIItems.Items.Add(strItem);
                }
            }
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            selectedAmount++;
            txtAmount.Text = selectedAmount.ToString();
            calculateTotalPrice();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (selectedAmount > 1)
            {
                selectedAmount--;
                txtAmount.Text = selectedAmount.ToString();
                calculateTotalPrice();
            }
        }
        private void chkboxIce_CheckedChanged(object sender, EventArgs e)
        {
            isIce = chkboxIce.Checked;
            calculateTotalPrice() ;
        }
        private void rbtnShipping_CheckedChanged(object sender, EventArgs e)
        {
            isShipping = rbtnShipping.Checked;
            calculateTotalPrice() ;
        }

        private void lboxIItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxIItems.SelectedIndex >=0) 
            {
                if (cboxFlavor.SelectedIndex == 0)
                {
                    selectedItem = listOriginalItem[lboxIItems.SelectedIndex];
                    selectedPrice = listOriginalPrice[lboxIItems.SelectedIndex];
                    lblPrice.Text = $"{selectedPrice}元";
                    calculateTotalPrice() ;
                }
                else 
                {
                    selectedItem = listOtherItem[lboxIItems.SelectedIndex];
                    selectedPrice = listOtherPrice[lboxIItems.SelectedIndex];
                    lblPrice.Text = $"{selectedPrice}元";
                    calculateTotalPrice() ;
                }
            }
        }
        /* 
         * dgvCart=SQL 可選取要呈現給使用者看的資料>確認訂購
         * dgv要呈現當下使用者的購物清單(配合訂購、收件人欄位)
         * 有會員系統就對照會員編號
         */

        // 新增
        private void btnJoinCart_Click(object sender, EventArgs e)
        {
            if ((txtBuyer.Text != "") && (txtReceiver.Text != "") && (txtAddress.Text != "") && (lboxIItems.SelectedIndex >= 0))
            {
                //todo 簡化
                DataRow newrow = dtCart.NewRow();
                newrow["訂購項目"] = selectedFlavor + " " + selectedItem;
                newrow["單價"] = selectedPrice;
                newrow["盒數"] = selectedAmount;
                newrow["保冷劑"] = isIce;
                newrow["宅配"] = isShipping;
                newrow["總價"] = TotalPrice;
                dtCart.Rows.Add(newrow);
                dgvCart.DataSource = dtCart;
            }
            else
                MessageBox.Show("資料未輸入完整！");
        }
        //刪除
        private void btnCancelCart_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("確認要刪除此商品？", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (R == DialogResult.Yes)
            {
                if (dgvCart.SelectedRows.Count > 0)
                {
                    int selectedCartIndex = dgvCart.SelectedRows[0].Index;
                    dgvCart.Rows.RemoveAt(selectedCartIndex);
                }
                else
                    MessageBox.Show("請選擇要刪除的商品！");
            }
        }

        private void timerCurrentTime_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("G", new System.Globalization.CultureInfo("zh-TW"));
        }

        //todo 存到SQL 要再修改
        private void btnBuyIt_Click(object sender, EventArgs e)
        {
            if ((txtBuyer.Text != "") && (txtReceiver.Text != "") && (txtAddress.Text != "") && (lboxIItems.SelectedIndex >= 0))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "insert into caneleOrder values (@newBuyer, @newReceiver, @newAddress, @newFlavor, @newItemName, @newPrice, @newAmount, @newIce, @newShipping, @newTotalPrice, @newOrderTime);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@newBuyer", txtBuyer.Text);
                cmd.Parameters.AddWithValue("@newReceiver", txtReceiver.Text);
                cmd.Parameters.AddWithValue("@newAddress", txtAddress.Text);
                cmd.Parameters.AddWithValue("@newFlavor", selectedFlavor);
                cmd.Parameters.AddWithValue("@newItemName", selectedItem);
                cmd.Parameters.AddWithValue("@newPrice", selectedPrice);
                cmd.Parameters.AddWithValue("@newAmount", selectedAmount);
                cmd.Parameters.AddWithValue("@newIce", isIce);
                cmd.Parameters.AddWithValue("@newShipping", isShipping);
                cmd.Parameters.AddWithValue("@newTotalPrice", TotalPrice);
                cmd.Parameters.AddWithValue("@newOrderTime", DateTime.Now);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"訂單新增成功，{rows}筆資料受影響");
            }
            else
            {
                MessageBox.Show("欄位未輸入完整！");
            }
        }
    }
}
