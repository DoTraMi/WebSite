using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Admin_SanPham_QLySanPham_Ajax_AjaxSanPham : System.Web.UI.Page
{
    private string thaotac = "";
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

        if (Request.Params["thaotac"] != null)
            thaotac = Request.Params["thaotac"];
        switch(thaotac)
        {
            case "Xoa":
                XoaSanPham();
                break;
        }
    }

    private void XoaSanPham()
    {
        string MaSP = "";
        if (Request.Params["MaSP"] != null)
            MaSP = Request.Params["MaSP"];
        //thực hiện xóa;
        //B1:Xóa ảnh trong server: chưa làm
        //B2:Xóa SP
        QuanLyBanHang.SanPham.Delete_SanPham(MaSP);
        //thông báo:1-thực hiện xóa thành công;
        Response.Write("1");
    }
}