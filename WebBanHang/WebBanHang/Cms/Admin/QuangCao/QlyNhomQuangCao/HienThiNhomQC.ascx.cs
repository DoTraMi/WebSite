using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Admin_QuangCao_QlyNhomQuangCao_HienThiNhomQC : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LayNhomQC();
        }
    }

    private void LayNhomQC()
    {
        DataTable dt = new DataTable();
        dt = QuanLyBanHang.NhomQuangCao.Thongtin_NhomQuangCao();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            LtrNhomQC.Text += @"
                <tr id='maDong_" + dt.Rows[i]["MaNhom"] + @"'>
                    <td class='CotMaNhom'>" + dt.Rows[i]["MaNhom"] + @"</td>
                    <td class='TenNhom'>" + dt.Rows[i]["TenNhom"] + @"</td>
                    <td class='Vitri'>" + dt.Rows[i]["Vitri"] + @"</td>
                    <td class='CotCongCu'>
                        <a href='/Admin.aspx?modul=quangcao&modulphu=nhomquangcao&thaotac=Chinhsua&id=" + dt.Rows[i]["MaNhom"] + @"' class='Sua' title='Sửa'></a>
                        <a href='javascript:XoaNhomQuangCao(" + dt.Rows[i]["MaNhom"] + @")' class='Xoa' title='Xóa'></a>
                    </td>
                </tr>
            ";
        }

    }
}