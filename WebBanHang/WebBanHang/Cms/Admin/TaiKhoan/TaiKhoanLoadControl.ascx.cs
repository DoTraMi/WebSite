using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Admin_TaiKhoan_TaiKhoanLoadControl : System.Web.UI.UserControl
{
    private string modulsp = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["modulsp"] != null)
            modulsp = Request.QueryString["modulsp"];

        switch (modulsp)
        {
            case "dstaikhoan":
                plTaiKhoanLoadControl.Controls.Add(LoadControl("QLyTaiKhoan/QLyTaiKhoanLoadControl.ascx"));
                break;
            default:
                plTaiKhoanLoadControl.Controls.Add(LoadControl("QLyTaiKhoan/HienThiTaiKhoan.ascx"));
                break;
        }

    }
    protected string DanhDau(string tenModul, string tenmodulsp, string tenthaotac)
    {
        string s = "";

        /*Lấy giá trị querystring modul*/
        string modul = "";
        if (Request.QueryString["modul"] != null)
            modul = Request.QueryString["modul"];

        string modulsp = "";
        if (Request.QueryString["modulsp"] != null)
            modulsp = Request.QueryString["modulsp"];

        string thaotac = "";
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];

        /*So sánh nếu querystring bằng tên modul truyền vào thì trả về current -->đánh dấu là menu hiện tại*/
        if (modul == tenModul && modulsp == tenmodulsp && thaotac == tenthaotac)
            s = "current";
        return s;
    }
}