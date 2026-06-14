using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace תרגיל_6_חלק_ב._2
{
    internal class Store
    {
        DBconection db;
        public Store()
        {
            db = new DBconection();
        }
        public DataTable ItemsTable()
        {
            return db.ItemsTable();
        }

        public DataTable InsertItem(Item item)
        {

            return db.InsertItem(item);
        }
        public DataTable DeleteItem(int code)
        {

            return db.DeleteItem(code);
        }
        public DataTable FilterByAbovePrice(int price)
        {
            return db.FilterByAbovePrice(price);
        }
        //public DataTable update(DataTable table)
        //{
        //    db.updateDB(table);
        //    return db.ItemsTable();
        //}
    }
}
