<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ThemMoiTaiKhoan.ascx.cs" Inherits="Cms_Admin_TaiKhoan_QLyTaiKhoan_ThemMoiTaiKhoan" %>
<div class="head">Thêm mới, chỉnh sửa thông tin sản phẩm</div>
<div class="FormThemMoi"> 
    <div class="thongTin">
        <div class="tenTruong">Tên đăng nhập</div>
        <div class="cNhap">
            <asp:TextBox ID="tbTenDangNhap" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" 
                ControlToValidate="tbTenDangNhap" Display="Dynamic" SetFocusOnError="true" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Mật khẩu</div>
        <div class="cNhap">
            <asp:HiddenField ID="HfMatKhauCu" runat="server" />
            <asp:TextBox ID="tbMatKhau" runat="server" TextMode="Password" Width="30%"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" 
                ControlToValidate="tbMatKhau" Display="Dynamic" SetFocusOnError="true" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Email</div>
        <div class="cNhap">
            <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Địa chỉ</div>
        <div class="cNhap">
            <asp:TextBox ID="tbDiaChi" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Họ Tên</div>
        <div class="cNhap">
            <asp:TextBox ID="tbTenDayDu" runat="server"></asp:TextBox>
       </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Câu hỏi bảo mật</div>
        <div class="cNhap">
            <asp:DropDownList ID="DdlCauHoi" runat="server"></asp:DropDownList>  
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">câu trả lời</div>
        <div class="cNhap">
            <asp:TextBox ID="tbCauTraLoi" runat="server"></asp:TextBox> 
        </div>    
    </div>
    <div class="thongTin">
        <div class="tenTruong">Ngày sinh (yyyy/mm/dd)</div>
        <div class="cNhap">
            <asp:TextBox ID="tbNgaySinh" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Giới tính</div>
        <div class="cNhap">
            <asp:TextBox ID="tbGioiTinh" runat="server"></asp:TextBox>
       </div>
    </div> 
    <div class="thongTin">
        <div class="tenTruong">Quyền đăng nhập</div>
        <div class="cNhap">
            <asp:DropDownList ID="DdlQuyenDN" runat="server"></asp:DropDownList>          
        </div>
     </div> 
    <div class="thongTin">   
        <div class="tenTruong">&nbsp</div>
        <div class="cNhap"><asp:CheckBox ID="cbThemNhieuTK" runat="server" Text="Tiếp tục thêm tài khoản khác sau khi thêm tài khoản này"/></div>       
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