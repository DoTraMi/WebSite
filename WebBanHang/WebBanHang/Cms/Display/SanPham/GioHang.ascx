<%@ Control Language="C#" AutoEventWireup="true" CodeFile="GioHang.ascx.cs" Inherits="Cms_Display_SanPham_GioHang" %>
<link href="../../../Css/GioHang.css" rel="stylesheet" />

<div class="model-content">
    <div class="model-head">
        <h4 class="model-title" id="exampleModelLabel">Bạn có <span class="TongSP"></span> sản phẩm trong giỏ hàng</h4>
        <asp:Button ID="BtnClose" runat="server" CssClass="btnClose" Text="Close" data-dismiss="model"/>
    </div>

    <div class="cartForm" style="display:block">
        <div class="model-body" id="BangThongTinGioHang">
            <%--Khu vực chứa dữ liệu giỏ hàng lấy qua ajax--%>
            <%--<table style="width:100%" id="cart-table">
                <tbody>
                    <tr>
                        <th class="item-image">Ảnh</th>
                        <th class="item-title">Tên sản phẩm</th>
                        <th class="item-quatity">Số lượng</th>
                        <th class="item-price">Giá tiền 1 sản phẩm</th>
                        <th class="delete-item"></th>
                    </tr>
                    <tr class="line-item">
                        <td class="item-image">
                            <img src="../../../Pictures/SanPham/Ao_Fila.jpg" /></td>
                        <td class="item-title"><a href="#">Áo Fila</a></td>
                        <td class="item-quatity"><TextBox runat="server" id="quatity" type="number" value="1"></TextBox></td>
                        <td class="item-price">180.000</td>
                        <td class="delete-item"><a href="#">Xóa</a></td>
                    </tr>
                </tbody>
            </table>--%>
         </div>

            <div class="model-footer">
                <div class="titlethongbao">Quý khách vui lòng điền đầy đủ thông tin trước khi ấn nút đặt hàng:<br /></div>
                <div class="titlehuongdan">Lưu ý:Nếu quý khách chưa có tài khoản trên trang web thì hệ thống sẽ kiểm tra và tạo cho quý khách một tài khoản
                    thành viên với tên đăng nhập và mật khẩu chính là Email quý khách điền bên dưới. Quý khách có thể sử dụng tài 
                    khoản đó để đăng nhập cho lần mua sau!</div>
                <div class="row">
                    <div class="col-lg">
                        <div class="model-title-note">
                            Ghi chú đơn đặt hàng:
                        </div>
                    </div>
                    <div class="col-lg">
                        <div class="model-note">
                            <textarea id="TaGhiChu" placeholder="Viết ghi chú về sản phẩm(size,màu,...)" data-="note" name="note" rows="5" cols="61"></textarea>
                        </div>
                    </div>
                </div>
                
                <div class="row">
                    <div class="col-lg">
                        <div class="model-title-note">
                            Họ tên (*)
                        </div>
                    </div>
                    <div class="col-lg">
                        <div class="model-note">
                            <input id="TbTenKH" type="text" value="<%=hoTen %>"/>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg">
                        <div class="model-title-note">
                            Email
                        </div>
                    </div>
                    <div class="col-lg">
                        <div class="model-note">
                            <input id="TbEmail" type="text" value="<%=email %>"/>                      
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg">
                        <div class="model-title-note">
                            Sđt (*)
                        </div>
                    </div>
                    <div class="col-lg">
                        <div class="model-note">
                            <input id="TbSdt" type="text" value="<%=sdt %>"/>
                        </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg">
                        <div class="model-title-note">
                            Địa chỉ
                        </div>
                    </div>
                    <div class="col-lg">
                        <div class="model-note">
                            <input id="TbDiaChi" type="text" value="<%=diaChi %>"/>
                        </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                   <div class="total-price-model">
                         Tổng cộng: <span class="total">0</span>.000đ
                   </div>
                </div>
                <div class="row">
                    <div class="col-lg-left">
                        <div class="comeback">
                            <a href="/Default.aspx?modul=sanpham">< Tiếp tục mua hàng</a>
                        </div>
                    </div>
                    <div class="col-lg-right">
                        <div class="btn-model-cart">
                            <a href="javascript://" onclick="GuiDonHang()" Class="btndefault">Đặt hàng ></a>
                        </div>
                    </div>
                </div>
            </div> 
        
    </div>
