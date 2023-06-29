namespace OrderingSystem
{
    partial class frmHome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteCart = new Guna.UI2.WinForms.Guna2Button();
            this.lblmemberName = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCart = new Guna.UI2.WinForms.Guna2Button();
            this.btnPlus = new Guna.UI2.WinForms.Guna2Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnMinus = new Guna.UI2.WinForms.Guna2Button();
            this.imglistProducts = new System.Windows.Forms.ImageList(this.components);
            this.btnEsc = new Guna.UI2.WinForms.Guna2Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuy = new Guna.UI2.WinForms.Guna2Button();
            this.rbtnShop = new System.Windows.Forms.RadioButton();
            this.rbtnShipping = new System.Windows.Forms.RadioButton();
            this.lvProducts = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtshipName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtShipAddr = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteCart);
            this.panel1.Controls.Add(this.lblmemberName);
            this.panel1.Controls.Add(this.lblTotalPrice);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCart);
            this.panel1.Controls.Add(this.btnPlus);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.btnMinus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 731);
            this.panel1.TabIndex = 40;
            // 
            // btnDeleteCart
            // 
            this.btnDeleteCart.AutoRoundedCorners = true;
            this.btnDeleteCart.BorderColor = System.Drawing.Color.DimGray;
            this.btnDeleteCart.BorderRadius = 15;
            this.btnDeleteCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteCart.FillColor = System.Drawing.Color.Gray;
            this.btnDeleteCart.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCart.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCart.Location = new System.Drawing.Point(36, 440);
            this.btnDeleteCart.Name = "btnDeleteCart";
            this.btnDeleteCart.Size = new System.Drawing.Size(184, 33);
            this.btnDeleteCart.TabIndex = 54;
            this.btnDeleteCart.Text = "Delete from cart";
            this.btnDeleteCart.Click += new System.EventHandler(this.btnDeleteCart_Click);
            // 
            // lblmemberName
            // 
            this.lblmemberName.AutoSize = true;
            this.lblmemberName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmemberName.ForeColor = System.Drawing.Color.DimGray;
            this.lblmemberName.Location = new System.Drawing.Point(12, 33);
            this.lblmemberName.Name = "lblmemberName";
            this.lblmemberName.Size = new System.Drawing.Size(38, 27);
            this.lblmemberName.TabIndex = 53;
            this.lblmemberName.Text = "Hi,";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPrice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(77, 590);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(76, 24);
            this.lblTotalPrice.TabIndex = 52;
            this.lblTotalPrice.Text = "NT 000";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 550);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 51;
            this.label4.Text = "Total Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(97, 318);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(76, 24);
            this.lblPrice.TabIndex = 50;
            this.lblPrice.Text = "NT 000";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 24);
            this.label8.TabIndex = 49;
            this.label8.Text = "Unit Price";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoRoundedCorners = true;
            this.btnLogin.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 23;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.DimGray;
            this.btnLogin.Location = new System.Drawing.Point(54, 680);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(147, 48);
            this.btnLogin.TabIndex = 39;
            this.btnLogin.Text = "Log out";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(32, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 48;
            this.label2.Text = "Quantity";
            // 
            // btnCart
            // 
            this.btnCart.AutoRoundedCorners = true;
            this.btnCart.BorderColor = System.Drawing.Color.DimGray;
            this.btnCart.BorderRadius = 15;
            this.btnCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCart.FillColor = System.Drawing.Color.Gray;
            this.btnCart.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.ForeColor = System.Drawing.Color.White;
            this.btnCart.Location = new System.Drawing.Point(36, 381);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(184, 33);
            this.btnCart.TabIndex = 37;
            this.btnCart.Text = "Add to cart";
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.AutoRoundedCorners = true;
            this.btnPlus.BorderColor = System.Drawing.Color.DimGray;
            this.btnPlus.BorderRadius = 15;
            this.btnPlus.BorderThickness = 1;
            this.btnPlus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlus.FillColor = System.Drawing.Color.Transparent;
            this.btnPlus.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnPlus.ForeColor = System.Drawing.Color.DimGray;
            this.btnPlus.Location = new System.Drawing.Point(166, 220);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(35, 33);
            this.btnPlus.TabIndex = 45;
            this.btnPlus.Text = "+";
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(115, 223);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(45, 30);
            this.txtQuantity.TabIndex = 46;
            // 
            // btnMinus
            // 
            this.btnMinus.AutoRoundedCorners = true;
            this.btnMinus.BorderColor = System.Drawing.Color.DimGray;
            this.btnMinus.BorderRadius = 15;
            this.btnMinus.BorderThickness = 1;
            this.btnMinus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinus.FillColor = System.Drawing.Color.Transparent;
            this.btnMinus.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnMinus.ForeColor = System.Drawing.Color.DimGray;
            this.btnMinus.Location = new System.Drawing.Point(74, 220);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(35, 33);
            this.btnMinus.TabIndex = 44;
            this.btnMinus.Text = "-";
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // imglistProducts
            // 
            this.imglistProducts.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglistProducts.ImageSize = new System.Drawing.Size(256, 256);
            this.imglistProducts.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnEsc
            // 
            this.btnEsc.AutoRoundedCorners = true;
            this.btnEsc.BorderColor = System.Drawing.Color.Transparent;
            this.btnEsc.BorderRadius = 15;
            this.btnEsc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEsc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEsc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEsc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEsc.FillColor = System.Drawing.Color.Transparent;
            this.btnEsc.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnEsc.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnEsc.Location = new System.Drawing.Point(1408, 0);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(38, 33);
            this.btnEsc.TabIndex = 41;
            this.btnEsc.Text = "X";
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // dgvCart
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCart.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(279, 589);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.Size = new System.Drawing.Size(601, 124);
            this.dgvCart.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(274, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Your cart";
            // 
            // btnBuy
            // 
            this.btnBuy.AutoRoundedCorners = true;
            this.btnBuy.BorderColor = System.Drawing.Color.DimGray;
            this.btnBuy.BorderRadius = 15;
            this.btnBuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuy.FillColor = System.Drawing.Color.Gray;
            this.btnBuy.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.Location = new System.Drawing.Point(1341, 639);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(91, 33);
            this.btnBuy.TabIndex = 47;
            this.btnBuy.Text = "Buy";
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // rbtnShop
            // 
            this.rbtnShop.AutoSize = true;
            this.rbtnShop.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtnShop.ForeColor = System.Drawing.Color.Black;
            this.rbtnShop.Location = new System.Drawing.Point(899, 604);
            this.rbtnShop.Name = "rbtnShop";
            this.rbtnShop.Size = new System.Drawing.Size(75, 28);
            this.rbtnShop.TabIndex = 27;
            this.rbtnShop.TabStop = true;
            this.rbtnShop.Text = "Shop";
            this.rbtnShop.UseVisualStyleBackColor = true;
            // 
            // rbtnShipping
            // 
            this.rbtnShipping.AutoSize = true;
            this.rbtnShipping.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtnShipping.ForeColor = System.Drawing.Color.Black;
            this.rbtnShipping.Location = new System.Drawing.Point(899, 664);
            this.rbtnShipping.Name = "rbtnShipping";
            this.rbtnShipping.Size = new System.Drawing.Size(109, 28);
            this.rbtnShipping.TabIndex = 26;
            this.rbtnShipping.TabStop = true;
            this.rbtnShipping.Text = "Shipping";
            this.rbtnShipping.UseVisualStyleBackColor = true;
            this.rbtnShipping.CheckedChanged += new System.EventHandler(this.rbtnShipping_CheckedChanged);
            // 
            // lvProducts
            // 
            this.lvProducts.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvProducts.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lvProducts.AutoArrange = false;
            this.lvProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvProducts.HideSelection = false;
            this.lvProducts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvProducts.Location = new System.Drawing.Point(279, 33);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(1095, 501);
            this.lvProducts.TabIndex = 50;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.SelectedIndexChanged += new System.EventHandler(this.lvProducts_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(894, 549);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 51;
            this.label3.Text = "Delivery";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(1047, 549);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 52;
            this.label5.Text = "Receiver";
            // 
            // txtshipName
            // 
            this.txtshipName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtshipName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtshipName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtshipName.Location = new System.Drawing.Point(1143, 606);
            this.txtshipName.Multiline = true;
            this.txtshipName.Name = "txtshipName";
            this.txtshipName.Size = new System.Drawing.Size(159, 30);
            this.txtshipName.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1048, 605);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 24);
            this.label6.TabIndex = 54;
            this.label6.Text = "Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1048, 668);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 24);
            this.label7.TabIndex = 55;
            this.label7.Text = "Address";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtShipAddr
            // 
            this.txtShipAddr.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtShipAddr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtShipAddr.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShipAddr.Location = new System.Drawing.Point(1143, 669);
            this.txtShipAddr.Multiline = true;
            this.txtShipAddr.Name = "txtShipAddr";
            this.txtShipAddr.Size = new System.Drawing.Size(159, 30);
            this.txtShipAddr.TabIndex = 56;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1444, 731);
            this.Controls.Add(this.txtShipAddr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtshipName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbtnShipping);
            this.Controls.Add(this.rbtnShop);
            this.Controls.Add(this.lvProducts);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.btnEsc);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imglistProducts;
        private Guna.UI2.WinForms.Guna2Button btnEsc;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnCart;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnBuy;
        private System.Windows.Forms.TextBox txtQuantity;
        private Guna.UI2.WinForms.Guna2Button btnPlus;
        private Guna.UI2.WinForms.Guna2Button btnMinus;
        private System.Windows.Forms.RadioButton rbtnShop;
        private System.Windows.Forms.RadioButton rbtnShipping;
        private System.Windows.Forms.ListView lvProducts;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.Label lblmemberName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtShipAddr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtshipName;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnDeleteCart;
    }
}