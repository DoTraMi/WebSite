using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Display_SanPham_DanhSachCacSanPham : System.Web.UI.UserControl
{
    string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
            id = Request.QueryString["id"];
        Ltrdanhsachsp.Text = LayDanhSachSP();
    }

    private string LayDanhSachSP()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = QuanLyBanHang.DanhMucSP.Thongtin_DanhMucSP_By_MaDanhMucSP(id);

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            s += "<div class='danhmucsp'>";
            s += @"<a class='title-line' href='/Default.aspx?modul=sanpham&modulphu=danhsachsp&id=" + dt.Rows[i]["MaDanhMucSP"] + @"' title='" + dt.Rows[i]["TenDanhMucSP"] + @"'>
                   <h3>" + dt.Rows[i]["TenDanhMucSP"] + @"</h3></a>";
            s += "<div class='dsitem'>";
            s += LayDanhSachSPTheoDanhMuc(dt.Rows[i]["MaDanhMucSP"].ToString());
            s += "</div";
            s += "<div style='clear:both'></div>";
            s += "</div>";
        }

        return s;
    }

    private string LayDanhSachSPTheoDanhMuc(string MaDanhMucSP)
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = QuanLyBanHang.SanPham.Thongtin_All_SanPham_By_MaDanhMucSP(MaDanhMucSP);

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