using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Display_DisplayLoadControl : System.Web.UI.UserControl
{
    private string modul = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["modul"] != null)
            modul = Request.QueryString["modul"];

        switch (modul)
        {
            case "sanpham":
                PlDisplayLoadControl.Controls.Add(LoadControl("SanPham/SanPhamLoadControl.ascx"));
                break;
            case "thanhvien":
                PlDisplayLoadControl.Controls.Add(LoadControl("ThanhVien/ThanhVienLoadControl.ascx"));
                break;
            case "tintuc":
                PlDisplayLoadControl.Controls.Add(LoadControl("TinTuc/TinTucLoadControl.ascx"));
                break;
            default:
                PlDisplayLoadControl.Controls.Add(LoadControl("TrangChu/TrangChuLoadControl.ascx"));
                break;
        }

    }
}