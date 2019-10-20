<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DangKyThanhVien.ascx.cs" Inherits="Cms_Display_ThanhVien_ChiTietThanhVien" %>
<link href="../../../Css/DangKy.css" rel="stylesheet" />

<div class="head">TẠO TÀI KHOẢN MỚI</div>
<div class="FormThemMoi">
    <div class="ghichu">Cần nhập tất cả thông tin có dấu (*)</div>
    <div class="thongTin">
        <div class="tenTruong">Họ Tên*</div>
        <div class="cNhap">
            <asp:TextBox ID="tbTenDangNhap" runat="server" placeHolder="Nhập họ và tên"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" 
                ControlToValidate="tbTenDangNhap" Display="Dynamic" SetFocusOnError="true" ForeColor="Red"></asp:RequiredFieldValidator>
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
        <div class="tenTruong">Nhập lại mật khẩu*</div>
        <div class="cNhap">
            <asp:TextBox ID="tbNhapLaiMatKhau" runat="server" TextMode="Password"  placeHolder="Nhập lại mật khẩu"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" 
                ControlToValidate="tbNhapLaiMatKhau" Display="Dynamic" SetFocusOnError="true" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Mật khẩu không trùng khớp"
                ControlToValidate="tbNhapLaiMatKhau" SetFocusOnError="true" Display="Dynamic" ControlToCompare="tbMatKhau" ForeColor="Red"></asp:CompareValidator>
       </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Email*</div>
        <div class="cNhap">
            <asp:TextBox ID="tbEmail" runat="server" placeHolder="Nhập địa chỉ Email"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Email sai định dạng"
                ControlToValidate="tbEmail" Display="Dynamic" SetFocusOnError="true" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Facebook</div>
        <div class="cNhap">
            <asp:TextBox ID="tbFacebook" runat="server" placeHolder="Nhập tên Facebook"></asp:TextBox>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Địa chỉ</div>
        <div class="cNhap">
            <asp:TextBox ID="tbDiaChi" runat="server" placeHolder="Nhập địa chỉ"></asp:TextBox>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">SĐT</div>
        <div class="cNhap">
            <asp:TextBox ID="tbsdt" runat="server" placeHolder="Nhập số điện thoại"></asp:TextBox>
       </div>
    </div> 
    <div class="thongTin">   
        <div class="tenTruong">&nbsp</div>
        <div class="cNhap">
            <asp:LinkButton ID="LbtnDangKy" runat="server" CssClass="btnDangKy" OnClick="LbtnDangKy_Click" Text="Đăng ký"></asp:LinkButton>
        </div>
    </div>
</div>
