﻿using quanlyCF.DTO;
using quanlyCF.NewFolder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace quanlyCF.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TableDAO();
                return TableDAO.instance;
            }
            private set { TableDAO.instance = value; }
        }
        private TableDAO() { }
        public static int TableWidth = 100;
        public static int TableHeight = 100;
        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }
    }
}
