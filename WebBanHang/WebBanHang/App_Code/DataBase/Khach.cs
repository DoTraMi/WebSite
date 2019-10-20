using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Khach
/// </summary>
namespace QuanLyBanHang
{
    public class Khach
    {
        #region Phuong thuc xoa khach hang theo id
        /// <summary>
        /// Phuong thuc xoa khach hang theo id
        /// </summary>
        /// <param name="Id_Khach_Hang"></param>
        public static void Delete_KhachHang(string Id_Khach_Hang)
        {
            SqlCommand cmd = new SqlCommand("Delete_KhachHang");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Khach_Hang", Id_Khach_Hang);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Them moi 1 khach hang 
        /// <summary>
        /// Them moi 1 khach hang 
        /// </summary>
        /// <param name="TenKH"></param>
        /// <param name="Facebook"></param>
        /// <param name="Email"></param>
        /// <param name="MatKhau"></param>
        /// <param name="Sdt"></param>
        /// <param name="DiaChi"></param>
        /// <param name="ret"></param>
        public static void Insert_KhachHang(string TenKH, string Facebook, string Email, string MatKhau, string Sdt, string DiaChi, string ret)
        {
            SqlCommand cmd = new SqlCommand("Insert_KhachHang");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenKH", TenKH);
            cmd.Parameters.AddWithValue("@Facebook", Facebook);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
            cmd.Parameters.AddWithValue("@Sdt", Sdt);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phuong thuc cap nhat thong tin khach hang
        /// <summary>
        /// Phuong thuc cap nhat thong tin khach hang
        /// </summary>
        /// <param name="Id_Khach_Hang"></param>
        /// <param name="TenKH"></param>
        /// <param name="Facebook"></param>
        /// <param name="Email"></param>
        /// <param name="MatKhau"></param>
        /// <param name="Sdt"></param>
        /// <param name="DiaChi"></param>
        public static void Update_KhachHang(string Id_Khach_Hang, string TenKH, string Facebook, string Email, string MatKhau, string Sdt, string DiaChi)
        {
            SqlCommand cmd = new SqlCommand("Update_KhachHang");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Khach_Hang", Id_Khach_Hang);
            cmd.Parameters.AddWithValue("@TenKH", TenKH);
            cmd.Parameters.AddWithValue("@Facebook", Facebook);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
            cmd.Parameters.AddWithValue("@Sdt", Sdt);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phuong thuc lay thong tin tat ca khach hang
        /// <summary>
        /// Phuong thuc lay thong tin tat ca khach hang
        /// </summary>
        public static DataTable Thongtin_KhachHang()
        {
            SqlCommand cmd = new SqlCommand("Thongtin_KhachHang");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDataBase.GetData(cmd);
        }
        #endregion

        #region Phuong thuc lay thong tin tat ca khach hang bang Email
        /// <summary>
        /// Phuong thuc lay thong tin tat ca khach hang bang Email
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_KhachHang_By_Email(string Email)
        {
            SqlCommand cmd = new SqlCommand("Thongtin_KhachHang_By_Email");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Email", Email);
            return SQLDataBase.GetData(cmd);
        }
        #endregion

        #region Phuong thuc lay thong tin tat ca khach hang bang Email va MatKhau
        /// <summary>
        /// Phuong thuc lay thong tin tat ca khach hang bang Email va MatKhau
        /// </summary>
        /// <param name="Email"></param>
        /// <param name="MatKhau"></param>
        /// <returns></returns>
        public static DataTable Thongtin_KhachHang_By_Email_MatKhau(string Email,string MatKhau)
        {
            SqlCommand cmd = new SqlCommand("Thongtin_KhachHang_By_Email_MatKhau");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
            return SQLDataBase.GetData(cmd);
        }
        #endregion
    }
}