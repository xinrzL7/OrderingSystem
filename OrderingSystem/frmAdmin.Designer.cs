namespace OrderingSystem
{
    partial class frmAdmin
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
            this.btnPM = new Guna.UI2.WinForms.Guna2Button();
            this.lblAdminHi = new System.Windows.Forms.Label();
            this.btnSignout = new Guna.UI2.WinForms.Guna2Button();
            this.btnMM = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnEsc = new Guna.UI2.WinForms.Guna2Button();
            this.btnOM = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPM
            // 
            this.btnPM.AutoRoundedCorners = true;
            this.btnPM.BorderColor = System.Drawing.Color.Gray;
            this.btnPM.BorderRadius = 16;
            this.btnPM.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPM.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnPM.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnPM.ForeColor = System.Drawing.Color.DimGray;
            this.btnPM.Location = new System.Drawing.Point(43, 241);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(278, 35);
            this.btnPM.TabIndex = 0;
            this.btnPM.Text = "Product Management";
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // lblAdminHi
            // 
            this.lblAdminHi.AutoSize = true;
            this.lblAdminHi.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminHi.ForeColor = System.Drawing.Color.DimGray;
            this.lblAdminHi.Location = new System.Drawing.Point(96, 168);
            this.lblAdminHi.Name = "lblAdminHi";
            this.lblAdminHi.Size = new System.Drawing.Size(163, 36);
            this.lblAdminHi.TabIndex = 1;
            this.lblAdminHi.Text = "Administer";
            // 
            // btnSignout
            // 
            this.btnSignout.AutoRoundedCorners = true;
            this.btnSignout.BorderColor = System.Drawing.Color.LightGray;
            this.btnSignout.BorderRadius = 17;
            this.btnSignout.BorderThickness = 1;
            this.btnSignout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignout.FillColor = System.Drawing.Color.White;
            this.btnSignout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSignout.ForeColor = System.Drawing.Color.DarkGray;
            this.btnSignout.Location = new System.Drawing.Point(127, 421);
            this.btnSignout.Name = "btnSignout";
            this.btnSignout.Size = new System.Drawing.Size(106, 37);
            this.btnSignout.TabIndex = 2;
            this.btnSignout.Text = "Sign out";
            this.btnSignout.Click += new System.EventHandler(this.btnSignout_Click);
            // 
            // btnMM
            // 
            this.btnMM.AutoRoundedCorners = true;
            this.btnMM.BorderColor = System.Drawing.Color.Gray;
            this.btnMM.BorderRadius = 19;
            this.btnMM.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMM.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnMM.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnMM.ForeColor = System.Drawing.Color.DimGray;
            this.btnMM.Location = new System.Drawing.Point(43, 299);
            this.btnMM.Name = "btnMM";
            this.btnMM.Size = new System.Drawing.Size(278, 40);
            this.btnMM.TabIndex = 3;
            this.btnMM.Text = "Member Management";
            this.btnMM.Click += new System.EventHandler(this.btnMM_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
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
            this.btnEsc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsc.ForeColor = System.Drawing.Color.DimGray;
            this.btnEsc.Location = new System.Drawing.Point(306, 12);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(38, 33);
            this.btnEsc.TabIndex = 42;
            this.btnEsc.Text = "X";
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // btnOM
            // 
            this.btnOM.AutoRoundedCorners = true;
            this.btnOM.BorderColor = System.Drawing.Color.Gray;
            this.btnOM.BorderRadius = 19;
            this.btnOM.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOM.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnOM.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnOM.ForeColor = System.Drawing.Color.DimGray;
            this.btnOM.Location = new System.Drawing.Point(43, 359);
            this.btnOM.Name = "btnOM";
            this.btnOM.Size = new System.Drawing.Size(278, 40);
            this.btnOM.TabIndex = 43;
            this.btnOM.Text = "Order Management";
            this.btnOM.Click += new System.EventHandler(this.btnOM_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OrderingSystem.Properties.Resources.management;
            this.pictureBox1.Location = new System.Drawing.Point(79, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(355, 482);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOM);
            this.Controls.Add(this.btnEsc);
            this.Controls.Add(this.btnMM);
            this.Controls.Add(this.btnSignout);
            this.Controls.Add(this.lblAdminHi);
            this.Controls.Add(this.btnPM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnPM;
        private System.Windows.Forms.Label lblAdminHi;
        private Guna.UI2.WinForms.Guna2Button btnSignout;
        private Guna.UI2.WinForms.Guna2Button btnMM;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnEsc;
        private Guna.UI2.WinForms.Guna2Button btnOM;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}