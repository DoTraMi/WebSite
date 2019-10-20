﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Display_Trangchu_TrangChuLoadControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Ltrnhom.Text = LayNhomSP();
    }

    private string LayNhomSP()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = QuanLyBanHang.NhomSanPham.Thongtin_NhomSanPham();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            s += "<div class='danhmucsp'>";
            s += @"<div class='title-line'><h3>" + dt.Rows[i]["TenNhom"] + @"</h3></div>";
            s += "<div class='dsitem'>";
            s += LayDanhSachSPTheoNhom(dt.Rows[i]["MaNhom"].ToString(), dt.Rows[i]["SoSPHienThi"].ToString());
            s += "</div";
            s += "<div style='clear:both'></div>";
            s += "</div>";
        }

        return s;
    }

    private string LayDanhSachSPTheoNhom(string MaNhom, string SoSPHienThi)
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = QuanLyBanHang.SanPham.Thongtin_SanPham_By_MaNhom(MaNhom, SoSPHienThi);

        string link = "";
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            link = "/Default.aspx?modul=sanpham&modulphu=chitietsp&id=" + dt.Rows[i]["MaSP"].ToString();
            s += @"<div class='item'>
                              <a class='title' href='" + link + "' title='" + dt.Rows[i]["TenSanPham"] + @"'>
                                      <img src='/pictures/SanPham/" + dt.Rows[i]["Anh"] + @"' alt='" + dt.Rows[i]["TenSanPham"] + @"'/>
                              </a>
                              <a class='title-sp' href='" + link + "' title='" + dt.Rows[i]["TenSanPham"] + @"'>" + dt.Rows[i]["TenSanPham"] + @"</a>
                              <a class='gia' href='#' title='" + dt.Rows[i]["GiaSP"] + @"'>Giá:" + dt.Rows[i]["GiaSP"] + @".000đ</a>
                        </div>";
        }

        return s;
    }
}