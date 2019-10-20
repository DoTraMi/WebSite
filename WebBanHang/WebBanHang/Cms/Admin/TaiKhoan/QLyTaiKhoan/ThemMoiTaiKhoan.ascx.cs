using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Admin_TaiKhoan_QLyTaiKhoan_ThemMoiTaiKhoan : System.Web.UI.UserControl
{
    private string thaotac = "";
    private string id = ""; //lấy tên đăng nhập
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];

        if (Request.QueryString["id"] != null)
            id = Request.QueryString["id"];

        if (!IsPostBack)
        {
            LayMaQuyen();
            LayMaCauHoi();

            HienThiThongTin();
        }
    }

    private void HienThiThongTin()
    {
        if (thaotac == "Chinhsua")
        {
            BtnThemMoi.Text = "Chỉnh sửa";
            cbThemNhieuTK.Visible = false;
            tbTenDangNhap.Enabled= false;
            DataTable dt = new DataTable();
            dt = QuanLyBanHang.DangKyTaiKhoan.Thongtin_TaiKhoan_By_TenDangNhap(id);
            if (dt.Rows.Count > 0)
            {
                tbTenDangNhap.Text = dt.Rows[0]["TenDangNhap"].ToString();
                //tbMatKhau.Text = dt.Rows[0]["MatKhau"].ToString();
                tbEmail.Text = dt.Rows[0]["EmailDK"].ToString();
                tbDiaChi.Text = dt.Rows[0]["DiaChiDK"].ToString();
                tbTenDayDu.Text = dt.Rows[0]["TenDayDu"].ToString();
                DdlCauHoi.SelectedValue = dt.Rows[0]["MaCauHoiBaoMat"].ToString();
                tbCauTraLoi.Text = dt.Rows[0]["CauTraLoi"].ToString();
                tbNgaySinh.Text = dt.Rows[0]["NgaySinh"].ToString();
                tbGioiTinh.Text = dt.Rows[0]["GioiTinh"].ToString();
                DdlQuyenDN.SelectedValue = dt.Rows[0]["MaQuyen"].ToString();

                //Neu k đổi mật khẩu;
                HfMatKhauCu.Value = dt.Rows[0]["MatKhau"].ToString();
                //Bỏ yêu cầu bắt buộc nhập mật khẩu khi cập nhật
                RequiredFieldValidator2.Visible = false;
            }
        }
        else
        {
            BtnThemMoi.Text = "Thêm mới";
            cbThemNhieuTK.Visible = true;
            RequiredFieldValidator2.Visible = true;
        }
    }

    private void LayMaQuyen()
    {
        DataTable dt = new DataTable();
        dt = QuanLyBanHang.QuyenDangNhap.Thongtin_QuyenDangNhap();
        DdlQuyenDN.Items.Clear();
        for (int i=0; i < dt.Rows.Count; i++)
        {
            DdlQuyenDN.Items.Add(new ListItem(dt.Rows[i]["TenQuyen"].ToString(), dt.Rows[i]["MaQuyen"].ToString()));
        }
        /*
        DdlQuyenDN.DataValueField = "MaQuyen";
        DdlQuyenDN.DataTextField = "TenQuyen";
        DdlQuyenDN.DataBind();
        */
    }

    private void LayMaCauHoi()
    {
        DdlCauHoi.DataSource = QuanLyBanHang.CauHoiBaoMat.Thongtin_CauHoi();
        DdlCauHoi.DataValueField = "MaCauHoiBaoMat";
        DdlCauHoi.DataTextField = "CauHoi";
        DdlCauHoi.DataBind();
    }

    protected void BtnThemMoi_Click(object sender, EventArgs e)
    {
        if (thaotac == "Themmoi")
        {
            #region Nút thêm mới
            //code ktra ton tai ten dang nhap co trong database chua
            string matkhau = QuanLyBanHang.MaHoa.MaHoaMD5(tbMatKhau.Text);

            QuanLyBanHang.DangKyTaiKhoan.Insert_TaiKhoan(tbTenDangNhap.Text, matkhau, tbEmail.Text, tbDiaChi.Text, tbTenDayDu.Text, DdlCauHoi.SelectedValue, tbCauTraLoi.Text, tbNgaySinh.Text, tbGioiTinh.Text, DdlQuyenDN.SelectedValue, "");
            LtrThongBao.Text = "<div class='thongBaoThanhCong'>Đã thêm tài khoản: " + tbTenDangNhap.Text + " thành công</div>";

            if (cbThemNhieuTK.Checked)
            {
                ResetTextBox();
            }
            else
            {
                Response.Redirect("/Admin.aspx?modul=taikhoan&modulsp=dstaikhoan");
            }
            #endregion
        }
        else
        {
            #region Nút chỉnh sửa
            string MK = "";
            if (tbMatKhau.Text != "")
            {
                //thay đổi mật khẩu
                MK = QuanLyBanHang.MaHoa.MaHoaMD5(tbMatKhau.Text);
            }
            else
            {
                //Giữ mật khẩu cũ
                MK = QuanLyBanHang.MaHoa.MaHoaMD5(HfMatKhauCu.Value);
            }
            QuanLyBanHang.DangKyTaiKhoan.Update_TaiKhoan(id, MK, tbEmail.Text, tbDiaChi.Text, tbTenDayDu.Text, DdlCauHoi.SelectedValue, tbCauTraLoi.Text, tbNgaySinh.Text, tbGioiTinh.Text, DdlQuyenDN.SelectedValue);
            Response.Redirect("/Admin.aspx?modul=taikhoan&modulsp=dstaikhoan");   
            #endregion
        }

    }

    private void ResetTextBox()
    {
        tbTenDangNhap.Text = "";
        tbMatKhau.Text = "";
        tbEmail.Text = "";
        tbDiaChi.Text = "";
        tbTenDayDu.Text = "";
        tbCauTraLoi.Text = "";
        tbNgaySinh.Text = "";
        tbGioiTinh.Text = "";
    }

    protected void BtnHuy_Click(object sender, EventArgs e)
    {
        ResetTextBox();
    }
}