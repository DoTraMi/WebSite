using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Admin_Menu_HienThiMenu : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LayMenu();
        }
    }

    private void LayMenu()
    {
        DataTable dt = new DataTable();
        dt = QuanLyBanHang.Menu.Thongtin_Menu();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            LtrMenu.Text += @"
                <tr id='maDong_" + dt.Rows[i]["Ma"] + @"'>
                    <td class='CotMa'>" + dt.Rows[i]["Ma"] + @"</td>
                    <td class='TenMenu'>" + dt.Rows[i]["TenMenu"] + @"</td>
                    <td class='ThuTu'>" + dt.Rows[i]["ThuTu"] + @"</td> 
                    <td class='MaMenuCha'>" + dt.Rows[i]["MaMenuCha"] + @"</td>
                    <td class='LienKet'>" + dt.Rows[i]["LienKet"] + @"</td>
                    <td class='CotCongCu'>
                        <a href='/Admin.aspx?modul=menu&modulmenu=Chinhsua&id=" + dt.Rows[i]["Ma"] + @"' class='Sua' title='Sửa'></a>
                        <a href='javascript:XoaMenu(" + dt.Rows[i]["Ma"] + @")' class='Xoa' title='Xóa'></a>
                    </td>
                </tr>
            ";
        }

    }
}