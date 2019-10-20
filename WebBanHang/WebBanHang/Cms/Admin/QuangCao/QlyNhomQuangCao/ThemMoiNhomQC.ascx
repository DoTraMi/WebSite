<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ThemMoiNhomQC.ascx.cs" Inherits="Cms_Admin_QuangCao_QlyNhomQuangCao_ThemMoiNhomQC" %>
<div class="head">Thêm mới, chỉnh sửa thông tin nhóm quảng cáo</div>
<div class="FormThemMoi">
    <div class="thongTin">
        <div class="tenTruong">Tên nhóm</div>
        <div class="cNhap">
            <asp:TextBox ID="TbTenNhom" runat="server"></asp:TextBox>       
        </div>
     </div>
    <div class="thongTin">
        <div class="tenTruong">Vị trí</div>
        <div class="cNhap">
            <asp:TextBox ID="TbVitri" runat="server"></asp:TextBox>      
        </div>
     </div>
    <div class="thongTin">   
        <div class="tenTruong">&nbsp</div>
        <div class="cNhap"><asp:CheckBox ID="cbThemNhieuNhom" runat="server" Text="Tiếp tục thêm nhóm quảng cáo khác sau khi thêm nhóm này"/></div>       
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