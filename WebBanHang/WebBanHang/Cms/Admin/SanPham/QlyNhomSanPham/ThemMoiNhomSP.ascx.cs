using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Admin_SanPham_QlyNhomSanPham_ThemMoiNhomSP : System.Web.UI.UserControl
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
            dt = QuanLyBanHang.NhomSanPham.Thongtin_NhomSanPham_By_MaNhom(id);
            if (dt.Rows.Count > 0)
            {
                TbTenNhom.Text = dt.Rows[0]["TenNhom"].ToString();
                TbThuTu.Text = dt.Rows[0]["ThuTu"].ToString();
                TbSoSanPhamHienThi.Text = dt.Rows[0]["SoSPHienThi"].ToString();
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
            QuanLyBanHang.NhomSanPham.Insert_NhomSanPham(TbTenNhom.Text, TbThuTu.Text, TbSoSanPhamHienThi.Text, "");
            LtrThongBao.Text = "<div class='thongBaoThanhCong'>Đã thêm nhóm sản phẩm thành công</div>";

            if (cbThemNhieuNhom.Checked)
            {
                ResetTextBox();
            }
            else
            {
                Response.Redirect("/Admin.aspx?modul=sanpham&modulsp=NhomSP");
            }
            #endregion
        }
        else
        {
            #region Nút chỉnh sửa
            QuanLyBanHang.NhomSanPham.Update_NhomSanPham(id, TbTenNhom.Text, TbThuTu.Text, TbSoSanPhamHienThi.Text);

            Response.Redirect("/Admin.aspx?modul=sanpham&modulsp=NhomSP");
            #endregion

        }

    }

    private void ResetTextBox()
    {
        TbTenNhom.Text = "";
        TbThuTu.Text = "";
        TbSoSanPhamHienThi.Text = "";
    }

    protected void BtnHuy_Click(object sender, EventArgs e)
    {
        ResetTextBox();
    }
}