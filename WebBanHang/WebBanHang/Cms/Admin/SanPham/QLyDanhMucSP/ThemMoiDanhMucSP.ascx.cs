using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Admin_SanPham_QLyDanhMucSP_ThemMoiDanhMucSP : System.Web.UI.UserControl
{
    private string thaotac = "";
    private string id = ""; //lấy mã danh mục
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];

        if (Request.QueryString["id"] != null)
            id = Request.QueryString["id"];

        if (!IsPostBack)
        {
            LayMaDanhMucCha();

            HienThiThongTin();
        }
    }


    private void HienThiThongTin()
    {
        if (thaotac == "Chinhsua")
        {
            BtnThemMoi.Text = "Chỉnh sửa";
            cbThemNhieuDanhMuc.Visible = false;
            DataTable dt = new DataTable();
            dt = QuanLyBanHang.DanhMucSP.Thongtin_DanhMucSP_By_MaDanhMucSP(id);
            if (dt.Rows.Count > 0)
            {
                TbTenDanhMuc.Text = dt.Rows[0]["TenDanhMucSP"].ToString();
                DdlMaDanhMucCha.SelectedValue = dt.Rows[0]["MaDanhMucCha"].ToString();
                TbSoSanPhamHienThi.Text = dt.Rows[0]["SoSPHienThi"].ToString();
            }
        }
        else
        {
            BtnThemMoi.Text = "Thêm mới";
            cbThemNhieuDanhMuc.Visible = true;
        }
    }

    private void LayMaDanhMucCha()
    {
        DataTable dt = new DataTable();
        dt = QuanLyBanHang.DanhMucSP.Thongtin_DanhMucSP();
        DdlMaDanhMucCha.Items.Clear();
        DdlMaDanhMucCha.Items.Add(new ListItem("Danh mục gốc", "0"));
        for(int i = 0; i< dt.Rows.Count; i++)
        {
            DdlMaDanhMucCha.Items.Add(new ListItem(dt.Rows[i]["TenDanhMucSP"].ToString(), dt.Rows[i]["MaDanhMucSP"].ToString()));
        }
    }

    protected void BtnThemMoi_Click(object sender, EventArgs e)
    {
        if (thaotac == "Themmoi")
        {
            #region Nút thêm mới
            QuanLyBanHang.DanhMucSP.Insert_DanhMucSP(TbTenDanhMuc.Text, DdlMaDanhMucCha.SelectedValue, TbSoSanPhamHienThi.Text, "");
            LtrThongBao.Text = "<div class='thongBaoThanhCong'>Đã thêm danh mục sản phẩm thành công</div>";

            if (cbThemNhieuDanhMuc.Checked)
            {
                ResetTextBox();
            }
            else
            {
                Response.Redirect("/Admin.aspx?modul=sanpham&modulsp=DanhMucSP");
            }
            #endregion
        }
        else
        {
            #region Nút chỉnh sửa
            QuanLyBanHang.DanhMucSP.Update_DanhMucSP(id, TbTenDanhMuc.Text,DdlMaDanhMucCha.SelectedValue,TbSoSanPhamHienThi.Text);

            Response.Redirect("/Admin.aspx?modul=sanpham&modulsp=DanhMucSP");
            #endregion

        }

    }

    private void ResetTextBox()
    {
        TbTenDanhMuc.Text = "";
        TbSoSanPhamHienThi.Text = "";
    }

    protected void BtnHuy_Click(object sender, EventArgs e)
    {
        ResetTextBox();
    }
}