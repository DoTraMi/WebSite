using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for QuyenDangNhap
/// </summary>
namespace QuanLyBanHang
{
    public class QuyenDangNhap
    {

        #region Phuong thuc xoa quyen dang nhap theo MaQuyen
        /// <summary>
        /// Phuong thuc xoa danh muc san pham theo MaDanhMucSP
        /// </summary>
        /// <param name="MaQuyen"></param>
        public static void Delete_QuyenDangNhap(string MaQuyen)
        {
            SqlCommand cmd = new SqlCommand("Delete_QuyenDangNhap");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaQuyen", MaQuyen);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Them moi 1 quyen dang nhap
        /// <summary>
        /// Them moi 1 quyen dang nhap
        /// </summary>
        /// <param name="TenQuyen"></param>
        /// <param name="MaQuyenCha"></param>
        /// <param name="ret"></param>
        public static void Insert_QuyenDangNhap(string TenQuyen, string MaQuyenCha, string ret)
        {
            SqlCommand cmd = new SqlCommand("Insert_QuyenDangNhap");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenQuyen", TenQuyen);
            cmd.Parameters.AddWithValue("@MaQuyenCha", MaQuyenCha);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phuong thuc cap nhat thong tin quyen dang nhap
        /// <summary>
        /// Phuong thuc cap nhat thong tin quyen dang nhap
        /// </summary>
        /// <param name="MaQuyen"></param>
        /// <param name="TenQuyen"></param>
        /// <param name="MaQuyenCha"></param>
        public static void Update_QuyenDangNhap(string MaQuyen, string TenQuyen, string MaQuyenCha)
        {
            SqlCommand cmd = new SqlCommand("Update_QuyenDangNhap");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaQuyen", MaQuyen);
            cmd.Parameters.AddWithValue("@TenQuyen", TenQuyen);
            cmd.Parameters.AddWithValue("@MaQuyenCha", MaQuyenCha);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phuong thuc lay thong tin tat ca quyen dang nhap
        /// <summary>
        /// Phuong thuc lay thong tin tat ca quyen dang nhap
        /// </summary>
        public static DataTable Thongtin_QuyenDangNhap()
        {
            SqlCommand cmd = new SqlCommand("Thongtin_QuyenDangNhap");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDataBase.GetData(cmd);
        }
        #endregion
    }
}