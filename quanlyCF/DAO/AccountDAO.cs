using quanlyCF.NewFolder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace quanlyCF.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO();
                return AccountDAO.instance;
            }
            private set { instance = value; }

        }
        private AccountDAO() { }
        public bool login(string username, string password)
        {
            
            string query = " USP_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query,new object[] {username,password });
            return result.Rows.Count>0;
        }
        
    }
}
