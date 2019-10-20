<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default"%>

<%@ Register Src="~/Cms/Display/DisplayLoadControl.ascx" TagPrefix="uc1" TagName="DisplayLoadControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hàng nội địa Thái Lan</title>
    <link href="Css/index.css" rel="stylesheet" />
    <script src="js/jquery-3.4.0.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <!--đầu trang-->
        <div id="dautrang">
                <div id="logoWeb">
                    <div class="logo">
                        <asp:Literal ID="LtrLogo" runat="server"></asp:Literal>
                    </div>
                    <div class="banner">
                        <asp:Literal ID="LtrBanner" runat="server"></asp:Literal>
                    </div>
                </div>
        </div>
        
        <!--menu đầu trang-->

        <div id="menudautrang">
            <div class ="contener">
                <div id="menutrai">
                    <ul class="menungang">
                        <asp:Literal ID="Ltrmenungang" runat="server"></asp:Literal>
                        
                    </ul>
                </div>
                <div id="dangnhap">
                    <asp:PlaceHolder ID="PlChuaDangNhap" runat="server">
                        <ul>
                            <li class="dangnhap1"><a href="/Default.aspx?modul=thanhvien&modulphu=dangky">Đăng ký</a></li>
                            <li class="dangnhap2"><a href="/Default.aspx?modul=thanhvien&modulphu=dangnhap">Đăng nhập</a></li>
                        </ul>
                    </asp:PlaceHolder>
                    <asp:PlaceHolder ID="PlDaDangNhap" runat="server" Visible="False">
                        <ul>
                            <li class="dangnhap1"><asp:Literal ID="LtrTenKH" runat="server"></asp:Literal></li>
                             <li class="dangnhap2"><asp:LinkButton ID="LbtnDangXuat" runat="server" Text="Đăng xuất" CausesValidation="false" OnClick="LbtnDangXuat_Click"></asp:LinkButton></li>
                        </ul>
                    </asp:PlaceHolder>                   
                </div>
            </div>
        </div>

        <!--thanh tìm kiếm + giỏ hàng-->
        <div id="thanhtimkiem">
            <div class="contener">
                <div id="timkiem">
                    <div class="timkiemtrai">
                        <div class="timkiemanh"></div>
                    </div>
                    <div class="timkiemphai">
                        <div class="otimkiem">
                            <div class="search">
                                <div id="searchForm">
                                    <input type="text" class="key" placeholder="Từ khóa tìm kiếm" value="" name="pr_name" id="keysearch"/>
                                    <input type="submit" value="Tìm kiếm" class="submit" />
                                </div>
                            </div>
                        </div>
                        <div class="giohang">
                            <div id="cart">
                                <a href="/Default.aspx?modul=sanpham&modulphu=giohang"><img src="Pictures/AnhQuangCao/logogiohang.jpg" /></a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        
        <br /><br /><br />
        <!--Thân trang-->
        <div id="thantrang">
            <div class="contener">
                <div id="trangtrai">
                    <div class="daumuc">DANH MỤC SẢN PHẨM</div>
                    <div class="thanmuc">
                        <ul>
                            <asp:Literal ID="Ltrdanhmucsanpham" runat="server"></asp:Literal>
                        </ul>
                    </div>
                    <div id="hotro">
                        <div id="pichotro">
                            <div class="logohotro">
                                <!--the img truyền ảnh vào-->
                            </div>
                            <h3>HỖ TRỢ TRỰC TUYẾN</h3>
                        </div>
                        <div class="support">
                            <div class="text-center">
                                <p>
                                    <span class="supp-name">Trà Mi</span>
                                    <br />
                                    <span class="phone">Sđt:0936.672.789</span>
                                </p>
                            </div>
                            <div class="text-center">
                                <p>
                                    <span class="supp-name">PanPage</span>
                                    <br />
                                    <a href="https://www.facebook.com/HangNoidDiaThaiLanMile" class="FanPage">Mua hàng nội địa</a>
                                </p>
                            </div>
                            <div class="text-center">
                                <p>
                                    <span class="supp-name">Facebook</span>
                                    <br />
                                    <a href="https://www.facebook.com/miledo93" class="Facebook">Mile Do</a>
                                </p>
                            </div>
                        </div>
                        <div id="thanhtoan">
                            <div class="title-thanhtoan">
                                <a>THÔNG TIN GIAO DỊCH</a>
                            </div>
                            <div class="nganhang">
                                <p>
                                    <a><strong>Ngân hàng Vietcombank</strong></a>
                                    <br />
                                    <a>Chủ TK: DAO PHUONG LE</a>
                                    <br />
                                    <a>Số TK: 0961000022555</a>
                                    <br />
                                    <a>Chi nhánh Đông Anh - Hà Nội</a>
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            
                <div id="trangphai">
                    <uc1:DisplayLoadControl runat="server" ID="DisplayLoadControl1" />
                </div>
            
            </div>
        </div>
        
        <!--chân trang-->
        <div id="footer">
            <div class="contener">
                <div class="menufooter">
                    <p>2019 Copyright by HangThai.vn</p>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
