using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Admin_TaiKhoan_Ajax_AjaxTaiKhoan : System.Web.UI.UserControl
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        //Cần viết code kiểm tra đăng nhập
        if (Session["DangNhap"] != null && Session["DangNhap"].ToString() != "2")
        {

        }
        else
        {
            //nếu chưa đăng nhâp thì dừng k cho thực hiện câu lệnh dưới
            return;
        }

        if (Request.Params["thaotac"] != null)
            thaotac = Request.Params["thaotac"];
        switch (thaotac)
        {
            case "Xoa":
                XoaTaiKhoan();
                break;
        }
    }

    private void XoaTaiKhoan()
    {
        string TenDN = "";
        if (Request.Params["TenDangNhap"] != null)
            TenDN = Request.Params["TenDangNhap"];
        //thực hiện xóa;
        //không cho xóa tài khoản admin
        if(TenDN.ToLower() != "admin")
        {
            QuanLyBanHang.DangKyTaiKhoan.Delete_TaiKhoan(TenDN);
            //thông báo:1-thực hiện xóa thành công;
            Response.Write("1");
        }
        else
        {
            Response.Write("Không được xóa tài khoản admin");
        }
        
    }
}