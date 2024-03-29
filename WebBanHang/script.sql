USE [master]
GO
/****** Object:  Database [QuanLyHangThai]    Script Date: 10/20/2019 10:51:44 PM ******/
CREATE DATABASE [QuanLyHangThai]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyHangThai', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLyHangThai.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyHangThai_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLyHangThai_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyHangThai] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyHangThai].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyHangThai] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyHangThai] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyHangThai] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyHangThai] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyHangThai] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyHangThai] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyHangThai] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyHangThai] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyHangThai] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyHangThai] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyHangThai] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyHangThai] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyHangThai] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyHangThai] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyHangThai] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyHangThai] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyHangThai] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyHangThai] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyHangThai] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyHangThai] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyHangThai] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyHangThai] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyHangThai] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyHangThai] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyHangThai] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyHangThai] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyHangThai] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyHangThai] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyHangThai] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QuanLyHangThai]
GO
/****** Object:  Table [dbo].[AnhQuangCao]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnhQuangCao](
	[MaAnh] [int] IDENTITY(1,1) NOT NULL,
	[MaNhom] [int] NOT NULL,
	[TenQuangCao] [nvarchar](50) NULL,
	[Anh] [nvarchar](100) NULL,
	[Thutu] [int] NULL,
	[LienKet] [nvarchar](100) NULL,
 CONSTRAINT [PK_AnhQuangCao] PRIMARY KEY CLUSTERED 
(
	[MaAnh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CauHoiBaoMat]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CauHoiBaoMat](
	[MaCauHoiBaoMat] [int] IDENTITY(1,1) NOT NULL,
	[CauHoi] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_CauHoiBaoMat] PRIMARY KEY CLUSTERED 
(
	[MaCauHoiBaoMat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietDonHang]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonHang](
	[MaChiTiet] [int] IDENTITY(1,1) NOT NULL,
	[MaSP] [int] NOT NULL,
	[MaDonDatHang] [int] NOT NULL,
	[SoLuongDat] [int] NULL,
	[DonGiaDat] [float] NULL,
 CONSTRAINT [PK_ChiTietDonHang_1] PRIMARY KEY CLUSTERED 
(
	[MaChiTiet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DangKyTaiKhoan]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangKyTaiKhoan](
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NOT NULL,
	[EmailDK] [nvarchar](50) NULL,
	[DiaChiDK] [nvarchar](100) NULL,
	[TenDayDu] [nvarchar](50) NULL,
	[MaCauHoiBaoMat] [int] NULL,
	[CauTraLoi] [nvarchar](100) NULL,
	[Ngaysinh] [date] NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[MaQuyen] [int] NOT NULL,
 CONSTRAINT [PK_DangKyTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DanhMucSP]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMucSP](
	[MaDanhMucSP] [int] IDENTITY(1,1) NOT NULL,
	[TenDanhMucSP] [nchar](50) NOT NULL,
	[MaDanhMucCha] [int] NULL,
	[SoSPHienThi] [int] NULL,
 CONSTRAINT [PK_DanhMucSP] PRIMARY KEY CLUSTERED 
(
	[MaDanhMucSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonDatHang]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonDatHang](
	[MaDonDatHang] [int] IDENTITY(1,1) NOT NULL,
	[GhiChu] [nvarchar](300) NULL,
	[NgayTao] [datetime] NULL,
	[ThanhTien] [float] NULL,
	[TinhTrangDonHang] [nchar](10) NULL,
	[Id_Khach_Hang] [int] NULL,
	[TenKH] [nvarchar](50) NULL,
	[SdtKH] [nvarchar](15) NULL,
	[EmailKH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](200) NULL,
 CONSTRAINT [PK_DonDatHang] PRIMARY KEY CLUSTERED 
(
	[MaDonDatHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Khach]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khach](
	[Id_Khach_Hang] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
	[Facebook] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
	[Sdt] [nvarchar](15) NULL,
	[DiaChi] [nvarchar](200) NULL,
 CONSTRAINT [PK_Khach] PRIMARY KEY CLUSTERED 
(
	[Id_Khach_Hang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Menu]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[Ma] [int] IDENTITY(1,1) NOT NULL,
	[TenMenu] [nvarchar](50) NOT NULL,
	[ThuTu] [int] NULL,
	[MaMenuCha] [int] NULL,
	[LienKet] [nvarchar](100) NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhomQuangCao]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomQuangCao](
	[MaNhom] [int] IDENTITY(1,1) NOT NULL,
	[TenNhom] [nvarchar](50) NOT NULL,
	[Vitri] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhomQuangCao] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhomSanPham]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomSanPham](
	[MaNhom] [int] IDENTITY(1,1) NOT NULL,
	[TenNhom] [nvarchar](100) NOT NULL,
	[ThuTu] [int] NULL,
	[SoSPHienThi] [int] NULL,
 CONSTRAINT [PK_NhomSanPham] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QuyenDangNhap]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuyenDangNhap](
	[MaQuyen] [int] IDENTITY(1,1) NOT NULL,
	[TenQuyen] [nvarchar](50) NOT NULL,
	[MaQuyenCha] [int] NULL,
 CONSTRAINT [PK_QuyenDangNhap] PRIMARY KEY CLUSTERED 
(
	[MaQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [int] IDENTITY(1,1) NOT NULL,
	[MaDanhMucSP] [int] NOT NULL,
	[DacDiemSP] [nchar](500) NULL,
	[GiaSP] [float] NULL,
	[Anh] [nchar](100) NULL,
	[TenSanPham] [nchar](50) NULL,
	[MaNhom] [int] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[AnhQuangCao] ON 

INSERT [dbo].[AnhQuangCao] ([MaAnh], [MaNhom], [TenQuangCao], [Anh], [Thutu], [LienKet]) VALUES (1, 1, N'Logo Web', N'logo1.jpg', 1, N'/')
INSERT [dbo].[AnhQuangCao] ([MaAnh], [MaNhom], [TenQuangCao], [Anh], [Thutu], [LienKet]) VALUES (2, 2, N'Banner WebSite', N'banner_2.jpg', 1, N'')
INSERT [dbo].[AnhQuangCao] ([MaAnh], [MaNhom], [TenQuangCao], [Anh], [Thutu], [LienKet]) VALUES (3, 3, N'Slide ảnh', N'chan_vay_hoa_tiet.jpg', 1, N'')
SET IDENTITY_INSERT [dbo].[AnhQuangCao] OFF
SET IDENTITY_INSERT [dbo].[CauHoiBaoMat] ON 

INSERT [dbo].[CauHoiBaoMat] ([MaCauHoiBaoMat], [CauHoi]) VALUES (1, N'Bạn thích chơi môn thể thao nào?')
INSERT [dbo].[CauHoiBaoMat] ([MaCauHoiBaoMat], [CauHoi]) VALUES (2, N'Bạn thích món ăn nào?')
INSERT [dbo].[CauHoiBaoMat] ([MaCauHoiBaoMat], [CauHoi]) VALUES (3, N'Tên người bạn thân của bạn?')
INSERT [dbo].[CauHoiBaoMat] ([MaCauHoiBaoMat], [CauHoi]) VALUES (4, N'Bạn thích đi du lịch ở đâu?')
SET IDENTITY_INSERT [dbo].[CauHoiBaoMat] OFF
SET IDENTITY_INSERT [dbo].[ChiTietDonHang] ON 

INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaSP], [MaDonDatHang], [SoLuongDat], [DonGiaDat]) VALUES (1, 2, 1, 2, 250)
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaSP], [MaDonDatHang], [SoLuongDat], [DonGiaDat]) VALUES (2, 5, 1, 2, 280)
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaSP], [MaDonDatHang], [SoLuongDat], [DonGiaDat]) VALUES (3, 7, 2, 2, 180)
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaSP], [MaDonDatHang], [SoLuongDat], [DonGiaDat]) VALUES (4, 1, 3, 2, 200)
SET IDENTITY_INSERT [dbo].[ChiTietDonHang] OFF
INSERT [dbo].[DangKyTaiKhoan] ([TenDangNhap], [MatKhau], [EmailDK], [DiaChiDK], [TenDayDu], [MaCauHoiBaoMat], [CauTraLoi], [Ngaysinh], [GioiTinh], [MaQuyen]) VALUES (N'admin', N'21232f297a57a5a743894a0e4a801fc3', N'admin@gmail.com', N'Hà Nội', N'Quản trị viên', 3, N'admin', CAST(N'1993-02-28' AS Date), N'Nữ', 1)
INSERT [dbo].[DangKyTaiKhoan] ([TenDangNhap], [MatKhau], [EmailDK], [DiaChiDK], [TenDayDu], [MaCauHoiBaoMat], [CauTraLoi], [Ngaysinh], [GioiTinh], [MaQuyen]) VALUES (N'DoTraMi', N'a3d284aa709ea983a15092ea039aa5c0', N'dotrami7893@gmail.com', N'Hà Nội', N'Đỗ Thị Trà Mi', 4, N'Biển', CAST(N'1993-08-07' AS Date), N'Nữ', 4)
INSERT [dbo].[DangKyTaiKhoan] ([TenDangNhap], [MatKhau], [EmailDK], [DiaChiDK], [TenDayDu], [MaCauHoiBaoMat], [CauTraLoi], [Ngaysinh], [GioiTinh], [MaQuyen]) VALUES (N'TuanCK', N'696307ace66505ca01c7e031df6e87aa', N'tuanck@gmail.com', N'Hà Nội', N'Đinh Thanh Tuấn', 1, N'Cầu lông', CAST(N'1991-01-17' AS Date), N'Nam', 2)
SET IDENTITY_INSERT [dbo].[DanhMucSP] ON 

INSERT [dbo].[DanhMucSP] ([MaDanhMucSP], [TenDanhMucSP], [MaDanhMucCha], [SoSPHienThi]) VALUES (1, N'Quần Áo                                           ', 0, 4)
INSERT [dbo].[DanhMucSP] ([MaDanhMucSP], [TenDanhMucSP], [MaDanhMucCha], [SoSPHienThi]) VALUES (2, N'Mỹ Phẩm                                           ', 0, 4)
INSERT [dbo].[DanhMucSP] ([MaDanhMucSP], [TenDanhMucSP], [MaDanhMucCha], [SoSPHienThi]) VALUES (3, N'Giầy Dép                                          ', 0, 4)
INSERT [dbo].[DanhMucSP] ([MaDanhMucSP], [TenDanhMucSP], [MaDanhMucCha], [SoSPHienThi]) VALUES (4, N'Đồ Ăn                                             ', 0, 4)
INSERT [dbo].[DanhMucSP] ([MaDanhMucSP], [TenDanhMucSP], [MaDanhMucCha], [SoSPHienThi]) VALUES (5, N'Đồ dùng gia đình                                  ', 0, 4)
SET IDENTITY_INSERT [dbo].[DanhMucSP] OFF
SET IDENTITY_INSERT [dbo].[DonDatHang] ON 

INSERT [dbo].[DonDatHang] ([MaDonDatHang], [GhiChu], [NgayTao], [ThanhTien], [TinhTrangDonHang], [Id_Khach_Hang], [TenKH], [SdtKH], [EmailKH], [DiaChi]) VALUES (1, N'Quần size S', CAST(N'2019-04-26 21:45:39.000' AS DateTime), 1060, N'Chưa chuyể', 1, N'Đỗ Thị Trà Mi', N'89537296260', N'dotrami78@gmail.com', N'Russia')
INSERT [dbo].[DonDatHang] ([MaDonDatHang], [GhiChu], [NgayTao], [ThanhTien], [TinhTrangDonHang], [Id_Khach_Hang], [TenKH], [SdtKH], [EmailKH], [DiaChi]) VALUES (2, N'', CAST(N'2019-04-26 21:50:50.000' AS DateTime), 360, N'Chưa chuyể', 6, N'Nguyễn Thị Quỳnh Anh', N'0988994093', N'QuynhAnh@gmail.com', N'Giáp Nhất, Ngã Tư Sở, Hà Nội')
INSERT [dbo].[DonDatHang] ([MaDonDatHang], [GhiChu], [NgayTao], [ThanhTien], [TinhTrangDonHang], [Id_Khach_Hang], [TenKH], [SdtKH], [EmailKH], [DiaChi]) VALUES (3, N'1 áo size S, 1 size M', CAST(N'2019-04-26 23:04:19.000' AS DateTime), 400, N'Chưa chuyể', 4, N'Đinh Thanh Tuấn', N'89531299698', N'tuanck@gmail.com', N'Hà Nội')
SET IDENTITY_INSERT [dbo].[DonDatHang] OFF
SET IDENTITY_INSERT [dbo].[Khach] ON 

INSERT [dbo].[Khach] ([Id_Khach_Hang], [TenKH], [Facebook], [Email], [MatKhau], [Sdt], [DiaChi]) VALUES (1, N'Đỗ Trà Mi', N'Tra Mi Do', N'dotrami78@gmail.com', N'a3d284aa709ea983a15092ea039aa5c0', N'89537296260', N'Hà Nội')
INSERT [dbo].[Khach] ([Id_Khach_Hang], [TenKH], [Facebook], [Email], [MatKhau], [Sdt], [DiaChi]) VALUES (4, N'Đinh Thanh Tuấn', N'Tuấn CK', N'tuanck@gmail.com', N'696307ace66505ca01c7e031df6e87aa', N'89531299698', N'Hà Nội')
INSERT [dbo].[Khach] ([Id_Khach_Hang], [TenKH], [Facebook], [Email], [MatKhau], [Sdt], [DiaChi]) VALUES (5, N'Đào Phương Lê', N'Dao Phuong Le', N'lede@gmail.com', N'f81f6afceecd1d749bd28f915e6ba130', N'0936672789', N'Hà Nội')
INSERT [dbo].[Khach] ([Id_Khach_Hang], [TenKH], [Facebook], [Email], [MatKhau], [Sdt], [DiaChi]) VALUES (6, N'Nguyễn Thị Quỳnh Anh', N'', N'QuynhAnh@gmail.com', N'fa9d8537e1e3f1f7a40f9780783cd331', N'0988994093', N'Giáp Nhất, Ngã Tư Sở, Hà Nội')
SET IDENTITY_INSERT [dbo].[Khach] OFF
SET IDENTITY_INSERT [dbo].[Menu] ON 

INSERT [dbo].[Menu] ([Ma], [TenMenu], [ThuTu], [MaMenuCha], [LienKet]) VALUES (1, N'Trang chủ', 1, 0, N'/')
INSERT [dbo].[Menu] ([Ma], [TenMenu], [ThuTu], [MaMenuCha], [LienKet]) VALUES (2, N'Sản Phẩm', 2, 0, N'/Default.aspx?modul=sanpham')
INSERT [dbo].[Menu] ([Ma], [TenMenu], [ThuTu], [MaMenuCha], [LienKet]) VALUES (3, N'Tin Tức', 3, 0, N'/Default.aspx?modul=tintuc')
INSERT [dbo].[Menu] ([Ma], [TenMenu], [ThuTu], [MaMenuCha], [LienKet]) VALUES (4, N'Thành viên', 4, 0, N'/Default.aspx?modul=thanhvien')
SET IDENTITY_INSERT [dbo].[Menu] OFF
SET IDENTITY_INSERT [dbo].[NhomQuangCao] ON 

INSERT [dbo].[NhomQuangCao] ([MaNhom], [TenNhom], [Vitri]) VALUES (1, N'Logo', N'Logo')
INSERT [dbo].[NhomQuangCao] ([MaNhom], [TenNhom], [Vitri]) VALUES (2, N'Banner', N'Banner')
INSERT [dbo].[NhomQuangCao] ([MaNhom], [TenNhom], [Vitri]) VALUES (3, N'Slide ảnh trang chủ', N'Slide')
INSERT [dbo].[NhomQuangCao] ([MaNhom], [TenNhom], [Vitri]) VALUES (4, N'Liên hệ', N'Liên hệ')
SET IDENTITY_INSERT [dbo].[NhomQuangCao] OFF
SET IDENTITY_INSERT [dbo].[NhomSanPham] ON 

INSERT [dbo].[NhomSanPham] ([MaNhom], [TenNhom], [ThuTu], [SoSPHienThi]) VALUES (1, N'HÀNG MỚI VỀ', 1, 6)
INSERT [dbo].[NhomSanPham] ([MaNhom], [TenNhom], [ThuTu], [SoSPHienThi]) VALUES (2, N'HÀNG SALE', 2, 6)
INSERT [dbo].[NhomSanPham] ([MaNhom], [TenNhom], [ThuTu], [SoSPHienThi]) VALUES (3, N'HÀNG HOT', 3, 6)
INSERT [dbo].[NhomSanPham] ([MaNhom], [TenNhom], [ThuTu], [SoSPHienThi]) VALUES (4, N'HÀNG HÃNG', 4, 6)
SET IDENTITY_INSERT [dbo].[NhomSanPham] OFF
SET IDENTITY_INSERT [dbo].[QuyenDangNhap] ON 

INSERT [dbo].[QuyenDangNhap] ([MaQuyen], [TenQuyen], [MaQuyenCha]) VALUES (1, N'Quản trị viên', 0)
INSERT [dbo].[QuyenDangNhap] ([MaQuyen], [TenQuyen], [MaQuyenCha]) VALUES (2, N'Khách Hàng', 0)
INSERT [dbo].[QuyenDangNhap] ([MaQuyen], [TenQuyen], [MaQuyenCha]) VALUES (3, N'Quản trị tài khoản', 1)
INSERT [dbo].[QuyenDangNhap] ([MaQuyen], [TenQuyen], [MaQuyenCha]) VALUES (4, N'Quản trị sản phẩm', 1)
SET IDENTITY_INSERT [dbo].[QuyenDangNhap] OFF
SET IDENTITY_INSERT [dbo].[SanPham] ON 

INSERT [dbo].[SanPham] ([MaSP], [MaDanhMucSP], [DacDiemSP], [GiaSP], [Anh], [TenSanPham], [MaNhom]) VALUES (1, 1, N'Fila Thái nam nữ mặc đôi cực đẹp lun nhaaa. Size: S M L XL                                                                                                                                                                                                                                                                                                                                                                                                                                                          ', 200, N'Ao_Fila.jpg                                                                                         ', N'Áo Fila                                           ', 1)
INSERT [dbo].[SanPham] ([MaSP], [MaDanhMucSP], [DacDiemSP], [GiaSP], [Anh], [TenSanPham], [MaNhom]) VALUES (2, 1, N'Quần sooc sọc                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       ', 250, N'Quan_sooc_soc.jpg                                                                                   ', N'Quần sooc sọc                                     ', 3)
INSERT [dbo].[SanPham] ([MaSP], [MaDanhMucSP], [DacDiemSP], [GiaSP], [Anh], [TenSanPham], [MaNhom]) VALUES (3, 3, N'Sandal bánh mì Thái đi nhẹ và êm cực                                                                                                                                                                                                                                                                                                                                                                                                                                                                                ', 250, N'Sandals_banh_mi.jpg                                                                                 ', N'Sandals bánh mì                                   ', 3)
INSERT [dbo].[SanPham] ([MaSP], [MaDanhMucSP], [DacDiemSP], [GiaSP], [Anh], [TenSanPham], [MaNhom]) VALUES (4, 3, N'Dép cườm Made in Thailand hàng chuẩn luôn cầm lên nặng tay mà mang vô êm chân dã mang bền lắm luôn cườm đc may lên bằng tay nên chắc chắn ko bị bung cườm .
Size : 35~41                                                                                                                                                                                                                                                                                                                                           ', 190, N'Dep_cuom.jpg                                                                                        ', N'Dép cườm                                          ', 1)
INSERT [dbo].[SanPham] ([MaSP], [MaDanhMucSP], [DacDiemSP], [GiaSP], [Anh], [TenSanPham], [MaNhom]) VALUES (5, 2, N'GỌI TÊN SET TRANG ĐIỂM ĐA-ZI-NĂNG XÀI QUANH NĂM💥 Kit Phấn Mắt Sivanna Hello Perfect 2 Tầng HF5016                                                                                                                                                                                                                                                                                                                                                                                                                  ', 280, N'set_trang_diem.jpg                                                                                  ', N'Set trang điểm Sivanna                            ', 2)
INSERT [dbo].[SanPham] ([MaSP], [MaDanhMucSP], [DacDiemSP], [GiaSP], [Anh], [TenSanPham], [MaNhom]) VALUES (6, 1, N'Áo quả cầu blingblinggg đang hot đây                                                                                                                                                                                                                                                                                                                                                                                                                                                                                ', 280, N'Ao_qua_cau.jpg                                                                                      ', N'Áo quả cầu bling                                  ', 3)
INSERT [dbo].[SanPham] ([MaSP], [MaDanhMucSP], [DacDiemSP], [GiaSP], [Anh], [TenSanPham], [MaNhom]) VALUES (7, 4, N'khô mực tẩm bbq vị cay loại này siu nghiện. Gói 1kg                                                                                                                                                                                                                                                                                                                                                                                                                                                                 ', 180, N'muc_kho.jpg                                                                                         ', N'khô mực cay                                       ', 1)
INSERT [dbo].[SanPham] ([MaSP], [MaDanhMucSP], [DacDiemSP], [GiaSP], [Anh], [TenSanPham], [MaNhom]) VALUES (9, 2, N'Mascara Maybeline có đầu chải như chiếc lược. E này đảm bảo chuốt lông mi cong vút, tơi mi cực kì luôn ạ. Riêng dòng Maybeline thì k lem, k trôi nên các ce cứ tự tin ngay cả khi trời mưa hay da dầu lunnn.                                                                                                                                                                                                                                                                                                        ', 350, N'mascara_maybelline.jpg                                                                              ', N'Mascara Maybeline                                 ', 2)
INSERT [dbo].[SanPham] ([MaSP], [MaDanhMucSP], [DacDiemSP], [GiaSP], [Anh], [TenSanPham], [MaNhom]) VALUES (10, 1, N'Chân váy hoạ tiết siêu cute luôn khách ơi. Mix với áo phông or áo 2s, áo ống gì cũng dth hết lun 
Size S M L                                                                                                                                                                                                                                                                                                                                                                                                       ', 280, N'chan_vay_hoa_tiet.jpg                                                                               ', N'Chân váy họa tiết                                 ', 1)
SET IDENTITY_INSERT [dbo].[SanPham] OFF
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_DanhMucSP] FOREIGN KEY([MaDanhMucSP])
REFERENCES [dbo].[DanhMucSP] ([MaDanhMucSP])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_DanhMucSP]
GO
/****** Object:  StoredProcedure [dbo].[Delete_AnhQuangCao]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Delete_AnhQuangCao]
@MaAnh int
AS
BEGIN
   Delete from AnhQuangCao where MaAnh =@MaAnh
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_CauHoiBaoMat]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Delete_CauHoiBaoMat]
@MaCauHoiBaoMat int
AS
BEGIN
   Delete from CauHoiBaoMat where MaCauHoiBaoMat =@MaCauHoiBaoMat
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_ChiTietDonHang]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Delete_ChiTietDonHang]
@MaChiTiet int
AS
BEGIN
   Delete from ChiTietDonHang where MaChiTiet = @MaChiTiet
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_DanhMucSP]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Delete_DanhMucSP]
@MaDanhMucSP int
AS
BEGIN
   Delete from DanhMucSP where MaDanhMucSP =@MaDanhMucSP
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_DonHang]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Delete_DonHang]
@MaDonDatHang int
AS
BEGIN
   Delete from DonDatHang where MaDonDatHang = @MaDonDatHang
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_KhachHang]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Delete_KhachHang]
@Id_Khach_Hang int
AS
BEGIN
   Delete from Khach where Id_Khach_Hang = @Id_Khach_Hang
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_Menu]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Delete_Menu]
@Ma int
AS
BEGIN
   Delete from Menu where Ma =@Ma
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_NhomQuangCao]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[Delete_NhomQuangCao]
@MaNhom int
AS
BEGIN
   Delete from NhomQuangCao where MaNhom =@MaNhom
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_NhomSanPham]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Delete_NhomSanPham]
@MaNhom int
AS
BEGIN
   Delete from NhomSanPham where MaNhom =@MaNhom
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_QuyenDangNhap]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Delete_QuyenDangNhap]
@MaQuyen int
AS
BEGIN
   Delete from QuyenDangNhap where MaQuyen =@MaQuyen
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_SanPham]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Delete_SanPham]
@MaSP int
AS
BEGIN
   Delete from SanPham where MaSP = @MaSP
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_TaiKhoan]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Delete_TaiKhoan]
@TenDangNhap nvarchar(50)
AS
BEGIN
   Delete from DangKyTaiKhoan where TenDangNhap = @TenDangNhap
END

GO
/****** Object:  StoredProcedure [dbo].[Insert_AnhQuangCao]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Insert_AnhQuangCao]
	@MaNhom int,
	@TenQuangCao nvarchar(50),
	@Anh nvarchar(100),
	@Thutu int,
	@LienKet nvarchar(100),
	@ret int out
AS
BEGIN
    Begin Tran
	insert into AnhQuangCao (MaNhom,TenQuangCao,Anh,Thutu,LienKet) values (@MaNhom,@TenQuangCao,@Anh,@Thutu,@LienKet)
	if(@@ERROR <> 0)
	Begin
	      set @ret = -1
		  rollback tran
    End
	set @ret = @@IDENTITY
	commit tran
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_CauHoiBaoMat]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Insert_CauHoiBaoMat]
	@CauHoi nvarchar(100),
	@ret int out
AS
BEGIN
    Begin Tran
	insert into CauHoiBaoMat (CauHoi) values (@CauHoi)
	if(@@ERROR <> 0)
	Begin
	      set @ret = -1
		  rollback tran
    End
	set @ret = @@IDENTITY
	commit tran
END

GO
/****** Object:  StoredProcedure [dbo].[Insert_ChiTietDonHang]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Insert_ChiTietDonHang]
    @MaSP int, 
	@MaDonDatHang int, 
	@SoLuongDat int, 
	@DonGiaDat float,
	@ret int out
AS
BEGIN
    Begin Tran
	insert into ChiTietDonHang(MaSP,MaDonDatHang,SoLuongDat,DonGiaDat) values (@MaSP,@MaDonDatHang,@SoLuongDat,@DonGiaDat)
	if(@@ERROR <> 0)
	Begin
	      set @ret = -1
		  rollback tran
    End
	set @ret = @@IDENTITY
	commit tran
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_DanhMucSP]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Insert_DanhMucSP]
	@TenDanhMucSP nchar(50),
	@MaDanhMucCha int,
	@SoSPHienThi int,
	@ret int out
AS
BEGIN
    Begin Tran
	insert into DanhMucSP (TenDanhMucSP,MaDanhMucCha,SoSPHienThi) values (@TenDanhMucSP,@MaDanhMucCha,@SoSPHienThi)
	if(@@ERROR <> 0)
	Begin
	      set @ret = -1
		  rollback tran
    End
	set @ret = @@IDENTITY
	commit tran
END

GO
/****** Object:  StoredProcedure [dbo].[Insert_DonHang]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Insert_DonHang]
    @GhiChu nvarchar(300), 
	@NgayTao datetime, 
	@ThanhTien float, 
	@TinhTrangDonHang nchar(10), 
	@Id_Khach_Hang int,
	@TenKH nvarchar(50),
	@SdtKH nvarchar(15),
	@EmailKH nvarchar(50),
	@DiaChi nvarchar(200),
	@ret int out
AS
BEGIN
    Begin Tran
	insert into DonDatHang(GhiChu,NgayTao,ThanhTien,TinhTrangDonHang,Id_Khach_Hang,TenKH,SdtKH,EmailKH,DiaChi) values (@GhiChu,@NgayTao,@ThanhTien,@TinhTrangDonHang,@Id_Khach_Hang,@TenKH,@SdtKH,@EmailKH,@DiaChi)
	if(@@ERROR <> 0)
	Begin
	      set @ret = -1
		  rollback tran
    End
	set @ret = @@IDENTITY
	commit tran
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_KhachHang]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Insert_KhachHang]
	@TenKH nvarchar(50),
	@Facebook nvarchar(50),
	@Email nvarchar(50),
	@MatKhau nvarchar(50),
	@Sdt nvarchar(15),
	@DiaChi nvarchar(200),
	@ret int out
AS
BEGIN
    Begin Tran
	insert into Khach(TenKH,Facebook,Email,MatKhau,Sdt,DiaChi) values (@TenKH,@Facebook,@Email,@MatKhau,@Sdt,@DiaChi)
	if(@@ERROR <> 0)
	Begin
	      set @ret = -1
		  rollback tran
    End
	set @ret = @@IDENTITY
	commit tran
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_Menu]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Insert_Menu]
	@TenMenu nvarchar(50),
	@ThuTu int,
	@MaMenuCha int,
	@LienKet nvarchar(100),
	@ret int out
AS
BEGIN
    Begin Tran
	insert into Menu (TenMenu,ThuTu,MaMenuCha,LienKet) values (@TenMenu,@ThuTu,@MaMenuCha,@LienKet)
	if(@@ERROR <> 0)
	Begin
	      set @ret = -1
		  rollback tran
    End
	set @ret = @@IDENTITY
	commit tran
END

GO
/****** Object:  StoredProcedure [dbo].[Insert_NhomQuangCao]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Insert_NhomQuangCao]
	@TenNhom nvarchar(50),
	@Vitri nvarchar(50),
	@ret int out
AS
BEGIN
    Begin Tran
	insert into NhomQuangCao (TenNhom,Vitri) values (@TenNhom,@Vitri)
	if(@@ERROR <> 0)
	Begin
	      set @ret = -1
		  rollback tran
    End
	set @ret = @@IDENTITY
	commit tran
END

GO
/****** Object:  StoredProcedure [dbo].[Insert_NhomSanPham]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Insert_NhomSanPham]
	@TenNhom nvarchar(100),
	@ThuTu int,
	@SoSPHienThi int,
	@ret int out
AS
BEGIN
    Begin Tran
	insert into NhomSanPham (TenNhom,ThuTu,SoSPHienThi) values (@TenNhom,@ThuTu,@SoSPHienThi)
	if(@@ERROR <> 0)
	Begin
	      set @ret = -1
		  rollback tran
    End
	set @ret = @@IDENTITY
	commit tran
END

GO
/****** Object:  StoredProcedure [dbo].[Insert_QuyenDangNhap]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Insert_QuyenDangNhap]
	@TenQuyen nvarchar(50),
	@MaQuyenCha int,
	@ret int out
AS
BEGIN
    Begin Tran
	insert into QuyenDangNhap (TenQuyen,MaQuyenCha) values (@TenQuyen,@MaQuyenCha)
	if(@@ERROR <> 0)
	Begin
	      set @ret = -1
		  rollback tran
    End
	set @ret = @@IDENTITY
	commit tran
END

GO
/****** Object:  StoredProcedure [dbo].[Insert_SanPham]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Insert_SanPham]
	@MaDanhMucSP int,
	@DacDiemSP nchar(500),
	@GiaSP money,
	@Anh nchar(100),
	@TenSanPham nchar(100),
	@MaNhom int,
	@ret int out
AS
BEGIN
    Begin Tran
	insert into SanPham (MaDanhMucSP,DacDiemSP,GiaSP,Anh,TenSanPham,MaNhom) values (@MaDanhMucSP,@DacDiemSP,@GiaSP,@Anh,@TenSanPham,@MaNhom)
	if(@@ERROR <> 0)
	Begin
	      set @ret = -1
		  rollback tran
    End
	set @ret = @@IDENTITY
	commit tran
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_TaiKhoan]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Insert_TaiKhoan]
	@TenDangNhap nvarchar(50),
	@MatKhau nvarchar(50),
    @EmailDK nvarchar(50),
    @DiaChiDK nvarchar(100),
    @TenDayDu nvarchar(50),
    @MaCauHoiBaoMat int,
    @CauTraLoi nvarchar(100),
    @Ngaysinh date,
    @GioiTinh nvarchar(5),
    @MaQuyen int, 
	@ret nvarchar(50) out
AS
BEGIN
    Begin Tran
	insert into DangKyTaiKhoan(TenDangNhap,MatKhau,EmailDK,DiaChiDK,TenDayDu,MaCauHoiBaoMat,CauTraLoi,Ngaysinh,GioiTinh,MaQuyen) 
	values (@TenDangNhap,@MatKhau,@EmailDK,@DiaChiDK,@TenDayDu,@MaCauHoiBaoMat,@CauTraLoi,@Ngaysinh,@GioiTinh,@MaQuyen)
	if(@@ERROR <> 0)
	Begin
	      set @ret = ' '
		  rollback tran
    End
	set @ret = @TenDangNhap
	commit tran
END

GO
/****** Object:  StoredProcedure [dbo].[Thongtin_All_SanPham_By_MaDanhMucSP]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Thongtin_All_SanPham_By_MaDanhMucSP]
@MaDanhMucSP int
AS
BEGIN
   Select * from SanPham where MaDanhMucSP = @MaDanhMucSP
END

GO
/****** Object:  StoredProcedure [dbo].[Thongtin_AnhQuangCao]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Thongtin_AnhQuangCao]
AS
BEGIN
   Select * from AnhQuangCao
END

GO
/****** Object:  StoredProcedure [dbo].[Thongtin_AnhQuangCao_By_MaAnh]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Thongtin_AnhQuangCao_By_MaAnh]
 @MaAnh int
AS
BEGIN
   Select * from AnhQuangCao where MaAnh  = @MaAnh 
END
GO
/****** Object:  StoredProcedure [dbo].[Thongtin_AnhQuangCao_By_MaNhom]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Thongtin_AnhQuangCao_By_MaNhom]
 @MaNhom int
AS
BEGIN
   Select * from AnhQuangCao where MaNhom  = @MaNhom 
END
GO
/****** Object:  StoredProcedure [dbo].[Thongtin_CauHoi]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Thongtin_CauHoi]
AS
BEGIN
   Select * from CauHoiBaoMat
END
GO
/****** Object:  StoredProcedure [dbo].[Thongtin_ChiTietDonHang]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Thongtin_ChiTietDonHang]
AS
BEGIN
   Select * from ChiTietDonHang
END

GO
/****** Object:  StoredProcedure [dbo].[Thongtin_DanhMucSP]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Thongtin_DanhMucSP]
AS
BEGIN
   Select * from DanhMucSP
END
GO
/****** Object:  StoredProcedure [dbo].[Thongtin_DanhMucSP_By_MaDanhMucCha]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Thongtin_DanhMucSP_By_MaDanhMucCha]
@MaDanhMucCha int 
AS
BEGIN
   Select * from DanhMucSP where MaDanhMucCha = @MaDanhMucCha
END

GO
/****** Object:  StoredProcedure [dbo].[Thongtin_DanhMucSP_By_MaDanhMucSP]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Thongtin_DanhMucSP_By_MaDanhMucSP]
@MaDanhMucSP int 
AS
BEGIN
   Select * from DanhMucSP where MaDanhMucSP = @MaDanhMucSP
END

GO
/****** Object:  StoredProcedure [dbo].[Thongtin_DonHang]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Thongtin_DonHang]
AS
BEGIN
   Select * from DonDatHang
END

GO
/****** Object:  StoredProcedure [dbo].[Thongtin_DonHangMoiNhat]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Thongtin_DonHangMoiNhat]
AS
BEGIN
   Select * from DonDatHang order by MaDonDatHang desc
END

GO
/****** Object:  StoredProcedure [dbo].[Thongtin_KhachHang]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Thongtin_KhachHang]
AS
BEGIN
   Select * from Khach
END

GO
/****** Object:  StoredProcedure [dbo].[Thongtin_KhachHang_By_Email]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Thongtin_KhachHang_By_Email]
@Email nvarchar(50)
AS
BEGIN
   Select * from Khach where Email=@Email
END

GO
/****** Object:  StoredProcedure [dbo].[Thongtin_KhachHang_By_Email_MatKhau]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Thongtin_KhachHang_By_Email_MatKhau]
@Email nvarchar(50),
@MatKhau nvarchar(50)
AS
BEGIN
   Select * from Khach where Email=@Email and MatKhau=@MatKhau
END

GO
/****** Object:  StoredProcedure [dbo].[Thongtin_Menu]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Thongtin_Menu]
AS
BEGIN
   Select * from Menu order by ThuTu
END
GO
/****** Object:  StoredProcedure [dbo].[Thongtin_Menu_By_Ma]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Thongtin_Menu_By_Ma]
@Ma int
AS
BEGIN
   Select * from Menu where Ma=@Ma
END
GO
/****** Object:  StoredProcedure [dbo].[Thongtin_Menu_By_MenuCha]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Thongtin_Menu_By_MenuCha]
 @MaMenuCha int
AS
BEGIN
   Select * from Menu where MaMenuCha  = @MaMenuCha order by ThuTu
END
GO
/****** Object:  StoredProcedure [dbo].[Thongtin_NhomQuangCao]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Thongtin_NhomQuangCao]
AS
BEGIN
   Select * from NhomQuangCao
END
GO
/****** Object:  StoredProcedure [dbo].[Thongtin_NhomQuangCao_By_MaNhom]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Thongtin_NhomQuangCao_By_MaNhom]
@MaNhom int
AS
BEGIN
   Select * from NhomQuangCao where MaNhom=@MaNhom
END
GO
/****** Object:  StoredProcedure [dbo].[Thongtin_NhomQuangCao_By_Vitri]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Thongtin_NhomQuangCao_By_Vitri]
 @Vitri nvarchar(50)
AS
BEGIN
   Select * from NhomQuangCao where Vitri  = @Vitri 
END
GO
/****** Object:  StoredProcedure [dbo].[Thongtin_NhomSanPham]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Thongtin_NhomSanPham]
AS
BEGIN
   Select * from NhomSanPham
END
GO
/****** Object:  StoredProcedure [dbo].[Thongtin_NhomSanPham_By_MaNhom]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Thongtin_NhomSanPham_By_MaNhom]
@MaNhom int
AS
BEGIN
   Select * from NhomSanPham where MaNhom=@MaNhom
END
GO
/****** Object:  StoredProcedure [dbo].[Thongtin_QuyenDangNhap]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Thongtin_QuyenDangNhap]
AS
BEGIN
   Select * from QuyenDangNhap
END
GO
/****** Object:  StoredProcedure [dbo].[Thongtin_SanPham]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Thongtin_SanPham]
AS
BEGIN
   Select * from SanPham
END

GO
/****** Object:  StoredProcedure [dbo].[Thongtin_SanPham_By_MaDanhMucSP]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Thongtin_SanPham_By_MaDanhMucSP]
@MaDanhMucSP int,
@SoSPHienThi int
AS
BEGIN
   declare @sql nvarchar(300)
   set @sql = 'Select top '+ CAST(@SoSPHienThi as varchar(10)) + ' * from SanPham where MaDanhMucSP = ' + CAST(@MaDanhMucSP as varchar(10))
   exec sp_executesql @sql
END

GO
/****** Object:  StoredProcedure [dbo].[Thongtin_SanPham_By_MaNhom]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Thongtin_SanPham_By_MaNhom]
@MaNhom int,
@SoSPHienThi int
AS
BEGIN
   declare @sql nvarchar(300)
   set @sql = 'Select top '+ CAST(@SoSPHienThi as varchar(10)) + ' * from SanPham where MaNhom = ' + CAST(@MaNhom as varchar(10))
   exec sp_executesql @sql
END

GO
/****** Object:  StoredProcedure [dbo].[Thongtin_SanPham_By_MaSP]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Thongtin_SanPham_By_MaSP]
@MaSP int
AS
BEGIN
   Select * from SanPham where MaSP = @MaSP
END

GO
/****** Object:  StoredProcedure [dbo].[Thongtin_TaiKhoan]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Thongtin_TaiKhoan]
AS
BEGIN
   Select * from DangKyTaiKhoan
END

GO
/****** Object:  StoredProcedure [dbo].[Thongtin_TaiKhoan_By_TenDangNhap]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Thongtin_TaiKhoan_By_TenDangNhap]
 @TenDangNhap nvarchar(50)
AS
BEGIN
   Select * from DangKyTaiKhoan where TenDangNhap = @TenDangNhap
END

GO
/****** Object:  StoredProcedure [dbo].[Thongtin_TaiKhoan_By_TenDangNhap_And_MatKhau]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Thongtin_TaiKhoan_By_TenDangNhap_And_MatKhau]
 @TenDangNhap nvarchar(50),
 @MatKhau nvarchar(50)
AS
BEGIN
   Select * from DangKyTaiKhoan where TenDangNhap = @TenDangNhap and MatKhau=@MatKhau
END
GO
/****** Object:  StoredProcedure [dbo].[Update_AnhQuangCao]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Update_AnhQuangCao]
    @MaAnh int,
	@MaNhom int,
	@TenQuangCao nvarchar(50),
	@Anh nvarchar(100),
	@Thutu int,
	@LienKet nvarchar(100)
AS
BEGIN
   update AnhQuangCao set MaNhom=@MaNhom,TenQuangCao=@TenQuangCao,Anh=@Anh,Thutu=@Thutu,LienKet=@LienKet where MaAnh=@MaAnh
END
GO
/****** Object:  StoredProcedure [dbo].[Update_CauHoiBaoMat]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Update_CauHoiBaoMat]
	@MaCauHoiBaoMat int,
	@CauHoi nvarchar(100)
AS
BEGIN
   update CauHoiBaoMat set CauHoi=@CauHoi where MaCauHoiBaoMat=@MaCauHoiBaoMat
END
GO
/****** Object:  StoredProcedure [dbo].[Update_ChiTietDonHang]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Update_ChiTietDonHang]
	@MaChiTiet int,
	@MaSP int, 
	@MaDonDatHang int, 
	@SoLuongDat int, 
	@DonGiaDat float
AS
BEGIN
	update ChiTietDonHang set MaSP=@MaSP,MaDonDatHang=@MaDonDatHang,DonGiaDat=@DonGiaDat where MaChiTiet=@MaChiTiet
END
GO
/****** Object:  StoredProcedure [dbo].[Update_DanhMucSP]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Update_DanhMucSP]
	@MaDanhMucSP int,
	@TenDanhMucSP nchar(50),
	@MaDanhMucCha int,
	@SoSPHienThi int
AS
BEGIN
   update DanhMucSP set TenDanhMucSP=@TenDanhMucSP,MaDanhMucCha=@MaDanhMucCha,SoSPHienThi=@SoSPHienThi where MaDanhMucSP=@MaDanhMucSP
END
GO
/****** Object:  StoredProcedure [dbo].[Update_DonDatHang]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Update_DonDatHang]
    @MaDonDatHang int,
	@GhiChu nvarchar(300), 
	@NgayTao datetime, 
	@ThanhTien float, 
	@TinhTrangDonHang nchar(10), 
	@Id_Khach_Hang int,
	@TenKH nvarchar(50),
	@SdtKH nvarchar(15),
	@EmailKH nvarchar(50),
	@DiaChi nvarchar(200)
AS
BEGIN
	update DonDatHang set GhiChu=@GhiChu,NgayTao=@NgayTao,ThanhTien=@ThanhTien,TinhTrangDonHang=@TinhTrangDonHang,
	Id_Khach_Hang=@Id_Khach_Hang,TenKH=@TenKH,SdtKH=@SdtKH,EmailKH=@EmailKH,DiaChi=@DiaChi where MaDonDatHang=@MaDonDatHang
END
GO
/****** Object:  StoredProcedure [dbo].[Update_KhachHang]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Update_KhachHang]
	@Id_Khach_Hang int,
	@TenKH nvarchar(50),
	@Facebook nvarchar(50),
	@Email nvarchar(50),
	@MatKhau nvarchar(50),
	@Sdt nvarchar(15),
	@DiaChi nvarchar(200)
AS
BEGIN
	update Khach set TenKH=@TenKH,Facebook=@Facebook,Email=@Email,MatKhau=@MatKhau,Sdt=@Sdt,DiaChi=@DiaChi where Id_Khach_Hang=@Id_Khach_Hang
END
GO
/****** Object:  StoredProcedure [dbo].[Update_Menu]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Update_Menu]
	@Ma int,
	@TenMenu nvarchar(50),
	@ThuTu int,
	@MaMenuCha int,
	@LienKet nvarchar(50)
AS
BEGIN
   update Menu set TenMenu=@TenMenu,ThuTu=@ThuTu,MaMenuCha=@MaMenuCha,LienKet=@LienKet where Ma=@Ma
END
GO
/****** Object:  StoredProcedure [dbo].[Update_NhomQuangCao]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Update_NhomQuangCao]
	@MaNhom int,
	@TenNhom nvarchar(50),
	@Vitri nvarchar(50)
AS
BEGIN
   update NhomQuangCao set TenNhom=@TenNhom,Vitri=@Vitri where MaNhom=@MaNhom
END
GO
/****** Object:  StoredProcedure [dbo].[Update_NhomSanPham]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Update_NhomSanPham]
	@MaNhom int,
	@TenNhom nvarchar(100),
	@ThuTu int,
	@SoSPHienThi int
AS
BEGIN
   update NhomSanPham set TenNhom=@TenNhom,ThuTu=@ThuTu,SoSPHienThi=@SoSPHienThi where MaNhom=@MaNhom
END
GO
/****** Object:  StoredProcedure [dbo].[Update_QuyenDangNhap]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Update_QuyenDangNhap]
	@MaQuyen int,
	@TenQuyen nvarchar(50),
	@MaQuyenCha int
AS
BEGIN
   update QuyenDangNhap set TenQuyen=@TenQuyen,MaQuyenCha=@MaQuyenCha where MaQuyen=@MaQuyen
END
GO
/****** Object:  StoredProcedure [dbo].[Update_SanPham]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Update_SanPham]
    @MaSP int,
	@MaDanhMucSP int,
	@DacDiemSP nchar(500),
	@GiaSP money,
	@Anh nchar(100),
	@TenSanPham nchar(100),
	@MaNhom int
AS
BEGIN
   update SanPham set MaDanhMucSP=@MaDanhMucSP,DacDiemSP=@DacDiemSP,GiaSP=@GiaSP,Anh=@Anh,TenSanPham=@TenSanPham,MaNhom=@MaNhom where MaSP=@MaSP
END
GO
/****** Object:  StoredProcedure [dbo].[Update_TaiKhoan]    Script Date: 10/20/2019 10:51:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Update_TaiKhoan]
    @TenDangNhap nvarchar(50),
	@MatKhau nvarchar(50),
    @EmailDK nvarchar(50),
    @DiaChiDK nvarchar(100),
    @TenDayDu nvarchar(50),
    @MaCauHoiBaoMat int,
    @CauTraLoi nvarchar(100),
    @Ngaysinh date,
    @GioiTinh nvarchar(5),
    @MaQuyen int
AS
BEGIN
   update DangKyTaiKhoan set MatKhau=@MatKhau,EmailDK=@EmailDK,DiaChiDK=@DiaChiDK,TenDayDu=@TenDayDu,MaCauHoiBaoMat=@MaCauHoiBaoMat,CauTraLoi=@CauTraLoi,Ngaysinh=@Ngaysinh,GioiTinh=@GioiTinh,MaQuyen=@MaQuyen where TenDangNhap=@TenDangNhap
END

GO
USE [master]
GO
ALTER DATABASE [QuanLyHangThai] SET  READ_WRITE 
GO
