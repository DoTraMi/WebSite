<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DangNhapThanhVien.ascx.cs" Inherits="Cms_Display_ThanhVien_DanhSachThanhVien" %>
<link href="../../../Css/DangNhap.css" rel="stylesheet" />

<div class="head">ĐĂNG NHẬP</div>
<div class="FormDangNhap">
    <div class="thongTin">
        <div class="tenTruong">Email*</div>
        <div class="cNhap">
            <asp:TextBox ID="tbEmail" runat="server" placeHolder="Nhập địa chỉ Email"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Email sai định dạng"
                ControlToValidate="tbEmail" Display="Dynamic" SetFocusOnError="true" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Mật khẩu*</div>
        <div class="cNhap">
            <asp:TextBox ID="tbMatKhau" runat="server" TextMode="Password"  placeHolder="Mật khẩu nên có cả chữ và số"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" 
                ControlToValidate="tbMatKhau" Display="Dynamic" SetFocusOnError="true" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="thongTin">   
        <div class="tenTruong">&nbsp</div>
        <div class="cNhap">
            <asp:LinkButton ID="LbtnDangNhap" runat="server" CssClass="btnDangNhap" Text="Đăng nhập" OnClick="LbtnDangNhap_Click"></asp:LinkButton>
        </div>
    </div>
</div>