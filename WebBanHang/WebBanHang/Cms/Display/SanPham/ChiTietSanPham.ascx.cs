using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Display_SanPham_ChiTietSanPham : System.Web.UI.UserControl
{
    protected string id = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
            id = Request.QueryString["id"];
        string MaDanhMucSP = "";
        if (!IsPostBack)
        {
            MaDanhMucSP = LayChiTietSP(id);
            LtrDanhSachSPLienQuan.Text = LayCacSanPhamLienQuan(MaDanhMucSP);
        }
    }

    private string LayCacSanPhamLienQuan(string MaDanhMucSP)
    {
        string s = "";
        string SoSPHienThi = "4";
        DataTable dt = new DataTable();
        dt = QuanLyBanHang.SanPham.Thongtin_SanPham_By_MaDanhMucSP(MaDanhMucSP, SoSPHienThi);

        string link = "";
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            if(dt.Rows[i]["MaSP"].ToString() != id)
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
           
        }

        return s;
    }

    private string LayChiTietSP(string id)
    {
        DataTable dt = new DataTable();
        dt = QuanLyBanHang.SanPham.Thongtin_SanPham_By_MaSP(id);
        if(dt.Rows.Count>0)
        {
            LtrAnh.Text = "<img src='/pictures/SanPham/" + dt.Rows[0]["Anh"] + @"' alt='" + dt.Rows[0]["TenSanPham"] + @"'/>";
            LtrTenSP.Text = dt.Rows[0]["TenSanPham"].ToString();
            Ltrdacdiem.Text = dt.Rows[0]["DacDiemSP"].ToString();
            Ltrgia.Text = dt.Rows[0]["GiaSP"].ToString() + ".000đ";
        }
        return dt.Rows[0]["MaDanhMucSP"].ToString();
    }
}