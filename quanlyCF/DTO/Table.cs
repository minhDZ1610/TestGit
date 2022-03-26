using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace quanlyCF.DTO
{
    public class Table
    {
           public Table(int id, string name, string status)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }

        private int iD;
        private string status;
        private string name;


        public int ID { get => iD; set => iD = value; }
        public string Status { get => status; set => status = value; }
        public string Name { get => name; set => name = value; }
        public Table(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["NAME"].ToString();
            this.Status = row["STATUS"].ToString();
        }
  
    }
}
