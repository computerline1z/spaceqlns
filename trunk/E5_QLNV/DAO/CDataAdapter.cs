using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class CDataAdapter
    {
        private string strConnection = "Data Source=UDMAN\\SQLEXPRESS ;Initial Catalog=QLNV; Integrated Security = True";
        private SqlConnection mCon = null;
        public CDataAdapter()
        {
            mCon = new SqlConnection ();
            mCon.ConnectionString = strConnection;
        }
        public int ExecuteNonQuery(string sql)
        {
            int n = 0;
            SqlCommand cmd = new SqlCommand ();
            try
            {
                mCon.Open();
                cmd.Connection = mCon;
                cmd.CommandText = sql;
                n=cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (mCon.State == ConnectionState.Open)
                    mCon.Close();
            }
            return n;
        }
        public DataTable ExecuteQuery(string sql)
        {
            DataTable dt = null;
            try
            {
                mCon.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, mCon);                
                dt = new DataTable();
                dap.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (mCon.State == ConnectionState.Open)
                    mCon.Close();
            }
            return dt;
        }
    }
}
