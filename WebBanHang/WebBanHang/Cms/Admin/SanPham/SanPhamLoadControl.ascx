<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SanPhamLoadControl.ascx.cs" Inherits="Cms_Admin_SanPham_SanPhamLoadControl" %>

<div class="container">
    <div style="clear:both;height:20px"></div>
    
    <div class="cotTrai">
            <div class="head">Quản lý</div>
            <ul>
                <li><a class="<%=DanhDau("sanpham","DanhMucSP","") %>" href="/Admin.aspx?modul=sanpham&modulsp=DanhMucSP">Danh mục sản phẩm</a></li>
                <li><a class="<%=DanhDau("sanpham","NhomSP","") %>" href="/Admin.aspx?modul=sanpham&modulsp=NhomSP">Nhóm sản phẩm</a></li>
                <li><a class="<%=DanhDau("sanpham","DacDiemSP","") %>" href="/Admin.aspx?modul=sanpham&modulsp=DacDiemSP">Sản phẩm</a></li>
            </ul>
            <div class="head">Thêm mới</div>
            <ul>
                 <li><a class="<%=DanhDau("sanpham","DanhMucSP","Themmoi") %>" href="/Admin.aspx?modul=sanpham&modulsp=DanhMucSP&thaotac=Themmoi">Danh mục sản phẩm</a></li>
                 <li><a class="<%=DanhDau("sanpham","NhomSP","Themmoi") %>" href="/Admin.aspx?modul=sanpham&modulsp=NhomSP&thaotac=Themmoi">Nhóm sản phẩm</a></li>
                 <li><a class="<%=DanhDau("sanpham","DacDiemSP","Themmoi") %>" href="/Admin.aspx?modul=sanpham&modulsp=DacDiemSP&thaotac=Themmoi">Sản phẩm</a></li>
            </ul>
    </div>
    
    <div class="cotPhai">
        <div class="container">
            <asp:PlaceHolder ID="plSanPhamLoadControl" runat="server"></asp:PlaceHolder>
        </div>
    </div>
    <div class="cb"><!-----></div>
</div>