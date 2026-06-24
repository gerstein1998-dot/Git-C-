using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace class_task_1
{
    internal class DBconection
    {
        string strCon = @"Data Source=DESKTOP-CLD11U2\SQLEXPRESS;Initial Catalog=""class task 7"";Integrated Security=True;Trust Server Certificate=True";
        string strCmd;

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        public DBconection()
        {
            con = new SqlConnection(strCon);
        }

        public string ReadKnightsTable()
        {
            string list = "";
            try
            {
                strCmd = "select * from KnightsTable";
                cmd = new SqlCommand(strCmd, con);
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list += $"ID: {reader["ID"]} First Name: {reader["FirstName"]}," +
                        $" Last Name: {reader["LastName"]}, Power: {reader["Power"]}\n"; // אין צורך לשים פה TOSTRNG
                }
                return list;
            }
            catch (Exception ex)
            {
                return "Exception:" + ex.Message;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            
        }


        public int AddKnightToDB(Knight knight)
        {
            int res = 0;
            try
            {
                strCmd = $"insert KnightsTable values " +
                    $" ('{knight.FirstName}', '{knight.LastName}', '{knight.Power}')";//תבנית השאילתה שאנחנו הולכים להריץ
                cmd = new SqlCommand(strCmd, con);
                con.Open();
                res = cmd.ExecuteNonQuery();

               // res = ExcNonQ(strCmd);
                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                return res;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }


        public int DeletKnightFromDB(int id)
        {
            int res = 0;
            try
            {
                strCmd = $"DELETE FROM KnightsTable WHERE ID = {id}";
                cmd = new SqlCommand(strCmd, con);
                con.Open();
                res = cmd.ExecuteNonQuery();
               // res = ExcNonQ(strCmd);
                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                return res;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public string PrintKnightsByPower(string power)
        {
            string knightPower = "";
            try
            {
                strCmd = "select * from KnightsTable " +
                    $" where Power = '{power}'";
                cmd = new SqlCommand(strCmd, con);
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    knightPower += $"ID: {reader["ID"]}, first name: {reader["FirstName"]}," +
                        $"last name: {reader["LastName"]} " +
                        $" power: {reader["Power"]} \n";
                }
                if (knightPower == "") // אם לא מצא אביר עם הכוח הזה 
                {
                    throw new Exception($"dont have knight with {power} power");
                }

                return knightPower;
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


        //public int ExcNonQ(string strCmd)
        //{
        //    int res = 0;
        //    try
        //    {
        //        cmd = new SqlCommand(strCmd, con);
        //        con.Open();
        //        res = cmd.ExecuteNonQuery();
        //        return res;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine( ex.Message);
        //        return res;
        //    }
        //    finally
        //    {
        //        if (con != null)
        //        {
        //            con.Close();
        //        }
        //    }

            

        }
    }

