using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace home_task_2__6._2_
{
    internal class Store
    {
        DBConnection db;

        public Store()
        {
            db= new DBConnection();
        }

        public DataTable ItemTable()
        {
            return db.ItemTable();
        }

        public DataTable FilterByAbovePrice(int price)
        {
            return db.FilterByAbovePrice(price);
        }

        public DataTable InsertItem(Item item)
        {
           return db.InsertItem(item);
        }

        public DataTable DeleteItem(int code)
        {
        return    db.DeleteItem(code);
        }

        //public void Update(DataTable table)
        //{

        //}
    }
}
