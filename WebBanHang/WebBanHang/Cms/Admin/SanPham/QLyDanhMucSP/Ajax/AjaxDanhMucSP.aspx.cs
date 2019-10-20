﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Admin_SanPham_QLyDanhMucSP_Ajax_AjaxDanhMucSP : System.Web.UI.Page
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        //Cần viết code kiểm tra đăng nhập
        if (Session["DangNhap"] != null && Session["DangNhap"].ToString() != "2")
        {

        }
        else
        {
            //nếu chưa đăng nhâp thì dừng k cho thực hiện câu lệnh dưới
            return;
        }

        if (Request.Params["thaotac"] != null)
            thaotac = Request.Params["thaotac"];
        switch (thaotac)
        {
            case "Xoa":
                XoaDanhMucSanPham();
                break;
        }
    }

    private void XoaDanhMucSanPham()
    {
        string MaDanhMucSP = "";
        if (Request.Params["MaDanhMucSP"] != null)
            MaDanhMucSP = Request.Params["MaDanhMucSP"];
        //thực hiện xóa
        QuanLyBanHang.DanhMucSP.Delete_DanhMucSP(MaDanhMucSP);
        //thông báo:1-thực hiện xóa thành công;
        Response.Write("1");
    }
}