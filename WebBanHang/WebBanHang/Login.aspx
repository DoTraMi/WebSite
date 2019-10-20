<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang đăng nhập</title>
    <link href="Cms/Admin/css/cssLogin.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="FormDangNhapHeThong">
            <div class="head">Đăng nhập Website</div>
            <div class="Controls">
                <div class="row">
                <div class="left">Tên đăng nhập</div>
                <div class="right">
                    <asp:TextBox ID="TbTenDangNhap" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" 
                        SetPocusOnError ="True" Display="Dynamic" ControlToValidate="TbTenDangNhap" ForeColor="Red"> </asp:RequiredFieldValidator>
                </div>
                </div>
                <div class="row">
                    <div class="left">Mật khẩu</div>
                    <div class="right">
                        <asp:TextBox ID="TbMatKhau" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" 
                            SetPocusOnError ="True" Display="Dynamic" ControlToValidate="TbMatKhau" ForeColor="Red"> </asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="row">
                    <div class="left">&nbsp;</div>
                    <div class="right">
                        <asp:Button ID="BtnDangNhap" runat="server" Text="Đăng Nhập" CssClass="BtnDangNhap" OnClick="BtnDangNhap_Click"/>
                    </div>
                </div>
                <div>
                    <asp:Literal ID="LtrThongBao" runat="server"></asp:Literal>
                </div>
            </div>           
        </div>
    </form>
</body>
</html>
