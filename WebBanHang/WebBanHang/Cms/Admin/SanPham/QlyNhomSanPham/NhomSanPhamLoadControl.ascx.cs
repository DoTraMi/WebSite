using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Admin_SanPham_QlyNhomSanPham_NhomSanPhamLoadControl : System.Web.UI.UserControl
{
    string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];
        switch (thaotac)
        {
            case "Themmoi":
                PlThaoTacSanPham.Controls.Add(LoadControl("ThemMoiNhomSP.ascx"));
                break;
            case "Chinhsua":
                PlThaoTacSanPham.Controls.Add(LoadControl("ThemMoiNhomSP.ascx"));
                break;
            default:
                PlThaoTacSanPham.Controls.Add(LoadControl("HienThiNhomSP.ascx"));
                break;
        }
    }
}