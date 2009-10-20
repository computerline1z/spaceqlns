using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace DAO
{
    public class CDataAdapter
    {
        private string strConnection = "Data Source=DUYTUYEN-PC ;Initial Catalog=QLNV; Integrated Security = True";
        private OleDbConnection mCon = null;
        public CDataAdapter()
        {
            mCon = new OleDbConnection();
            mCon.ConnectionString = strConnection;
        }
        public void ExecuteNonQuery(string sql)
        {
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                mCon.Open();
                cmd.Connection = mCon;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
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
        }
        public DataTable ExecuteQuery(string sql)
        {
            DataTable dt = null;
            try
            {
                mCon.Open();
                OleDbDataAdapter dap = new OleDbDataAdapter(sql, mCon);
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
