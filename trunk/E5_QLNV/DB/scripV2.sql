SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ChiTietDuAn]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ChiTietDuAn](
	[MaCT] [int] IDENTITY(1,1) NOT NULL,
	[MaDuAn] [int] NOT NULL,
	[MaNV] [int] NOT NULL CONSTRAINT [DF_ChiTietDuAn_MaCT]  DEFAULT ((0)),
 CONSTRAINT [PK_ChiTietDuAn] PRIMARY KEY CLUSTERED 
(
	[MaCT] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NhanVien]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[HoTenNV] [nvarchar](30) NOT NULL,
	[GioiTinh] [int] NOT NULL,
	[NgaySinh] [datetime] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[MaBangCap] [int] NULL,
	[MaChucVu] [int] NULL,
	[MaQuocTich] [int] NULL,
	[MaBoPhan] [int] NULL CONSTRAINT [DF_NhanVien_MaNV]  DEFAULT ((0)),
	[NgayBatDauLamViec] [datetime] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BangCap]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BangCap](
	[MaBangCap] [int] IDENTITY(1,1) NOT NULL,
	[BangCap] [nvarchar](10) NULL CONSTRAINT [DF_BangCap_MaBangCap]  DEFAULT ((0)),
 CONSTRAINT [PK_BangCap] PRIMARY KEY CLUSTERED 
(
	[MaBangCap] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[QuocTich]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[QuocTich](
	[MaQuocTich] [int] IDENTITY(1,1) NOT NULL,
	[QuocTich] [nvarchar](20) NULL CONSTRAINT [DF_QuocTich_MaQuocTich]  DEFAULT ((0)),
 CONSTRAINT [PK_QuocTich] PRIMARY KEY CLUSTERED 
(
	[MaQuocTich] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BoPhan]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BoPhan](
	[MaBoPhan] [int] IDENTITY(1,1) NOT NULL,
	[BoPhan] [nvarchar](10) NULL CONSTRAINT [DF_BoPhan_MaBoPhan]  DEFAULT ((0)),
 CONSTRAINT [PK_BoPhan] PRIMARY KEY CLUSTERED 
(
	[MaBoPhan] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ChucVu]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ChucVu](
	[MaChucVu] [int] IDENTITY(1,1) NOT NULL,
	[ChucVu] [nvarchar](10) NULL CONSTRAINT [DF_ChucVu_MaChucVu]  DEFAULT ((0)),
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DuAn]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DuAn](
	[MaDuAn] [int] IDENTITY(1,1) NOT NULL,
	[TenDuAn] [nvarchar](100) NULL,
	[ThoiGianBatDau] [smalldatetime] NULL,
	[ThoiGianKetThuc] [smalldatetime] NULL,
	[NgayGiaoSanPham] [smalldatetime] NULL,
	[TenKhachHang] [nvarchar](50) NULL,
	[Gia] [float] NULL CONSTRAINT [DF_DuAn_MaDuAn]  DEFAULT ((0)),
 CONSTRAINT [PK_DuAn] PRIMARY KEY CLUSTERED 
(
	[MaDuAn] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END

/****** Object:  Table [dbo].[ThanhVien]    Script Date: 10/20/2009 19:54:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhVien](
	[MaUser] [nvarchar](10)  NOT NULL,
	[PassWord] [nvarchar](20) NOT NULL CONSTRAINT [DF_User_MaUser]  DEFAULT ((0)),
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[MaUser] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


select * from ChucVu
insert into ChucVu (ChucVu) values ('GiamDoc')

select * from BangCap

insert into BangCap (BangCap) values ('Dai Hoc')

select * from ThanhVien
insert into ThanhVien(MaUser,PassWord) values ('admin','admin')
select * from ThanhVien where MaUser = 'admin' and PassWord = 'admin'