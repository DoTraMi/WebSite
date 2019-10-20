using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DangKyTaiKhoan
/// </summary>
namespace QuanLyBanHang
{
    public class DangKyTaiKhoan
    {
        #region Phuong thuc xoa tai khoan theo ten dang nhap
        /// <summary>
        /// Phuong thuc xoa tai khoan theo ten dang nhap
        /// </summary>
        /// <param name="TenDangNhap">Ten dang nhap can xoa</param>
        public static void Delete_TaiKhoan(string TenDangNhap)
        {
            SqlCommand cmd = new SqlCommand("Delete_TaiKhoan");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Them moi 1 tai khoan vao bang DangKyTaiKhoan
        /// <summary>
        /// Them moi 1 tai khoan vao bang DangKyTaiKhoan
        /// </summary>
        /// <param name="TenDangNhap"></param>
        /// <param name="MatKhau"></param>
        /// <param name="EmailDK"></param>
        /// <param name="DiaChiDK"></param>
        /// <param name="TenDayDu"></param>
        /// <param name="MaCauHoiBaoMat"></param>
        /// <param name="CauTraLoi"></param>
        /// <param name="NgaySinh"></param>
        /// <param name="GioiTinh"></param>
        /// <param name="MaQuyen"></param>
        /// <param name="ret"></param>
        public static void Insert_TaiKhoan(string TenDangNhap, string MatKhau, string EmailDK, string DiaChiDK, string TenDayDu, string MaCauHoiBaoMat, string CauTraLoi, string NgaySinh, string GioiTinh, string MaQuyen, string ret)
        {
            SqlCommand cmd = new SqlCommand("Insert_TaiKhoan");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
            cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
            cmd.Parameters.AddWithValue("@EmailDK", EmailDK);
            cmd.Parameters.AddWithValue("@DiaChiDK", DiaChiDK);
            cmd.Parameters.AddWithValue("@TenDayDu", TenDayDu);
            cmd.Parameters.AddWithValue("@MaCauHoiBaoMat", MaCauHoiBaoMat);
            cmd.Parameters.AddWithValue("@CauTraLoi", CauTraLoi);
            cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
            cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            cmd.Parameters.AddWithValue("@MaQuyen", MaQuyen);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phuong thuc cap nhat thong tin tai khoan
        /// <summary>
        /// Phuong thuc cap nhat thong tin tai khoan
        /// </summary>
        /// <param name="TenDangNhap"></param>
        /// <param name="MatKhau"></param>
        /// <param name="EmailDK"></param>
        /// <param name="DiaChiDK"></param>
        /// <param name="TenDayDu"></param>
        /// <param name="MaCauHoiBaoMat"></param>
        /// <param name="CauTraLoi"></param>
        /// <param name="NgaySinh"></param>
        /// <param name="GioiTinh"></param>
        /// <param name="MaQuyen"></param>
        public static void Update_TaiKhoan(string TenDangNhap, string MatKhau, string EmailDK, string DiaChiDK, string TenDayDu, string MaCauHoiBaoMat, string CauTraLoi, string NgaySinh, string GioiTinh, string MaQuyen)
        {
            SqlCommand cmd = new SqlCommand("Update_TaiKhoan");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
            cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
            cmd.Parameters.AddWithValue("@EmailDK", EmailDK);
            cmd.Parameters.AddWithValue("@DiaChiDK", DiaChiDK);
            cmd.Parameters.AddWithValue("@TenDayDu", TenDayDu);
            cmd.Parameters.AddWithValue("@MaCauHoiBaoMat", MaCauHoiBaoMat);
            cmd.Parameters.AddWithValue("@CauTraLoi", CauTraLoi);
            cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
            cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            cmd.Parameters.AddWithValue("@MaQuyen", MaQuyen);

            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phuong thuc lay thong tin tat ca tai khoan
        /// <summary>
        /// Phuong thuc lay thong tin tat ca tai khoan
        /// </summary>
        public static DataTable Thongtin_TaiKhoan()
        {
            SqlCommand cmd = new SqlCommand("Thongtin_TaiKhoan");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDataBase.GetData(cmd);
        }
        #endregion

        #region Phuong thuc lay thong tin tat ca tai khoan theo TenDangNhap
        /// <summary>
        /// Phuong thuc lay thong tin tat ca tai khoan theo TenDangNhap
        /// </summary>
        /// <param name="TenDangNhap"></param>
        /// <returns></returns>
        public static DataTable Thongtin_TaiKhoan_By_TenDangNhap(string TenDangNhap)
        {
            SqlCommand cmd = new SqlCommand("Thongtin_TaiKhoan_By_TenDangNhap");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
            return SQLDataBase.GetData(cmd);
        }
        #endregion

        #region Phuong thuc lay thong tin tat ca tai khoan theo TenDangNhap va MatKhau
        /// <summary>
        /// Phuong thuc lay thong tin tat ca tai khoan theo TenDangNhap
        /// </summary>
        /// <param name="TenDangNhap"></param>
        /// <returns></returns>
        public static DataTable Thongtin_TaiKhoan_By_TenDangNhap_And_MatKhau(string TenDangNhap, string MatKhau)
        {
            SqlCommand cmd = new SqlCommand("Thongtin_TaiKhoan_By_TenDangNhap_And_MatKhau");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
            cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
            return SQLDataBase.GetData(cmd);
        }
        #endregion
    }
}
