using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace quanlyCF.DTO
{
    public class BillInFo
    {   public BillInFo(int id,int billID,int foodID,int cout)
        {
            this.ID = id;
            this.BillID = billID;
            this.FoodID = foodID;
            this.Cout = cout;
        }
        public BillInFo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.BillID = (int)row["idbill"];
            this.FoodID = (int)row["idfood"];
            this.Cout = (int)row["cout"];
        }
        private int cout;
        private int foodID;
        private int billID;
        private int iD;
        public int ID { get => iD; set => iD = value; }
        public int BillID { get => billID; set => billID = value; }
        public int FoodID { get => foodID; set => foodID = value; }
        public int Cout { get => cout; set => cout = value; }
    }
}
