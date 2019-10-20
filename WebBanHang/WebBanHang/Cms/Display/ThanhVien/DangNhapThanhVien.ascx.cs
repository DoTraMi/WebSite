using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Display_ThanhVien_DanhSachThanhVien : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LbtnDangNhap_Click(object sender, EventArgs e)
    {
        //Kiểm tra trong DataBase có email và mật khẩu
        DataTable dt = QuanLyBanHang.Khach.Thongtin_KhachHang_By_Email_MatKhau(tbEmail.Text, QuanLyBanHang.MaHoa.MaHoaMD5(tbMatKhau.Text));

        if (dt.Rows.Count > 0)
        {
            //Đăng nhập thành công --> lưu giá trị vào session để đánh dấu là đăng nhập thành công
            Session["KhachHang"] = "1";//Gán bằng 1 để thể hiện thành công
            //gan thong tin khach hang
            Session["IdKH"] = dt.Rows[0]["Id_Khach_Hang"];
            Session["TenKH"] = dt.Rows[0]["TenKH"];           
            Session["FacebookKH"] = dt.Rows[0]["Facebook"];
            Session["EmailKH"] = dt.Rows[0]["Email"];
            Session["SdtKH"] = dt.Rows[0]["Sdt"];
            Session["DiaChiKH"] = dt.Rows[0]["DiaChi"];

            Response.Redirect("/Default.aspx");
        }
        else
        {
            ScriptManager.RegisterStartupScript(this,this.GetType(),"","alert('Email hoặc mật khẩu không chính xác!');",true);
        }
    }
}