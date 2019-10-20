<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ChiTietSanPham.ascx.cs" Inherits="Cms_Display_SanPham_ChiTietSanPham" %>
<link href="../../../Css/Chitietsp.css" rel="stylesheet" />
<div class="chitietsp">
    <div class="anhsp">
        <asp:Literal ID="LtrAnh" runat="server"></asp:Literal>
    </div>
    <div class="baochitiet">
        <div class="tensp">
            <h2><asp:Literal ID="LtrTenSP" runat="server"></asp:Literal></h2>        
        </div>
        <div class="dacdiemsp">
             <span><asp:Literal ID="Ltrdacdiem" runat="server"></asp:Literal></span>
        </div>
        <div class="giasp">
            <span><asp:Literal ID="Ltrgia" runat="server"></asp:Literal></span>
        </div>
        <div class="datmua">
            <div class="truong">
                <label class="tentruong">Số lượng</label>
                <input id="quatity" type="number" name="quatity" min="1" value="1" class="tc-item-quantity" />
            </div>
            <div class="truong">
                <label class="tentruong">Kích thước</label>
                <input id="size" type="number" name="size" min="1" value="" class="tc-item-size" />
            </div>
            <div class="truong">
                <label class="tentruong">Màu sắc</label>
                <select class="select-mau">
                    <option value="Đen">Đen</option>
                    <option value="Trắng">Trắng</option>
                    <option value="Đỏ">Đỏ</option>
                    <option value="Hồng">Hồng</option>
                    <option value="Xanh">Xanh</option>
                </select>
            </div>
            <div class="truong">
                <div><a id="add-to-cart"  Class="btnDetails" href="javascript:ThemVaoGioHang()">Thêm vào giỏ</a></div>
                <div><a id="by-now" Class="btnDetails" href="javascript:MuaNgay()">Mua Ngay</a></div>
            </div>
        </div>
    </div>   
</div>

<div class="sanphamlienquan">
    <div class="title-line">
        <a class="groupname" href="#">
            <h2>SẢN PHẨM LIÊN QUAN</h2>
        </a>
    </div>
    <div class="dsitem">
        <asp:Literal ID="LtrDanhSachSPLienQuan" runat="server"></asp:Literal>
        <%--<div class="item">
            <a class="title" href="#" title="Áo quả cầu bling">
                <img src="/Pictures/SanPham/Ao_qua_cau.jpg" alt="Áo quả cầu bling"/>
            </a>
            <a class="title-sp" href="#" title="Áo quả cầu bling">
                Áo quả cầu bling
            </a>
            <a class="gia" href="#" title="gia">Giá:280.000đ</a>
        </div>--%>
    </div>
</div>

<%--Cac script xu ly gio hang--%>
<script type="text/javascript">
    function ThemVaoGioHang() {
        var id = "<%=id%>";
        var soluong = $("#quatity").val();

        //Code thêm sản phẩm vào giỏ hàng bằng jquery ajax post
            $.post("Cms/Display/SanPham/Ajax/AjaxGioHang.aspx",
                {
                    "thaotac": "ThemVaoGioHang",
                    "id": id,
                    "soluong": soluong
                },
                function (data, status) {
                    //alert("Data: " + data + "\nStatus: " + status);
                    if (data == "") { //thực hiện thêm thành công 
                        alert("Đã thêm vào giỏ hàng thành công");
                    }
                    else {
                        alert(data);
                    }
                });
    }

    function MuaNgay() {
         var id = "<%=id%>";
        var soluong = $("#quatity").val();

        //Code thêm sản phẩm vào giỏ hàng bằng jquery ajax post
            $.post("Cms/Display/SanPham/Ajax/AjaxGioHang.aspx",
                {
                    "thaotac": "ThemVaoGioHang",
                    "id": id,
                    "soluong": soluong
                },
                function (data, status) {
                    //alert("Data: " + data + "\nStatus: " + status);
                    if (data == "") { //thực hiện thêm thành công 
                        alert("Đã thêm vào giỏ hàng thành công");
                        //Đẩy về trang giỏ hàng
                        location.href = "/Default.aspx?modul=sanpham&modulphu=giohang";
                    }
                    else {
                        alert(data);
                    }
                });
    }
</script>