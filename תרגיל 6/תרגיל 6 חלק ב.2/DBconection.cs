using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace תרגיל_6_חלק_ב._2
{
    internal class DBconection
    {
        string strCon = @"Data Source=DESKTOP-CLD11U2\SQLEXPRESS;Initial Catalog=""targil 6 oran"";Integrated Security=True;Trust Server Certificate=True";
        string strCmd = "";

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;

        public DBconection()
        {
            con = new SqlConnection(strCon);
            ds = new DataSet();
        }
        public DataTable ItemsTable()
        {
            try
            {
                ds.Clear();
                strCmd = "SELECT * FROM TBitemS";          //קורא לכל הטבלה שיש במסד נתונים
                adapter = new SqlDataAdapter(strCmd, con); //מחבר את האדפטר שימשוך נתונים מתוך החיבור ביחד עם השאילתא שכתבתי
                adapter.Fill(ds, "Items");                 // ממלא את הדאטה סט שיצרנו עם המסד נתונים
                dt = ds.Tables["Items"];                   // ממלא את הטבלה שיצרנו וקורא לה בשם שנתנו לה
                return dt;                                 // מחזיר את הטבלה שיצרתי בסיש

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable InsertItem(Item item)
        {
            try
            {
                dt = ds.Tables["Items"];
                if (dt == null)
                {
                    MessageBox.Show("Null Table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return null;
                }
                DataRow dr = dt.NewRow();
                dr["Name"] = item.Name;
                dr["Description"] = item.Description;
                dr["Price"] = item.Price;

                dt.Rows.Add(dr);                  // בעצם מויסף לי את השורה הזאת לתוך הטבלה שלי בסיש

                //מעדכנים את מסד הנתונים 
                updateDB(dt);

                return ItemsTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
        public DataTable DeleteItem(int code)
        {
            try
            {
                dt = ds.Tables["Items"];
                if (dt == null)
                {
                    MessageBox.Show("Null Table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return null;
                }
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
                //מעדכנים את מסד הנתונים 
                updateDB(dt);

                return ItemsTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        public void updateDB(DataTable table)
        {
            new SqlCommandBuilder(adapter);
            adapter.Update(table);
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

            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds, "Filter");

            return ds.Tables["Filter"];
        }

    }
}
