using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cms_Display_SanPham_Ajax_AjaxGioHang : System.Web.UI.Page
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        thaotac = Request.Params["thaotac"];
        switch(thaotac)
        {
            case "ThemVaoGioHang":
                ThemVaoGioHang();
                break;
            case "LayThongTinGioHang":
                LayThongTinGioHang();
                break;
            case "LayTongSoSPTrongGioHang":
                LayTongSoSPTrongGioHang();
                break;
            case "LayTongTien":
                LayTongTien();
                break;
            case "XoaSPGioHang":
                XoaSPGioHang();
                break;
            case "CapNhatSoLuong":
                CapNhatSoLuong();
                break;
            case "GuiDonHang":
                GuiDonHang();
                break;
        }
    }

    private void GuiDonHang()
    {
        string ketQua = "";
        string hoTen = Request.Params["HoTen"];
        string email = Request.Params["Email"];
        string sdt = Request.Params["Sdt"];
        string diaChi = Request.Params["DiaChi"];
        string ghiChu = Request.Params["GhiChu"];

        //Nếu có giỏ hàng thì mới cho đặt hàng
        if (Session["giohang"] != null)
        {
            //Khai bao datatable để chứa giỏ hàng
            DataTable dtGioHang = new DataTable();
            dtGioHang = (DataTable)Session["giohang"];

            #region Kiểm tra thông tin xem có khách hàng trong database chưa.Nếu chưa thì tạo khách hàng mới
            string Id_Khach_Hang = XuLyThongTinKhachHang(hoTen,email,sdt,diaChi);
            #endregion

            #region Thêm thông tin vào bảng đơn đặt hàng
            double tongTien = 0;
            //Lập trong giỏ hàng để lấy tổng tiền
            for (int i = 0; i < dtGioHang.Rows.Count; i++)
            {
                tongTien += double.Parse(dtGioHang.Rows[i]["SoLuong"].ToString()) * Convert.ToDouble(dtGioHang.Rows[i]["GiaSP"].ToString());
            }

            string ngayTao = DateTime.Now.ToString();
            QuanLyBanHang.DonDatHang.Insert_DonHang(ghiChu, ngayTao, tongTien.ToString(), "Chưa chuyển", Id_Khach_Hang, hoTen, sdt, email, diaChi, "");
            #endregion

            #region Đọc giỏ hàng và thêm sản phẩm vào bảng chi tiết đơn đặt hàng
            //Lấy thông tin đơn đặt hàng vừa tạo
            DataTable dtDonDatHang = QuanLyBanHang.DonDatHang.Thongtin_DonHangMoiNhat();
            string MaDonDatHang = dtDonDatHang.Rows[0]["MaDonDatHang"].ToString();

            for (int i = 0; i < dtGioHang.Rows.Count; i++)
            {
                QuanLyBanHang.ChiTietDonHang.Insert_ChiTietDonHang(dtGioHang.Rows[i]["MaSP"].ToString(), MaDonDatHang, dtGioHang.Rows[i]["SoLuong"].ToString(), dtGioHang.Rows[i]["GiaSP"].ToString(), "");
            }
            #endregion

            #region Xóa giỏ hàng
            Session["giohang"] = null;
            #endregion
        }
        else
        {
            ketQua = "Vui lòng chọn lại sản phẩm và thực hiện đặt hàng lại.";
        }

        Response.Write(ketQua);
    }

    private string XuLyThongTinKhachHang(string hoTen, string email, string sdt, string diaChi)
    {
        string idKH = "";
        //Lấy danh sách khách hàng theo Email.Nếu chưa có thì thêm mới.
        DataTable dt = new DataTable();
        dt = QuanLyBanHang.Khach.Thongtin_KhachHang_By_Email(email);
        if(dt.Rows.Count == 0)
        {
            QuanLyBanHang.Khach.Insert_KhachHang(hoTen, "", email, QuanLyBanHang.MaHoa.MaHoaMD5(email), sdt, diaChi, "");
            dt = QuanLyBanHang.Khach.Thongtin_KhachHang_By_Email(email);
            idKH = dt.Rows[0]["Id_Khach_Hang"].ToString();
        }
        else
        {
            idKH = dt.Rows[0]["Id_Khach_Hang"].ToString();
        }
        return idKH;
    }

    private void CapNhatSoLuong()
    {
        string MaSP = Request.Params["MaSP"];
        string soLuongMoi = Request.Params["soLuongMoi"];

        //Nếu có giỏ hàng
        if (Session["giohang"] != null)
        {
            //Khai bao datatable để chứa giỏ hàng
            DataTable dtGioHang = new DataTable();
            dtGioHang = (DataTable)Session["giohang"];

            //lặp qua danh sách sản phẩm trong giỏ hàng
            //cập nhật số lượng sản phẩm
            for (int i = 0; i < dtGioHang.Rows.Count; i++)
            {
                if (dtGioHang.Rows[i]["MaSP"].ToString() == MaSP)
                    dtGioHang.Rows[i]["SoLuong"] = soLuongMoi;
            }

            Session["giohang"] = dtGioHang;
        }

        Response.Write("");
    }


    private void XoaSPGioHang()
    {
        string MaSP = Request.Params["MaSP"];

        //Nếu có giỏ hàng
        if (Session["giohang"] != null)
        {
            //Khai bao datatable để chứa giỏ hàng
            DataTable dtGioHang = new DataTable();
            dtGioHang = (DataTable)Session["giohang"];

            //lặp qua danh sách sản phẩm trong giỏ hàng
            //bỏ sản phẩm theo id truyền lên
            for (int i = 0; i < dtGioHang.Rows.Count; i++)
            {
                if(dtGioHang.Rows[i]["MaSP"].ToString() == MaSP )
                dtGioHang.Rows[i].Delete();
            }

            Session["giohang"] = dtGioHang;
        }

        Response.Write("");
    }

    private void LayTongTien()
    {
        double tongTien = 0;
        //Nếu có giỏ hàng
        if (Session["giohang"] != null)
        {
            //Khai bao datatable để chứa giỏ hàng
            DataTable dtGioHang = new DataTable();
            dtGioHang = (DataTable)Session["giohang"];

            //chạy vong lặp và xuất tong so sap trong giỏ
            for (int i = 0; i < dtGioHang.Rows.Count; i++)
            {
                tongTien += double.Parse(dtGioHang.Rows[i]["SoLuong"].ToString()) * Convert.ToDouble(dtGioHang.Rows[i]["GiaSP"].ToString());
            }
        }

        Response.Write(tongTien);
    }

    private void LayTongSoSPTrongGioHang()
    {
        int tongSo = 0;
        //Nếu có giỏ hàng
        if (Session["giohang"] != null)
        {
            //Khai bao datatable để chứa giỏ hàng
            DataTable dtGioHang = new DataTable();
            dtGioHang = (DataTable)Session["giohang"];

            //chạy vong lặp và xuất tong so sap trong giỏ
            for (int i = 0; i < dtGioHang.Rows.Count; i++)
            {
                tongSo += int.Parse(dtGioHang.Rows[i]["SoLuong"].ToString());
            }
        }

        Response.Write(tongSo);
    }

    private void LayThongTinGioHang()
    {
        string ketQua = "";
        //Nếu có giỏ hàng
        if (Session["giohang"] != null)
        {
            //Khai bao datatable để chứa giỏ hàng
            DataTable dtGioHang = new DataTable();
            dtGioHang = (DataTable)Session["giohang"];

            ketQua += @"
            <table style='width:100%' id='cart-table'>
                <tbody>
                    <tr>
                        <th class='item-image'>Ảnh</th>
                        <th class='item-title'>Tên sản phẩm</th>
                        <th class='item-quatity'>Số lượng</th>
                        <th class='item-price'>Giá tiền 1 sản phẩm</th>
                        <th class='delete-item'></th>
                    </tr>";
            //chạy vong lặp và xuất dữ liệu trong giỏ ra bảng
            for (int i = 0; i < dtGioHang.Rows.Count; i++)
            {
                //<input id='quatity' min='1' type='number' class='' value='" + dtGioHang.Rows[i]["SoLuong"] + @"'/>
                ketQua += @"
                   <tr class='line-item' id='tr_" + dtGioHang.Rows[i]["MaSP"] + @"'>
                        <td class='item-image'>
                            <img src='../../../Pictures/SanPham/" + dtGioHang.Rows[i]["Anh"] + @"'/></td>
                        <td class='item-title'><a href='/Default.aspx?modul=sanpham&modulphu=chitietsp&id=" + dtGioHang.Rows[i]["MaSP"] + @"'>" + dtGioHang.Rows[i]["TenSanPham"] + @"</a></td>
                        <td class='item-quatity'><input onclick='CapNhatSoLuong(" + dtGioHang.Rows[i]["MaSP"] + @")' id='quatity_" + dtGioHang.Rows[i]["MaSP"] + @"' min='1' type='number' class='' value='" + dtGioHang.Rows[i]["SoLuong"] + @"'/></td>
                        <td class='item-price'>" + dtGioHang.Rows[i]["GiaSP"] + @".000đ</td>
                        <td class='delete-item'><a href='javascript://' onclick='XoaSPGioHang(" + dtGioHang.Rows[i]["MaSP"] + @")'>Xóa</a></td>
                    </tr>";               
            }

            ketQua += @"</tbody>
            </table>";

        }

        Response.Write(ketQua);
    }

    private void ThemVaoGioHang()
    {
        string ketQua = "";

        string id = Request.Params["id"];
        string soLuong = Request.Params["soluong"];

        //Lay thông tin chi tiết san pham de them vao gio hang
        DataTable dt = new DataTable();
        dt = QuanLyBanHang.SanPham.Thongtin_SanPham_By_MaSP(id);
        //Neu ton tai san pham moi thuc hien thao tac
        if (dt.Rows.Count>0)
        {
            //Neu chua co gio hang => tao gio hang
            if(Session["giohang"] == null)
            {
                //tạo bảng lưu thông tin san phẩm vào giỏ hàng đầu tiên
                DataTable dtGioHang = new DataTable();
                dtGioHang.Columns.Add("MaSP");
                dtGioHang.Columns.Add("TenSanPham");
                dtGioHang.Columns.Add("Anh");
                dtGioHang.Columns.Add("GiaSP");
                dtGioHang.Columns.Add("SoLuong");

                //Bảng tạm lưu thông tin các sản phẩm hiện tại vào giỏ hàng
                dtGioHang.Rows.Add(dt.Rows[0]["MaSP"].ToString(), dt.Rows[0]["TenSanPham"].ToString(), dt.Rows[0]["Anh"].ToString(), dt.Rows[0]["GiaSP"].ToString(), soLuong);

                //Gán giá trị của bảng tạm vào session giỏ hàng
                Session["giohang"] = dtGioHang;
            }
            else //neu co gio hang thi them san pham vao gio hang
            {
                //Khai bao datatable để chứa giỏ hàng
                DataTable dtGioHang = new DataTable();
                dtGioHang = (DataTable)Session["giohang"];
                //Ktra trong giỏ hàng có sp này chưa
                //Nếu có thì tăng số lượng vào dòng sản phẩm này
                //Nếu k có thì thêm 1 dòng sản phẩm
                int viTriSPTrongGioHang = -1;//Nếu sau vòng lặp vitri thay đổi thì có sp trong giở hàng
                for (int i=0;i<dtGioHang.Rows.Count;i++)
                {
                    if(dtGioHang.Rows[i]["MaSP"].ToString() == id)
                    {
                        //Có sp trong giỏ hàng
                        viTriSPTrongGioHang = i;
                        break;
                    }
                }

                if(viTriSPTrongGioHang!=-1)
                {
                    //Lấy ra số lượng hiện tại trong giỏ hàng
                    int soLuongHienTai = int.Parse(dtGioHang.Rows[viTriSPTrongGioHang]["SoLuong"].ToString());
                    //Tăng số lượng mua thêm
                    soLuongHienTai += int.Parse(soLuong);
                    //Cập nhật bảng tạm
                    dtGioHang.Rows[viTriSPTrongGioHang]["SoLuong"] = soLuongHienTai;
                    //Gán giá trị của bảng tạm vào session giỏ hàng
                    Session["giohang"] = dtGioHang;
                }
                else
                {
                    //Bảng tạm lưu thông tin các sản phẩm hiện tại vào giỏ hàng
                    dtGioHang.Rows.Add(dt.Rows[0]["MaSP"].ToString(), dt.Rows[0]["TenSanPham"].ToString(), dt.Rows[0]["Anh"].ToString(), dt.Rows[0]["GiaSP"].ToString(), soLuong);

                    //Gán giá trị của bảng tạm vào session giỏ hàng
                    Session["giohang"] = dtGioHang;
                }
            }
        }
        else
        {
            ketQua = "Không tồn tại sản phẩm này.";
        }
        Response.Write(ketQua);
    }
}