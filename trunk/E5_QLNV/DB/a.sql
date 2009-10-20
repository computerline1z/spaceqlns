USE [QLNV]
GO
/****** Object:  Table [dbo].[QuocTich]    Script Date: 10/20/2009 19:57:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuocTich](
	[MaQuocTich] [int] NOT NULL,
	[QuocTich] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 10/20/2009 19:57:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] NOT NULL,
	[HoTenNV] [nvarchar](30) NOT NULL,
	[GioiTinh] [int] NOT NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[MaBangCap] [int] NULL,
	[MaChucVu] [int] NULL,
	[MaQuocTich] [int] NULL,
	[MaBoPhan] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DuAn]    Script Date: 10/20/2009 19:57:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DuAn](
	[MaDuAn] [int] NOT NULL,
	[TenDuAn] [nvarchar](100) NULL,
	[ThoiGianBatDau] [smalldatetime] NULL,
	[ThoiGianKetThuc] [smalldatetime] NULL,
	[NgayGiaoSanPham] [smalldatetime] NULL,
	[TenKhachHang] [nvarchar](50) NULL,
	[Gia] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 10/20/2009 19:57:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaChucVu] [int] NOT NULL,
	[ChucVu] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietDuAn]    Script Date: 10/20/2009 19:57:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDuAn](
	[MaCT] [int] NOT NULL,
	[MaDuAn] [int] NOT NULL,
	[MaNV] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BoPhan]    Script Date: 10/20/2009 19:57:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BoPhan](
	[MaBoPhan] [int] NOT NULL,
	[BoPhan] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BangCap]    Script Date: 10/20/2009 19:57:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangCap](
	[MaBangCap] [int] NOT NULL,
	[BangCap] [nvarchar](10) NULL
) ON [PRIMARY]
GO
