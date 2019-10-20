using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Admin_TaiKhoan_HienThiTaiKhoan : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LayDsTaiKhoan();
        }
    }

    private void LayDsTaiKhoan()
    {
        DataTable dt = new DataTable();
        dt = QuanLyBanHang.DangKyTaiKhoan.Thongtin_TaiKhoan();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            LtrTaiKhoan.Text += @"
                <tr id='maDong_" + dt.Rows[i]["TenDangNhap"] + @"'>
                    <td class='CotTenDangNhap'>" + dt.Rows[i]["TenDangNhap"] + @"</td>
                    <td class='CotEmail'>" + dt.Rows[i]["EmailDK"] + @"</td>
                    <td class='CotDiaChi'>" + dt.Rows[i]["DiaChiDK"] + @"</td>
                    <td class='CotTenDayDu'>" + dt.Rows[i]["TenDayDu"] + @"</td>
                    <td class='CotNgaySinh'>" + dt.Rows[i]["NgaySinh"] + @"</td>
                    <td class='CotGioiTinh'>" + dt.Rows[i]["GioiTinh"] + @"</td>
                    <td class='CotQuyenDN'>" + dt.Rows[i]["MaQuyen"] + @"</td>
                    <td class='CotCongCu'>
                        <a href='/Admin.aspx?modul=taikhoan&modulsp=dstaikhoan&thaotac=Chinhsua&id=" + dt.Rows[i]["TenDangNhap"] + @"' class='Sua' title='Sửa'></a>
                        <a href=javascript:XoaTaiKhoan('" + dt.Rows[i]["TenDangNhap"] + @"') class='Xoa' title='Xóa'></a>
                    </td>
                </tr>
            ";
        }

    }
}