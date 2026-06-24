using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace home_task_2__6._2_
{
    internal class DBConnection
    {
        string strCon = @"Data Source=DESKTOP-CLD11U2\SQLEXPRESS;Initial Catalog=OranTestRep;Integrated Security=True;Trust Server Certificate=True";
        string strCmd;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adtr;
        DataSet ds;
        DataTable dt;

        public DBConnection()
        {
            con = new SqlConnection(strCon);
            ds = new DataSet();
        }

        public DataTable ItemTable()
        {
            try
            {
                ds.Clear();
                strCmd = "select * from TBItem";
                adtr = new SqlDataAdapter(strCmd, con);
                adtr.Fill(ds);
                dt = ds.Tables["Titem"];
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        public DataTable FilterByAbovePrice(int price)
        {
            ds = new DataSet();
            cmd = new SqlCommand("P_Item_By_Above_Price", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parPrice = new SqlParameter("@Price", SqlDbType.Int);
            parPrice.Value = price;
            parPrice.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(parPrice);

            SqlParameter parReturn = new SqlParameter();
            parReturn.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(parReturn);


            adtr = new SqlDataAdapter(cmd);
            adtr.Fill(ds, "Filter");

            return ds.Tables["Filter"];
        }

        public DataTable InsertItem(Item item)
        {
            try
            {
                dt = ds.Tables["Titem"];
                DataRow dr = dt.NewRow();
                dr["Name"] = item.Name;
                dr["Price"] = item.Price;
                dr["Description"] = item.Description;

                dt.Rows.Add(dr);

                UpdateDB(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        public DataTable DeleteItem(int code)
        {
            try
            {
                dt = ds.Tables["Titem"];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i].RowState != DataRowState.Deleted && dt.Rows[i]["Code"].ToString() == code.ToString())
                    {
                        dt.Rows[i].Delete();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("item not found");
                    }
                }
                UpdateDB(dt);
                return ItemTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        public void UpdateDB(DataTable table)
        {
            new SqlCommandBuilder(adtr);
            adtr.Update(table);
        }

    }
}
