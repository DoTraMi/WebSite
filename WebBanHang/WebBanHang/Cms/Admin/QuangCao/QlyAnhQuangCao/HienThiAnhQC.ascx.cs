using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Admin_QuangCao_QlyAnhQuangCao_HienThiAnhQC : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LayDsAnh();
        }
    }

    private void LayDsAnh()
    {
        DataTable dt = new DataTable();
        dt = QuanLyBanHang.AnhQuangCao.Thongtin_AnhQuangCao();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            LtrSanPham.Text += @"
                <tr id='maDong_" + dt.Rows[i]["MaAnh"] + @"'>
                    <td class='CotMaAnh'>" + dt.Rows[i]["MaAnh"] + @"</td>
                    <td class='CotMaNhom'>" + dt.Rows[i]["MaNhom"] + @"</td>
                    <td class='CotTenQuangCao'>" + dt.Rows[i]["TenQuangCao"] + @"</td>                  
                    <td class='CotAnh'>
                        <img class='AnhSP' src='/pictures/AnhQuangCao/" + dt.Rows[i]["Anh"] + @"'/>
                        <img class='AnhSPHover' src='/pictures/AnhQuangCao/" + dt.Rows[i]["Anh"] + @"'/>
                    </td>
                    <td class='CotThutu'>" + dt.Rows[i]["Thutu"] + @"</td>
                    <td class='CotLienKet'>" + dt.Rows[i]["LienKet"] + @"</td>
                    <td class='CotCongCu'>
                        <a href='/Admin.aspx?modul=quangcao&modulphu=anhquangcao&thaotac=Chinhsua&id=" + dt.Rows[i]["MaAnh"] + @"' class='Sua' title='Sửa'></a>
                        <a href='javascript:XoaAnh(" + dt.Rows[i]["MaAnh"] + @")' class='Xoa' title='Xóa'></a>
                    </td>
                </tr>
            ";
        }

    }
}