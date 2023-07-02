using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OrderingSystem
{
    public partial class frmAdmin : Form
    {
        private frmHome home;

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin(home);
            login.ShowDialog();
            this.Close();
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            frmProductDetail pd = new frmProductDetail();
            pd.ShowDialog();
        }

        private void btnMM_Click(object sender, EventArgs e)
        {
            frmMemberInfo mm =  new frmMemberInfo();
            mm.ShowDialog();
        }

        private void btnOM_Click(object sender, EventArgs e)
        {
            frmOrderManagement om = new frmOrderManagement();
            om.ShowDialog();
        }
        
    }
}
