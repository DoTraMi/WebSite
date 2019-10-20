<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HienThiTaiKhoan.ascx.cs" Inherits="Cms_Admin_TaiKhoan_HienThiTaiKhoan" %>
<div class="head">Danh sách các tài khoản</div>
<div class="FormDanhSach">
    
    <table class="Danhsach">
        <tr>
            <th class="CotTenDangNhap">Tên đăng nhập</th>
            <th class="CotEmail">Email</th>
            <th class="CotDiaChi">Địa chỉ</th>
            <th class="CotTenDayDu">Họ tên</th>
            <th class="CotNgaySinh">Ngày sinh</th>
            <th class="CotGioiTinh">Giới tính</th>
            <th class="CotQuyenDN">Quyền đăng nhập</th>
            <th class="CotCongCu">Công cụ</th>
        </tr>
        <asp:Literal ID="LtrTaiKhoan" runat="server"></asp:Literal>      
    </table>
</div>

<script type="text/javascript"> 
    function XoaTaiKhoan(TenDangNhap) {
        if (confirm("Bạn muốn xóa tài khoản này?"))
        {
            //alert("Xóa mã sản phẩm:"+ MaSP);
            //Code xóa sản phẩm bằng jquery ajax post
            $.post("Cms/Admin/TaiKhoan/QLyTaiKhoan/Ajax/AjaxTaiKhoan.aspx",
                {
                    "thaotac": "Xoa",
                    "TenDangNhap": TenDangNhap
                },
                function (data) {
                    //alert("Data: " + data + "\nStatus: " + status);
                    if (data == 1) { //thực hiện xóa thành công thì sẽ ẩn dòng đó
                        $("#maDong_" + TenDangNhap).slideUp();
                        alert("Xóa thành công!");
                    }
                    else {
                        alert(data);
                    }
                });
        }       
    }
</script>