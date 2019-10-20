<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HienThiSP.ascx.cs" Inherits="Cms_Admin_SanPham_QLyTenSP_HienThiTenSP" %>
<div class="head">Danh sách các sản phẩm</div>
<div class="FormDanhSach">
    
    <table class="Danhsach">
        <tr>
            <th class="CotMaSP">Mã sản phẩm</th>
            <th class="CotMaDM">Mã danh mục</th>
            <th class="CotDacDiem">Đặc điểm</th>
            <th class="CotGia">Giá</th>
            <th class="CotAnh">Ảnh</th>
            <th class="CotCongCu">Công cụ</th>
        </tr>
        <asp:Literal ID="LtrSanPham" runat="server"></asp:Literal>      
    </table>
</div>

<script type="text/javascript"> 
    function XoaSanPham(MaSP) {
        if (confirm("Bạn muốn xóa sản phẩm này?"))
        {
            //alert("Xóa mã sản phẩm:"+ MaSP);
            //Code xóa sản phẩm bằng jquery ajax post
            $.post("Cms/Admin/SanPham/QLySanPham/Ajax/AjaxSanPham.aspx",
                {
                    "thaotac": "Xoa",
                    "MaSP": MaSP
                },
                function (data, status) {
                    //alert("Data: " + data + "\nStatus: " + status);
                    if (data == 1) { //thực hiện xóa thành công thì sẽ ẩn dòng đó
                        $("#maDong_" + MaSP).slideUp();
                    }
                });
        }       
    }
</script>