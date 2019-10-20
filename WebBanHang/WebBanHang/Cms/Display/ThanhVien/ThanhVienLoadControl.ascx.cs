using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Display_ThanhVien_ThanhVienLoadControl : System.Web.UI.UserControl
{
    private string modulphu = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["modulphu"] != null)
            modulphu = Request.QueryString["modulphu"];

        switch (modulphu)
        {
            case "dangky":
                PlThanhVienLoadControl.Controls.Add(LoadControl("DangKyThanhVien.ascx"));
                break;
            case "dangnhap":
                PlThanhVienLoadControl.Controls.Add(LoadControl("DangNhapThanhVien.ascx"));
                break;
            default:
                PlThanhVienLoadControl.Controls.Add(LoadControl("DangNhapThanhVien.ascx"));
                break;
        }

    }
}