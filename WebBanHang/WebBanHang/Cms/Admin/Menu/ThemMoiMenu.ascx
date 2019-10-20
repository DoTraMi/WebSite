<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ThemMoiMenu.ascx.cs" Inherits="Cms_Admin_Menu_ThemMoiMenu" %>
<div class="head">Thêm mới, chỉnh sửa thông tin menu</div>
<div class="FormThemMoi">
    <div class="thongTin">
        <div class="tenTruong">Tên menu</div>
        <div class="cNhap">
            <asp:TextBox ID="TbTenMenu" runat="server"></asp:TextBox>       
        </div>
     </div>
    <div class="thongTin">
        <div class="tenTruong">Thứ tự</div>
        <div class="cNhap">
            <asp:TextBox ID="TbThuTu" runat="server"></asp:TextBox>         
        </div>
     </div>
    <div class="thongTin">
        <div class="tenTruong">Mã menu cha</div>
        <div class="cNhap">
            <asp:DropDownList ID="DdlMaMenuCha" runat="server"></asp:DropDownList>       
        </div>
     </div>
    <div class="thongTin">
        <div class="tenTruong">Liên kết</div>
        <div class="cNhap">
            <asp:TextBox ID="TbLienKet" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="thongTin">   
        <div class="tenTruong">&nbsp</div>
        <div class="cNhap"><asp:CheckBox ID="cbThemNhieuMenu" runat="server" Text="Tiếp tục thêm menu khác sau khi thêm menu này"/></div>       
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
