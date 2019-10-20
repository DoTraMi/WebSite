using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Admin_QuangCao_QlyAnhQuangCao_Ajax_AjaxAnhQC : System.Web.UI.Page
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
        switch (thaotac)
        {
            case "Xoa":
                XoaAnhQC();
                break;
        }
    }

    private void XoaAnhQC()
    {
        string MaAnh = "";
        if (Request.Params["MaAnh"] != null)
            MaAnh = Request.Params["MaAnh"];
        //thực hiện xóa;
        //B1:Xóa ảnh trong server: chưa làm
        //B2:Xóa SP
        QuanLyBanHang.AnhQuangCao.Delete_AnhQuangCao(MaAnh);
        //thông báo:1-thực hiện xóa thành công;
        Response.Write("1");
    }
}