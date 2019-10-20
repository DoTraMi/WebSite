using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Admin_SanPham_QLyTenSP_HienThiTenSP : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            LayDsSanPham();
        }
    }

    private void LayDsSanPham()
    {
        DataTable dt = new DataTable();
        dt = QuanLyBanHang.SanPham.Thongtin_SanPham();

        for(int i = 0; i< dt.Rows.Count; i++)
        {
            LtrSanPham.Text += @"
                <tr id='maDong_" + dt.Rows[i]["MaSP"] + @"'>
                    <td class='CotMaSP'>" + dt.Rows[i]["MaSP"] + @"</td>
                    <td class='CotMaDM'>" + dt.Rows[i]["MaDanhMucSP"] + @"</td>
                    <td class='CotDacDiem'>" + dt.Rows[i]["DacDiemSP"] + @"</td>
                    <td class='CotGia'>" + dt.Rows[i]["GiaSP"] + @"</td>
                    <td class='CotAnh'>
                        <img class='AnhSP' src='/pictures/SanPham/" + dt.Rows[i]["Anh"] + @"'/>
                        <img class='AnhSPHover' src='/pictures/SanPham/" + dt.Rows[i]["Anh"] + @"'/>
                    </td>
                    <td class='CotCongCu'>
                        <a href='/Admin.aspx?modul=sanpham&modulsp=DacDiemSP&thaotac=Chinhsua&id="+ dt.Rows[i]["MaSP"] + @"' class='Sua' title='Sửa'></a>
                        <a href='javascript:XoaSanPham("+ dt.Rows[i]["MaSP"] + @")' class='Xoa' title='Xóa'></a>
                    </td>
                </tr>
            ";
        }
          
    }
}