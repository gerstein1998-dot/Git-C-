using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace תרגיל_6_חלק_א
{
    internal class DBConnection
    {
        string strCon = @"Data Source=DESKTOP-CLD11U2\SQLEXPRESS;Initial Catalog=""targil 6 oran"";Integrated Security=True;Trust Server Certificate=True";
        string strCmd;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        
        public DBConnection()
        {
            con = new SqlConnection(strCon);
        }

        public string ReadIteamsTable()
        {
            string list = "";
            try
            {
                con.Open();
                strCmd = "SELECT * FROM TBitemS";
                cmd = new SqlCommand(strCmd, con);
                reader = cmd.ExecuteReader(); // הרידר יקבל את השאילתה של להחזיר את כל הטבלה מהמסד נתונים
                while (reader.Read())
                {
                    list += $"Code: {reader["Code"].ToString()}, Name: {reader["Name"]}, " + 
                            $"Description: {reader["Description"]}, Price: {reader["Price"].ToString()}\n";
                }
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
            return list;

        }
        public int AddItemToDB(Item item)
        {
            int res = 0;
            try
            {
                strCmd = "insert into TBitemS(Name, Description, Price) " +
                    $"values ('{item.Name}', '{item.Description}', {item.Price})";
                res = ExcNonQ(strCmd);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return res;
        }
        
        public int DeleteItemFromDB(int code)
        {
            int res = 0;
            try
            {
                strCmd = $"DELETE FROM TBitemS WHERE Code = {code}";
                res = ExcNonQ(strCmd);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return res;
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
