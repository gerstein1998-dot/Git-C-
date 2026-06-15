using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace targil_7_class
{
    internal class DBConnection
    {
        string strCon = @"Data Source=DESKTOP-CLD11U2\SQLEXPRESS;Initial Catalog=KnightsGUI;Integrated Security=True;Trust Server Certificate=True";
        string strCmd;

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        public DBConnection()
        {
            con = new SqlConnection(strCon);
        }
        public string ReadKnightsTable()
        {
            string res = "";
            try
            {
                con.Open();
                strCon = @"select * from KnightsTable";
                cmd = new SqlCommand(strCmd, con);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    knight k = new knight(int.Parse(reader["ID"].ToString()), reader["FirstName"].ToString(), reader["LastName"].ToString(), reader["Power"].ToString());
                    res += k.ToString()+  "\n";
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
            return res;
            
        }
        public int AddKnightToDB(knight knight)
        {
            return 1;
        }
        public int DeleteKnightFromDB(int ID)
        {
            return 1;
        }
        public string PrintKnightsByPower(string power)
        {
            return "";
        }
    }
}
