namespace OrderingSystem
{
    partial class frmProductMaintain
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.btnListMode = new System.Windows.Forms.Button();
            this.btnPicMode = new System.Windows.Forms.Button();
            this.lvShowProduct = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.imglistProduct = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Linen;
            this.btnRefresh.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRefresh.Location = new System.Drawing.Point(590, 366);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(127, 40);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "重新整理";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.BackColor = System.Drawing.Color.Linen;
            this.btnNewProduct.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNewProduct.Location = new System.Drawing.Point(404, 366);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(127, 40);
            this.btnNewProduct.TabIndex = 10;
            this.btnNewProduct.Text = "新增商品";
            this.btnNewProduct.UseVisualStyleBackColor = false;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // btnListMode
            // 
            this.btnListMode.BackColor = System.Drawing.Color.Linen;
            this.btnListMode.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnListMode.Location = new System.Drawing.Point(217, 366);
            this.btnListMode.Name = "btnListMode";
            this.btnListMode.Size = new System.Drawing.Size(127, 40);
            this.btnListMode.TabIndex = 9;
            this.btnListMode.Text = "列表模式";
            this.btnListMode.UseVisualStyleBackColor = false;
            this.btnListMode.Click += new System.EventHandler(this.btnListMode_Click);
            // 
            // btnPicMode
            // 
            this.btnPicMode.BackColor = System.Drawing.Color.Linen;
            this.btnPicMode.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPicMode.Location = new System.Drawing.Point(41, 366);
            this.btnPicMode.Name = "btnPicMode";
            this.btnPicMode.Size = new System.Drawing.Size(127, 40);
            this.btnPicMode.TabIndex = 8;
            this.btnPicMode.Text = "圖片模式";
            this.btnPicMode.UseVisualStyleBackColor = false;
            this.btnPicMode.Click += new System.EventHandler(this.btnPicMode_Click);
            // 
            // lvShowProduct
            // 
            this.lvShowProduct.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvShowProduct.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lvShowProduct.HideSelection = false;
            this.lvShowProduct.Location = new System.Drawing.Point(41, 89);
            this.lvShowProduct.Name = "lvShowProduct";
            this.lvShowProduct.Size = new System.Drawing.Size(676, 232);
            this.lvShowProduct.TabIndex = 7;
            this.lvShowProduct.UseCompatibleStateImageBehavior = false;
            this.lvShowProduct.ItemActivate += new System.EventHandler(this.lvShowProduct_ItemActivate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(287, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "商品維護表單";
            // 
            // imglistProduct
            // 
            this.imglistProduct.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imglistProduct.ImageSize = new System.Drawing.Size(256, 256);
            this.imglistProduct.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmProductMaintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(767, 444);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnNewProduct);
            this.Controls.Add(this.btnListMode);
            this.Controls.Add(this.btnPicMode);
            this.Controls.Add(this.lvShowProduct);
            this.Controls.Add(this.label1);
            this.Name = "frmProductMaintain";
            this.Text = "商品維護";
            this.Load += new System.EventHandler(this.frmProductMaintain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.Button btnListMode;
        private System.Windows.Forms.Button btnPicMode;
        private System.Windows.Forms.ListView lvShowProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imglistProduct;
    }
}