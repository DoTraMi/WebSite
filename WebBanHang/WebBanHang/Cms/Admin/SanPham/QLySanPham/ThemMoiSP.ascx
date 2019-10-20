<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ThemMoiSP.ascx.cs" Inherits="Cms_Admin_SanPham_QLyTenSP_ThemMoiTenSP" %>
<div class="head">Thêm mới, chỉnh sửa thông tin sản phẩm</div>
<div class="FormThemMoi">
    <div class="thongTin">
        <div class="tenTruong">Danh Mục Sản Phẩm</div>
        <div class="cNhap">
            <asp:DropDownList ID="DdlDanhMucSP" runat="server"></asp:DropDownList>          
        </div>
     </div>
    <div class="thongTin">
        <div class="tenTruong">Nhóm Sản Phẩm</div>
        <div class="cNhap">
            <asp:DropDownList ID="DdlNhomSP" runat="server"></asp:DropDownList>          
        </div>
     </div>
    <div class="thongTin">
        <div class="tenTruong">Tên Sản Phẩm</div>
        <div class="cNhap">
            <asp:TextBox ID="TbTenSP" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Đặc điểm Sản Phẩm</div>
        <div class="cNhap">
            <asp:TextBox ID="tbDacDiemSP" runat="server" TextMode="MultiLine" Width="30%" Height="100px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" 
                ControlToValidate="tbDacDiemSP" Display="Dynamic" SetFocusOnError="true" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Giá Sản Phẩm</div>
        <div class="cNhap">
            <asp:TextBox ID="tbGiaSP" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Nhập số"
                ControlToValidate="tbGiaSP" Display="Dynamic" SetFocusOnError="true" ValidationExpression="(\d)*" ForeColor="Red" >
            </asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="thongTin">   
        <div class="tenTruong">Ảnh Sản Phẩm</div>
        <div class="cNhap">
            <div>
                <asp:HiddenField ID="HfTenAnhSPcu" runat="server" />
                <asp:Literal ID="LtrAnhSP" runat="server"></asp:Literal>
            </div>
            <asp:FileUpload ID="FulAnhSP" runat="server" />
        </div>
    </div>
    <div class="thongTin">   
        <div class="tenTruong">&nbsp</div>
        <div class="cNhap"><asp:CheckBox ID="cbThemNhieuSP" runat="server" Text="Tiếp tục thêm sản phẩm khác sau khi thêm sản phẩm này"/></div>       
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
