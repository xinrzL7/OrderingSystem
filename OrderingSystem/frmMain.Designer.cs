namespace OrderingSystem
{
    partial class frmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnOrderManage = new System.Windows.Forms.Button();
            this.btnProductMaintain = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnSystemMaintain = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMenu.Location = new System.Drawing.Point(12, 28);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(131, 96);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "訂購表單";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnOrderManage
            // 
            this.btnOrderManage.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrderManage.Location = new System.Drawing.Point(160, 28);
            this.btnOrderManage.Name = "btnOrderManage";
            this.btnOrderManage.Size = new System.Drawing.Size(131, 96);
            this.btnOrderManage.TabIndex = 1;
            this.btnOrderManage.Text = "訂單管理";
            this.btnOrderManage.UseVisualStyleBackColor = true;
            // 
            // btnProductMaintain
            // 
            this.btnProductMaintain.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnProductMaintain.Location = new System.Drawing.Point(306, 28);
            this.btnProductMaintain.Name = "btnProductMaintain";
            this.btnProductMaintain.Size = new System.Drawing.Size(131, 96);
            this.btnProductMaintain.TabIndex = 2;
            this.btnProductMaintain.Text = "商品維護";
            this.btnProductMaintain.UseVisualStyleBackColor = true;
            // 
            // btnMember
            // 
            this.btnMember.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMember.Location = new System.Drawing.Point(12, 140);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(131, 96);
            this.btnMember.TabIndex = 3;
            this.btnMember.Text = "會員系統";
            this.btnMember.UseVisualStyleBackColor = true;
            // 
            // btnSystemMaintain
            // 
            this.btnSystemMaintain.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSystemMaintain.Location = new System.Drawing.Point(160, 140);
            this.btnSystemMaintain.Name = "btnSystemMaintain";
            this.btnSystemMaintain.Size = new System.Drawing.Size(131, 96);
            this.btnSystemMaintain.TabIndex = 4;
            this.btnSystemMaintain.Text = "系統維護";
            this.btnSystemMaintain.UseVisualStyleBackColor = true;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSignIn.Location = new System.Drawing.Point(306, 165);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(131, 46);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "登入";
            this.btnSignIn.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(458, 258);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnSystemMaintain);
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.btnProductMaintain);
            this.Controls.Add(this.btnOrderManage);
            this.Controls.Add(this.btnMenu);
            this.Name = "frmMain";
            this.Text = "訂購系統";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnOrderManage;
        private System.Windows.Forms.Button btnProductMaintain;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnSystemMaintain;
        private System.Windows.Forms.Button btnSignIn;
    }
}

