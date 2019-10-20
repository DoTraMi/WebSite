using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Admin_QuangCao_QlyNhomQuangCao_Ajax_AjaxNhomQC : System.Web.UI.Page
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
                XoaNhomQC();
                break;
        }
    }
    private void XoaNhomQC()
    {
        string MaNhom = "";
        if (Request.Params["MaNhom"] != null)
            MaNhom = Request.Params["MaNhom"];
        //thực hiện xóa
        QuanLyBanHang.NhomQuangCao.Delete_NhomQuangCao(MaNhom);
        //thông báo:1-thực hiện xóa thành công;
        Response.Write("1");
    }
}