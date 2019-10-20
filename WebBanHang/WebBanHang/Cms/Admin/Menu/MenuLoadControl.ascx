<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MenuLoadControl.ascx.cs" Inherits="Cms_Admin_Menu_MenuLoadControl" %>
<div class="container">
    <div style="clear:both;height:20px"></div>
    
    <div class="cotTrai">
            <div class="head">Quản lý</div>
            <ul>
                <li><a class="<%=DanhDau("menu","dsmenu") %>" href="/Admin.aspx?modul=menu&modulmenu=dsmenu">Menu</a></li>               
            </ul>
            <div class="head">Thêm mới</div>
            <ul>
                 <li><a class="<%=DanhDau("menu","Themmoi") %>" href="/Admin.aspx?modul=menu&modulmenu=Themmoi">Menu</a></li>
            </ul>    
    </div>
    
    <div class="cotPhai">
        <div class ="MenuThaoTac">
            <ul>
                <li><a class="Add" href="/Admin.aspx?modul=menu&modulmenu=Themmoi">Thêm mới</a></li>    
            </ul>
        </div>
        <asp:PlaceHolder ID="PlQLyMenu" runat="server"></asp:PlaceHolder> 
    </div>
    <div class="cb"><!-----></div>
</div>