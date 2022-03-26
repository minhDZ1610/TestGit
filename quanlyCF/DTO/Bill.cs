using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace quanlyCF.DTO
{
    class Bill
    {   public Bill(int id,DateTime? datecheckout, DateTime? datecheckin,int status)
        {
            this.ID = id;
            this.Datecheckin = datecheckin;
            this.Datecheckout = datecheckout;
            this.Status2 = status;
        }
        public Bill(DataRow Row)
        {
            this.ID = (int)Row["id"];
            this.Datecheckin = (DateTime)Row["dataCheckin"];
            this.Datecheckout = (DateTime)Row["dataCheckout"];
            this.Status = (int)Row["status"];
        }
        private int iD;

        public int ID { get => iD; set => iD = value; }
        private DateTime? datecheckout;
        private DateTime? datecheckin;
        private int Status;
        public DateTime? Datecheckout { get => datecheckout; set => datecheckout = value; }
        public DateTime? Datecheckin { get => datecheckin; set => datecheckin = value; }
        public int Status1 { get => Status2; set => Status2 = value; }
        public int Status2 { get => Status; set => Status = value; }

        
    }
}
