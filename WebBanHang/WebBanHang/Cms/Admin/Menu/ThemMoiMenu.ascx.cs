using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Admin_Menu_ThemMoiMenu : System.Web.UI.UserControl
{
    private string modulmenu = "";
    private string id = ""; //lấy mã danh mục
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["modulmenu"] != null)
            modulmenu = Request.QueryString["modulmenu"];

        if (Request.QueryString["id"] != null)
            id = Request.QueryString["id"];

        if (!IsPostBack)
        {
            LayMaMenucCha();

            HienThiThongTin();
        }
    }


    private void HienThiThongTin()
    {
        if (modulmenu == "Chinhsua")
        {
            BtnThemMoi.Text = "Chỉnh sửa";
            cbThemNhieuMenu.Visible = false;
            DataTable dt = new DataTable();
            dt = QuanLyBanHang.Menu.Thongtin_Menu_By_Ma(id);
            if (dt.Rows.Count > 0)
            {
                TbTenMenu.Text = dt.Rows[0]["TenMenu"].ToString();
                TbThuTu.Text = dt.Rows[0]["ThuTu"].ToString();
                DdlMaMenuCha.SelectedValue = dt.Rows[0]["MaMenuCha"].ToString();
                TbLienKet.Text = dt.Rows[0]["LienKet"].ToString();
            }
        }
        else
        {
            BtnThemMoi.Text = "Thêm mới";
            cbThemNhieuMenu.Visible = true;
        }
    }

    private void LayMaMenucCha()
    {
        DataTable dt = new DataTable();
        dt = QuanLyBanHang.Menu.Thongtin_Menu();
        DdlMaMenuCha.Items.Clear();
        DdlMaMenuCha.Items.Add(new ListItem("Menu gốc", "0"));
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            DdlMaMenuCha.Items.Add(new ListItem(dt.Rows[i]["TenMenu"].ToString(), dt.Rows[i]["Ma"].ToString()));
        }
    }

    protected void BtnThemMoi_Click(object sender, EventArgs e)
    {
        if (modulmenu == "Themmoi")
        {
            #region Nút thêm mới
            QuanLyBanHang.Menu.Insert_Menu(TbTenMenu.Text, TbThuTu.Text, DdlMaMenuCha.SelectedValue, TbLienKet.Text, "");
            LtrThongBao.Text = "<div class='thongBaoThanhCong'>Đã thêm menu thành công</div>";

            if (cbThemNhieuMenu.Checked)
            {
                ResetTextBox();
            }
            else
            {
                Response.Redirect("/Admin.aspx?modul=menu");
            }
            #endregion
        }
        else
        {
            #region Nút chỉnh sửa
            QuanLyBanHang.Menu.Update_Menu(id, TbTenMenu.Text, TbThuTu.Text, DdlMaMenuCha.SelectedValue, TbLienKet.Text);

            Response.Redirect("/Admin.aspx?modul=menu");
            #endregion

        }

    }

    private void ResetTextBox()
    {
        TbTenMenu.Text = "";
        TbThuTu.Text = "";
        TbLienKet.Text = "";
    }

    protected void BtnHuy_Click(object sender, EventArgs e)
    {
        ResetTextBox();
    }
}