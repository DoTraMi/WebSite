using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DonDatHang
/// </summary>
namespace QuanLyBanHang
{
    public class DonDatHang
    {
        #region Phuong thuc xoa khach hang theo MaDonDatHang
        /// <summary>
        /// Phuong thuc xoa khach hang theo MaDonDatHang
        /// </summary>
        /// <param name="MaDonDatHang"></param>
        public static void Delete_DonHang(string MaDonDatHang)
        {
            SqlCommand cmd = new SqlCommand("Delete_DonHang");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDonDatHang", MaDonDatHang);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Them moi 1 don hang
        /// <summary>
        /// Them moi 1 don hang
        /// </summary>
        /// <param name="GhiChu"></param>
        /// <param name="NgayTao"></param>
        /// <param name="ThanhTien"></param>
        /// <param name="TinhTrangDonHang"></param>
        /// <param name="Id_Khach_Hang"></param>
        /// <param name="TenKH"></param>
        /// <param name="SdtKH"></param>
        /// <param name="EmailKH"></param>
        /// <param name="DiaChi"></param>
        /// <param name="ret"></param>
        public static void Insert_DonHang(string GhiChu, string NgayTao, string ThanhTien, string TinhTrangDonHang, string Id_Khach_Hang, string TenKH, string SdtKH, string EmailKH, string DiaChi, string ret)
        {
            SqlCommand cmd = new SqlCommand("Insert_DonHang");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GhiChu", GhiChu);
            cmd.Parameters.AddWithValue("@NgayTao", NgayTao);
            cmd.Parameters.AddWithValue("@ThanhTien", ThanhTien);
            cmd.Parameters.AddWithValue("@TinhTrangDonHang", TinhTrangDonHang);
            cmd.Parameters.AddWithValue("@Id_Khach_Hang", Id_Khach_Hang);
            cmd.Parameters.AddWithValue("@TenKH", TenKH);
            cmd.Parameters.AddWithValue("@SdtKH", SdtKH);
            cmd.Parameters.AddWithValue("@EmailKH", EmailKH);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phuong thuc cap nhat thong tin don hang
        /// <summary>
        /// Phuong thuc cap nhat thong tin don hang
        /// </summary>
        /// <param name="MaDonDatHang"></param>
        /// <param name="GhiChu"></param>
        /// <param name="NgayTao"></param>
        /// <param name="ThanhTien"></param>
        /// <param name="TinhTrangDonHang"></param>
        /// <param name="Id_Khach_Hang"></param>
        /// <param name="TenKH"></param>
        /// <param name="SdtKH"></param>
        /// <param name="EmailKH"></param>
        /// <param name="DiaChi"></param>
        public static void Update_DonHang(string MaDonDatHang, string GhiChu, string NgayTao, string ThanhTien, string TinhTrangDonHang, string Id_Khach_Hang, string TenKH, string SdtKH, string EmailKH, string DiaChi)
        {
            SqlCommand cmd = new SqlCommand("Update_DonHang");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDonDatHang", MaDonDatHang);
            cmd.Parameters.AddWithValue("@GhiChu", GhiChu);
            cmd.Parameters.AddWithValue("@NgayTao", NgayTao);
            cmd.Parameters.AddWithValue("@ThanhTien", ThanhTien);
            cmd.Parameters.AddWithValue("@TinhTrangDonHang", TinhTrangDonHang);
            cmd.Parameters.AddWithValue("@Id_Khach_Hang", Id_Khach_Hang);
            cmd.Parameters.AddWithValue("@TenKH", TenKH);
            cmd.Parameters.AddWithValue("@SdtKH", SdtKH);
            cmd.Parameters.AddWithValue("@EmailKH", EmailKH);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phuong thuc lay thong tin tat ca don hang
        /// <summary>
        /// Phuong thuc lay thong tin tat ca don hang
        /// </summary>
        public static DataTable Thongtin_DonHang()
        {
            SqlCommand cmd = new SqlCommand("Thongtin_DonHang");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDataBase.GetData(cmd);
        }
        #endregion

        #region Phuong thuc lay thong tin tat ca don hang moi nhat
        /// <summary>
        /// Phuong thuc lay thong tin tat ca don hang
        /// </summary>
        public static DataTable Thongtin_DonHangMoiNhat()
        {
            SqlCommand cmd = new SqlCommand("Thongtin_DonHangMoiNhat");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDataBase.GetData(cmd);
        }
        #endregion
    }
}