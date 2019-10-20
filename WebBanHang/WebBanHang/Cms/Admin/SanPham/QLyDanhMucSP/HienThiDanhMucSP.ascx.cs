using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Admin_SanPham_QLyDanhMucSP_HienThiDanhMucSP : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LayDanhmucSP();
        }
    }

    private void LayDanhmucSP()
    {
        DataTable dt = new DataTable();
        dt = QuanLyBanHang.DanhMucSP.Thongtin_DanhMucSP();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            LtrDanhMucSP.Text += @"
                <tr id='maDong_" + dt.Rows[i]["MaDanhMucSP"] + @"'>
                    <td class='CotMaDanhMucSP'>" + dt.Rows[i]["MaDanhMucSP"] + @"</td>
                    <td class='TenDanhMucSP'>" + dt.Rows[i]["TenDanhMucSP"] + @"</td>
                    <td class='MaDanhMucCha'>" + dt.Rows[i]["MaDanhMucCha"] + @"</td>
                    <td class='SoSPHienThi'>" + dt.Rows[i]["SoSPHienThi"] + @"</td>
                    <td class='CotCongCu'>
                        <a href='/Admin.aspx?modul=sanpham&modulsp=DanhMucSP&thaotac=Chinhsua&id=" + dt.Rows[i]["MaDanhMucSP"] + @"' class='Sua' title='Sửa'></a>
                        <a href='javascript:XoaDanhMucSanPham(" + dt.Rows[i]["MaDanhMucSP"] + @")' class='Xoa' title='Xóa'></a>
                    </td>
                </tr>
            ";
        }

    }
}