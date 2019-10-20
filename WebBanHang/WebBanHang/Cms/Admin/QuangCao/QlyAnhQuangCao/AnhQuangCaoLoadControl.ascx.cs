using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Admin_QuangCao_QlyAnhQuangCao_AnhQuangCaoLoadControl : System.Web.UI.UserControl
{
    string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];
        switch (thaotac)
        {
            case "Themmoi":
                PlThaoTacAnhQC.Controls.Add(LoadControl("ThemMoiAnhQC.ascx"));
                break;
            case "Chinhsua":
                PlThaoTacAnhQC.Controls.Add(LoadControl("ThemMoiAnhQC.ascx"));
                break;
            default:
                PlThaoTacAnhQC.Controls.Add(LoadControl("HienThiAnhQC.ascx"));
                break;
        }
    }
}