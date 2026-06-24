using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace task1
{
    public class DBConnection
    {
        string strCon = @"Data Source=DESKTOP-CLD11U2\SQLEXPRESS;Initial Catalog=OranTestRep;Integrated Security=True;Trust Server Certificate=True";
        string strCmd;

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataSet ds;
        DataTable dt;

        public DBConnection()
        {
            con = new SqlConnection(strCon);
            ds = new DataSet();
        }

        public DataTable NumberTable()
        {

            strCmd = "select * from TBNumber";
            adpt = new SqlDataAdapter(strCmd, con);
            adpt.Fill(ds);
            dt = ds.Tables["TBNum"];

            return dt;

        }

        public DataTable MaxNumber()
        {
            strCmd = " select * from TBGames";
            adpt = new SqlDataAdapter(strCmd, con);
            adpt.Fill(ds);
            dt = ds.Tables["TBNum"];

            return dt;
        }

        public DataTable InsertToTBGames(int game, DateTimeIRN dateTime)
        {
            dt = ds.Tables["TBGame"];
            DataRow dr = dt.NewRow();
            dr["GameId"] = game;
            dr["MaxNumber"] = dateTime.Number;

            dt.Rows.Add(dr);
            UpdateDB(dt);
            return dt;
        }
        public DataTable InsertToTBNum(int game, DateTimeIRN dateTime)
        {
            dt = ds.Tables["TBNum"];
            DataRow dr = dt.NewRow();

            dr["GameId"] = game;
            dr["RNumber"] = dateTime.Number;

            dt.Rows.Add(dr);

            UpdateDB(dt);
            return dt;

        }


        public void UpdateDB(DataTable table)
        {
            new SqlCommandBuilder(adpt);
            adpt.Update(table);
        }

    }
}
