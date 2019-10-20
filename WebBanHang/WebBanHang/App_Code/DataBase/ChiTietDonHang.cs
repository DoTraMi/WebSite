using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ChiTietDonHang
/// </summary>
namespace QuanLyBanHang
{
    public class ChiTietDonHang
    {
        #region Phuong thuc xoa khach hang theo MaChiTiet
        /// <summary>
        /// Phuong thuc xoa khach hang theo MaChiTiet
        /// </summary>
        /// <param name="MaChiTiet"></param>
        public static void Delete_ChiTietDonHang(string MaChiTiet)
        {
            SqlCommand cmd = new SqlCommand("Delete_ChiTietDonHang");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaChiTiet", MaChiTiet);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Them moi 1 ChiTietDonHang 
        /// <summary>
        /// Them moi 1 ChiTietDonHang 
        /// </summary>
        /// <param name="MaSP"></param>
        /// <param name="MaDonDatHang"></param>
        /// <param name="SoLuongDat"></param>
        /// <param name="DonGiaDat"></param>
        /// <param name="ret"></param>
        public static void Insert_ChiTietDonHang(string MaSP, string MaDonDatHang, string SoLuongDat, string DonGiaDat, string ret)
        {
            SqlCommand cmd = new SqlCommand("Insert_ChiTietDonHang");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaSP", MaSP);
            cmd.Parameters.AddWithValue("@MaDonDatHang", MaDonDatHang);
            cmd.Parameters.AddWithValue("@SoLuongDat", SoLuongDat);
            cmd.Parameters.AddWithValue("@DonGiaDat", DonGiaDat);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phuong thuc cap nhat thong tin ChiTietDonHang
        /// <summary>
        /// Phuong thuc cap nhat thong tin ChiTietDonHang
        /// </summary>
        /// <param name="MaChiTiet"></param>
        /// <param name="MaSP"></param>
        /// <param name="MaDonDatHang"></param>
        /// <param name="SoLuongDat"></param>
        /// <param name="DonGiaDat"></param>
        public static void Update_ChiTietDonHang(string MaChiTiet, string MaSP, string MaDonDatHang, string SoLuongDat, string DonGiaDat)
        {
            SqlCommand cmd = new SqlCommand("Update_ChiTietDonHang");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaChiTiet", MaChiTiet);
            cmd.Parameters.AddWithValue("@MaSP", MaSP);
            cmd.Parameters.AddWithValue("@MaDonDatHang", MaDonDatHang);
            cmd.Parameters.AddWithValue("@SoLuongDat", SoLuongDat);
            cmd.Parameters.AddWithValue("@DonGiaDat", DonGiaDat);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phuong thuc lay thong tin tat ca ChiTietDonHang
        /// <summary>
        /// Phuong thuc lay thong tin tat ca ChiTietDonHang
        /// </summary>
        public static DataTable Thongtin_ChiTietDonHang()
        {
            SqlCommand cmd = new SqlCommand("Thongtin_ChiTietDonHang");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDataBase.GetData(cmd);
        }
        #endregion
    }
}