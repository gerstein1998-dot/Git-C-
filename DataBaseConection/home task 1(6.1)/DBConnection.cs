using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace home_task_1_6._1_
{
    internal class DBConnection
    {
        string strCon = @"Data Source=DESKTOP-CLD11U2\SQLEXPRESS;Initial Catalog=OranTestRep;Integrated Security=True;Trust Server Certificate=True";
        string strCmd;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        public DBConnection()
        {
            con = new SqlConnection(strCon);
        }

        public string ReadItemsTable()
        {
            string listItems = "";
            try
            {
                strCmd = $"select * from TBItem";
                cmd = new SqlCommand(strCmd, con);
                con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listItems += $"Code: {reader["Code"].ToString()}, Name: {reader["Name"]}" +
                        $"Price: {reader["Price"].ToString()}, Descrition: {reader["Description"]}" + "\n";
                }

                if (listItems == "")
                {
                    throw new Exception("No Items");
                }
                return listItems;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public int AddItemToDB(Item item)
        {
            int res = 0;
            try
            {
                strCmd = $"insert into TBItem (Name, Price, Description)" +
                $"values ('{item.Name}','{item.Price}','{item.Description}')";
                res = ExcNonQ(strCmd);
                return res;
            }
            catch (Exception ex)
            {
                return res=-1;
            }

        }


        public int DeleteItemFromDB(int code)
        {
            int res = 0;
            try
            {
                strCmd = $"delete from TBItem " +
                    $" where Code = {code}";
                res = ExcNonQ(strCmd);
                return res;
            }
            catch (Exception ex)
            {
                return res= -1;
            }
            


        }
        public int ExcNonQ(string strCmd)
        {
            int res = 0;
            try
            {
                con = new SqlConnection(strCon);
                con.Open();
                cmd = new SqlCommand(strCmd, con);
                res = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return res;
        }
    }
}
