using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Admin_AdminLoadControl : System.Web.UI.UserControl
{
    private string modul = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["modul"] != null)
            modul = Request.QueryString["modul"];

        switch(modul)
        {
            case "sanpham":
                PlAdminLoadControl.Controls.Add(LoadControl("SanPham/SanPhamLoadControl.ascx"));
                break;
            case "taikhoan":
                PlAdminLoadControl.Controls.Add(LoadControl("TaiKhoan/TaiKhoanLoadControl.ascx"));
                break;
            case "menu":
                PlAdminLoadControl.Controls.Add(LoadControl("Menu/MenuLoadControl.ascx"));
                break;
            case "quangcao":
                PlAdminLoadControl.Controls.Add(LoadControl("QuangCao/QuangCaoLoadControl.ascx"));
                break;
            case "khachhang":
                PlAdminLoadControl.Controls.Add(LoadControl("KhachHang/KhachHangLoadControl.ascx"));
                break;
            case "donhang":
                PlAdminLoadControl.Controls.Add(LoadControl("DonHang/DonHangLoadControl.ascx"));
                break;
            default:
                PlAdminLoadControl.Controls.Add(LoadControl("SanPham/SanPhamLoadControl.ascx"));
                break;
        }
        
    }
}