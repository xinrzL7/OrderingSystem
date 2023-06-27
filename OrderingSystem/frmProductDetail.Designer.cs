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
            this.label6 = new System.Windows.Forms.Label();
            this.gboxProductNew = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNewProPic = new System.Windows.Forms.Button();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.gboxProductEdit = new System.Windows.Forms.GroupBox();
            this.btnEditSave = new System.Windows.Forms.Button();
            this.btnEditProPic = new System.Windows.Forms.Button();
            this.pboxProduct = new System.Windows.Forms.PictureBox();
            this.txtProductCaption = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gboxProductNew.SuspendLayout();
            this.gboxProductEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Ivory;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(411, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 34);
            this.label6.TabIndex = 25;
            this.label6.Text = "商品維護資訊";
            // 
            // gboxProductNew
            // 
            this.gboxProductNew.BackColor = System.Drawing.Color.Ivory;
            this.gboxProductNew.Controls.Add(this.btnClear);
            this.gboxProductNew.Controls.Add(this.btnNewProPic);
            this.gboxProductNew.Controls.Add(this.btnNewProduct);
            this.gboxProductNew.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gboxProductNew.Location = new System.Drawing.Point(512, 421);
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
            this.btnNewProPic.Location = new System.Drawing.Point(67, 39);
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
            this.gboxProductEdit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gboxProductEdit.Location = new System.Drawing.Point(61, 421);
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
            this.pboxProduct.Location = new System.Drawing.Point(512, 135);
            this.pboxProduct.Name = "pboxProduct";
            this.pboxProduct.Size = new System.Drawing.Size(395, 271);
            this.pboxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxProduct.TabIndex = 22;
            this.pboxProduct.TabStop = false;
            // 
            // txtProductCaption
            // 
            this.txtProductCaption.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProductCaption.Location = new System.Drawing.Point(187, 250);
            this.txtProductCaption.Multiline = true;
            this.txtProductCaption.Name = "txtProductCaption";
            this.txtProductCaption.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProductCaption.Size = new System.Drawing.Size(279, 156);
            this.txtProductCaption.TabIndex = 21;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProductPrice.Location = new System.Drawing.Point(187, 194);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(189, 35);
            this.txtProductPrice.TabIndex = 20;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProductName.Location = new System.Drawing.Point(187, 135);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(279, 35);
            this.txtProductName.TabIndex = 19;
            // 
            // txtProductID
            // 
            this.txtProductID.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProductID.Location = new System.Drawing.Point(187, 84);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(189, 35);
            this.txtProductID.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Ivory;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(798, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 30);
            this.label5.TabIndex = 17;
            this.label5.Text = "商品圖檔";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(56, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "商品描述";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(56, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "商品價格";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(56, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "商品名稱";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(56, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID";
            // 
            // frmProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1075, 641);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gboxProductNew);
            this.Controls.Add(this.gboxProductEdit);
            this.Controls.Add(this.pboxProduct);
            this.Controls.Add(this.txtProductCaption);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmProductDetail";
            this.Text = "商品詳細資訊";
            this.Load += new System.EventHandler(this.frmProductDetail_Load);
            this.gboxProductNew.ResumeLayout(false);
            this.gboxProductEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gboxProductNew;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNewProPic;
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.GroupBox gboxProductEdit;
        private System.Windows.Forms.Button btnEditSave;
        private System.Windows.Forms.Button btnEditProPic;
        private System.Windows.Forms.PictureBox pboxProduct;
        private System.Windows.Forms.TextBox txtProductCaption;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}