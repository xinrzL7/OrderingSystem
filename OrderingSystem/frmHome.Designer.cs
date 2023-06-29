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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.cboxCategories = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lvProducts = new System.Windows.Forms.ListView();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imglistTop = new System.Windows.Forms.ImageList(this.components);
            this.btnEsc = new Guna.UI2.WinForms.Guna2Button();
            this.imglistBottoms = new System.Windows.Forms.ImageList(this.components);
            this.imglistOutwears = new System.Windows.Forms.ImageList(this.components);
            this.imglistDress = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // cboxCategories
            // 
            this.cboxCategories.AutoRoundedCorners = true;
            this.cboxCategories.BackColor = System.Drawing.Color.Transparent;
            this.cboxCategories.BorderRadius = 17;
            this.cboxCategories.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategories.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cboxCategories.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxCategories.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxCategories.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.cboxCategories.ForeColor = System.Drawing.Color.Black;
            this.cboxCategories.ItemHeight = 30;
            this.cboxCategories.Items.AddRange(new object[] {
            "Top",
            "Bottoms",
            "Outwears",
            "Dress"});
            this.cboxCategories.Location = new System.Drawing.Point(12, 63);
            this.cboxCategories.Name = "cboxCategories";
            this.cboxCategories.Size = new System.Drawing.Size(172, 36);
            this.cboxCategories.StartIndex = 0;
            this.cboxCategories.TabIndex = 36;
            this.cboxCategories.SelectedIndexChanged += new System.EventHandler(this.cboxCategories_SelectedIndexChanged);
            // 
            // lvProducts
            // 
            this.lvProducts.HideSelection = false;
            this.lvProducts.Location = new System.Drawing.Point(226, 63);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(933, 589);
            this.lvProducts.TabIndex = 37;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoRoundedCorners = true;
            this.btnLogin.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.DimGray;
            this.btnLogin.Location = new System.Drawing.Point(949, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(102, 42);
            this.btnLogin.TabIndex = 39;
            this.btnLogin.Text = "Log in";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboxCategories);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 664);
            this.panel1.TabIndex = 40;
            // 
            // imglistTop
            // 
            this.imglistTop.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistTop.ImageStream")));
            this.imglistTop.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistTop.Images.SetKeyName(0, "top1.png");
            this.imglistTop.Images.SetKeyName(1, "top2.png");
            this.imglistTop.Images.SetKeyName(2, "top3.png");
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
            this.btnEsc.Location = new System.Drawing.Point(1132, 21);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(38, 33);
            this.btnEsc.TabIndex = 41;
            this.btnEsc.Text = "X";
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // imglistBottoms
            // 
            this.imglistBottoms.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglistBottoms.ImageSize = new System.Drawing.Size(256, 256);
            this.imglistBottoms.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imglistOutwears
            // 
            this.imglistOutwears.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglistOutwears.ImageSize = new System.Drawing.Size(256, 256);
            this.imglistOutwears.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imglistDress
            // 
            this.imglistDress.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglistDress.ImageSize = new System.Drawing.Size(256, 256);
            this.imglistDress.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 664);
            this.Controls.Add(this.btnEsc);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lvProducts);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ComboBox cboxCategories;
        private System.Windows.Forms.ListView lvProducts;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imglistTop;
        private Guna.UI2.WinForms.Guna2Button btnEsc;
        private System.Windows.Forms.ImageList imglistBottoms;
        private System.Windows.Forms.ImageList imglistOutwears;
        private System.Windows.Forms.ImageList imglistDress;
    }
}