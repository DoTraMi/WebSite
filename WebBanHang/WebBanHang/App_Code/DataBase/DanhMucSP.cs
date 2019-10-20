using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DanhMucSP
/// </summary>
namespace QuanLyBanHang
{
    public class DanhMucSP
    {
        #region Phuong thuc xoa danh muc san pham theo MaDanhMucSP
        /// <summary>
        /// Phuong thuc xoa danh muc san pham theo MaDanhMucSP
        /// </summary>
        /// <param name="MaDanhMucSP">Ma san pham can xoa</param>
        public static void Delete_DanhMucSP(string MaDanhMucSP)
        {
            SqlCommand cmd = new SqlCommand("Delete_DanhMucSP");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDanhMucSP", MaDanhMucSP);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Them moi 1 danh muc san pham vao bang DanhMucSP
        /// <summary>
        /// Them moi 1 danh muc san pham vao bang DanhMucSP
        /// </summary>
        /// <param name="TenDanhMucSP"></param>
        /// <param name="MaDanhMucCha"></param>
        /// <param name="SoSPHienThi"></param>
        /// <param name="ret"></param>
        public static void Insert_DanhMucSP(string TenDanhMucSP, string MaDanhMucCha, string SoSPHienThi, string ret)
        {
            SqlCommand cmd = new SqlCommand("Insert_DanhMucSP");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenDanhMucSP", TenDanhMucSP);
            cmd.Parameters.AddWithValue("@MaDanhMucCha", MaDanhMucCha);
            cmd.Parameters.AddWithValue("@SoSPHienThi", SoSPHienThi);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phuong thuc cap nhat thong tin danh muc san pham
        /// <summary>
        /// Phuong thuc cap nhat thong tin danh muc san pham
        /// </summary>
        /// <param name="MaDanhMucSP"></param>
        /// <param name="TenDanhMucSP"></param>
        /// <param name="SoSPHienThi"></param>
        public static void Update_DanhMucSP(string MaDanhMucSP, string TenDanhMucSP, string MaDanhMucCha, string SoSPHienThi)
        {
            SqlCommand cmd = new SqlCommand("Update_DanhMucSP");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDanhMucSP", MaDanhMucSP);
            cmd.Parameters.AddWithValue("@TenDanhMucSP", TenDanhMucSP);
            cmd.Parameters.AddWithValue("@MaDanhMucCha", MaDanhMucCha);
            cmd.Parameters.AddWithValue("@SoSPHienThi", SoSPHienThi);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phuong thuc lay thong tin tat ca danh muc san pham
        /// <summary>
        /// Phuong thuc lay thong tin tat ca danh muc san pham
        /// </summary>
        public static DataTable Thongtin_DanhMucSP()
        {
            SqlCommand cmd = new SqlCommand("Thongtin_DanhMucSP");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDataBase.GetData(cmd);
        }
        #endregion

        #region Phuong thuc lay thong tin tat ca danh muc san pham theo MaDanhMucCha
        /// <summary>
        /// Phuong thuc lay thong tin tat ca danh muc san pham theo MaDanhMucCha
        /// </summary>
        /// <param name="MaDanhMucCha"></param>
        /// <returns></returns>
        public static DataTable Thongtin_DanhMucSP_By_MaDanhMucCha(string MaDanhMucCha)
        {
            SqlCommand cmd = new SqlCommand("Thongtin_DanhMucSP_By_MaDanhMucCha");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDanhMucCha", MaDanhMucCha);
            return SQLDataBase.GetData(cmd);
        }
        #endregion

        #region Phuong thuc lay thong tin tat ca danh muc san pham theo MaDanhMucSP
        /// <summary>
        /// Phuong thuc lay thong tin tat ca danh muc san pham theo MaDanhMucSP
        /// </summary>
        /// <param name="MaDanhMucSP"></param>
        /// <returns></returns>
        public static DataTable Thongtin_DanhMucSP_By_MaDanhMucSP(string MaDanhMucSP)
        {
            SqlCommand cmd = new SqlCommand("Thongtin_DanhMucSP_By_MaDanhMucSP");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDanhMucSP", MaDanhMucSP);
            return SQLDataBase.GetData(cmd);
        }
        #endregion
    }
}