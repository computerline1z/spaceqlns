using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace moncongcu
{
  public  class KetNoi
    {
                       
    protected static String sqlConnection;
    public static SqlConnection GetConnection()
    {
       // return new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        sqlConnection =  @"Data Source=.\SQLEXPRESS;Initial Catalog=QLNV;Integrated Security=True";
        return new SqlConnection(sqlConnection);
    }
   public static SqlConnection OpenConnection()
    {
        SqlConnection cn = GetConnection();
        try
        {
            cn.Open();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return cn;
    }
    

    #region ExecuteQuery
    public static DataTable  ExecuteQuery(String spNames, List<SqlParameter> sqlParams)
    {
        DataTable dt = new DataTable();
        try
        {
            SqlConnection cn =OpenConnection();
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = spNames;
                if (sqlParams != null)
                {
                    foreach (SqlParameter param in sqlParams)
                    {
                        cmd.Parameters.Add(param);
                    }
                }
                SqlDataAdapter apdater = new SqlDataAdapter();
                apdater.SelectCommand = cmd;
                apdater.Fill(dt);
                cn.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return dt;
    }
    public static DataTable ExecuteQuery(String spName)
    {
        return ExecuteQuery(spName, null);
    }
    public static DataTable StringExecuteQuery(String sql)
    {
        DataTable dt = new DataTable();
        try
        {
            SqlConnection cn = OpenConnection();
            try
            {
                SqlDataAdapter apdater = new SqlDataAdapter(sql, cn);               
                apdater.Fill(dt);
                cn.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return dt;  
    }
    #endregion

    #region ExecuteNonQuery
    public static int ExecuteNonQuery(String spNames, List<SqlParameter> sqlParams)
    {
        int n = 0;
        try
        {
            SqlConnection cn = OpenConnection();
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = spNames;
                if (sqlParams != null)
                {
                    foreach (SqlParameter param in sqlParams)
                        cmd.Parameters.Add(param);
                }
                n = cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return n;
    }
     public static int ExecuteNonQuery(String spNames)
    {
        return ExecuteNonQuery(spNames, null);
    }
      public static int StringExecuteNonQuery(string sql)
    {
        int n = 0;
        try
        {
            SqlConnection cn = OpenConnection();
            try
            {
                SqlCommand cmd = cn.CreateCommand();           
                cmd.CommandText = sql;                
                n = cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return n;
        
    }

    #endregion


    }
}
