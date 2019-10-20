using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Display_SanPham_SanPhamLoadControl : System.Web.UI.UserControl
{
    private string modulphu = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["modulphu"] != null)
            modulphu = Request.QueryString["modulphu"];

        switch (modulphu)
        {
            case "danhsachsp":
                PlModulSPLoadControl.Controls.Add(LoadControl("DanhSachSanPham.ascx"));
                break;
            case "chitietsp":
                PlModulSPLoadControl.Controls.Add(LoadControl("ChiTietSanPham.ascx"));
                break;
            case "giohang":
                PlModulSPLoadControl.Controls.Add(LoadControl("GioHang.ascx"));
                break;
            default:
                PlModulSPLoadControl.Controls.Add(LoadControl("TrangChuModulSanPham.ascx"));
                break;
        }

    }
}