using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_6_חלק_א
{
    internal class Store
    {
        DBConnection db = new DBConnection();
       

        public string AddItem(Item item)
        {
            int res = db.AddItemToDB(item);
            if (res != 0) 
            {
                return "1 new item added!";
            }
            else
            {
                return "No item added";
            }
        }
        public string DeleteItem(int code)
        {
            int res = db.DeleteItemFromDB(code);
            if (res != 0)
            {
                return "1 item deleted";
            }
            else
            {
                return "No item deleted";
             }
        }
        public override string ToString()
        {
            string list = db.ReadIteamsTable();
            if (list == "")
            {
                return "No Item";
            }
            else
            {
                return list;
            }
        }
    }
}
