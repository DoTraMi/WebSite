using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Admin_QuangCao_QlyNhomQuangCao_ThemMoiNhomQC : System.Web.UI.UserControl
{
    private string thaotac = "";
    private string id = ""; //lấy mã nhóm
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];

        if (Request.QueryString["id"] != null)
            id = Request.QueryString["id"];

        if (!IsPostBack)
        {
            HienThiThongTin();
        }
    }


    private void HienThiThongTin()
    {
        if (thaotac == "Chinhsua")
        {
            BtnThemMoi.Text = "Chỉnh sửa";
            cbThemNhieuNhom.Visible = false;
            DataTable dt = new DataTable();
            dt = QuanLyBanHang.NhomQuangCao.Thongtin_NhomQuangCao_By_MaNhom(id);
            if (dt.Rows.Count > 0)
            {
                TbTenNhom.Text = dt.Rows[0]["TenNhom"].ToString();
                TbVitri.Text = dt.Rows[0]["Vitri"].ToString();
            }
        }
        else
        {
            BtnThemMoi.Text = "Thêm mới";
            cbThemNhieuNhom.Visible = true;
        }
    }


    protected void BtnThemMoi_Click(object sender, EventArgs e)
    {
        if (thaotac == "Themmoi")
        {
            #region Nút thêm mới
            QuanLyBanHang.NhomQuangCao.Insert_NhomQuangCao(TbTenNhom.Text, TbVitri.Text, "");
            LtrThongBao.Text = "<div class='thongBaoThanhCong'>Đã thêm nhóm quảng cáo thành công</div>";

            if (cbThemNhieuNhom.Checked)
            {
                ResetTextBox();
            }
            else
            {
                Response.Redirect("/Admin.aspx?modul=quangcao&modulphu=nhomquangcao");
            }
            #endregion
        }
        else
        {
            #region Nút chỉnh sửa
            QuanLyBanHang.NhomQuangCao.Update_NhomQuangCao(id, TbTenNhom.Text, TbVitri.Text);

            Response.Redirect("/Admin.aspx?modul=quangcao&modulphu=nhomquangcao");
            #endregion

        }

    }

    private void ResetTextBox()
    {
        TbTenNhom.Text = "";
        TbVitri.Text = "";
    }

    protected void BtnHuy_Click(object sender, EventArgs e)
    {
        ResetTextBox();
    }
}