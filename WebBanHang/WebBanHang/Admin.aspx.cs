using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Kiểm tra đã đăng nhập thì mới được vào trang này
        if(Session["DangNhap"] != null && Session["DangNhap"].ToString() != "2")
        {

        }
        else
        {
            //nếu chưa đăng nhâp đẩy lại về trang login
            Response.Redirect("/Login.aspx");
        }

        if (!IsPostBack)
            LtrTenDangNhap.Text = Session["TenDangNhap"].ToString();

    }

    protected string DanhDau(string tenModul)
    {
        string s = "";

        /*Lấy giá trị querystring modul*/
        string modul = "";
        if (Request.QueryString["modul"] != null)
            modul = Request.QueryString["modul"];

        /*So sánh nếu querystring bằng tên modul truyền vào thì trả về current -->đánh dấu là menu hiện tại*/
        if (modul == tenModul)
            s = "current";
        return s;
    }

    protected void LbtnDangXuat_Click(object sender, EventArgs e)
    {
        //Xoa cac session đã lưu
        Session["TenDangNhap"] = null;
        Session["DangNhap"] = null;
        //Đẩy về trang Login
        Response.Redirect("/Login.aspx");

    }
}