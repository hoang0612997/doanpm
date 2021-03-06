USE [master]
GO
/****** Object:  Database [QL_SimThe]    Script Date: 9/5/2021 6:27:13 PM ******/
CREATE DATABASE [QL_SimThe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QL_SimThe', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER01\MSSQL\DATA\QL_SimThe.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QL_SimThe_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER01\MSSQL\DATA\QL_SimThe_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QL_SimThe] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_SimThe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_SimThe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_SimThe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_SimThe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_SimThe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_SimThe] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_SimThe] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QL_SimThe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_SimThe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_SimThe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_SimThe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_SimThe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_SimThe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_SimThe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_SimThe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_SimThe] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QL_SimThe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_SimThe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_SimThe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_SimThe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_SimThe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_SimThe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_SimThe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_SimThe] SET RECOVERY FULL 
GO
ALTER DATABASE [QL_SimThe] SET  MULTI_USER 
GO
ALTER DATABASE [QL_SimThe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_SimThe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_SimThe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_SimThe] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QL_SimThe] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QL_SimThe] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QL_SimThe', N'ON'
GO
ALTER DATABASE [QL_SimThe] SET QUERY_STORE = OFF
GO
USE [QL_SimThe]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 9/5/2021 6:27:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[Makh] [varchar](50) NOT NULL,
	[Tenkh] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDienThoai] [varchar](10) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[Makh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MuaBanSim]    Script Date: 9/5/2021 6:27:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MuaBanSim](
	[Makh] [varchar](50) NOT NULL,
	[MaS] [varchar](50) NOT NULL,
	[NgayMuaBan] [date] NULL,
 CONSTRAINT [PK_MuaBanSim] PRIMARY KEY CLUSTERED 
(
	[Makh] ASC,
	[MaS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MuaBanThe]    Script Date: 9/5/2021 6:27:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MuaBanThe](
	[Makh] [varchar](50) NOT NULL,
	[MaThe] [varchar](50) NOT NULL,
	[NgayMuaBan] [date] NULL,
	[SoLuong] [numeric](18, 0) NULL,
 CONSTRAINT [PK_MuaBanThe] PRIMARY KEY CLUSTERED 
(
	[Makh] ASC,
	[MaThe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaMang_KM]    Script Date: 9/5/2021 6:27:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaMang_KM](
	[TenNhaMang] [nvarchar](50) NOT NULL,
	[CTKM] [nvarchar](200) NULL,
 CONSTRAINT [PK_NhaMang_KM] PRIMARY KEY CLUSTERED 
(
	[TenNhaMang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sim]    Script Date: 9/5/2021 6:27:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sim](
	[MaS] [varchar](50) NOT NULL,
	[TenNhaMang] [nvarchar](50) NOT NULL,
	[NgayKichHoat] [date] NULL,
	[SoSim] [varchar](10) NULL,
	[LoaiSim] [nvarchar](50) NULL,
	[GiaSim] [numeric](18, 0) NULL,
	[TinhTrang] [nvarchar](10) NULL,
	[GiaNhap] [numeric](18, 0) NULL,
 CONSTRAINT [PK_Sim_1] PRIMARY KEY CLUSTERED 
(
	[MaS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[taikhoan]    Script Date: 9/5/2021 6:27:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[taikhoan](
	[taikhoan] [nchar](50) NOT NULL,
	[matkhau] [nchar](50) NULL,
 CONSTRAINT [PK_taikhoan] PRIMARY KEY CLUSTERED 
(
	[taikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[The]    Script Date: 9/5/2021 6:27:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[The](
	[MaThe] [varchar](50) NOT NULL,
	[TenNhaMang] [nvarchar](50) NOT NULL,
	[MenhGia] [numeric](18, 0) NULL,
	[SoLuong] [numeric](18, 0) NULL,
	[GiaNhap] [numeric](18, 0) NULL,
 CONSTRAINT [PK_The_1] PRIMARY KEY CLUSTERED 
(
	[MaThe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[KhachHang] ([Makh], [Tenkh], [DiaChi], [SoDienThoai]) VALUES (N'KH01', N'Phạm Huy Hoàng', N'Thái Bình', N'0982305030')
INSERT [dbo].[KhachHang] ([Makh], [Tenkh], [DiaChi], [SoDienThoai]) VALUES (N'KH02', N'Lê Đức Anh', N'Nam Định', N'0123456789')
INSERT [dbo].[KhachHang] ([Makh], [Tenkh], [DiaChi], [SoDienThoai]) VALUES (N'KH03', N'Nguyễn Tuấn Anh', N'Hà Nam', N'0123789456')
INSERT [dbo].[KhachHang] ([Makh], [Tenkh], [DiaChi], [SoDienThoai]) VALUES (N'KH04', N'Nguyễn Lương Hiếu', N'Thái Bình', N'0234567891')
INSERT [dbo].[KhachHang] ([Makh], [Tenkh], [DiaChi], [SoDienThoai]) VALUES (N'KH05', N'Phạm Thị Thảo', N'Thái Bình', N'0123548567')
INSERT [dbo].[KhachHang] ([Makh], [Tenkh], [DiaChi], [SoDienThoai]) VALUES (N'KH07', N'Hoàng Thị Hiền', N'Thái Bình', N'0976001385')
INSERT [dbo].[KhachHang] ([Makh], [Tenkh], [DiaChi], [SoDienThoai]) VALUES (N'KH08', N'Phạm Thị Hương', N'Thái Bình', N'0345678912')
INSERT [dbo].[KhachHang] ([Makh], [Tenkh], [DiaChi], [SoDienThoai]) VALUES (N'KH09', N'Phạm Thị Khánh Huyền', N'Quảng Bình', N'0784091998')
INSERT [dbo].[KhachHang] ([Makh], [Tenkh], [DiaChi], [SoDienThoai]) VALUES (N'KH10', N'Nguyễn Văn A', N'Hà Nội', N'0987654321')
GO
INSERT [dbo].[MuaBanSim] ([Makh], [MaS], [NgayMuaBan]) VALUES (N'KH01', N'MBP258745', CAST(N'2020-10-31' AS Date))
INSERT [dbo].[MuaBanSim] ([Makh], [MaS], [NgayMuaBan]) VALUES (N'KH02', N'SIM324585', CAST(N'2020-11-01' AS Date))
INSERT [dbo].[MuaBanSim] ([Makh], [MaS], [NgayMuaBan]) VALUES (N'KH04', N'MBP258746', CAST(N'2020-11-06' AS Date))
INSERT [dbo].[MuaBanSim] ([Makh], [MaS], [NgayMuaBan]) VALUES (N'KH05', N'MBP258747', CAST(N'2020-01-01' AS Date))
INSERT [dbo].[MuaBanSim] ([Makh], [MaS], [NgayMuaBan]) VALUES (N'KH08', N'VNP11255', CAST(N'2020-11-06' AS Date))
GO
INSERT [dbo].[MuaBanThe] ([Makh], [MaThe], [NgayMuaBan], [SoLuong]) VALUES (N'KH01', N'MB100', CAST(N'2020-10-22' AS Date), CAST(2 AS Numeric(18, 0)))
INSERT [dbo].[MuaBanThe] ([Makh], [MaThe], [NgayMuaBan], [SoLuong]) VALUES (N'KH01', N'MB50', CAST(N'2020-11-05' AS Date), CAST(3 AS Numeric(18, 0)))
INSERT [dbo].[MuaBanThe] ([Makh], [MaThe], [NgayMuaBan], [SoLuong]) VALUES (N'KH01', N'VT100', CAST(N'2020-10-25' AS Date), CAST(4 AS Numeric(18, 0)))
INSERT [dbo].[MuaBanThe] ([Makh], [MaThe], [NgayMuaBan], [SoLuong]) VALUES (N'KH02', N'VT100', CAST(N'2020-10-12' AS Date), CAST(2 AS Numeric(18, 0)))
INSERT [dbo].[MuaBanThe] ([Makh], [MaThe], [NgayMuaBan], [SoLuong]) VALUES (N'KH03', N'VN100', CAST(N'2020-10-25' AS Date), CAST(10 AS Numeric(18, 0)))
INSERT [dbo].[MuaBanThe] ([Makh], [MaThe], [NgayMuaBan], [SoLuong]) VALUES (N'KH03', N'VN50', CAST(N'2020-11-06' AS Date), CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[MuaBanThe] ([Makh], [MaThe], [NgayMuaBan], [SoLuong]) VALUES (N'KH04', N'MB100', CAST(N'2020-11-11' AS Date), CAST(12 AS Numeric(18, 0)))
INSERT [dbo].[MuaBanThe] ([Makh], [MaThe], [NgayMuaBan], [SoLuong]) VALUES (N'KH05', N'VN100', CAST(N'2020-11-05' AS Date), CAST(3 AS Numeric(18, 0)))
INSERT [dbo].[MuaBanThe] ([Makh], [MaThe], [NgayMuaBan], [SoLuong]) VALUES (N'KH07', N'MB100', CAST(N'2020-11-11' AS Date), CAST(2 AS Numeric(18, 0)))
INSERT [dbo].[MuaBanThe] ([Makh], [MaThe], [NgayMuaBan], [SoLuong]) VALUES (N'KH07', N'VT100', CAST(N'2020-11-01' AS Date), CAST(1 AS Numeric(18, 0)))
GO
INSERT [dbo].[NhaMang_KM] ([TenNhaMang], [CTKM]) VALUES (N'Mobiphone', N'Nạp lần đầu tặng 100% giá trị thẻ nạp')
INSERT [dbo].[NhaMang_KM] ([TenNhaMang], [CTKM]) VALUES (N'Viettel', N'Ngày đầu của tháng tặng 20% giá trị thẻ nạp')
INSERT [dbo].[NhaMang_KM] ([TenNhaMang], [CTKM]) VALUES (N'Vinaphone', N'Ngày đầu của tháng tặng 20% giá trị thẻ nạp')
GO
INSERT [dbo].[Sim] ([MaS], [TenNhaMang], [NgayKichHoat], [SoSim], [LoaiSim], [GiaSim], [TinhTrang], [GiaNhap]) VALUES (N'MBP258745', N'Mobiphone', CAST(N'2020-09-30' AS Date), N'0901986035', N'Sim Thường', CAST(90000 AS Numeric(18, 0)), N'Đã bán', CAST(70000 AS Numeric(18, 0)))
INSERT [dbo].[Sim] ([MaS], [TenNhaMang], [NgayKichHoat], [SoSim], [LoaiSim], [GiaSim], [TinhTrang], [GiaNhap]) VALUES (N'MBP258746', N'Mobiphone', CAST(N'2020-10-31' AS Date), N'0901844777', N'Sim Tam Hoa', CAST(1290000 AS Numeric(18, 0)), N'Đã bán', CAST(1050000 AS Numeric(18, 0)))
INSERT [dbo].[Sim] ([MaS], [TenNhaMang], [NgayKichHoat], [SoSim], [LoaiSim], [GiaSim], [TinhTrang], [GiaNhap]) VALUES (N'MBP258747', N'Mobiphone', CAST(N'2020-10-31' AS Date), N'0901844888', N'Sim Tam Hoa', CAST(5400000 AS Numeric(18, 0)), N'Đã bán', CAST(4870000 AS Numeric(18, 0)))
INSERT [dbo].[Sim] ([MaS], [TenNhaMang], [NgayKichHoat], [SoSim], [LoaiSim], [GiaSim], [TinhTrang], [GiaNhap]) VALUES (N'SIM316865', N'Viettel', CAST(N'2020-10-25' AS Date), N'0984887232', N'Sim Thường', CAST(150000 AS Numeric(18, 0)), N'Còn hàng', CAST(120000 AS Numeric(18, 0)))
INSERT [dbo].[Sim] ([MaS], [TenNhaMang], [NgayKichHoat], [SoSim], [LoaiSim], [GiaSim], [TinhTrang], [GiaNhap]) VALUES (N'SIM324585', N'Viettel', CAST(N'2020-10-15' AS Date), N'0868908999', N'Sim Tam Hoa', CAST(4500000 AS Numeric(18, 0)), N'Đã bán', CAST(4000000 AS Numeric(18, 0)))
INSERT [dbo].[Sim] ([MaS], [TenNhaMang], [NgayKichHoat], [SoSim], [LoaiSim], [GiaSim], [TinhTrang], [GiaNhap]) VALUES (N'SIM325678', N'Viettel', CAST(N'2020-11-02' AS Date), N'0984001601', N'Sim Đẹp', CAST(850000 AS Numeric(18, 0)), N'Còn hàng', CAST(690000 AS Numeric(18, 0)))
INSERT [dbo].[Sim] ([MaS], [TenNhaMang], [NgayKichHoat], [SoSim], [LoaiSim], [GiaSim], [TinhTrang], [GiaNhap]) VALUES (N'SIM325685', N'Viettel', CAST(N'2020-10-21' AS Date), N'0389639999', N'Sim Tứ Quý', CAST(254000000 AS Numeric(18, 0)), N'Còn hàng', CAST(216000000 AS Numeric(18, 0)))
INSERT [dbo].[Sim] ([MaS], [TenNhaMang], [NgayKichHoat], [SoSim], [LoaiSim], [GiaSim], [TinhTrang], [GiaNhap]) VALUES (N'VNP11254', N'Vinaphone', CAST(N'2020-10-22' AS Date), N'0911748066', N'Sim Thường', CAST(200000 AS Numeric(18, 0)), N'Còn hàng', CAST(165000 AS Numeric(18, 0)))
INSERT [dbo].[Sim] ([MaS], [TenNhaMang], [NgayKichHoat], [SoSim], [LoaiSim], [GiaSim], [TinhTrang], [GiaNhap]) VALUES (N'VNP11255', N'Vinaphone', CAST(N'2020-10-18' AS Date), N'0858899999', N'Sim Ngũ Qúy', CAST(1245000000 AS Numeric(18, 0)), N'Đã bán', CAST(1125000000 AS Numeric(18, 0)))
GO
INSERT [dbo].[taikhoan] ([taikhoan], [matkhau]) VALUES (N'admin                                             ', N'123456                                            ')
INSERT [dbo].[taikhoan] ([taikhoan], [matkhau]) VALUES (N'huyhoang                                          ', N'061297                                            ')
GO
INSERT [dbo].[The] ([MaThe], [TenNhaMang], [MenhGia], [SoLuong], [GiaNhap]) VALUES (N'MB100', N'Mobiphone', CAST(100000 AS Numeric(18, 0)), CAST(15 AS Numeric(18, 0)), CAST(93500 AS Numeric(18, 0)))
INSERT [dbo].[The] ([MaThe], [TenNhaMang], [MenhGia], [SoLuong], [GiaNhap]) VALUES (N'MB50', N'Mobiphone', CAST(50000 AS Numeric(18, 0)), CAST(16 AS Numeric(18, 0)), CAST(46000 AS Numeric(18, 0)))
INSERT [dbo].[The] ([MaThe], [TenNhaMang], [MenhGia], [SoLuong], [GiaNhap]) VALUES (N'VN100', N'Vinaphone', CAST(100000 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), CAST(93500 AS Numeric(18, 0)))
INSERT [dbo].[The] ([MaThe], [TenNhaMang], [MenhGia], [SoLuong], [GiaNhap]) VALUES (N'VN20', N'Vinaphone', CAST(20000 AS Numeric(18, 0)), CAST(20 AS Numeric(18, 0)), CAST(17600 AS Numeric(18, 0)))
INSERT [dbo].[The] ([MaThe], [TenNhaMang], [MenhGia], [SoLuong], [GiaNhap]) VALUES (N'VN50', N'Vinaphone', CAST(50000 AS Numeric(18, 0)), CAST(18 AS Numeric(18, 0)), CAST(46000 AS Numeric(18, 0)))
INSERT [dbo].[The] ([MaThe], [TenNhaMang], [MenhGia], [SoLuong], [GiaNhap]) VALUES (N'VT100', N'Viettel', CAST(100000 AS Numeric(18, 0)), CAST(13 AS Numeric(18, 0)), CAST(93500 AS Numeric(18, 0)))
INSERT [dbo].[The] ([MaThe], [TenNhaMang], [MenhGia], [SoLuong], [GiaNhap]) VALUES (N'VT20', N'Viettel', CAST(20000 AS Numeric(18, 0)), CAST(23 AS Numeric(18, 0)), CAST(17600 AS Numeric(18, 0)))
INSERT [dbo].[The] ([MaThe], [TenNhaMang], [MenhGia], [SoLuong], [GiaNhap]) VALUES (N'VT50', N'Viettel', CAST(50000 AS Numeric(18, 0)), CAST(13 AS Numeric(18, 0)), CAST(46000 AS Numeric(18, 0)))
GO
ALTER TABLE [dbo].[MuaBanSim]  WITH CHECK ADD  CONSTRAINT [FK_MuaBanSim_KhachHang] FOREIGN KEY([Makh])
REFERENCES [dbo].[KhachHang] ([Makh])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MuaBanSim] CHECK CONSTRAINT [FK_MuaBanSim_KhachHang]
GO
ALTER TABLE [dbo].[MuaBanSim]  WITH CHECK ADD  CONSTRAINT [FK_MuaBanSim_Sim1] FOREIGN KEY([MaS])
REFERENCES [dbo].[Sim] ([MaS])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MuaBanSim] CHECK CONSTRAINT [FK_MuaBanSim_Sim1]
GO
ALTER TABLE [dbo].[MuaBanThe]  WITH CHECK ADD  CONSTRAINT [FK_MuaBanThe_KhachHang] FOREIGN KEY([Makh])
REFERENCES [dbo].[KhachHang] ([Makh])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MuaBanThe] CHECK CONSTRAINT [FK_MuaBanThe_KhachHang]
GO
ALTER TABLE [dbo].[MuaBanThe]  WITH CHECK ADD  CONSTRAINT [FK_MuaBanThe_The1] FOREIGN KEY([MaThe])
REFERENCES [dbo].[The] ([MaThe])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MuaBanThe] CHECK CONSTRAINT [FK_MuaBanThe_The1]
GO
ALTER TABLE [dbo].[Sim]  WITH CHECK ADD  CONSTRAINT [FK_Sim_NhaMang_KM] FOREIGN KEY([TenNhaMang])
REFERENCES [dbo].[NhaMang_KM] ([TenNhaMang])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sim] CHECK CONSTRAINT [FK_Sim_NhaMang_KM]
GO
ALTER TABLE [dbo].[The]  WITH CHECK ADD  CONSTRAINT [FK_The_NhaMang_KM] FOREIGN KEY([TenNhaMang])
REFERENCES [dbo].[NhaMang_KM] ([TenNhaMang])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[The] CHECK CONSTRAINT [FK_The_NhaMang_KM]
GO
USE [master]
GO
ALTER DATABASE [QL_SimThe] SET  READ_WRITE 
GO
