using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Admin_QuangCao_QlyNhomQuangCao_NhomQuangCaoLoadControl : System.Web.UI.UserControl
{
    string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];
        switch (thaotac)
        {
            case "Themmoi":
                PlThaoTacNhomQC.Controls.Add(LoadControl("ThemMoiNhomQC.ascx"));
                break;
            case "Chinhsua":
                PlThaoTacNhomQC.Controls.Add(LoadControl("ThemMoiNhomQC.ascx"));
                break;
            default:
                PlThaoTacNhomQC.Controls.Add(LoadControl("HienThiNhomQC.ascx"));
                break;
        }
    }
}