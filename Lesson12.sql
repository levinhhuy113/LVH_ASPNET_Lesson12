USE [LeVinhHuy_2210900106]
GO
/****** Object:  Table [dbo].[Lvh_SACH]    Script Date: 7/12/2024 9:19:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lvh_SACH](
	[Lvh_MaSach] [nchar](10) NOT NULL,
	[Lvh_TenSach] [nvarchar](50) NULL,
	[Lvh__SoTrang] [int] NULL,
	[Lvh_NamXB] [int] NULL,
	[Lvh_MaTG] [nchar](10) NULL,
	[Lvh_TrangThai] [bit] NULL,
 CONSTRAINT [PK_Lvh_SACH] PRIMARY KEY CLUSTERED 
(
	[Lvh_MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lvh_TACGIA]    Script Date: 7/12/2024 9:19:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lvh_TACGIA](
	[Lvh_MaTG] [nchar](10) NOT NULL,
	[Lvh_TenTG] [nvarchar](50) NULL,
 CONSTRAINT [PK_Lvh_TACGIA] PRIMARY KEY CLUSTERED 
(
	[Lvh_MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Lvh_SACH] ([Lvh_MaSach], [Lvh_TenSach], [Lvh__SoTrang], [Lvh_NamXB], [Lvh_MaTG], [Lvh_TrangThai]) VALUES (N'S1        ', N'Ngữ Văn', 200, 2023, N'T1        ', 1)
INSERT [dbo].[Lvh_SACH] ([Lvh_MaSach], [Lvh_TenSach], [Lvh__SoTrang], [Lvh_NamXB], [Lvh_MaTG], [Lvh_TrangThai]) VALUES (N'S2        ', N'Toán', 150, 2022, N'T2        ', 0)
INSERT [dbo].[Lvh_TACGIA] ([Lvh_MaTG], [Lvh_TenTG]) VALUES (N'T1        ', N'Lê Vinh Huy')
INSERT [dbo].[Lvh_TACGIA] ([Lvh_MaTG], [Lvh_TenTG]) VALUES (N'T2        ', N'Nguyễn Văn Thạo')
ALTER TABLE [dbo].[Lvh_SACH]  WITH CHECK ADD  CONSTRAINT [FK_Lvh_SACH_Lvh_TACGIA] FOREIGN KEY([Lvh_MaTG])
REFERENCES [dbo].[Lvh_TACGIA] ([Lvh_MaTG])
GO
ALTER TABLE [dbo].[Lvh_SACH] CHECK CONSTRAINT [FK_Lvh_SACH_Lvh_TACGIA]
GO
