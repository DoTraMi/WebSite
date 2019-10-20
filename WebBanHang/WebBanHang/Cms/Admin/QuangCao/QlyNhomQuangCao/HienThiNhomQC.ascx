<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HienThiNhomQC.ascx.cs" Inherits="Cms_Admin_QuangCao_QlyNhomQuangCao_HienThiNhomQC" %>
<div class="head">Nhóm quảng cáo</div>
<div class="FormDanhSach">   
    <table class="Danhsach">
        <tr>
            <th class="MaNhom">Mã nhóm</th>
            <th class="TenNhom">Tên nhóm</th>
            <th class="Vitri">Vị trí</th>
            <th class="CotCongCu">Công cụ</th>
        </tr>
        <asp:Literal ID="LtrNhomQC" runat="server"></asp:Literal>      
    </table>
</div>

<script type="text/javascript"> 
    function XoaNhomQuangCao(MaNhom) {
        if (confirm("Bạn muốn xóa nhóm quảng cáo này?"))
        {
            //alert("Xóa mã sản phẩm:"+ MaSP);
            //Code xóa bằng jquery ajax post
            $.post("Cms/Admin/QuangCao/QlyNhomQuangCao/Ajax/AjaxNhomQC.aspx",
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