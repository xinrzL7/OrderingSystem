namespace OrderingSystem
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lboxIItems = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuyer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReceiver = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxFlavor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.chkboxIce = new System.Windows.Forms.CheckBox();
            this.rbtnShipping = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rbtnPickup = new System.Windows.Forms.RadioButton();
            this.gboxCustomer = new System.Windows.Forms.GroupBox();
            this.gboxFood = new System.Windows.Forms.GroupBox();
            this.btnCancelCart = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnJoinCart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.btnBuyIt = new System.Windows.Forms.Button();
            this.timerCurrentTime = new System.Windows.Forms.Timer(this.components);
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gboxCustomer.SuspendLayout();
            this.gboxFood.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // lboxIItems
            // 
            this.lboxIItems.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lboxIItems.FormattingEnabled = true;
            this.lboxIItems.ItemHeight = 24;
            this.lboxIItems.Location = new System.Drawing.Point(211, 43);
            this.lboxIItems.Name = "lboxIItems";
            this.lboxIItems.Size = new System.Drawing.Size(286, 292);
            this.lboxIItems.TabIndex = 7;
            this.lboxIItems.SelectedIndexChanged += new System.EventHandler(this.lboxIItems_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(344, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "可麗露訂購表單";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(40, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "訂購人姓名 / 電話";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBuyer
            // 
            this.txtBuyer.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBuyer.Location = new System.Drawing.Point(208, 48);
            this.txtBuyer.Name = "txtBuyer";
            this.txtBuyer.Size = new System.Drawing.Size(197, 33);
            this.txtBuyer.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(40, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "收件人姓名 / 電話";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtReceiver
            // 
            this.txtReceiver.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtReceiver.Location = new System.Drawing.Point(208, 101);
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.Size = new System.Drawing.Size(197, 33);
            this.txtReceiver.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(40, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "收件地址(非宅配請填無)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAddress.Location = new System.Drawing.Point(258, 152);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(273, 33);
            this.txtAddress.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(14, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "口味";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxFlavor
            // 
            this.cboxFlavor.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxFlavor.FormattingEnabled = true;
            this.cboxFlavor.Location = new System.Drawing.Point(78, 51);
            this.cboxFlavor.Name = "cboxFlavor";
            this.cboxFlavor.Size = new System.Drawing.Size(123, 32);
            this.cboxFlavor.TabIndex = 15;
            this.cboxFlavor.Text = "請選擇";
            this.cboxFlavor.SelectedIndexChanged += new System.EventHandler(this.cboxFlavor_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(14, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "盒數";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAmount.Location = new System.Drawing.Point(114, 184);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(51, 33);
            this.txtAmount.TabIndex = 17;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMinus.Location = new System.Drawing.Point(78, 184);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(30, 33);
            this.btnMinus.TabIndex = 18;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPlus.Location = new System.Drawing.Point(171, 184);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(30, 33);
            this.btnPlus.TabIndex = 19;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(14, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "單價";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPrice.Location = new System.Drawing.Point(81, 124);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(62, 24);
            this.lblPrice.TabIndex = 21;
            this.lblPrice.Text = "000元";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(11, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 24);
            this.label10.TabIndex = 22;
            this.label10.Text = "總價";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalPrice.Location = new System.Drawing.Point(81, 355);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(84, 24);
            this.lblTotalPrice.TabIndex = 23;
            this.lblTotalPrice.Text = "00000元";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkboxIce
            // 
            this.chkboxIce.AutoSize = true;
            this.chkboxIce.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkboxIce.Location = new System.Drawing.Point(15, 307);
            this.chkboxIce.Name = "chkboxIce";
            this.chkboxIce.Size = new System.Drawing.Size(177, 28);
            this.chkboxIce.TabIndex = 25;
            this.chkboxIce.Text = "加購保冷劑(10元)";
            this.chkboxIce.UseVisualStyleBackColor = true;
            this.chkboxIce.CheckedChanged += new System.EventHandler(this.chkboxIce_CheckedChanged);
            // 
            // rbtnShipping
            // 
            this.rbtnShipping.AutoSize = true;
            this.rbtnShipping.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtnShipping.Location = new System.Drawing.Point(154, 68);
            this.rbtnShipping.Name = "rbtnShipping";
            this.rbtnShipping.Size = new System.Drawing.Size(66, 28);
            this.rbtnShipping.TabIndex = 26;
            this.rbtnShipping.TabStop = true;
            this.rbtnShipping.Text = "宅配";
            this.rbtnShipping.UseVisualStyleBackColor = true;
            this.rbtnShipping.CheckedChanged += new System.EventHandler(this.rbtnShipping_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.rbtnPickup);
            this.groupBox1.Controls.Add(this.rbtnShipping);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(554, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 153);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "運送方式";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(154, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 42);
            this.label9.TabIndex = 31;
            this.label9.Text = "運費150元\r\n滿五盒免運哦!";
            // 
            // rbtnPickup
            // 
            this.rbtnPickup.AutoSize = true;
            this.rbtnPickup.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtnPickup.Location = new System.Drawing.Point(15, 68);
            this.rbtnPickup.Name = "rbtnPickup";
            this.rbtnPickup.Size = new System.Drawing.Size(123, 28);
            this.rbtnPickup.TabIndex = 27;
            this.rbtnPickup.TabStop = true;
            this.rbtnPickup.Text = "工作室取貨";
            this.rbtnPickup.UseVisualStyleBackColor = true;
            // 
            // gboxCustomer
            // 
            this.gboxCustomer.Controls.Add(this.label3);
            this.gboxCustomer.Controls.Add(this.txtBuyer);
            this.gboxCustomer.Controls.Add(this.label4);
            this.gboxCustomer.Controls.Add(this.groupBox1);
            this.gboxCustomer.Controls.Add(this.txtReceiver);
            this.gboxCustomer.Controls.Add(this.label5);
            this.gboxCustomer.Controls.Add(this.txtAddress);
            this.gboxCustomer.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gboxCustomer.Location = new System.Drawing.Point(17, 72);
            this.gboxCustomer.Name = "gboxCustomer";
            this.gboxCustomer.Size = new System.Drawing.Size(868, 222);
            this.gboxCustomer.TabIndex = 28;
            this.gboxCustomer.TabStop = false;
            this.gboxCustomer.Text = "顧客資訊";
            // 
            // gboxFood
            // 
            this.gboxFood.Controls.Add(this.btnCancelCart);
            this.gboxFood.Controls.Add(this.label11);
            this.gboxFood.Controls.Add(this.btnJoinCart);
            this.gboxFood.Controls.Add(this.chkboxIce);
            this.gboxFood.Controls.Add(this.lblTotalPrice);
            this.gboxFood.Controls.Add(this.lboxIItems);
            this.gboxFood.Controls.Add(this.label10);
            this.gboxFood.Controls.Add(this.label6);
            this.gboxFood.Controls.Add(this.lblPrice);
            this.gboxFood.Controls.Add(this.cboxFlavor);
            this.gboxFood.Controls.Add(this.label8);
            this.gboxFood.Controls.Add(this.label7);
            this.gboxFood.Controls.Add(this.btnPlus);
            this.gboxFood.Controls.Add(this.txtAmount);
            this.gboxFood.Controls.Add(this.btnMinus);
            this.gboxFood.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gboxFood.Location = new System.Drawing.Point(17, 314);
            this.gboxFood.Name = "gboxFood";
            this.gboxFood.Size = new System.Drawing.Size(513, 390);
            this.gboxFood.TabIndex = 29;
            this.gboxFood.TabStop = false;
            this.gboxFood.Text = "訂購項目";
            // 
            // btnCancelCart
            // 
            this.btnCancelCart.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancelCart.Location = new System.Drawing.Point(377, 346);
            this.btnCancelCart.Name = "btnCancelCart";
            this.btnCancelCart.Size = new System.Drawing.Size(120, 33);
            this.btnCancelCart.TabIndex = 33;
            this.btnCancelCart.Text = "取消加入";
            this.btnCancelCart.UseVisualStyleBackColor = true;
            this.btnCancelCart.Click += new System.EventHandler(this.btnCancelCart_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(12, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 22);
            this.label11.TabIndex = 32;
            this.label11.Text = "同品項三盒以上95折優惠";
            // 
            // btnJoinCart
            // 
            this.btnJoinCart.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnJoinCart.Location = new System.Drawing.Point(211, 346);
            this.btnJoinCart.Name = "btnJoinCart";
            this.btnJoinCart.Size = new System.Drawing.Size(120, 33);
            this.btnJoinCart.TabIndex = 26;
            this.btnJoinCart.Text = "加入購物車";
            this.btnJoinCart.UseVisualStyleBackColor = true;
            this.btnJoinCart.Click += new System.EventHandler(this.btnJoinCart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCart);
            this.groupBox2.Controls.Add(this.btnBuyIt);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(536, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 390);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "購物清單";
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(15, 43);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.Size = new System.Drawing.Size(681, 292);
            this.dgvCart.TabIndex = 28;
            // 
            // btnBuyIt
            // 
            this.btnBuyIt.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBuyIt.Location = new System.Drawing.Point(500, 341);
            this.btnBuyIt.Name = "btnBuyIt";
            this.btnBuyIt.Size = new System.Drawing.Size(105, 33);
            this.btnBuyIt.TabIndex = 27;
            this.btnBuyIt.Text = "結帳";
            this.btnBuyIt.UseVisualStyleBackColor = true;
            this.btnBuyIt.Click += new System.EventHandler(this.btnBuyIt_Click);
            // 
            // timerCurrentTime
            // 
            this.timerCurrentTime.Enabled = true;
            this.timerCurrentTime.Tick += new System.EventHandler(this.timerCurrentTime_Tick);
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCurrentTime.Location = new System.Drawing.Point(703, 49);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(54, 20);
            this.lblCurrentTime.TabIndex = 31;
            this.lblCurrentTime.Text = "label1";
            this.lblCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1257, 763);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gboxFood);
            this.Controls.Add(this.gboxCustomer);
            this.Controls.Add(this.label2);
            this.Name = "frmMenu";
            this.Text = "訂購表單";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboxCustomer.ResumeLayout(false);
            this.gboxCustomer.PerformLayout();
            this.gboxFood.ResumeLayout(false);
            this.gboxFood.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxIItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuyer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReceiver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxFlavor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.CheckBox chkboxIce;
        private System.Windows.Forms.RadioButton rbtnShipping;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnPickup;
        private System.Windows.Forms.GroupBox gboxCustomer;
        private System.Windows.Forms.GroupBox gboxFood;
        private System.Windows.Forms.Button btnJoinCart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuyIt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCancelCart;
        private System.Windows.Forms.Timer timerCurrentTime;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.DataGridView dgvCart;
    }
}