using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AnhQuangCao
/// </summary>
namespace QuanLyBanHang
{
    public class AnhQuangCao
    {
        #region Phuong thuc xoa anh quang cao theo MaAnh
        /// <summary>
        /// Phuong thuc xoa anh quang cao theo MaAnh
        /// </summary>
        /// <param name="MaAnh"></param>
        public static void Delete_AnhQuangCao(string MaAnh)
        {
            SqlCommand cmd = new SqlCommand("Delete_AnhQuangCao");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaAnh", MaAnh);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Them moi 1 anh quang cao
        /// <summary>
        /// Them moi 1 anh quang cao
        /// </summary>
        /// <param name="MaNhom"></param>
        /// <param name="TenQuangCao"></param>
        /// <param name="Anh"></param>
        /// <param name="Thutu"></param>
        /// <param name="LienKet"></param>
        /// <param name="ret"></param>
        public static void Insert_AnhQuangCao(string MaNhom, string TenQuangCao, string Anh, string Thutu, string LienKet, string ret)
        {
            SqlCommand cmd = new SqlCommand("Insert_AnhQuangCao");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNhom", MaNhom);
            cmd.Parameters.AddWithValue("@TenQuangCao", TenQuangCao);
            cmd.Parameters.AddWithValue("@Anh", Anh);
            cmd.Parameters.AddWithValue("@Thutu", Thutu);
            cmd.Parameters.AddWithValue("@LienKet", LienKet);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phuong thuc cap nhat thong tin anh quang cao
        /// <summary>
        /// Phuong thuc cap nhat thong tin anh quang cao
        /// </summary>
        /// <param name="MaAnh"></param>
        /// <param name="MaNhom"></param>
        /// <param name="TenQuangCao"></param>
        /// <param name="Anh"></param>
        /// <param name="Thutu"></param>
        /// <param name="LienKet"></param>
        public static void Update_AnhQuangCao(string MaAnh, string MaNhom, string TenQuangCao, string Anh, string Thutu, string LienKet)
        {
            SqlCommand cmd = new SqlCommand("Update_AnhQuangCao");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaAnh", MaAnh);
            cmd.Parameters.AddWithValue("@MaNhom", MaNhom);
            cmd.Parameters.AddWithValue("@TenQuangCao", TenQuangCao);
            cmd.Parameters.AddWithValue("@Anh", Anh);
            cmd.Parameters.AddWithValue("@Thutu", Thutu);
            cmd.Parameters.AddWithValue("@LienKet", LienKet);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phuong thuc lay thong tin tat ca anh quang cao
        /// <summary>
        /// Phuong thuc lay thong tin tat ca anh quang cao
        /// </summary>
        public static DataTable Thongtin_AnhQuangCao()
        {
            SqlCommand cmd = new SqlCommand("Thongtin_AnhQuangCao");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDataBase.GetData(cmd);
        }
        #endregion

        #region Phuong thuc lay thong tin tat ca anh quang cao theo MaAnh
        /// <summary>
        /// Phuong thuc lay thong tin tat ca anh quang cao theo MaAnh
        /// </summary>
        /// <param name="MaAnh"></param>
        /// <returns></returns>
        public static DataTable Thongtin_AnhQuangCao_By_MaAnh(string MaAnh)
        {
            SqlCommand cmd = new SqlCommand("Thongtin_AnhQuangCao_By_MaAnh");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaAnh", MaAnh);
            return SQLDataBase.GetData(cmd);
        }
        #endregion

        #region Phuong thuc lay thong tin tat ca anh quang cao theo Manhom
        /// <summary>
        /// Phuong thuc lay thong tin tat ca anh quang cao theo MaNhom
        /// </summary>
        /// <param name="MaNhom"></param>
        /// <returns></returns>
        public static DataTable Thongtin_AnhQuangCao_By_MaNhom(string MaNhom)
        {
            SqlCommand cmd = new SqlCommand("Thongtin_AnhQuangCao_By_MaNhom");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNhom", MaNhom);
            return SQLDataBase.GetData(cmd);
        }
        #endregion
    }
}