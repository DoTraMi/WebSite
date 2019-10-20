<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ThemMoiAnhQC.ascx.cs" Inherits="Cms_Admin_QuangCao_QlyAnhQuangCao_ThemMoiAnhQC" %>
<div class="head">Thêm mới, chỉnh sửa thông tin sản phẩm</div>
<div class="FormThemMoi">
    <div class="thongTin">
        <div class="tenTruong">Nhóm quảng cáo</div>
        <div class="cNhap">
            <asp:DropDownList ID="DdlNhomQC" runat="server"></asp:DropDownList>          
        </div>
     </div>
    <div class="thongTin">
        <div class="tenTruong">Tên quảng cáo</div>
        <div class="cNhap">
            <asp:TextBox ID="TbTenQuangCao" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Thứ tự</div>
        <div class="cNhap">
            <asp:TextBox ID="tbThuTu" runat="server" TextMode="MultiLine" Width="30%" Height="100px"></asp:TextBox>         
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Liên kết</div>
        <div class="cNhap">
            <asp:TextBox ID="tbLienKet" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="thongTin">   
        <div class="tenTruong">Ảnh quảng cáo</div>
        <div class="cNhap">
            <div>
                <asp:HiddenField ID="HfTenAnhQCcu" runat="server" />
                <asp:Literal ID="LtrAnhQC" runat="server"></asp:Literal>
            </div>
            <asp:FileUpload ID="FulAnhQC" runat="server" />
        </div>
    </div>
    <div class="thongTin">   
        <div class="tenTruong">&nbsp</div>
        <div class="cNhap"><asp:CheckBox ID="cbThemNhieuAnh" runat="server" Text="Tiếp tục thêm ảnh khác sau khi thêm ảnh này"/></div>       
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
