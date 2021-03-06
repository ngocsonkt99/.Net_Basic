use master
go
create database NorthwindCopy
go
USE [NorthwindCopy]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 10/09/2013 01:17:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [nchar](5) NOT NULL,
	[UserName] [nvarchar](30) NOT NULL,
	[Password] [nvarchar](50) NULL,
	[ContactName] [nvarchar](30) NULL,
	[Address] [nvarchar](60) NULL,
	[Phone] [nvarchar](24) NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [U_Name] UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Customers] ([CustomerID], [UserName], [Password], [ContactName], [Address], [Phone]) VALUES (N'1    ', N'minh', N'123', N'hong minh', N'xxx', N'12345678')
INSERT [dbo].[Customers] ([CustomerID], [UserName], [Password], [ContactName], [Address], [Phone]) VALUES (N'2    ', N'phuong', N'123', N'Le Thanh Phuong', N'Hoc Mon', N'0987654321')
/****** Object:  Table [dbo].[Categories]    Script Date: 10/09/2013 01:17:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](15) NOT NULL,
	[Description] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (1, N'Điện thoại', N'xxx')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (2, N'Laptop', N'xxx')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (3, N'Máy để bàn', N'xxx')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (4, N'USB ', NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (5, N'Tivi', NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (6, N'Máy lạnh', NULL)
SET IDENTITY_INSERT [dbo].[Categories] OFF
/****** Object:  Table [dbo].[Account]    Script Date: 10/09/2013 01:17:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[AccountID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](30) unique NOT NULL,
	[Password] [nvarchar](50) NULL,
	[FullName] [nvarchar](30) NOT NULL,
	[Type] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[AccountID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON
INSERT [dbo].[Account] ([AccountID], [UserName], [Password], [FullName], [Type]) VALUES (1, N'admin', N'123', N'hong minh', 1)
INSERT [dbo].[Account] ([AccountID], [UserName], [Password], [FullName], [Type]) VALUES (2, N'lam', N'123', N'thanh lam', 2)
SET IDENTITY_INSERT [dbo].[Account] OFF
/****** Object:  Table [dbo].[Suppliers]    Script Date: 10/09/2013 01:17:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](40) NOT NULL,
	[Address] [nvarchar](60) NULL,
	[Phone] [nvarchar](24) NULL,
PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Suppliers] ON
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [Phone]) VALUES (1, N'Nokia', N'xxx', N'054353')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [Phone]) VALUES (2, N'Samsung', N'xxx', N'05354')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [Phone]) VALUES (3, N'Hitachi', N'xxx', N'0532535')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [Phone]) VALUES (4, N'Sanyo', N'4335', N'04325325')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [Phone]) VALUES (5, N'LG', N'fdsgf', N'31232432')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [Phone]) VALUES (6, N'Toshiba', N'csdf', N'321324')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [Phone]) VALUES (7, N'Dell', N'xxxx', N'0134323')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [Phone]) VALUES (8, N'HP', N'xxx', N'12121232')
SET IDENTITY_INSERT [dbo].[Suppliers] OFF
/****** Object:  Table [dbo].[Feedback]    Script Date: 10/09/2013 01:17:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feedback](
	[FId] [int] IDENTITY(1,1) NOT NULL,
	[FTitle] [nvarchar](100) NULL,
	[FContent] [nvarchar](max) NULL,
	[FDate] [datetime] NULL,
	[CustomerID] [nchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[FId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 10/09/2013 01:17:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](40) NOT NULL,
	[SupplierID] [int] NULL,
	[CategoryID] [int] NULL,
	[QuantityPerUnit] [int] NULL,
	[UnitPrice] [money] NULL,
	[ProductImage] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Products] ON
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [CategoryID], [QuantityPerUnit], [UnitPrice], [ProductImage]) VALUES (1, N'Nokia 6131', 1, 1, 5, 1000000.0000, N'mobi1.png')
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [CategoryID], [QuantityPerUnit], [UnitPrice], [ProductImage]) VALUES (2, N'Samsung xxx', 2, 1, 10, 1500000.0000, N'mobi2.png')
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [CategoryID], [QuantityPerUnit], [UnitPrice], [ProductImage]) VALUES (3, N'Vostro', 7, 2, 2, 14000000.0000, N'laptop3.jpg')
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [CategoryID], [QuantityPerUnit], [UnitPrice], [ProductImage]) VALUES (4, N'Vaio', 4, 2, 6, 20000000.0000, N'laptop4.jpg')
SET IDENTITY_INSERT [dbo].[Products] OFF
/****** Object:  Table [dbo].[Orders]    Script Date: 10/09/2013 01:17:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] NOT NULL,
	[CustomerID] [nchar](5) NULL,
	[OrderDate] [datetime] NULL,
	[RequiredDate] [datetime] NULL,
	[ShippedDate] [datetime] NULL,
	[Freight] [money] NULL,
	[ShipAddress] [nvarchar](60) NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order Details]    Script Date: 10/09/2013 01:17:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order Details](
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[Quantity] [smallint] NOT NULL,
 CONSTRAINT [PK_Order_Details] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK__Feedback__Custom__2C3393D0]    Script Date: 10/09/2013 01:17:57 ******/
ALTER TABLE [dbo].[Feedback]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
/****** Object:  ForeignKey [FK__Products__Catego__117F9D94]    Script Date: 10/09/2013 01:17:57 ******/
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
/****** Object:  ForeignKey [FK__Products__Suppli__108B795B]    Script Date: 10/09/2013 01:17:57 ******/
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Suppliers] ([SupplierID])
GO
/****** Object:  ForeignKey [FK__Orders__Customer__164452B1]    Script Date: 10/09/2013 01:17:57 ******/
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
/****** Object:  ForeignKey [FK__Order Det__Order__1920BF5C]    Script Date: 10/09/2013 01:17:57 ******/
ALTER TABLE [dbo].[Order Details]  WITH CHECK ADD FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
/****** Object:  ForeignKey [FK__Order Det__Produ__1A14E395]    Script Date: 10/09/2013 01:17:57 ******/
ALTER TABLE [dbo].[Order Details]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
--tạo stored procedure
use NorthwindCopy
go
CREATE PROCEDURE insertAccount	
	@userName nvarchar(30),
	@passWord nvarchar(50),
	@fullName nvarchar(30),
	@type int
AS
	insert into Account values(@userName,@passWord,@fullName,@type)
GO

-- =============================================
-- Example to execute the stored procedure
-- =============================================
EXECUTE insertAccount 'minh','123',N'Hồng Minh',2
GO
