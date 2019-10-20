<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HienThiMenu.ascx.cs" Inherits="Cms_Admin_Menu_HienThiMenu" %>
<div class="head">Menu</div>
<div class="FormDanhSach">   
    <table class="Danhsach">
        <tr>
            <th class="CotMa">Mã</th>
            <th class="TenMenu">Tên menu</th>
            <th class="ThuTu">Thứ tự</th>
            <th class="MaMenuCha">Mã menu cha</th>
            <th class="LienKet">Liên kết</th>
            <th class="CotCongCu">Công cụ</th>
        </tr>
        <asp:Literal ID="LtrMenu" runat="server"></asp:Literal>      
    </table>
</div>

<script type="text/javascript"> 
    function XoaMenu(Ma) {
        if (confirm("Bạn muốn xóa danh mục sản phẩm này?"))
        {
            //alert("Xóa mã sản phẩm:"+ MaSP);
            //Code xóa sản phẩm bằng jquery ajax post
            $.post("Cms/Admin/Menu/Ajax/AjaxMenu.aspx",
                {
                    "modulmenu": "Xoa",
                    "Ma": Ma
                },
                function (data, status) {
                    //alert("Data: " + data + "\nStatus: " + status);
                    if (data == 1) { //thực hiện xóa thành công thì sẽ ẩn dòng đó
                        $("#maDong_" + Ma).slideUp();
                    }
                });
        }       
    }
</script>