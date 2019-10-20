using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Display_SanPham_GioHang : System.Web.UI.UserControl
{
    #region
    //Khai báo các biến chứa thông tin khách hàng khi họ đã đăng nhập
    protected string hoTen = "";
    protected string email = "";
    protected string sdt = "";
    protected string diaChi = "";
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            LayThongTinKhachHangDaDangNhap();
    }

    private void LayThongTinKhachHangDaDangNhap()
    {
        if (Session["KhachHang"] != null && Session["KhachHang"].ToString() == "1")
        {
            //Lấy thông tin khách hàng đã lưu khi đăng nhập
            hoTen = Session["TenKH"].ToString();
            email = Session["EmailKH"].ToString();
            sdt = Session["SdtKH"].ToString();
            diaChi = Session["DiaChiKH"].ToString();
        }
    }
}