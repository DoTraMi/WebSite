using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for NhomSanPham
/// </summary>
namespace QuanLyBanHang
{
    public class NhomSanPham
    {
        #region Phuong thuc xoa nhom san pham theo MaNhom
        /// <summary>
        /// Phuong thuc xoa nhom san pham theo MaNhom
        /// </summary>
        /// <param name="MaNhom">Ma san pham can xoa</param>
        public static void Delete_NhomSanPham(string MaNhom)
        {
            SqlCommand cmd = new SqlCommand("Delete_NhomSanPham");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNhom", MaNhom);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Them moi 1 danh muc san pham vao bang NhomSanPham
        /// <summary>
        /// Them moi 1 danh muc san pham vao bang NhomSanPham
        /// </summary>
        /// <param name="TenNhom"></param>
        /// <param name="ThuTu"></param>
        /// <param name="SoSPHienThi"></param>
        /// <param name="ret"></param>
        public static void Insert_NhomSanPham(string TenNhom, string ThuTu, string SoSPHienThi, string ret)
        {
            SqlCommand cmd = new SqlCommand("Insert_NhomSanPham");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenNhom", TenNhom);
            cmd.Parameters.AddWithValue("@ThuTu", ThuTu);
            cmd.Parameters.AddWithValue("@SoSPHienThi", SoSPHienThi);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phuong thuc cap nhat thong tin nhom san pham
        /// <summary>
        /// Phuong thuc cap nhat thong tin nhom san pham
        /// </summary>
        /// <param name="MaNhom"></param>
        /// <param name="TenNhom"></param>
        /// <param name="ThuTu"></param>
        /// <param name="SoSPHienThi"></param>
        public static void Update_NhomSanPham(string MaNhom, string TenNhom, string ThuTu, string SoSPHienThi)
        {
            SqlCommand cmd = new SqlCommand("Update_NhomSanPham");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNhom", MaNhom);
            cmd.Parameters.AddWithValue("@TenNhom", TenNhom);
            cmd.Parameters.AddWithValue("@ThuTu", ThuTu);
            cmd.Parameters.AddWithValue("@SoSPHienThi", SoSPHienThi);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phuong thuc lay thong tin tat ca nhom san pham
        /// <summary>
        /// Phuong thuc lay thong tin tat ca nhom san pham
        /// </summary>
        public static DataTable Thongtin_NhomSanPham()
        {
            SqlCommand cmd = new SqlCommand("Thongtin_NhomSanPham");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDataBase.GetData(cmd);
        }
        #endregion

        #region Phuong thuc lay thong tin tat ca nhom san pham bang MaNhom
        /// <summary>
        /// Phuong thuc lay thong tin tat ca nhom san pham bang MaNhom
        /// </summary>
        /// <param name="MaNhom"></param>
        /// <returns></returns>
        public static DataTable Thongtin_NhomSanPham_By_MaNhom(string MaNhom)
        {
            SqlCommand cmd = new SqlCommand("Thongtin_NhomSanPham_By_MaNhom");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNhom", MaNhom);
            return SQLDataBase.GetData(cmd);
        }
        #endregion
    }
}