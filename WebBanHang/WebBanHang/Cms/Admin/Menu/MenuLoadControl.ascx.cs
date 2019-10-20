using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Admin_Menu_MenuLoadControl : System.Web.UI.UserControl
{
    private string modulmenu = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["modulmenu"] != null)
            modulmenu = Request.QueryString["modulmenu"];

        switch (modulmenu)
        {
            case "dsmenu":
                PlQLyMenu.Controls.Add(LoadControl("HienThiMenu.ascx"));
                break;
            case "Themmoi":
                PlQLyMenu.Controls.Add(LoadControl("ThemMoiMenu.ascx"));
                break;
            case "Chinhsua":
                PlQLyMenu.Controls.Add(LoadControl("ThemMoiMenu.ascx"));
                break;
            default:
                PlQLyMenu.Controls.Add(LoadControl("HienThiMenu.ascx"));
                break;
        }

    }
    protected string DanhDau(string tenModul, string tenmodulmenu)
    {
        string s = "";

        /*Lấy giá trị querystring modul*/
        string modul = "";
        if (Request.QueryString["modul"] != null)
            modul = Request.QueryString["modul"];

        string modulmenu = "";
        if (Request.QueryString["modulmenu"] != null)
            modulmenu = Request.QueryString["modulmenu"];


        /*So sánh nếu querystring bằng tên modul truyền vào thì trả về current -->đánh dấu là menu hiện tại*/
        if (modul == tenModul && modulmenu == tenmodulmenu)
            s = "current";
        return s;
    }
}