using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Menu
/// </summary>
namespace QuanLyBanHang
{
    public class Menu
    {
        #region Phuong thuc xoa menu theo Ma
        /// <summary>
        /// Phuong thuc xoa menu theo Ma
        /// </summary>
        /// <param name="Ma"></param>
        public static void Delete_Menu(string Ma)
        {
            SqlCommand cmd = new SqlCommand("Delete_Menu");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ma", Ma);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Them moi 1 danh muc vao Menu
        /// <summary>
        /// Them moi 1 danh muc vao Menu
        /// </summary>
        /// <param name="TenMenu"></param>
        /// <param name="ThuTu"></param>
        /// <param name="MaMenuCha"></param>
        /// <param name="LienKet"></param>
        /// <param name="ret"></param>
        public static void Insert_Menu(string TenMenu, string ThuTu, string MaMenuCha, string LienKet, string ret)
        {
            SqlCommand cmd = new SqlCommand("Insert_Menu");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenMenu", TenMenu);
            cmd.Parameters.AddWithValue("@ThuTu", ThuTu);
            cmd.Parameters.AddWithValue("@MaMenuCha", MaMenuCha);
            cmd.Parameters.AddWithValue("@LienKet", LienKet);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phuong thuc cap nhat Menu
        /// <summary>
        /// Phuong thuc cap nhat Menu
        /// </summary>
        /// <param name="Ma"></param>
        /// <param name="TenMenu"></param>
        /// <param name="ThuTu"></param>
        /// <param name="MaMenuCha"></param>
        /// <param name="LienKet"></param>
        public static void Update_Menu(string Ma, string TenMenu, string ThuTu, string MaMenuCha, string LienKet)
        {
            SqlCommand cmd = new SqlCommand("Update_Menu");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ma", Ma);
            cmd.Parameters.AddWithValue("@TenMenu", TenMenu);
            cmd.Parameters.AddWithValue("@ThuTu", ThuTu);
            cmd.Parameters.AddWithValue("@MaMenuCha", MaMenuCha);
            cmd.Parameters.AddWithValue("@LienKet", LienKet);
            SQLDataBase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phuong thuc lay thong tin menu
        /// <summary>
        /// Phuong thuc lay thong tin menu
        /// </summary>
        public static DataTable Thongtin_Menu()
        {
            SqlCommand cmd = new SqlCommand("Thongtin_Menu");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDataBase.GetData(cmd);
        }
        #endregion

        #region Phuong thuc lay thong tin tat ca Menu bang Ma
        /// <summary>
        /// Phuong thuc lay thong tin tat ca Menu bang Ma
        /// </summary>
        /// <param name="Ma"></param>
        /// <returns></returns>
        public static DataTable Thongtin_Menu_By_Ma(string Ma)
        {
            SqlCommand cmd = new SqlCommand("Thongtin_Menu_By_Ma");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ma", Ma);
            return SQLDataBase.GetData(cmd);
        }
        #endregion

        #region Phuong thuc lay thong tin tat ca MenuCha
        /// <summary>
        /// Phuong thuc lay thong tin tat ca MenuCha
        /// </summary>
        /// <param name="MaMenuCha"></param>
        /// <returns></returns>
        public static DataTable Thongtin_Menu_By_MenuCha(string MaMenuCha)
        {
            SqlCommand cmd = new SqlCommand("Thongtin_Menu_By_MenuCha");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaMenuCha", MaMenuCha);
            return SQLDataBase.GetData(cmd);
        }
        #endregion
    }
}
