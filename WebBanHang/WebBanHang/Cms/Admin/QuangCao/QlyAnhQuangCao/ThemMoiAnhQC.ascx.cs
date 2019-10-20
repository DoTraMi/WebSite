using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Admin_QuangCao_QlyAnhQuangCao_ThemMoiAnhQC : System.Web.UI.UserControl
{
    private string thaotac = "";
    private string id = ""; //lấy mã ảnh
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];

        if (Request.QueryString["id"] != null)
            id = Request.QueryString["id"];

        if (!IsPostBack)
        {
            LayNhomQuangCao();

            HienThiThongTin();
        }
    }

    private void LayNhomQuangCao()
    {
        DdlNhomQC.DataSource = QuanLyBanHang.NhomQuangCao.Thongtin_NhomQuangCao();
        DdlNhomQC.DataValueField = "MaNhom";
        DdlNhomQC.DataTextField = "TenNhom";
        DdlNhomQC.DataBind();
    }

    private void HienThiThongTin()
    {
        if (thaotac == "Chinhsua")
        {
            BtnThemMoi.Text = "Chỉnh sửa";
            cbThemNhieuAnh.Visible = false;
            DataTable dt = new DataTable();
            dt = QuanLyBanHang.AnhQuangCao.Thongtin_AnhQuangCao_By_MaAnh(id);
            if (dt.Rows.Count > 0)
            {
                DdlNhomQC.SelectedValue = dt.Rows[0]["MaNhom"].ToString();
                TbTenQuangCao.Text = dt.Rows[0]["TenQuangCao"].ToString();
                tbThuTu.Text = dt.Rows[0]["Thutu"].ToString();
                tbLienKet.Text = dt.Rows[0]["LienKet"].ToString();
            }
            LtrAnhQC.Text = "<img id='imgAnh' class='Anh' src='/Pictures/AnhQuangCao/" + dt.Rows[0]["Anh"] + @"'/>";
            HfTenAnhQCcu.Value = dt.Rows[0]["Anh"].ToString();
        }
        else
        {
            BtnThemMoi.Text = "Thêm mới";
            cbThemNhieuAnh.Visible = true;
        }
    }

    protected void BtnThemMoi_Click(object sender, EventArgs e)
    {
        if (thaotac == "Themmoi")
        {
            #region Nút thêm mới
            //Luu anh vao thu muc pictures cua server
            if (FulAnhQC.FileContent.Length > 0) //ktra co chon file
            {   //ktra co phai la file anh
                if (FulAnhQC.FileName.EndsWith(".jpeg") || FulAnhQC.FileName.EndsWith(".jpg") || FulAnhQC.FileName.EndsWith(".png") || FulAnhQC.FileName.EndsWith(".gif"))
                {
                    FulAnhQC.SaveAs(Server.MapPath("Pictures/AnhQuangCao/") + FulAnhQC.FileName);
                }
            }
            QuanLyBanHang.AnhQuangCao.Insert_AnhQuangCao(DdlNhomQC.SelectedValue, TbTenQuangCao.Text, FulAnhQC.FileName, tbThuTu.Text, tbLienKet.Text, "");
            LtrThongBao.Text = "<div class='thongBaoThanhCong'>Đã thêm ảnh quảng cáo thành công</div>";

            if (cbThemNhieuAnh.Checked)
            {
                ResetTextBox();
            }
            else
            {
                Response.Redirect("/Admin.aspx?modul=quangcao&modulphu=anhquangcao");
            }
            #endregion
        }
        else
        {
            #region Nút chỉnh sửa
            string tenAnh = "";
            //Luu anh vao thu muc pictures cua server
            //Nếu upload ảnh khác
            if (FulAnhQC.FileContent.Length > 0) //ktra co chon file
            {   //ktra co phai la file anh
                if (FulAnhQC.FileName.EndsWith(".jpeg") || FulAnhQC.FileName.EndsWith(".jpg") || FulAnhQC.FileName.EndsWith(".png") || FulAnhQC.FileName.EndsWith(".gif"))
                {
                    FulAnhQC.SaveAs(Server.MapPath("Pictures/AnhQuangCao/") + FulAnhQC.FileName);
                    tenAnh = FulAnhQC.FileName;
                    //code xóa ảnh
                    //imgAnh.Visible = false;
                }
            }
            //giữ ảnh cũ
            if (tenAnh == "")
            {
                tenAnh = HfTenAnhQCcu.Value;
            }
            QuanLyBanHang.AnhQuangCao.Update_AnhQuangCao(id, DdlNhomQC.SelectedValue, TbTenQuangCao.Text, FulAnhQC.FileName, tbThuTu.Text, tbLienKet.Text);

            Response.Redirect("/Admin.aspx?modul=quangcao&modulphu=anhquangcao");
            #endregion

        }

    }

    private void ResetTextBox()
    {
        TbTenQuangCao.Text = "";
        tbThuTu.Text = "";
        tbLienKet.Text = "";
    }

    protected void BtnHuy_Click(object sender, EventArgs e)
    {
        ResetTextBox();
    }
}