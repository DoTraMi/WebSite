<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HienThiAnhQC.ascx.cs" Inherits="Cms_Admin_QuangCao_QlyAnhQuangCao_HienThiAnhQC" %>
<div class="head">Danh sách các ảnh quảng cáo</div>
<div class="FormDanhSach">
    
    <table class="Danhsach">
        <tr>
            <th class="CotMaAnh">Mã ảnh</th>
            <th class="CotMaNhom">Mã nhóm quảng cáo</th>
            <th class="CotTenQuangCao">Tên quảng cáo</th>           
            <th class="CotAnh">Ảnh</th>
            <th class="CotThutu">Thứ tự</th>
            <th class="CotLienKet">Liên kết</th>
            <th class="CotCongCu">Công cụ</th>
        </tr>
        <asp:Literal ID="LtrSanPham" runat="server"></asp:Literal>      
    </table>
</div>

<script type="text/javascript"> 
    function XoaAnh(MaAnh) {
        if (confirm("Bạn muốn xóa sản phẩm này?"))
        {
            //alert("Xóa mã sản phẩm:"+ MaSP);
            //Code xóa sản phẩm bằng jquery ajax post
            $.post("Cms/Admin/QuangCao/QlyAnhQuangCao/Ajax/AjaxAnhQC.aspx",
                {
                    "thaotac": "Xoa",
                    "MaAnh": MaAnh
                },
                function (data, status) {
                    //alert("Data: " + data + "\nStatus: " + status);
                    if (data == 1) { //thực hiện xóa thành công thì sẽ ẩn dòng đó
                        $("#maDong_" + MaAnh).slideUp();
                    }
                });
        }       
    }
</script>