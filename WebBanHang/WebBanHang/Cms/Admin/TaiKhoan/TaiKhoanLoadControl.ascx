<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TaiKhoanLoadControl.ascx.cs" Inherits="Cms_Admin_TaiKhoan_TaiKhoanLoadControl" %>
<div class="container">
    <div style="clear:both;height:20px"></div>
    
    <div class="cotTrai">
            <div class="head">Quản lý</div>
            <ul>
                <li><a class="<%=DanhDau("taikhoan","dstaikhoan","") %>" href="/Admin.aspx?modul=taikhoan&modulsp=dstaikhoan">Danh sách tài khoản</a></li>               
            </ul>
            <div class="head">Thêm mới</div>
            <ul>
                 <li><a class="<%=DanhDau("taikhoan","dstaikhoan","Themmoi") %>" href="/Admin.aspx?modul=taikhoan&modulsp=dstaikhoan&thaotac=Themmoi">Danh sách tài khoản</a></li>
            </ul>    
    </div>
    
    <div class="cotPhai">
        <div class="container">
            <asp:PlaceHolder ID="plTaiKhoanLoadControl" runat="server"></asp:PlaceHolder>
        </div>
    </div>
    <div class="cb"><!-----></div>
</div>