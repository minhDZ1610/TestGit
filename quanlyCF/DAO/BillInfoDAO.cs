using quanlyCF.DTO;
using quanlyCF.NewFolder;
using System.Collections.Generic;
using System.Data;



namespace quanlyCF.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO();return BillInfoDAO.instance; }
            private set { instance = value; }
        }
        private BillInfoDAO() { }
        public List<BillInFo> GetListBillInfo(int id)
        {
            List<BillInFo> listBillInfo = new List<BillInFo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from dbo.BillInfo where idBill=" + id + "");
            foreach(DataRow item in data.Rows)
            {
                BillInFo info = new BillInFo(item);
                listBillInfo.Add(info);
            }
            return listBillInfo;
        }
    }
}
