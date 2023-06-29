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


namespace OrderingSystem
{
    public partial class frmMember : Form
    {
        SqlConnectionStringBuilder scsb =new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        
        public frmMember()
        {
            InitializeComponent();
        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            scsb.DataSource =@"." ;
            scsb.InitialCatalog = "OlineStore";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString;
        }




    }
}
