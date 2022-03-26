using quanlyCF.DTO;
using quanlyCF.NewFolder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace quanlyCF.DAO
{
     class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        { get
            {
                if (instance == null) instance = new BillDAO();
                return instance;
            }
            private set { BillDAO.instance = value; }
        }
        private BillDAO() { }
        public int GetUncheckBillIDByTableID(int id)
        {
            
            DataTable data=DataProvider.Instance.ExecuteQuery("Select * from dbo.Bill Where idTable="+ id +" and status=0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }

    }
}
