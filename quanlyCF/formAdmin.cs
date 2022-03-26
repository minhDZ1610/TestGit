using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using quanlyCF.NewFolder;

namespace quanlyCF
{
    public partial class formAdmin : Form
    {
        public formAdmin()
        {   
            InitializeComponent();
            LoadAccountList();
        }
        void LoadAccountList()
        {   
            string query = "EXEC dbo.USP_GetaccountbyuserName @userName";
          
            dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query,new object[]{ "Minh" });
        }
        void loadFoodList()
        {
            string query = "select * from food";

            dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
