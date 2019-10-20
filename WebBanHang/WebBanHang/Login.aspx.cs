using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnDangNhap_Click(object sender, EventArgs e)
    {
        //Kiểm tra trong DataBase có tên đăng nhập và mật khẩu

        DataTable dt = QuanLyBanHang.DangKyTaiKhoan.Thongtin_TaiKhoan_By_TenDangNhap_And_MatKhau(TbTenDangNhap.Text, QuanLyBanHang.MaHoa.MaHoaMD5(TbMatKhau.Text));
        //&& (dt.Rows[0]["MaQuyen"].ToString() != "2")
        if (dt.Rows.Count > 0)
        {
                //Đăng nhập thành công --> lưu giá trị vào session để đánh dấu là đăng nhập thành công
                Session["DangNhap"] = dt.Rows[0]["MaQuyen"];//Gán bằng 1 để thể hiện thành công
                Session["TenDangNhap"] = dt.Rows[0]["TenDangNhap"];
                if (Session["DangNhap"].ToString() != "2")
                {
                    Response.Redirect("/Admin.aspx");
                }               
                else
                {
                    //chuyển đến trang cho khách hàng
                    LtrThongBao.Text = "<div class='thongBao'>Bạn không phải quản trị viên</div>";
                }
        }
        else
        {
            LtrThongBao.Text = "<div class='thongBao' >Tên đăng nhập hoặc mật khẩu không chính xác!</div>";
        }
    }
}