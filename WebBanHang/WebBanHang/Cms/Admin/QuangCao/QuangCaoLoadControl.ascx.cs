using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Admin_QuangCao_QuangCaoLoadControl : System.Web.UI.UserControl
{
    private string modulphu = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["modulphu"] != null)
            modulphu = Request.QueryString["modulphu"];

        switch (modulphu)
        {
            case "nhomquangcao":
                plQuangCaoLoadControl.Controls.Add(LoadControl("QlyNhomQuangCao/NhomQuangCaoLoadControl.ascx"));
                break;
            case "anhquangcao":
                plQuangCaoLoadControl.Controls.Add(LoadControl("QlyAnhQuangCao/AnhQuangCaoLoadControl.ascx"));
                break;
            default:
                plQuangCaoLoadControl.Controls.Add(LoadControl("QlyAnhQuangCao/AnhQuangCaoLoadControl.ascx"));
                break;
        }

    }
    protected string DanhDau(string tenModul, string tenmodulphu, string tenthaotac)
    {
        string s = "";

        /*Lấy giá trị querystring modul*/
        string modul = "";
        if (Request.QueryString["modul"] != null)
            modul = Request.QueryString["modul"];

        string modulphu = "";
        if (Request.QueryString["modulphu"] != null)
            modulphu = Request.QueryString["modulphu"];

        string thaotac = "";
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];

        /*So sánh nếu querystring bằng tên modul truyền vào thì trả về current -->đánh dấu là menu hiện tại*/
        if (modul == tenModul && modulphu == tenmodulphu && thaotac == tenthaotac)
            s = "current";
        return s;
    }
}