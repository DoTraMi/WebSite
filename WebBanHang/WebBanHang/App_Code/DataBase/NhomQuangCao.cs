using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for NhomQuangCao
/// </summary>
namespace QuanLyBanHang
{
    public class NhomQuangCao
    {
        #region Phuong thuc xoa nhom quang cao theo MaNhom
        /// <summary>
        /// Phuong thuc xoa nhom quang cao theo MaNhom
        /// </summary>
        /// <param name="MaNhom">Ma san pham can xoa</param>
        public static void Delete_NhomQuangCao(string MaNhom)
        {
            SqlCommand cmd = new SqlCommand("Delete_NhomQuangCao");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNhom", MaNhom);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Them moi 1 nhom quang cao
        /// <summary>
        /// Them moi 1 nhom quang cao
        /// </summary>
        /// <param name="TenNhom"></param>
        /// <param name="Vitri"></param>
        /// <param name="ret"></param>
        public static void Insert_NhomQuangCao(string TenNhom, string Vitri, string ret)
        {
            SqlCommand cmd = new SqlCommand("Insert_NhomQuangCao");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenNhom", TenNhom);
            cmd.Parameters.AddWithValue("@Vitri", Vitri);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phuong thuc cap nhat thong tin nhom quang cao
        /// <summary>
        /// Phuong thuc cap nhat thong tin nhom quang cao
        /// </summary>
        /// <param name="MaNhom"></param>
        /// <param name="TenNhom"></param>
        /// <param name="Vitri"></param>
        public static void Update_NhomQuangCao(string MaNhom, string TenNhom, string Vitri)
        {
            SqlCommand cmd = new SqlCommand("Update_NhomQuangCao");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNhom", MaNhom);
            cmd.Parameters.AddWithValue("@TenNhom", TenNhom);
            cmd.Parameters.AddWithValue("@Vitri", Vitri);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phuong thuc lay thong tin tat ca nhom quang cao
        /// <summary>
        /// Phuong thuc lay thong tin tat ca nhom quang cao
        /// </summary>
        public static DataTable Thongtin_NhomQuangCao()
        {
            SqlCommand cmd = new SqlCommand("Thongtin_NhomQuangCao");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDataBase.GetData(cmd);
        }
        #endregion

        #region Phuong thuc lay thong tin tat ca nhom quang cao theo MaNhom
        /// <summary>
        /// Phuong thuc lay thong tin tat ca nhom quang cao theo MaNhom
        /// </summary>
        /// <param name="MaNhom"></param>
        /// <returns></returns>
        public static DataTable Thongtin_NhomQuangCao_By_MaNhom(string MaNhom)
        {
            SqlCommand cmd = new SqlCommand("Thongtin_NhomQuangCao_By_MaNhom");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNhom", MaNhom);
            return SQLDataBase.GetData(cmd);
        }
        #endregion

        #region Phuong thuc lay thong tin tat ca nhom quang cao theo vitri
        /// <summary>
        /// Phuong thuc lay thong tin tat ca nhom quang cao theo vitri
        /// </summary>
        /// <param name="Vitri"></param>
        /// <returns></returns>
        public static DataTable Thongtin_NhomQuangCao_By_Vitri(string Vitri)
        {
            SqlCommand cmd = new SqlCommand("Thongtin_NhomQuangCao_By_Vitri");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Vitri", Vitri);
            return SQLDataBase.GetData(cmd);
        }
        #endregion
    }
}
