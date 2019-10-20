<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HienThiNhomSP.ascx.cs" Inherits="Cms_Admin_SanPham_QlyNhomSanPham_HienThiNhomSP" %>
<div class="head">Nhóm các sản phẩm</div>
<div class="FormDanhSach">   
    <table class="Danhsach">
        <tr>
            <th class="MaNhom">Mã nhóm</th>
            <th class="TenNhom">Tên nhóm</th>
            <th class="ThuTu">Thứ tự</th>
            <th class="SoSPHienThi">Số sản phẩm hiển thị</th>
            <th class="CotCongCu">Công cụ</th>
        </tr>
        <asp:Literal ID="LtrNhomSP" runat="server"></asp:Literal>      
    </table>
</div>

<script type="text/javascript"> 
    function XoaNhomSanPham(MaNhom) {
        if (confirm("Bạn muốn xóa nhóm sản phẩm này?"))
        {
            //alert("Xóa mã sản phẩm:"+ MaSP);
            //Code xóa sản phẩm bằng jquery ajax post
            $.post("Cms/Admin/SanPham/QLyNhomSanPham/Ajax/AjaxNhomSP.aspx",
                {
                    "thaotac": "Xoa",
                    "MaNhom": MaNhom
                },
                function (data, status) {
                    //alert("Data: " + data + "\nStatus: " + status);
                    if (data == 1) { //thực hiện xóa thành công thì sẽ ẩn dòng đó
                        $("#maDong_" + MaNhom).slideUp();
                    }
                });
        }       
    }
</script>