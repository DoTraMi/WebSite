using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Display_SanPham_TrangChuModulSanPham : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Ltrdanhmucsp.Text = LayDanhMucSP();
    }

    private string LayDanhMucSP()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = QuanLyBanHang.DanhMucSP.Thongtin_DanhMucSP_By_MaDanhMucCha("0");

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            s += "<div class='danhmucsp'>";
            s += @"<a class='title-line' href='/Default.aspx?modul=sanpham&modulphu=danhsachsp&id=" + dt.Rows[i]["MaDanhMucSP"] + @"' title='" + dt.Rows[i]["TenDanhMucSP"] + @"'>
                   <h3>" + dt.Rows[i]["TenDanhMucSP"] + @"</h3>
                   <span class='xemchitiet'>Xem tất cả [+]</span>
                   </a>";
            s += "<div class='dsitem'>";
            s += LayDanhSachSPTheoDanhMuc(dt.Rows[i]["MaDanhMucSP"].ToString(), dt.Rows[i]["SoSPHienThi"].ToString());
            s += "</div";
            s += "<div style='clear:both'></div>";
            s += "</div>";
        }

        return s;
    }

    private string LayDanhSachSPTheoDanhMuc(string MaDanhMucSP, string SoSPHienThi)
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = QuanLyBanHang.SanPham.Thongtin_SanPham_By_MaDanhMucSP(MaDanhMucSP, SoSPHienThi);

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