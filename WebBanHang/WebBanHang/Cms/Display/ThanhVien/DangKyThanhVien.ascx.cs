using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Display_ThanhVien_ChiTietThanhVien : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    //Phương thức kiểm tra có Email trong danh sách không
    private bool DatontaiEmail(string Email)
    {
        DataTable dt = new DataTable();
        dt = QuanLyBanHang.Khach.Thongtin_KhachHang_By_Email(Email);
        if (dt.Rows.Count > 0)
            return true;
        else
            return false;
    }

    protected void LbtnDangKy_Click(object sender, EventArgs e)
    {

        if (DatontaiEmail(tbEmail.Text))
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "", "alert('Email này đã được đăng ký.Bạn vui lòng chọn Email khác.');", true);
        }
        else
        {
            string matkhau = QuanLyBanHang.MaHoa.MaHoaMD5(tbMatKhau.Text);

            QuanLyBanHang.Khach.Insert_KhachHang(tbTenDangNhap.Text, tbFacebook.Text, tbEmail.Text, matkhau, tbsdt.Text, tbDiaChi.Text, "");
            ScriptManager.RegisterStartupScript(this, this.GetType(), "", "alert('Bạn đã đăng ký thành công.Bạn có thể đăng nhập với Email và mật khẩu vừa rồi.'); location.href='/Default.aspx?modul=thanhvien&modulphu=dangnhap';", true);

        }
    }
}