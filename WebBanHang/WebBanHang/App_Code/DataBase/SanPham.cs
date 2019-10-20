using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for HangHoa
/// </summary>
namespace QuanLyBanHang
{
    public class SanPham
    {
        #region Phuong thuc xoa san pham theo MaSP
        /// <summary>
        /// Phuong thuc xoa san pham theo MaSP
        /// </summary>
        /// <param name="MaSP">Ma san pham can xoa</param>
        public static void Delete_SanPham(string MaSP)
        {
            SqlCommand cmd = new SqlCommand("Delete_SanPham");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaSP", MaSP);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Them moi 1 san pham vao bang SanPham
        /// <summary>
        /// Them moi 1 san pham vao bang SanPham
        /// </summary>
        /// <param name="MaDanhMucSP"></param>
        /// <param name="DacDiemSP"></param>
        /// <param name="GiaSP"></param>
        /// <param name="Anh"></param>
        /// <param name="TenSanPham"></param>
        /// <param name="MaNhom"></param>
        /// <param name="ret"></param>
        public static void Insert_SanPham(string MaDanhMucSP, string DacDiemSP, string GiaSP, string Anh, string TenSanPham, string MaNhom, string ret)
        {
            SqlCommand cmd = new SqlCommand("Insert_SanPham");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDanhMucSP", MaDanhMucSP);
            cmd.Parameters.AddWithValue("@DacDiemSP", DacDiemSP);
            cmd.Parameters.AddWithValue("@GiaSP", GiaSP);
            cmd.Parameters.AddWithValue("@Anh", Anh);
            cmd.Parameters.AddWithValue("@TenSanPham", TenSanPham);
            cmd.Parameters.AddWithValue("@MaNhom", MaNhom);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phuong thuc cap nhat thong tin san pham
        /// <summary>
        /// Phuong thuc cap nhat thong tin hang hoa
        /// </summary>
        /// <param name="MaSP"></param>
        /// <param name="MaDanhMucSP"></param>
        /// <param name="DacDiemSP"></param>
        /// <param name="GiaSP"></param>
        /// <param name="Anh"></param>
        /// <param name="TenSanPham"></param>
        /// <param name="MaNhom"></param>
        public static void Update_SanPham(string MaSP, string MaDanhMucSP, string DacDiemSP, string GiaSP, string Anh, string TenSanPham,string MaNhom)
        {
            SqlCommand cmd = new SqlCommand("Update_SanPham");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaSP", MaSP);
            cmd.Parameters.AddWithValue("@MaDanhMucSP", MaDanhMucSP);
            cmd.Parameters.AddWithValue("@DacDiemSP", DacDiemSP);
            cmd.Parameters.AddWithValue("@GiaSP", GiaSP);
            cmd.Parameters.AddWithValue("@Anh", Anh);
            cmd.Parameters.AddWithValue("@TenSanPham", TenSanPham);
            cmd.Parameters.AddWithValue("@MaNhom", MaNhom);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phuong thuc lay thong tin tat ca san pham
        /// <summary>
        /// Phuong thuc lay thong tin tat ca hang hoa
        /// </summary>
        /// <param name="MaSP"></param>
        public static DataTable Thongtin_SanPham()
        {
            SqlCommand cmd = new SqlCommand("Thongtin_SanPham");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDataBase.GetData(cmd);
        }
        #endregion

        #region Phuong thuc lay thong tin tat ca san pham theo mã sản phẩm
        /// <summary>
        /// Phuong thuc lay thong tin tat ca san pham theo mã sản phẩm
        /// </summary>
        /// <param name="MaSP"></param>
        /// <returns></returns>
        public static DataTable Thongtin_SanPham_By_MaSP(string MaSP)
        {
            SqlCommand cmd = new SqlCommand("Thongtin_SanPham_By_MaSP");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaSP", MaSP);
            return SQLDataBase.GetData(cmd);
        }
        #endregion

        #region Phuong thuc lay thong tin tat ca san pham theo mã danh mục sản phẩm
        /// <summary>
        /// Phuong thuc lay thong tin tat ca san pham theo mã danh mục sản phẩm
        /// </summary>
        /// <param name="MaSP"></param>
        /// <returns></returns>
        public static DataTable Thongtin_All_SanPham_By_MaDanhMucSP(string MaDanhMucSP)
        {
            SqlCommand cmd = new SqlCommand("Thongtin_All_SanPham_By_MaDanhMucSP");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDanhMucSP", MaDanhMucSP);
            return SQLDataBase.GetData(cmd);
        }
        #endregion

        #region Phuong thuc lay thong tin san pham theo mã danh mục sản phẩm va so luong
        /// <summary>
        ///  Phuong thuc lay thong tin san pham theo mã danh mục sản phẩm va so luong
        /// </summary>
        /// <param name="MaDanhMucSP"></param>
        /// <returns></returns>
        public static DataTable Thongtin_SanPham_By_MaDanhMucSP(string MaDanhMucSP,string SoSPHienThi)
        {
            SqlCommand cmd = new SqlCommand("Thongtin_SanPham_By_MaDanhMucSP");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDanhMucSP", MaDanhMucSP);
            cmd.Parameters.AddWithValue("@SoSPHienThi", SoSPHienThi);
            return SQLDataBase.GetData(cmd);
        }
        #endregion

        #region Phuong thuc lay thong tin tat ca san pham theo mã nhóm sản phẩm
        /// <summary>
        ///  Phuong thuc lay thong tin tat ca san pham theo mã nhóm sản phẩm
        /// </summary>
        /// <param name="MaNhom"></param>
        /// <returns></returns>
        public static DataTable Thongtin_SanPham_By_MaNhom(string MaNhom, string SoSPHienThi)
        {
            SqlCommand cmd = new SqlCommand("Thongtin_SanPham_By_MaNhom");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNhom", MaNhom);
            cmd.Parameters.AddWithValue("@SoSPHienThi", SoSPHienThi);
            return SQLDataBase.GetData(cmd);
        }
        #endregion
    }
}