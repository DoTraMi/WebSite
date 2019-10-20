using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Admin_SanPham_QLyGia_GiaSPLoadControl : System.Web.UI.UserControl
{
    string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];
        switch (thaotac)
        {
            case "Themmoi":
                PlThaoTacSanPham.Controls.Add(LoadControl("ThemMoiDanhMucSP.ascx"));
                break;
            case "Chinhsua":
                PlThaoTacSanPham.Controls.Add(LoadControl("ThemMoiDanhMucSP.ascx"));
                break;
            default:
                PlThaoTacSanPham.Controls.Add(LoadControl("HienThiDanhMucSP.ascx"));
                break;
        }
    }
}