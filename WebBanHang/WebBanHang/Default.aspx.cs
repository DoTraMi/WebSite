using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            #region Kiểm tra đăng nhập hay chưa 
            if(Session["KhachHang"] != null && Session["KhachHang"].ToString() == "1")
            {
                PlDaDangNhap.Visible = true;
                PlChuaDangNhap.Visible = false;

                if(Session["TenKH"] != null)
                LtrTenKH.Text = "Xin chào "+ Session["TenKH"].ToString() + " | ";
            }
            else
            {
                PlDaDangNhap.Visible = false;
                PlChuaDangNhap.Visible = true;

            }
            #endregion
            LtrLogo.Text = LayLogo();
            LtrBanner.Text = LayBanner();

            Ltrmenungang.Text = LayMenu();
            Ltrdanhmucsanpham.Text = LayDanhMucSanPham();           
        }
    }

   

    private string LayDanhMucSanPham()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = QuanLyBanHang.DanhMucSP.Thongtin_DanhMucSP_By_MaDanhMucCha("0");

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            s += @"<li><a href='/Default.aspx?modul=sanpham&modulphu=danhsachsp&id=" + dt.Rows[i]["MaDanhMucSP"] + @"' title='" + dt.Rows[i]["TenDanhMucSP"] + @"'>" + dt.Rows[i]["TenDanhMucSP"] + @"</a></li>";
        }

        return s;
    }

    private string LayMenu()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = QuanLyBanHang.Menu.Thongtin_Menu_By_MenuCha("0");
      
        for(int i = 0; i<dt.Rows.Count;i++)
        {
            string lk = dt.Rows[i]["LienKet"].ToString();
            if (lk == "") lk = "#";

            s += @"<li class='menu1'><a href='" + lk + @"' title='" + dt.Rows[i]["TenMenu"] + @"'>" + dt.Rows[i]["TenMenu"] + @"</a></li>";
        }
       
        return s;
    }

    private string LayBanner()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = QuanLyBanHang.NhomQuangCao.Thongtin_NhomQuangCao_By_Vitri("Banner");

        if (dt.Rows.Count > 0)
        {
            //Lấy ảnh quảng cáo theo mã nhóm
            s = LayAnh(dt.Rows[0]["MaNhom"].ToString());
        }

        return s;
    }

    private string LayLogo()
    {
        string s = "";

        //Lấy vị trí nhóm
        DataTable dt = new DataTable();
        dt = QuanLyBanHang.NhomQuangCao.Thongtin_NhomQuangCao_By_Vitri("Logo");

        if(dt.Rows.Count > 0)
        {
            //Lấy ảnh quảng cáo theo mã nhóm
            s = LayAnh(dt.Rows[0]["MaNhom"].ToString());
        }

        return s;
    }

    private string LayAnh(string maNhom)
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = QuanLyBanHang.AnhQuangCao.Thongtin_AnhQuangCao_By_MaNhom(maNhom);

        if (dt.Rows.Count > 0)
        {
            string lk = dt.Rows[0]["LienKet"].ToString();
            if (lk == "") lk = "#";
            s += @"<a href='" + lk + @"' title='" + dt.Rows[0]["TenQuangCao"] + @"'>
                <img src='/Pictures/AnhQuangCao/" + dt.Rows[0]["Anh"] + @"' alt='"+ dt.Rows[0]["TenQuangCao"] + @"' /></a>";
        }

        return s;
    }

    protected void LbtnDangXuat_Click(object sender, EventArgs e)
    {
        Session["KhachHang"] = null;
        Session["IdKH"] = null;
        Session["TenKH"] = null;
        Session["FacebookKH"] = null;
        Session["EmailKH"] = null;
        Session["SdtKH"] = null;
        Session["DiaChiKH"] = null;

        Response.Redirect("/Default.aspx");
    }
}