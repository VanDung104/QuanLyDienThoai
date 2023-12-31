USE [master]
GO
/****** Object:  Database [QLDienThoai_Csharp]    Script Date: 11/13/2023 10:27:26 PM ******/
CREATE DATABASE [QLDienThoai_Csharp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLDienThoai_Csharp', FILENAME = N'D:\SQLServer\MSSQL16.SQLEXPRESS\MSSQL\DATA\QLDienThoai_Csharp.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLDienThoai_Csharp_log', FILENAME = N'D:\SQLServer\MSSQL16.SQLEXPRESS\MSSQL\DATA\QLDienThoai_Csharp_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QLDienThoai_Csharp] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLDienThoai_Csharp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLDienThoai_Csharp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLDienThoai_Csharp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLDienThoai_Csharp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLDienThoai_Csharp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLDienThoai_Csharp] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLDienThoai_Csharp] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLDienThoai_Csharp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLDienThoai_Csharp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLDienThoai_Csharp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLDienThoai_Csharp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLDienThoai_Csharp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLDienThoai_Csharp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLDienThoai_Csharp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLDienThoai_Csharp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLDienThoai_Csharp] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLDienThoai_Csharp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLDienThoai_Csharp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLDienThoai_Csharp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLDienThoai_Csharp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLDienThoai_Csharp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLDienThoai_Csharp] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLDienThoai_Csharp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLDienThoai_Csharp] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLDienThoai_Csharp] SET  MULTI_USER 
GO
ALTER DATABASE [QLDienThoai_Csharp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLDienThoai_Csharp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLDienThoai_Csharp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLDienThoai_Csharp] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLDienThoai_Csharp] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLDienThoai_Csharp] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QLDienThoai_Csharp] SET QUERY_STORE = ON
GO
ALTER DATABASE [QLDienThoai_Csharp] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QLDienThoai_Csharp]
GO
/****** Object:  Table [dbo].[CT_HOADON]    Script Date: 11/13/2023 10:27:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_HOADON](
	[MaHD] [nvarchar](50) NOT NULL,
	[MaHH] [nvarchar](50) NOT NULL,
	[SL] [int] NULL,
 CONSTRAINT [PK_CT_HOADON] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HANGHOA]    Script Date: 11/13/2023 10:27:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HANGHOA](
	[MaHH] [nvarchar](50) NOT NULL,
	[HangSX] [nvarchar](255) NULL,
	[TenHH] [nvarchar](255) NULL,
	[GiaBan] [float] NULL,
	[DacDiem] [nvarchar](max) NULL,
	[Anh] [nvarchar](50) NULL,
	[Loai] [nvarchar](50) NULL,
	[Hang] [nvarchar](255) NULL,
	[Bo_nho] [nvarchar](50) NULL,
	[So_luong] [int] NULL,
 CONSTRAINT [PK_HANGHOA] PRIMARY KEY CLUSTERED 
(
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 11/13/2023 10:27:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHD] [nvarchar](50) NOT NULL,
	[MaKH] [nvarchar](50) NULL,
	[MaNV] [nvarchar](50) NULL,
	[NgayLap] [datetime] NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[fnViewHD]    Script Date: 11/13/2023 10:27:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[fnViewHD](@maHD nvarchar(50))
returns table
as
return
(
select hh.MaHH as N'Mã sản phẩm', hh.TenHH as N'Tên sản phẩm', ct.SL as N'Số lượng', 
hh.GiaBan, hh.GiaBan*ct.SL as N'Thành tiền' from HOADON hd 
join CT_HOADON ct on ct.MaHD = hd.MaHD
join HANGHOA hh on hh.MaHH = ct.MaHH
where hd.MaHD = @maHD
)
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 11/13/2023 10:27:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [nvarchar](50) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nvarchar](15) NULL,
	[NgaySInh] [date] NULL,
	[Anh] [nvarchar](50) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 11/13/2023 10:27:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [nvarchar](50) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[QueQuan] [nvarchar](max) NULL,
	[Gioi Tinh] [nvarchar](10) NULL,
	[SDT] [nvarchar](15) NULL,
	[NgaySinh] [datetime] NULL,
	[NgayLV] [datetime] NULL,
	[HSL] [nvarchar](50) NULL,
	[Anh] [nvarchar](50) NULL,
	[MaTK] [nvarchar](50) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[fnViewHD_KH_NV]    Script Date: 11/13/2023 10:27:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[fnViewHD_KH_NV](@maHD nvarchar(50))
returns table
as
return
(
	select hd.MaHD, kh.MaKH, Nv.MaNV ,sum(cthd.SL * hh.GiaBan) as Tong_tien
	from HOADON hd join CT_HOADON cthd on cthd.MaHD = hd.MaHD 
	join KHACHHANG kh on kh.MaKH = hd.MaKH
	join HANGHOA hh on hh.MaHH = cthd.MaHH
	join NHANVIEN nv on nv.MaNV = hd.MaNV
	Where hd.MaHD =@maHD
	group by hd.MaHD,kh.MaKH, Nv.MaNV
)
GO
/****** Object:  UserDefinedFunction [dbo].[Thong_ke]    Script Date: 11/13/2023 10:27:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[Thong_ke](@nam int)
returns table
as
return
(
select ct.MaHH, hh.TenHH , sum(ct.SL) as So_luong_ban from HOADON hd join CT_HOADON ct on ct.MaHD = hd.MaHD
join HANGHOA hh on hh.MaHH = ct.MaHH
where Year(hd.NgayLap) = @nam
group by ct.MaHH, hh.TenHH
)
GO
/****** Object:  UserDefinedFunction [dbo].[Thong_ke_doanh_thu]    Script Date: 11/13/2023 10:27:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[Thong_ke_doanh_thu](@nam int)
returns table
return
(
select month(hd.NgayLap) as N'Tháng', sum(hh.GiaBan * ct.SL) as N'Doanh thu' from HOADON hd 
join CT_HOADON ct on hd.MaHD = ct.MaHD
join HANGHOA hh on hh.MaHH = ct.MaHH
where year(hd.NgayLap) = @nam
group by month(hd.NgayLap)
)
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 11/13/2023 10:27:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[MaTK] [nvarchar](50) NOT NULL,
	[TenDN] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](50) NULL,
	[Quyen] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CT_HOADON] ([MaHD], [MaHH], [SL]) VALUES (N'HD001', N'MH001', 2)
INSERT [dbo].[CT_HOADON] ([MaHD], [MaHH], [SL]) VALUES (N'HD001', N'MH002', 1)
INSERT [dbo].[CT_HOADON] ([MaHD], [MaHH], [SL]) VALUES (N'HD001', N'MH003', 1)
INSERT [dbo].[CT_HOADON] ([MaHD], [MaHH], [SL]) VALUES (N'HD002', N'MH002', 2)
INSERT [dbo].[CT_HOADON] ([MaHD], [MaHH], [SL]) VALUES (N'HD002', N'MH004', 3)
INSERT [dbo].[CT_HOADON] ([MaHD], [MaHH], [SL]) VALUES (N'HD03', N'MH003', 4)
INSERT [dbo].[CT_HOADON] ([MaHD], [MaHH], [SL]) VALUES (N'HD03', N'MH004', 2)
INSERT [dbo].[CT_HOADON] ([MaHD], [MaHH], [SL]) VALUES (N'HD04', N'MH003', 1)
INSERT [dbo].[CT_HOADON] ([MaHD], [MaHH], [SL]) VALUES (N'HD04', N'MH005', 2)
INSERT [dbo].[CT_HOADON] ([MaHD], [MaHH], [SL]) VALUES (N'HD05', N'MH003', 1)
INSERT [dbo].[CT_HOADON] ([MaHD], [MaHH], [SL]) VALUES (N'HD05', N'MH005', 2)
GO
INSERT [dbo].[HANGHOA] ([MaHH], [HangSX], [TenHH], [GiaBan], [DacDiem], [Anh], [Loai], [Hang], [Bo_nho], [So_luong]) VALUES (N'MH001', N'Apple', N'Iphone11', 35000000, NULL, N'f1.jpg', NULL, NULL, N'64GB', 14)
INSERT [dbo].[HANGHOA] ([MaHH], [HangSX], [TenHH], [GiaBan], [DacDiem], [Anh], [Loai], [Hang], [Bo_nho], [So_luong]) VALUES (N'MH002', N'Apple', N'Iphone12', 35000000, NULL, N'f2.jpg', NULL, NULL, N'64GB', 14)
INSERT [dbo].[HANGHOA] ([MaHH], [HangSX], [TenHH], [GiaBan], [DacDiem], [Anh], [Loai], [Hang], [Bo_nho], [So_luong]) VALUES (N'MH003', N'Apple', N'Iphone13', 35000000, NULL, N'f3.jpg', NULL, NULL, N'64GB', 8)
INSERT [dbo].[HANGHOA] ([MaHH], [HangSX], [TenHH], [GiaBan], [DacDiem], [Anh], [Loai], [Hang], [Bo_nho], [So_luong]) VALUES (N'MH004', N'Apple', N'Iphone14', 35000000, NULL, N'f4.jpg', NULL, NULL, N'64GB', 15)
INSERT [dbo].[HANGHOA] ([MaHH], [HangSX], [TenHH], [GiaBan], [DacDiem], [Anh], [Loai], [Hang], [Bo_nho], [So_luong]) VALUES (N'MH005', N'SamSung', N'SamSungXS_12', 35000000, NULL, N'n1.jpg', NULL, NULL, N'64GB', 11)
GO
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLap]) VALUES (N'HD001', N'KH001', N'NV02', CAST(N'2023-11-04T00:00:00.000' AS DateTime))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLap]) VALUES (N'HD002', N'KH002', N'NV01', CAST(N'2023-11-03T00:00:00.000' AS DateTime))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLap]) VALUES (N'HD03', N'KH002', N'NV02', CAST(N'2023-11-04T00:00:00.000' AS DateTime))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLap]) VALUES (N'HD04', N'KH004', N'NV02', CAST(N'2023-11-05T00:00:00.000' AS DateTime))
INSERT [dbo].[HOADON] ([MaHD], [MaKH], [MaNV], [NgayLap]) VALUES (N'HD05', N'KH003', N'NV02', CAST(N'2023-11-13T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [SDT], [NgaySInh], [Anh]) VALUES (N'KH001', N'Nguyễn Tiến Hoàng', N'Hà Tây', N'098231212321', CAST(N'2003-04-10' AS Date), NULL)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [SDT], [NgaySInh], [Anh]) VALUES (N'KH002', N'Nguyễn Văn Trường', N'Hà Nội', N'098231212321', CAST(N'2003-04-10' AS Date), NULL)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [SDT], [NgaySInh], [Anh]) VALUES (N'KH003', N'Nguyễn Tiến Long', N'Nghệ An', N'098256412123', CAST(N'2003-10-10' AS Date), NULL)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [SDT], [NgaySInh], [Anh]) VALUES (N'KH004', N'Phạm Ngọc Thạch', N'Bắc Cạn', N'098231212321', CAST(N'2003-04-10' AS Date), NULL)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [SDT], [NgaySInh], [Anh]) VALUES (N'KH005', N'John Alexander', N'American', N'098237867321', CAST(N'2001-04-10' AS Date), NULL)
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [QueQuan], [Gioi Tinh], [SDT], [NgaySinh], [NgayLV], [HSL], [Anh], [MaTK]) VALUES (N'NV01', N'Chu Van Dung', N'Ha Dong', N'Nam', N'0982312321', CAST(N'2003-04-10T00:00:00.000' AS DateTime), CAST(N'2023-10-23T00:00:00.000' AS DateTime), N'3', N'Anh2.jpg', N'TK01')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [QueQuan], [Gioi Tinh], [SDT], [NgaySinh], [NgayLV], [HSL], [Anh], [MaTK]) VALUES (N'NV02', N'Pham Van Linh', N'Bắc Giang', N'Nam', N'0982312321', CAST(N'2003-04-12T00:00:00.000' AS DateTime), CAST(N'2023-10-23T00:00:00.000' AS DateTime), N'1', N'Anh2.jpg', N'TK02')
GO
INSERT [dbo].[TAIKHOAN] ([MaTK], [TenDN], [MatKhau], [Quyen]) VALUES (N'TK01', N'chudung', N'123456', N'Admin')
INSERT [dbo].[TAIKHOAN] ([MaTK], [TenDN], [MatKhau], [Quyen]) VALUES (N'TK02', N'linhca', N'123456', N'User')
INSERT [dbo].[TAIKHOAN] ([MaTK], [TenDN], [MatKhau], [Quyen]) VALUES (N'TK03', N'TruongVu', N'123456789', N'User')
GO
ALTER TABLE [dbo].[CT_HOADON]  WITH CHECK ADD  CONSTRAINT [FK_CT_HOADON_HANGHOA] FOREIGN KEY([MaHH])
REFERENCES [dbo].[HANGHOA] ([MaHH])
GO
ALTER TABLE [dbo].[CT_HOADON] CHECK CONSTRAINT [FK_CT_HOADON_HANGHOA]
GO
ALTER TABLE [dbo].[CT_HOADON]  WITH CHECK ADD  CONSTRAINT [FK_CT_HOADON_HOADON] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHD])
GO
ALTER TABLE [dbo].[CT_HOADON] CHECK CONSTRAINT [FK_CT_HOADON_HOADON]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_KHACHHANG]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_NHANVIEN]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD FOREIGN KEY([MaTK])
REFERENCES [dbo].[TAIKHOAN] ([MaTK])
GO
/****** Object:  StoredProcedure [dbo].[ThemCT_HOADON]    Script Date: 11/13/2023 10:27:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ThemCT_HOADON] @maHD nvarchar(50),@maKH nvarchar(50), @maNV nvarchar(50), @ngay datetime, @maHH nvarchar(50), @sl int
as
begin
	if ((select count(*) from HOADON where MaHD = @maHD) = 0)
	begin
	insert into HOADON values(@maHD,@maKH, @maNV, @ngay)
	end
	insert into CT_HOADON values(@maHD, @maHH, @sl)
end
GO
USE [master]
GO
ALTER DATABASE [QLDienThoai_Csharp] SET  READ_WRITE 
GO
