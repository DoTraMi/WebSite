using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Admin_SanPham_QlyNhomSanPham_HienThiNhomSP : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LayNhomSP();
        }
    }

    private void LayNhomSP()
    {
        DataTable dt = new DataTable();
        dt = QuanLyBanHang.NhomSanPham.Thongtin_NhomSanPham();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            LtrNhomSP.Text += @"
                <tr id='maDong_" + dt.Rows[i]["MaNhom"] + @"'>
                    <td class='CotMaNhom'>" + dt.Rows[i]["MaNhom"] + @"</td>
                    <td class='TenNhom'>" + dt.Rows[i]["TenNhom"] + @"</td>
                    <td class='ThuTu'>" + dt.Rows[i]["ThuTu"] + @"</td>
                    <td class='SoSPHienThi'>" + dt.Rows[i]["SoSPHienThi"] + @"</td>
                    <td class='CotCongCu'>
                        <a href='/Admin.aspx?modul=sanpham&modulsp=NhomSP&thaotac=Chinhsua&id=" + dt.Rows[i]["MaNhom"] + @"' class='Sua' title='Sửa'></a>
                        <a href='javascript:XoaNhomSanPham(" + dt.Rows[i]["MaNhom"] + @")' class='Xoa' title='Xóa'></a>
                    </td>
                </tr>
            ";
        }

    }
}