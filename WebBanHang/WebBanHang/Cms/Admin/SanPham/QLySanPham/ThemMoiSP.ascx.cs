using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Admin_SanPham_QLyTenSP_ThemMoiTenSP : System.Web.UI.UserControl
{
    private string thaotac = "";
    private string id = ""; //lấy mã sp
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];

        if(Request.QueryString["id"] != null)
            id = Request.QueryString["id"];

        if (!IsPostBack)
        {
            LayDanhMucSP();
            LayNhomSP();

            HienThiThongTin();
        }
    }

    private void LayNhomSP()
    {
        DdlNhomSP.DataSource = QuanLyBanHang.NhomSanPham.Thongtin_NhomSanPham();
        DdlNhomSP.DataValueField = "MaNhom";
        DdlNhomSP.DataTextField = "TenNhom";
        DdlNhomSP.DataBind();
    }

    private void HienThiThongTin()
    {
        if (thaotac == "Chinhsua")
        {
            BtnThemMoi.Text = "Chỉnh sửa";
            cbThemNhieuSP.Visible = false;
            DataTable dt = new DataTable();
            dt = QuanLyBanHang.SanPham.Thongtin_SanPham_By_MaSP(id);
            if(dt.Rows.Count > 0)
            {
                DdlDanhMucSP.SelectedValue = dt.Rows[0]["MaDanhMucSP"].ToString();
                DdlNhomSP.SelectedValue = dt.Rows[0]["MaNhom"].ToString();
                tbDacDiemSP.Text = dt.Rows[0]["DacDiemSP"].ToString();
                tbGiaSP.Text = dt.Rows[0]["GiaSP"].ToString();
                TbTenSP.Text = dt.Rows[0]["TenSanPham"].ToString();
            }
            LtrAnhSP.Text = "<img id='imgAnh' class='Anh' src='/Pictures/SanPham/" + dt.Rows[0]["Anh"] + @"'/>";
            HfTenAnhSPcu.Value = dt.Rows[0]["Anh"].ToString();
        }
        else
        {
            BtnThemMoi.Text = "Thêm mới";
            cbThemNhieuSP.Visible = true;
        }
    }

    private void LayDanhMucSP()
    {
        DdlDanhMucSP.DataSource = QuanLyBanHang.DanhMucSP.Thongtin_DanhMucSP();
        DdlDanhMucSP.DataValueField = "MaDanhMucSP";
        DdlDanhMucSP.DataTextField = "TenDanhMucSP";
        DdlDanhMucSP.DataBind();
    }

    protected void BtnThemMoi_Click(object sender, EventArgs e)
    {
        if(thaotac=="Themmoi")
        {
            #region Nút thêm mới
            //Luu anh vao thu muc pictures cua server
            if (FulAnhSP.FileContent.Length > 0) //ktra co chon file
            {   //ktra co phai la file anh
                if (FulAnhSP.FileName.EndsWith(".jpeg") || FulAnhSP.FileName.EndsWith(".jpg") || FulAnhSP.FileName.EndsWith(".png") || FulAnhSP.FileName.EndsWith(".gif"))
                {
                    FulAnhSP.SaveAs(Server.MapPath("Pictures/SanPham/") + FulAnhSP.FileName);
                }
            }
            QuanLyBanHang.SanPham.Insert_SanPham(DdlDanhMucSP.SelectedValue, tbDacDiemSP.Text, tbGiaSP.Text, FulAnhSP.FileName, TbTenSP.Text, DdlNhomSP.SelectedValue, "");
            LtrThongBao.Text = "<div class='thongBaoThanhCong'>Đã thêm sản phẩm thành công</div>";

            if (cbThemNhieuSP.Checked)
            {
                ResetTextBox();
            }
            else
            {
                Response.Redirect("/Admin.aspx?modul=sanpham&modulsp=DacDiemSP");
            }
            #endregion
        }
        else
        {
            #region Nút chỉnh sửa
            string tenAnh = "";
            //Luu anh vao thu muc pictures cua server
            //Nếu upload ảnh khác
            if (FulAnhSP.FileContent.Length > 0) //ktra co chon file
            {   //ktra co phai la file anh
                if (FulAnhSP.FileName.EndsWith(".jpeg") || FulAnhSP.FileName.EndsWith(".jpg") || FulAnhSP.FileName.EndsWith(".png") || FulAnhSP.FileName.EndsWith(".gif"))
                {
                    FulAnhSP.SaveAs(Server.MapPath("Pictures/SanPham/") + FulAnhSP.FileName);
                    tenAnh = FulAnhSP.FileName;
                    //code xóa ảnh
                    //imgAnh.Visible = false;
                }
            }
            //giữ ảnh cũ
            if(tenAnh=="")
            {
                tenAnh = HfTenAnhSPcu.Value;
            }
            QuanLyBanHang.SanPham.Update_SanPham(id,DdlDanhMucSP.SelectedValue, tbDacDiemSP.Text, tbGiaSP.Text, tenAnh, TbTenSP.Text, DdlNhomSP.SelectedValue);

            Response.Redirect("/Admin.aspx?modul=sanpham&modulsp=DacDiemSP");
            #endregion

        }
       
    }

    private void ResetTextBox()
    {
        tbDacDiemSP.Text = "";
        tbGiaSP.Text = "";
        TbTenSP.Text = "";
    }

    protected void BtnHuy_Click(object sender, EventArgs e)
    {
        ResetTextBox();
    }
}