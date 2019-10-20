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
    public class CauHoiBaoMat
    {

        #region Phuong thuc xoa cau hoi bao mat theo MaCauHoiBaoMat
        /// <summary>
        /// Phuong thuc xoa danh muc san pham theo MaDanhMucSP
        /// </summary>
        /// <param name="MaCauHoiBaoMat"></param>
        public static void Delete_CauHoiBaoMat(string MaCauHoiBaoMat)
        {
            SqlCommand cmd = new SqlCommand("Delete_CauHoiBaoMat");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaCauHoiBaoMat", MaCauHoiBaoMat);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Them moi 1 cau hoi
        /// <summary>
        /// Them moi 1 cau hoi
        /// </summary>
        /// <param name="CauHoi"></param>
        /// <param name="ret"></param>
        public static void Insert_CauHoiBaoMat(string CauHoi, string ret)
        {
            SqlCommand cmd = new SqlCommand("Insert_CauHoiBaoMat");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CauHoi", CauHoi);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phuong thuc cap nhat cau hoi bao mat
        /// <summary>
        /// Phuong thuc cap nhat cau hoi bao mat
        /// </summary>
        /// <param name="MaCauHoiBaoMat"></param>
        /// <param name="CauHoi"></param>
        public static void Update_CauHoiBaoMat(string MaCauHoiBaoMat, string CauHoi)
        {
            SqlCommand cmd = new SqlCommand("Update_CauHoiBaoMat");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaCauHoiBaoMat", MaCauHoiBaoMat);
            cmd.Parameters.AddWithValue("@CauHoi", CauHoi);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phuong thuc lay thong tin tat ca cau hoi
        /// <summary>
        /// Phuong thuc lay thong tin tat ca cau hoi
        /// </summary>
        public static DataTable Thongtin_CauHoi()
        {
            SqlCommand cmd = new SqlCommand("Thongtin_CauHoi");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDataBase.GetData(cmd);
        }
        #endregion
    }
}