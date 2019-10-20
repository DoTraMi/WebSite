using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Admin_TaiKhoan_QLyTaiKhoan_QLyTaiKhoanLoadControl : System.Web.UI.UserControl
{
    string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];
        switch (thaotac)
        {
            case "Themmoi":
                PlQLyTaiKhoan.Controls.Add(LoadControl("ThemMoiTaiKhoan.ascx"));
                break;
            case "Chinhsua":
                PlQLyTaiKhoan.Controls.Add(LoadControl("ThemMoiTaiKhoan.ascx"));
                break;
            default:
                PlQLyTaiKhoan.Controls.Add(LoadControl("HienThiTaiKhoan.ascx"));
                break;
        }
    }
}