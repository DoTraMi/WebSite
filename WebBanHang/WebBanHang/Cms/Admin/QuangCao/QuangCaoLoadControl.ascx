<%@ Control Language="C#" AutoEventWireup="true" CodeFile="QuangCaoLoadControl.ascx.cs" Inherits="Cms_Admin_QuangCao_QuangCaoLoadControl" %>
<div class="container">
    <div style="clear:both;height:20px"></div>
    
    <div class="cotTrai">
            <div class="head">Quản lý</div>
            <ul>
                <li><a class="<%=DanhDau("quangcao","nhomquangcao","") %>" href="/Admin.aspx?modul=quangcao&modulphu=nhomquangcao">Nhóm quảng cáo</a></li>
                <li><a class="<%=DanhDau("quangcao","anhquangcao","") %>" href="/Admin.aspx?modul=quangcao&modulphu=anhquangcao">Ảnh quảng cáo</a></li>             
            </ul>
            <div class="head">Thêm mới</div>
            <ul>
                 <li><a class="<%=DanhDau("quangcao","nhomquangcao","Themmoi") %>" href="/Admin.aspx?modul=quangcao&modulphu=nhomquangcao&thaotac=Themmoi">Nhóm quảng cáo</a></li>
                 <li><a class="<%=DanhDau("quangcao","anhquangcao","Themmoi") %>" href="/Admin.aspx?modul=quangcao&modulphu=anhquangcao&thaotac=Themmoi">Ảnh quảng cáo</a></li>                
            </ul>
    </div>
    
    <div class="cotPhai">
        <div class="container">
            <asp:PlaceHolder ID="plQuangCaoLoadControl" runat="server"></asp:PlaceHolder>
        </div>
    </div>
    <div class="cb"><!-----></div>
</div>