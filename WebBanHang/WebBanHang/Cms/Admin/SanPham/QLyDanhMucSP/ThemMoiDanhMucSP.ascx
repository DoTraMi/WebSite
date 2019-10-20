<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ThemMoiDanhMucSP.ascx.cs" Inherits="Cms_Admin_SanPham_QLyDanhMucSP_ThemMoiDanhMucSP" %>
<div class="head">Thêm mới, chỉnh sửa thông tin danh mục sản phẩm</div>
<div class="FormThemMoi">
    <div class="thongTin">
        <div class="tenTruong">Tên danh mục</div>
        <div class="cNhap">
            <asp:TextBox ID="TbTenDanhMuc" runat="server"></asp:TextBox>       
        </div>
     </div>
    <div class="thongTin">
        <div class="tenTruong">Mã danh mục cha</div>
        <div class="cNhap">
            <asp:DropDownList ID="DdlMaDanhMucCha" runat="server"></asp:DropDownList>       
        </div>
     </div>
    <div class="thongTin">
        <div class="tenTruong">Số sản phẩm hiển thị</div>
        <div class="cNhap">
            <asp:TextBox ID="TbSoSanPhamHienThi" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="thongTin">   
        <div class="tenTruong">&nbsp</div>
        <div class="cNhap"><asp:CheckBox ID="cbThemNhieuDanhMuc" runat="server" Text="Tiếp tục thêm danh mục sản phẩm khác sau khi thêm danh mục này"/></div>       
    </div>
    <div class="thongTin">   
        <div class="tenTruong">&nbsp</div>
        <div class="cNhap">
            <asp:Button ID="BtnThemMoi" runat="server" Text="Thêm mới" CssClass="btnThemMoi" OnClick="BtnThemMoi_Click"/>
            <asp:Button ID="BtnHuy" runat="server" Text="Hủy" CssClass="btnHuy" OnClick="BtnHuy_Click" CausesValidation="False"/>
        </div>
    </div>
    <asp:Literal ID="LtrThongBao" runat="server"></asp:Literal>
</div>
