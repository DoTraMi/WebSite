<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<%@ Register Src="~/Cms/Admin/AdminLoadControl.ascx" TagPrefix="uc1" TagName="AdminLoadControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TRANG QUẢN TRỊ WEBSITE</title>
    <link href="Cms/Admin/css/cssAdmin.css" rel="stylesheet" />
    <script src="Cms/Admin/js/jquery-3.4.0.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">

    <%--Header--%>
    <div id="header">
        <div class="container">
           <div class="logo">
               <a href="/Admin.aspx"><img src="Pictures/AnhBia/logo.jpg" /></a>
           </div>
           <div class="accountMenu">
                Xin chào: <asp:Literal ID="LtrTenDangNhap" runat="server"></asp:Literal> | <asp:LinkButton ID="LbtnDangXuat" runat="server" OnClick="LbtnDangXuat_Click">Đăng xuất</asp:LinkButton>
           </div>
        </div>
    </div>
    <%--Menu chinh--%>
        <div class ="MenuChinh">
            <div class="container">
                <ul>
                    <li><a class="<%=DanhDau("sanpham") %>" href="Admin.aspx?modul=sanpham" title="Sản phẩm">Sản phẩm</a></li>
                    <li><a class="<%=DanhDau("menu") %>" href="Admin.aspx?modul=menu" title="Menu">Menu</a></li>
                    <li><a class="<%=DanhDau("quangcao") %>" href="Admin.aspx?modul=quangcao" title="Quảng cáo">Quảng cáo</a></li>
                    <li><a class="<%=DanhDau("khachhang") %>" href="Admin.aspx?modul=khachhang" title="Khách hàng">Khách hàng</a></li>
                    <li><a class="<%=DanhDau("donhang") %>" href="Admin.aspx?modul=donhang" title="Đơn hàng">Đơn hàng</a></li>
                    <li><a class="<%=DanhDau("taikhoan") %>" href="Admin.aspx?modul=taikhoan" title="Tài khoản">Tài khoản</a></li>
                </ul>
            </div>
        </div>
    <%--Phần nội dung trang --%>
        <uc1:AdminLoadControl runat="server" ID="AdminLoadControl" />

    </form>
</body>
</html>
