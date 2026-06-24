using System;
using System.Collections.Generic;
using System.Text;

namespace home_task_1_6._1_
{
    internal class Store
    {
        Store[] store;
        DBConnection db = new DBConnection();

        public Store()
        {
            store = new Store[0];
        }

        public override string ToString()
        {
            return db.ReadItemsTable();
        }
        
        public void AddItem(Item item)
        {
           int res = db.AddItemToDB(item);
            if (res == 1)
            {
                Console.WriteLine("1 new item added!");
            }
            else
            {
                Console.WriteLine("No item added!");
            }
        }

        public void DeleteItem(int code)
        {
            int res = db.DeleteItemFromDB(code);
            if (res == 1)
            {
                Console.WriteLine("1 item deleted!");
            }
            else
            {
                Console.WriteLine("No item deleted!"); 
            }
        }
    }
}
