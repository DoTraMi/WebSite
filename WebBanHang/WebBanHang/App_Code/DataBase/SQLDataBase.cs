using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

/// <summary>
/// Summary description for SQLDataBase
/// </summary>
namespace QuanLyBanHang
{
    /// <summary>
    /// Class thuc hien cac phuong thuc connect, truy van lenh sql, tra du lieu ve bang
    /// </summary>
    public class SQLDataBase
    {
        #region Khai bao bien chuoi connect
        /// <summary>
        /// khai bao bien chuoi connect
        /// </summary>
        private static string _connectionString = string.Empty;

        public static string ConnectionString
        {
            get
            {
                if (_connectionString.Equals(""))
                {
                    _connectionString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]; 
                    //_connectionString = @"Data Source=DESKTOP-66DCJS3\SQLEXPRESS;Initial Catalog=QuanLyHangThai;User ID=sa;Password=123456";
                }
                return _connectionString;
            }
            set
            {
                _connectionString = value;
            }
        }
        #endregion

        #region Mo ket noi vao CSDL
        /// <summary>
        /// Mo ket noi vao CSDL
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }
        #endregion

        #region Phuong thuc thuc hien lenh truy van sql delete, update, insert
        /// <summary>
        /// Thuc hien lenh truy van sql delete, update, insert
        /// </summary>
        /// <param name="cmd"></param>
        public static void ExecuteNoneQuery(SqlCommand cmd)
        {
            if(cmd.Connection != null)
            {
                cmd.ExecuteNonQuery();
            }
            else
            {
                SqlConnection conn = GetConnection();
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Phuong thuc thuc hien lenh truy van sql Select tra ve 1 bang
        /// <summary>
        /// Phuong thuc thuc hien lenh truy van sql Select tra ve 1 bang
        /// </summary>
        /// <param name="cmd">OleDbCommand</param>
        /// <returns></returns>
        public static DataTable GetData(SqlCommand cmd)
        {
            if(cmd.Connection != null)
            {
                using (DataSet ds = new DataSet())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                        return ds.Tables[0];
                    }
                }
            }
            else
            {
                using (SqlConnection conn = GetConnection())
                {
                    cmd.Connection = conn;
                    using (DataSet ds = new DataSet())
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(ds);
                            return ds.Tables[0];
                        }
                    }
                }
            }
        }
        #endregion

        #region Phuong thuc thuc hien lenh truy van sql Select tra ve nhieu bang
        /// <summary>
        /// Phuong thuc thuc hien lenh truy van sql Select tra ve nhieu bang
        /// </summary>
        /// <param name="cmd">OleDbCommand</param>
        /// <returns></returns>
        public static DataSet SetData_OverDataSet(SqlCommand cmd)
        {
            if (cmd.Connection != null)
            {
                //DataSet chua nhieu DataTable
                using (DataSet ds = new DataSet())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                        return ds;
                    }
                }
            }
            else
            {
                using (SqlConnection conn = GetConnection())
                {
                    cmd.Connection = conn;
                    using (DataSet ds = new DataSet())
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(ds);
                            return ds;
                        }
                    }
                }
            }
        }
        #endregion
    }
}