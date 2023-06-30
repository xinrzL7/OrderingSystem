namespace OrderingSystem
{
    partial class frmProductDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gboxProductNew = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNewProPic = new System.Windows.Forms.Button();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.gboxProductEdit = new System.Windows.Forms.GroupBox();
            this.btnEditSave = new System.Windows.Forms.Button();
            this.btnEditProPic = new System.Windows.Forms.Button();
            this.pboxProduct = new System.Windows.Forms.PictureBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dgvProductAll = new System.Windows.Forms.DataGridView();
            this.btnCart = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnEsc = new Guna.UI2.WinForms.Guna2Button();
            this.gboxProductNew.SuspendLayout();
            this.gboxProductEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductAll)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxProductNew
            // 
            this.gboxProductNew.BackColor = System.Drawing.Color.Ivory;
            this.gboxProductNew.Controls.Add(this.btnClear);
            this.gboxProductNew.Controls.Add(this.btnNewProPic);
            this.gboxProductNew.Controls.Add(this.btnNewProduct);
            this.gboxProductNew.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gboxProductNew.Location = new System.Drawing.Point(200, 39);
            this.gboxProductNew.Name = "gboxProductNew";
            this.gboxProductNew.Size = new System.Drawing.Size(405, 152);
            this.gboxProductNew.TabIndex = 24;
            this.gboxProductNew.TabStop = false;
            this.gboxProductNew.Text = "商品新增";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(250, 63);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 53);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "清空欄位";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnNewProPic
            // 
            this.btnNewProPic.BackColor = System.Drawing.Color.White;
            this.btnNewProPic.Location = new System.Drawing.Point(67, 51);
            this.btnNewProPic.Name = "btnNewProPic";
            this.btnNewProPic.Size = new System.Drawing.Size(141, 37);
            this.btnNewProPic.TabIndex = 2;
            this.btnNewProPic.Text = "選取商品照片";
            this.btnNewProPic.UseVisualStyleBackColor = false;
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.BackColor = System.Drawing.Color.White;
            this.btnNewProduct.Location = new System.Drawing.Point(67, 94);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(141, 37);
            this.btnNewProduct.TabIndex = 1;
            this.btnNewProduct.Text = "儲存商品";
            this.btnNewProduct.UseVisualStyleBackColor = false;
            // 
            // gboxProductEdit
            // 
            this.gboxProductEdit.BackColor = System.Drawing.Color.Ivory;
            this.gboxProductEdit.Controls.Add(this.btnEditSave);
            this.gboxProductEdit.Controls.Add(this.btnEditProPic);
            this.gboxProductEdit.Controls.Add(this.gboxProductNew);
            this.gboxProductEdit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gboxProductEdit.Location = new System.Drawing.Point(137, 533);
            this.gboxProductEdit.Name = "gboxProductEdit";
            this.gboxProductEdit.Size = new System.Drawing.Size(405, 152);
            this.gboxProductEdit.TabIndex = 23;
            this.gboxProductEdit.TabStop = false;
            this.gboxProductEdit.Text = "商品修改";
            // 
            // btnEditSave
            // 
            this.btnEditSave.BackColor = System.Drawing.Color.White;
            this.btnEditSave.Location = new System.Drawing.Point(126, 94);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.Size = new System.Drawing.Size(141, 37);
            this.btnEditSave.TabIndex = 1;
            this.btnEditSave.Text = "儲存修改";
            this.btnEditSave.UseVisualStyleBackColor = false;
            // 
            // btnEditProPic
            // 
            this.btnEditProPic.BackColor = System.Drawing.Color.White;
            this.btnEditProPic.Location = new System.Drawing.Point(126, 39);
            this.btnEditProPic.Name = "btnEditProPic";
            this.btnEditProPic.Size = new System.Drawing.Size(141, 37);
            this.btnEditProPic.TabIndex = 0;
            this.btnEditProPic.Text = "選取商品照片";
            this.btnEditProPic.UseVisualStyleBackColor = false;
            // 
            // pboxProduct
            // 
            this.pboxProduct.Location = new System.Drawing.Point(44, 49);
            this.pboxProduct.Name = "pboxProduct";
            this.pboxProduct.Size = new System.Drawing.Size(284, 284);
            this.pboxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxProduct.TabIndex = 22;
            this.pboxProduct.TabStop = false;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductPrice.Location = new System.Drawing.Point(158, 468);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(189, 33);
            this.txtProductPrice.TabIndex = 20;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(158, 413);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(188, 33);
            this.txtProductName.TabIndex = 19;
            this.txtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProductID
            // 
            this.txtProductID.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.Location = new System.Drawing.Point(159, 357);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(49, 33);
            this.txtProductID.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // dgvProductAll
            // 
            this.dgvProductAll.AllowUserToAddRows = false;
            this.dgvProductAll.AllowUserToDeleteRows = false;
            this.dgvProductAll.AllowUserToResizeColumns = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProductAll.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProductAll.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProductAll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductAll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProductAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductAll.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProductAll.Location = new System.Drawing.Point(38, 49);
            this.dgvProductAll.Name = "dgvProductAll";
            this.dgvProductAll.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductAll.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProductAll.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProductAll.RowTemplate.Height = 24;
            this.dgvProductAll.Size = new System.Drawing.Size(457, 284);
            this.dgvProductAll.TabIndex = 43;
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
            this.btnCart.Location = new System.Drawing.Point(38, 447);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(118, 33);
            this.btnCart.TabIndex = 44;
            this.btnCart.Text = "Insert";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEsc);
            this.panel1.Controls.Add(this.pboxProduct);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtProductPrice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.gboxProductEdit);
            this.panel1.Controls.Add(this.txtProductID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(529, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 616);
            this.panel1.TabIndex = 45;
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Gray;
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(207, 447);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(118, 33);
            this.guna2Button1.TabIndex = 46;
            this.guna2Button1.Text = "Update";
            // 
            // guna2Button2
            // 
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Button2.BorderRadius = 15;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Gray;
            this.guna2Button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(377, 447);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(118, 33);
            this.guna2Button2.TabIndex = 47;
            this.guna2Button2.Text = "Delete";
            // 
            // guna2Button3
            // 
            this.guna2Button3.AutoRoundedCorners = true;
            this.guna2Button3.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Button3.BorderRadius = 15;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Gray;
            this.guna2Button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(38, 353);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(118, 33);
            this.guna2Button3.TabIndex = 48;
            this.guna2Button3.Text = "Image";
            // 
            // guna2Button4
            // 
            this.guna2Button4.AutoRoundedCorners = true;
            this.guna2Button4.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Button4.BorderRadius = 15;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.Gray;
            this.guna2Button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(377, 353);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(118, 33);
            this.guna2Button4.TabIndex = 49;
            this.guna2Button4.Text = "Clear";
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
            this.btnEsc.Location = new System.Drawing.Point(345, 3);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(38, 33);
            this.btnEsc.TabIndex = 50;
            this.btnEsc.Text = "X";
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // frmProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 616);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.dgvProductAll);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductDetail";
            this.Text = "商品詳細資訊";
            this.Load += new System.EventHandler(this.frmProductDetail_Load);
            this.gboxProductNew.ResumeLayout(false);
            this.gboxProductEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductAll)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gboxProductNew;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNewProPic;
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.GroupBox gboxProductEdit;
        private System.Windows.Forms.Button btnEditSave;
        private System.Windows.Forms.Button btnEditProPic;
        private System.Windows.Forms.PictureBox pboxProduct;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.DataGridView dgvProductAll;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnCart;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btnEsc;
    }
}