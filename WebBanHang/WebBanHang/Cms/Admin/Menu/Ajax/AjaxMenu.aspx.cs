using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Admin_Menu_Ajax_AjaxMenu : System.Web.UI.Page
{
    private string modulmenu = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        //Cần viết code kiểm tra đăng nhập
        //Cần viết code kiểm tra đăng nhập
        if (Session["DangNhap"] != null && Session["DangNhap"].ToString() != "2")
        {

        }
        else
        {
            //nếu chưa đăng nhâp thì dừng k cho thực hiện câu lệnh dưới
            return;
        }

        if (Request.Params["modulmenu"] != null)
            modulmenu = Request.Params["modulmenu"];
        switch (modulmenu)
        {
            case "Xoa":
                XoaMenu();
                break;
        }
    }

    private void XoaMenu()
    {
        string Ma = "";
        if (Request.Params["Ma"] != null)
            Ma = Request.Params["Ma"];
        //thực hiện xóa
        QuanLyBanHang.Menu.Delete_Menu(Ma);
        //thông báo:1-thực hiện xóa thành công;
        Response.Write("1");
    }
}