</div>

<script type="text/javascript">
    <%--Viết Ajax lấy thông tin giỏ hàng từ session--%>
    function LayThongTinGioHang() {
            $.post("Cms/Display/SanPham/Ajax/AjaxGioHang.aspx",
                {
                    "thaotac": "LayThongTinGioHang",
                },
                function (data, status) {
                    //alert("Data: " + data + "\nStatus: " + status);
                    $("#BangThongTinGioHang").html(data);
                });
    }

    function LayTongSoSPTrongGioHang() {
            $.post("Cms/Display/SanPham/Ajax/AjaxGioHang.aspx",
                {
                    "thaotac": "LayTongSoSPTrongGioHang",
                },
                function (data, status) {
                    //alert("Data: " + data + "\nStatus: " + status);
                    $(".TongSP").html(data);
                });
    }

    function LayTongTien() {
            $.post("Cms/Display/SanPham/Ajax/AjaxGioHang.aspx",
                {
                    "thaotac": "LayTongTien",
                },
                function (data, status) {
                    //alert("Data: " + data + "\nStatus: " + status);
                    $(".total").html(data);
                });
    }

    //Goi ham lan dau de khi load trang se lay thong tin
    $(document)
        .ready(function() {
            LayThongTinGioHang();
            LayTongSoSPTrongGioHang();
            LayTongTien();
        });


    function XoaSPGioHang(MaSP) {
        //Xác nhận người dùng có muốn xóa k
        if (confirm("Bạn muốn xóa sản phẩm này khỏi giỏ hàng")) {
             $.post("Cms/Display/SanPham/Ajax/AjaxGioHang.aspx",
                {
                    "thaotac": "XoaSPGioHang",
                    "MaSP": MaSP
                },
                function (data, status) {
                    //Nếu không có lỗi thì ẩn dòng sản phẩm trong giỏ hàng
                    //Sau đó gọi hàng cập nhật số lượng và tổng tiền
                    if (data === "") {
                        $("#tr_" + MaSP).remove();

                        LayTongSoSPTrongGioHang();
                        LayTongTien();
                    }
                });
        }           
    }

    function CapNhatSoLuong(MaSP) {
        //Cập nhật số lượng mới
        var soLuongMoi = $("#quatity_" + MaSP).val();
        $.post("Cms/Display/SanPham/Ajax/AjaxGioHang.aspx",
            {
                "thaotac": "CapNhatSoLuong",
                "MaSP": MaSP,
                "soLuongMoi": soLuongMoi
            },
            function (data, status) {
                //Nếu không có lỗi thì ẩn dòng sản phẩm trong giỏ hàng
                //Sau đó gọi hàng cập nhật số lượng và tổng tiền
                if (data === "") {
                    LayTongSoSPTrongGioHang();
                    LayTongTien();
                }
            });        
    }

    function GuiDonHang() {
        //Ktra xem khách hàng điền đầy đủ thông tin chưa
        if ($("#TbTenKH").val() !== "" && $("#TbSdt").val() !== "") {
            $.post("cms/display/sanpham/ajax/ajaxgiohang.aspx",
                {
                    "thaotac": "GuiDonHang",
                    "HoTen": $("#TbTenKH").val(),
                    "Email": $("#TbEmail").val(),
                    "Sdt": $("#TbSdt").val(),
                    "DiaChi": $("#TbDiaChi").val(),
                    "GhiChu": $("#TaGhiChu").val()
                },
                function (data, status) {
                    //nếu thành công thông báo đặt hàng thành công -> trả về trang chủ
                    if (data === "") {
                        alert("Bạn đã đặt hàng thành công");
                        location.href = "/";
                    }
                });      
        }
        else {
            alert("Vui lòng nhập đầy đủ họ tên và số điện thoại để đặt hàng");
        }
          
    }

</script>