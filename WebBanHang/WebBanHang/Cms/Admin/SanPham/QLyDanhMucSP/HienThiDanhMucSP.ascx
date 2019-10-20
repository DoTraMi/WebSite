<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HienThiDanhMucSP.ascx.cs" Inherits="Cms_Admin_SanPham_QLyDanhMucSP_HienThiDanhMucSP" %>
<div class="head">Danh mục các sản phẩm</div>
<div class="FormDanhSach">   
    <table class="Danhsach">
        <tr>
            <th class="CotMaDanhMucSP">Mã danh mục</th>
            <th class="TenDanhMucSP">Tên danh mục</th>
            <th class="MaDanhMucCha">Mã danh mục cha</th>
            <th class="SoSPHienThi">Số sản phẩm hiển thị</th>
            <th class="CotCongCu">Công cụ</th>
        </tr>
        <asp:Literal ID="LtrDanhMucSP" runat="server"></asp:Literal>      
    </table>
</div>

<script type="text/javascript"> 
    function XoaDanhMucSanPham(MaDanhMucSP) {
        if (confirm("Bạn muốn xóa danh mục sản phẩm này?"))
        {
            //alert("Xóa mã sản phẩm:"+ MaSP);
            //Code xóa sản phẩm bằng jquery ajax post
            $.post("Cms/Admin/SanPham/QLyDanhMucSP/Ajax/AjaxDanhMucSP.aspx",
                {
                    "thaotac": "Xoa",
                    "MaDanhMucSP": MaDanhMucSP
                },
                function (data, status) {
                    //alert("Data: " + data + "\nStatus: " + status);
                    if (data == 1) { //thực hiện xóa thành công thì sẽ ẩn dòng đó
                        $("#maDong_" + MaDanhMucSP).slideUp();
                    }
                });
        }       
    }
</script>