USE [FlowerShop]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 11/24/2018 6:44:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[MaNV] [nvarchar](50) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[TaiKhoan] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](50) NULL,
	[QuyenSuDung] [int] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PayCheck Details]    Script Date: 11/24/2018 6:44:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PayCheck Details](
	[MaHD] [nvarchar](50) NOT NULL,
	[MaHH] [varchar](50) NOT NULL,
	[TenHH] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [int] NULL,
 CONSTRAINT [PK_PayCheck Details] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PayCheckk]    Script Date: 11/24/2018 6:44:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PayCheckk](
	[MaHD] [nvarchar](50) NOT NULL,
	[NgayThanhToan] [date] NULL,
	[TenKH] [nvarchar](50) NULL,
	[ThanhTien] [int] NULL,
	[MaNV] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PayCheckk] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 11/24/2018 6:44:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[MaHH] [varchar](50) NOT NULL,
	[TenHH] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
	[MaNCC] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Shop Details]    Script Date: 11/24/2018 6:44:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shop Details](
	[TenShop] [nvarchar](50) NOT NULL,
	[SDT] [nchar](10) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Website] [nvarchar](50) NULL,
 CONSTRAINT [PK_Shop Details] PRIMARY KEY CLUSTERED 
(
	[TenShop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 11/24/2018 6:44:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Supplier](
	[MaNCC] [varchar](50) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[Website] [nvarchar](100) NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Employee] ([MaNV], [TenNV], [TaiKhoan], [MatKhau], [QuyenSuDung]) VALUES (N'E001', N'Nguyễn Văn Tri', N'admin01', N'123', 2)
GO
INSERT [dbo].[Employee] ([MaNV], [TenNV], [TaiKhoan], [MatKhau], [QuyenSuDung]) VALUES (N'E002', N'Lê Lợi', N'admin02', N'111', 1)
GO
INSERT [dbo].[Employee] ([MaNV], [TenNV], [TaiKhoan], [MatKhau], [QuyenSuDung]) VALUES (N'E003', N'Vũ Thị Ba', N'admin03', N'222', 1)
GO
INSERT [dbo].[Employee] ([MaNV], [TenNV], [TaiKhoan], [MatKhau], [QuyenSuDung]) VALUES (N'E004', N'Trịnh Trung', N'admin04', N'333', 1)
GO
INSERT [dbo].[Employee] ([MaNV], [TenNV], [TaiKhoan], [MatKhau], [QuyenSuDung]) VALUES (N'E005', N'Tâm Bông', N'emp2', N'444', 1)
GO
INSERT [dbo].[PayCheck Details] ([MaHD], [MaHH], [TenHH], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HD01', N'LASPEC', N'Bằng Lăng', 100000, 2, 200000)
GO
INSERT [dbo].[PayCheck Details] ([MaHD], [MaHH], [TenHH], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HD02', N'HIBI', N'Dâm Bụt', 169000, 1, 169000)
GO
INSERT [dbo].[PayCheck Details] ([MaHD], [MaHH], [TenHH], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HD03', N'LASPEC', N'Bằng Lăng', 100000, 4, 400000)
GO
INSERT [dbo].[PayCheck Details] ([MaHD], [MaHH], [TenHH], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HD05', N'OCIN', N'Mai Vàng', 340000, 2, 680000)
GO
INSERT [dbo].[PayCheck Details] ([MaHD], [MaHH], [TenHH], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HD06', N'POPUL', N'Điệp ', 200000, 1, 20000)
GO
INSERT [dbo].[PayCheckk] ([MaHD], [NgayThanhToan], [TenKH], [ThanhTien], [MaNV]) VALUES (N'HD01', CAST(0x982D0B00 AS Date), N'Trần Thị Lê', 200000, N'E004')
GO
INSERT [dbo].[PayCheckk] ([MaHD], [NgayThanhToan], [TenKH], [ThanhTien], [MaNV]) VALUES (N'HD02', CAST(0x832C0B00 AS Date), N'Nguyễn Bí', 169000, N'E001')
GO
INSERT [dbo].[PayCheckk] ([MaHD], [NgayThanhToan], [TenKH], [ThanhTien], [MaNV]) VALUES (N'HD03', CAST(0xD8300B00 AS Date), N'Nhữ Văn Chiến', 400000, N'E004')
GO
INSERT [dbo].[PayCheckk] ([MaHD], [NgayThanhToan], [TenKH], [ThanhTien], [MaNV]) VALUES (N'HD04', CAST(0xB5300B00 AS Date), N'Lê Minh Thông', 180000, N'E002')
GO
INSERT [dbo].[PayCheckk] ([MaHD], [NgayThanhToan], [TenKH], [ThanhTien], [MaNV]) VALUES (N'HD05', CAST(0x4F3E0B00 AS Date), N'Nguyễn Lệ Dũng', 680000, N'E002')
GO
INSERT [dbo].[PayCheckk] ([MaHD], [NgayThanhToan], [TenKH], [ThanhTien], [MaNV]) VALUES (N'HD06', CAST(0x4B2B0B00 AS Date), N'Lý Thái Vinh', 200000, N'E001')
GO
INSERT [dbo].[PayCheckk] ([MaHD], [NgayThanhToan], [TenKH], [ThanhTien], [MaNV]) VALUES (N'HD07', CAST(0x9B310B00 AS Date), N'Đỗ Thị Mười', 90000, N'E003')
GO
INSERT [dbo].[Product] ([MaHH], [TenHH], [DonGia], [MaNCC]) VALUES (N'ASTER', N'Cúc Hướng Dương', 250000, N'LOVEP')
GO
INSERT [dbo].[Product] ([MaHH], [TenHH], [DonGia], [MaNCC]) VALUES (N'BOMBAX', N'Hoa Gạo', 321600, N'LOVEP')
GO
INSERT [dbo].[Product] ([MaHH], [TenHH], [DonGia], [MaNCC]) VALUES (N'BOUGAN', N'Bông Giấy', 120000, N'SWAGF')
GO
INSERT [dbo].[Product] ([MaHH], [TenHH], [DonGia], [MaNCC]) VALUES (N'CEIBA', N'Bông Gòn', 15800, N'SWAGF')
GO
INSERT [dbo].[Product] ([MaHH], [TenHH], [DonGia], [MaNCC]) VALUES (N'DECA', N'Hoa Phượng', 60000, N'LOVEP')
GO
INSERT [dbo].[Product] ([MaHH], [TenHH], [DonGia], [MaNCC]) VALUES (N'HIBI', N'Dâm Bụt', 169000, N'SOMA')
GO
INSERT [dbo].[Product] ([MaHH], [TenHH], [DonGia], [MaNCC]) VALUES (N'HYAC', N'Dạ Lan', 76000, N'SOMA')
GO
INSERT [dbo].[Product] ([MaHH], [TenHH], [DonGia], [MaNCC]) VALUES (N'JACA', N'Phượng Tím', 90000, N'LOVEP')
GO
INSERT [dbo].[Product] ([MaHH], [TenHH], [DonGia], [MaNCC]) VALUES (N'LASPEC', N'Bằng Lăng ', 100000, N'LOVEP')
GO
INSERT [dbo].[Product] ([MaHH], [TenHH], [DonGia], [MaNCC]) VALUES (N'OCIN', N'Mai Vàng', 340000, N'SWAGF')
GO
INSERT [dbo].[Product] ([MaHH], [TenHH], [DonGia], [MaNCC]) VALUES (N'POPUL', N'Điệp', 200000, N'SOMA')
GO
INSERT [dbo].[Product] ([MaHH], [TenHH], [DonGia], [MaNCC]) VALUES (N'SACURA', N'Đào Hồng', 222500, N'SOMA')
GO
INSERT [dbo].[Shop Details] ([TenShop], [SDT], [DiaChi], [Website]) VALUES (N'KTFlower Shop', N'0932930293', N'211/58/1A Lê Văn Quới Q Bình Tân TPHCM', N'http://www.ktplants.net')
GO
INSERT [dbo].[Supplier] ([MaNCC], [TenNCC], [DiaChi], [SDT], [Website]) VALUES (N'LOVEP', N'Cây Trồng Plants', N'80 Xô Viết Nghệ Tĩnh Q.Bình Thạnh TPHCM', N'01219606350', N'www.loveplants.com')
GO
INSERT [dbo].[Supplier] ([MaNCC], [TenNCC], [DiaChi], [SDT], [Website]) VALUES (N'SOMA', N'Hội Thực Vật', N'320/55 Độc Lập Q.Tân Phú TPHCM', N'0839616263', N'www.sissolut12.vn')
GO
INSERT [dbo].[Supplier] ([MaNCC], [TenNCC], [DiaChi], [SDT], [Website]) VALUES (N'SWAGF', N'Hoa Ban Phước', N'6 Nguyễn Đình Chiểu Q.3 TPHCM', N'01264725141', N'http://www.phuocbnhoa.org')
GO
ALTER TABLE [dbo].[PayCheck Details]  WITH CHECK ADD  CONSTRAINT [FK_PayCheck Details_PayCheckk] FOREIGN KEY([MaHD])
REFERENCES [dbo].[PayCheckk] ([MaHD])
GO
ALTER TABLE [dbo].[PayCheck Details] CHECK CONSTRAINT [FK_PayCheck Details_PayCheckk]
GO
ALTER TABLE [dbo].[PayCheck Details]  WITH CHECK ADD  CONSTRAINT [FK_PayCheck Details_Product] FOREIGN KEY([MaHH])
REFERENCES [dbo].[Product] ([MaHH])
GO
ALTER TABLE [dbo].[PayCheck Details] CHECK CONSTRAINT [FK_PayCheck Details_Product]
GO
ALTER TABLE [dbo].[PayCheckk]  WITH CHECK ADD  CONSTRAINT [FK_PayCheckk_Employee] FOREIGN KEY([MaNV])
REFERENCES [dbo].[Employee] ([MaNV])
GO
ALTER TABLE [dbo].[PayCheckk] CHECK CONSTRAINT [FK_PayCheckk_Employee]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Supplier] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[Supplier] ([MaNCC])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Supplier]
GO
