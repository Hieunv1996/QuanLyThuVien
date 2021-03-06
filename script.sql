USE [master]
GO
/****** Object:  Database [QLTV]    Script Date: 12/25/2016 01:08:47 PM ******/
CREATE DATABASE [QLTV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLTV', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\QLTV.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLTV_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\QLTV_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLTV] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLTV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLTV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLTV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLTV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLTV] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QLTV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLTV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLTV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLTV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLTV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLTV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLTV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLTV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLTV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLTV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLTV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLTV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLTV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLTV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLTV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLTV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLTV] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLTV] SET  MULTI_USER 
GO
ALTER DATABASE [QLTV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLTV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLTV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLTV] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QLTV]
GO
/****** Object:  Table [dbo].[tb_CTPM]    Script Date: 12/25/2016 01:08:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_CTPM](
	[maCTPM] [nvarchar](50) NOT NULL,
	[maPM] [nvarchar](50) NOT NULL,
	[maSach] [nvarchar](50) NOT NULL,
	[ngayTra] [date] NOT NULL,
	[tienCoc] [bigint] NOT NULL,
 CONSTRAINT [PK_tb_CTPM] PRIMARY KEY CLUSTERED 
(
	[maCTPM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_CTPT]    Script Date: 12/25/2016 01:08:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_CTPT](
	[maCTPT] [nvarchar](50) NOT NULL,
	[maPT] [nvarchar](50) NOT NULL,
	[maSach] [nvarchar](50) NOT NULL,
	[thanhTien] [bigint] NOT NULL,
 CONSTRAINT [PK_tb_CTPT] PRIMARY KEY CLUSTERED 
(
	[maCTPT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_DocGia]    Script Date: 12/25/2016 01:08:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_DocGia](
	[maDocGia] [nvarchar](50) NOT NULL,
	[tenDocGia] [ntext] NOT NULL,
	[email] [ntext] NOT NULL,
	[dienThoai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tb_DocGia] PRIMARY KEY CLUSTERED 
(
	[maDocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_LoaiSach]    Script Date: 12/25/2016 01:08:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_LoaiSach](
	[maLoaiSach] [nvarchar](50) NOT NULL,
	[tenLoaiSach] [ntext] NOT NULL,
	[moTa] [ntext] NULL,
 CONSTRAINT [PK_tb_LoaiSach] PRIMARY KEY CLUSTERED 
(
	[maLoaiSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_NguoiDung]    Script Date: 12/25/2016 01:08:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_NguoiDung](
	[taiKhoan] [nvarchar](50) NOT NULL,
	[matKhau] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tb_NguuoiDung] PRIMARY KEY CLUSTERED 
(
	[taiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_PhieuMuon]    Script Date: 12/25/2016 01:08:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_PhieuMuon](
	[maPM] [nvarchar](50) NOT NULL,
	[maDocGia] [nvarchar](50) NOT NULL,
	[ngayMuon] [date] NOT NULL,
	[thanhTien] [bigint] NOT NULL,
 CONSTRAINT [PK_tb_PhieuMuon] PRIMARY KEY CLUSTERED 
(
	[maPM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_PhieuTra]    Script Date: 12/25/2016 01:08:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_PhieuTra](
	[maPT] [nvarchar](50) NOT NULL,
	[maDocGia] [nvarchar](50) NOT NULL,
	[ngayTra] [date] NOT NULL,
	[thanhTien] [bigint] NOT NULL,
 CONSTRAINT [PK_tb_PhieuTra] PRIMARY KEY CLUSTERED 
(
	[maPT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_Sach]    Script Date: 12/25/2016 01:08:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Sach](
	[maSach] [nvarchar](50) NOT NULL,
	[tieuDe] [ntext] NOT NULL,
	[giaBia] [bigint] NOT NULL,
	[tacGia] [ntext] NOT NULL,
	[namXuatBan] [int] NOT NULL,
	[soLuongTon] [int] NOT NULL,
	[maLoaiSach] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tb_Sach] PRIMARY KEY CLUSTERED 
(
	[maSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  View [dbo].[vw_SachView]    Script Date: 12/25/2016 01:08:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[vw_SachView]
as
select maSach, tieuDe,[giaBia],[tacGia],[namXuatBan],[soLuongTon],
(select tenLoaiSach from [dbo].[tb_LoaiSach] where tb_Sach.maLoaiSach = tb_LoaiSach.maLoaiSach) as 'LoaiSach'
from tb_Sach
GO
INSERT [dbo].[tb_CTPT] ([maCTPT], [maPT], [maSach], [thanhTien]) VALUES (N'CTPT1', N'PT1', N'TCC1', 50000)
INSERT [dbo].[tb_CTPT] ([maCTPT], [maPT], [maSach], [thanhTien]) VALUES (N'CTPT10', N'PT4', N'TCC1', -5000)
INSERT [dbo].[tb_CTPT] ([maCTPT], [maPT], [maSach], [thanhTien]) VALUES (N'CTPT11', N'PT4', N'TTNT', 0)
INSERT [dbo].[tb_CTPT] ([maCTPT], [maPT], [maSach], [thanhTien]) VALUES (N'CTPT12', N'PT5', N'LTC#', 1000)
INSERT [dbo].[tb_CTPT] ([maCTPT], [maPT], [maSach], [thanhTien]) VALUES (N'CTPT13', N'PT6', N'NMTH', 0)
INSERT [dbo].[tb_CTPT] ([maCTPT], [maPT], [maSach], [thanhTien]) VALUES (N'CTPT14', N'PT7', N'TCC1', -9000)
INSERT [dbo].[tb_CTPT] ([maCTPT], [maPT], [maSach], [thanhTien]) VALUES (N'CTPT15', N'PT7', N'TCC2', 0)
INSERT [dbo].[tb_CTPT] ([maCTPT], [maPT], [maSach], [thanhTien]) VALUES (N'CTPT2', N'PT2', N'NMTH', 0)
INSERT [dbo].[tb_CTPT] ([maCTPT], [maPT], [maSach], [thanhTien]) VALUES (N'CTPT3', N'PT2', N'LTC#', 74000)
INSERT [dbo].[tb_CTPT] ([maCTPT], [maPT], [maSach], [thanhTien]) VALUES (N'CTPT4', N'PT3', N'LTC#', 0)
INSERT [dbo].[tb_CTPT] ([maCTPT], [maPT], [maSach], [thanhTien]) VALUES (N'CTPT5', N'PT3', N'NMTH', 0)
INSERT [dbo].[tb_CTPT] ([maCTPT], [maPT], [maSach], [thanhTien]) VALUES (N'CTPT6', N'PT3', N'TCC2', 0)
INSERT [dbo].[tb_CTPT] ([maCTPT], [maPT], [maSach], [thanhTien]) VALUES (N'CTPT7', N'PT3', N'TTNT', 0)
INSERT [dbo].[tb_CTPT] ([maCTPT], [maPT], [maSach], [thanhTien]) VALUES (N'CTPT8', N'PT4', N'TCC1', 234000)
INSERT [dbo].[tb_CTPT] ([maCTPT], [maPT], [maSach], [thanhTien]) VALUES (N'CTPT9', N'PT4', N'NMTH', -1000)
INSERT [dbo].[tb_DocGia] ([maDocGia], [tenDocGia], [email], [dienThoai]) VALUES (N'NTVG', N'Nguyễn Thị Vân Giang', N'gianvan1997@gmail.com', N'0978456185')
INSERT [dbo].[tb_DocGia] ([maDocGia], [tenDocGia], [email], [dienThoai]) VALUES (N'NVH', N'Nguyễn Văn Hiếu', N'vanhieu2910@gmail.com', N'01649346164')
INSERT [dbo].[tb_DocGia] ([maDocGia], [tenDocGia], [email], [dienThoai]) VALUES (N'NVH1', N'Nguyễn Văn Hồng', N'vietnamvodoi96vt@gmail.com', N'0167954654')
INSERT [dbo].[tb_DocGia] ([maDocGia], [tenDocGia], [email], [dienThoai]) VALUES (N'PXD', N'Phạm Xuân Duy', N'campha10x@gmail.com', N'0975842456')
INSERT [dbo].[tb_LoaiSach] ([maLoaiSach], [tenLoaiSach], [moTa]) VALUES (N'COKHI', N'Cơ khí', N'Cơ khí')
INSERT [dbo].[tb_LoaiSach] ([maLoaiSach], [tenLoaiSach], [moTa]) VALUES (N'DIEN', N'Điện', N'Điện')
INSERT [dbo].[tb_LoaiSach] ([maLoaiSach], [tenLoaiSach], [moTa]) VALUES (N'TINHOC', N'Tin học', N'Tin học')
INSERT [dbo].[tb_LoaiSach] ([maLoaiSach], [tenLoaiSach], [moTa]) VALUES (N'TOAN', N'Toán', N'Toán')
INSERT [dbo].[tb_NguoiDung] ([taiKhoan], [matKhau]) VALUES (N'admin', N'admin')
INSERT [dbo].[tb_PhieuTra] ([maPT], [maDocGia], [ngayTra], [thanhTien]) VALUES (N'PT1', N'NVH', CAST(0xF83B0B00 AS Date), 50000)
INSERT [dbo].[tb_PhieuTra] ([maPT], [maDocGia], [ngayTra], [thanhTien]) VALUES (N'PT2', N'PXD', CAST(0x3F3C0B00 AS Date), 74000)
INSERT [dbo].[tb_PhieuTra] ([maPT], [maDocGia], [ngayTra], [thanhTien]) VALUES (N'PT3', N'PXD', CAST(0x3F3C0B00 AS Date), 0)
INSERT [dbo].[tb_PhieuTra] ([maPT], [maDocGia], [ngayTra], [thanhTien]) VALUES (N'PT4', N'NVH', CAST(0x423C0B00 AS Date), 228000)
INSERT [dbo].[tb_PhieuTra] ([maPT], [maDocGia], [ngayTra], [thanhTien]) VALUES (N'PT5', N'PXD', CAST(0x423C0B00 AS Date), 1000)
INSERT [dbo].[tb_PhieuTra] ([maPT], [maDocGia], [ngayTra], [thanhTien]) VALUES (N'PT6', N'NVH', CAST(0x423C0B00 AS Date), 0)
INSERT [dbo].[tb_PhieuTra] ([maPT], [maDocGia], [ngayTra], [thanhTien]) VALUES (N'PT7', N'PXD', CAST(0x423C0B00 AS Date), -9000)
INSERT [dbo].[tb_Sach] ([maSach], [tieuDe], [giaBia], [tacGia], [namXuatBan], [soLuongTon], [maLoaiSach]) VALUES (N'LTC#', N'Lập trình C#', 80000, N'Nguyễn Văn Hiếu', 2016, 180004, N'TINHOC')
INSERT [dbo].[tb_Sach] ([maSach], [tieuDe], [giaBia], [tacGia], [namXuatBan], [soLuongTon], [maLoaiSach]) VALUES (N'NMTH', N'Nhập môn tin học', 15000, N'Nguyễn Văn Hiếu', 2000, 50005, N'TINHOC')
INSERT [dbo].[tb_Sach] ([maSach], [tieuDe], [giaBia], [tacGia], [namXuatBan], [soLuongTon], [maLoaiSach]) VALUES (N'TCC1', N'Toán cao cấp 1', 15000, N'Nguyễn Văn Minh', 1996, 152556, N'TOAN')
INSERT [dbo].[tb_Sach] ([maSach], [tieuDe], [giaBia], [tacGia], [namXuatBan], [soLuongTon], [maLoaiSach]) VALUES (N'TCC2', N'Toán cao cấp 2', 18000, N'Nguyễn Trần Minh', 1997, 154446, N'TOAN')
INSERT [dbo].[tb_Sach] ([maSach], [tieuDe], [giaBia], [tacGia], [namXuatBan], [soLuongTon], [maLoaiSach]) VALUES (N'TTNT', N'Trí tuệ nhân tạo', 58000, N'Nguyễn Văn Hồng', 2015, 144446, N'TINHOC')
ALTER TABLE [dbo].[tb_CTPM]  WITH CHECK ADD  CONSTRAINT [FK_tb_CTPM_tb_PhieuMuon1] FOREIGN KEY([maPM])
REFERENCES [dbo].[tb_PhieuMuon] ([maPM])
GO
ALTER TABLE [dbo].[tb_CTPM] CHECK CONSTRAINT [FK_tb_CTPM_tb_PhieuMuon1]
GO
ALTER TABLE [dbo].[tb_CTPM]  WITH CHECK ADD  CONSTRAINT [FK_tb_CTPM_tb_Sach] FOREIGN KEY([maSach])
REFERENCES [dbo].[tb_Sach] ([maSach])
GO
ALTER TABLE [dbo].[tb_CTPM] CHECK CONSTRAINT [FK_tb_CTPM_tb_Sach]
GO
ALTER TABLE [dbo].[tb_CTPT]  WITH CHECK ADD  CONSTRAINT [FK_tb_CTPT_tb_PhieuTra] FOREIGN KEY([maPT])
REFERENCES [dbo].[tb_PhieuTra] ([maPT])
GO
ALTER TABLE [dbo].[tb_CTPT] CHECK CONSTRAINT [FK_tb_CTPT_tb_PhieuTra]
GO
ALTER TABLE [dbo].[tb_CTPT]  WITH CHECK ADD  CONSTRAINT [FK_tb_CTPT_tb_Sach] FOREIGN KEY([maSach])
REFERENCES [dbo].[tb_Sach] ([maSach])
GO
ALTER TABLE [dbo].[tb_CTPT] CHECK CONSTRAINT [FK_tb_CTPT_tb_Sach]
GO
ALTER TABLE [dbo].[tb_PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_tb_PhieuMuon_tb_DocGia] FOREIGN KEY([maDocGia])
REFERENCES [dbo].[tb_DocGia] ([maDocGia])
GO
ALTER TABLE [dbo].[tb_PhieuMuon] CHECK CONSTRAINT [FK_tb_PhieuMuon_tb_DocGia]
GO
ALTER TABLE [dbo].[tb_PhieuTra]  WITH CHECK ADD  CONSTRAINT [FK_tb_PhieuTra_tb_DocGia] FOREIGN KEY([maDocGia])
REFERENCES [dbo].[tb_DocGia] ([maDocGia])
GO
ALTER TABLE [dbo].[tb_PhieuTra] CHECK CONSTRAINT [FK_tb_PhieuTra_tb_DocGia]
GO
ALTER TABLE [dbo].[tb_Sach]  WITH CHECK ADD  CONSTRAINT [FK_tb_Sach_tb_LoaiSach] FOREIGN KEY([maLoaiSach])
REFERENCES [dbo].[tb_LoaiSach] ([maLoaiSach])
GO
ALTER TABLE [dbo].[tb_Sach] CHECK CONSTRAINT [FK_tb_Sach_tb_LoaiSach]
GO
USE [master]
GO
ALTER DATABASE [QLTV] SET  READ_WRITE 
GO
