USE [POS_DB]
GO
/****** Object:  Table [dbo].[CATEGORIES]    Script Date: 2024/2/15 08:41:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORIES](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](25) NULL,
 CONSTRAINT [PK_CATEGORIES] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CUSTOMER]    Script Date: 2024/2/15 08:41:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CUSTOMER](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](20) NULL,
	[Email] [nvarchar](35) NULL,
	[ContactNumber] [nvarchar](25) NULL,
	[Address] [nvarchar](50) NULL,
	[BDay] [date] NULL,
 CONSTRAINT [PK_CUSTOMER] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMPLOYEE]    Script Date: 2024/2/15 08:41:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLOYEE](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeName] [nvarchar](50) NULL,
	[e_password] [nvarchar](20) NULL,
	[ContactNumber] [nvarchar](25) NULL,
	[Address] [nvarchar](50) NULL,
	[BDay] [date] NULL,
	[Permission] [int] NULL,
 CONSTRAINT [PK_EMPLOYEE] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ORDERDETAIL]    Script Date: 2024/2/15 08:41:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDERDETAIL](
	[OrderDetailID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NULL,
	[ProductID] [int] NULL,
	[Quantity] [int] NULL,
	[Subtotal] [int] NULL,
 CONSTRAINT [PK_ORDERDETAIL] PRIMARY KEY CLUSTERED 
(
	[OrderDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ORDERS]    Script Date: 2024/2/15 08:41:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDERS](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NULL,
	[EmployeeID] [int] NULL,
	[OrderDate] [date] NULL,
	[TotalPrice] [int] NULL,
 CONSTRAINT [PK_ORDERS] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCT]    Script Date: 2024/2/15 08:41:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCT](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](25) NULL,
	[Unit] [int] NULL,
	[Price] [int] NULL,
	[Image] [nvarchar](100) NULL,
	[CategoryID] [int] NULL,
	[Description] [nvarchar](500) NULL,
 CONSTRAINT [PK_PRODUCT] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CATEGORIES] ON 

INSERT [dbo].[CATEGORIES] ([CategoryID], [CategoryName]) VALUES (1, N'無酒精飲料')
INSERT [dbo].[CATEGORIES] ([CategoryID], [CategoryName]) VALUES (2, N'調酒飲料')
INSERT [dbo].[CATEGORIES] ([CategoryID], [CategoryName]) VALUES (3, N'義大利麵')
INSERT [dbo].[CATEGORIES] ([CategoryID], [CategoryName]) VALUES (4, N'披薩')
INSERT [dbo].[CATEGORIES] ([CategoryID], [CategoryName]) VALUES (5, N'甜點')
INSERT [dbo].[CATEGORIES] ([CategoryID], [CategoryName]) VALUES (6, N'炸物')
SET IDENTITY_INSERT [dbo].[CATEGORIES] OFF
GO
SET IDENTITY_INSERT [dbo].[CUSTOMER] ON 

INSERT [dbo].[CUSTOMER] ([CustomerID], [CustomerName], [Email], [ContactNumber], [Address], [BDay]) VALUES (1, N'TOKYO', N'tokyo@gmail.com', N'0912654776', N'東京市', CAST(N'2000-01-01' AS Date))
INSERT [dbo].[CUSTOMER] ([CustomerID], [CustomerName], [Email], [ContactNumber], [Address], [BDay]) VALUES (2, N'KYOTO', N'kyoto@gmail.com', N'0912654775', N'京都市', CAST(N'1998-08-08' AS Date))
INSERT [dbo].[CUSTOMER] ([CustomerID], [CustomerName], [Email], [ContactNumber], [Address], [BDay]) VALUES (3, N'SEOUL', N'seoul@gmail.com', N'0912654774', N'首爾市', CAST(N'1997-07-07' AS Date))
INSERT [dbo].[CUSTOMER] ([CustomerID], [CustomerName], [Email], [ContactNumber], [Address], [BDay]) VALUES (4, N'BUSAN', N'busan@gmail.com', N'0912654772', N'釜山市', CAST(N'1996-06-06' AS Date))
INSERT [dbo].[CUSTOMER] ([CustomerID], [CustomerName], [Email], [ContactNumber], [Address], [BDay]) VALUES (5, N'TAIPEI', N'taipei@gmail.com', N'0912654771', N'台北市', CAST(N'1995-05-05' AS Date))
INSERT [dbo].[CUSTOMER] ([CustomerID], [CustomerName], [Email], [ContactNumber], [Address], [BDay]) VALUES (6, N'SYDNEY', N'sydney@gmail.com', N'0987345666', N'雪梨市', CAST(N'2000-03-05' AS Date))
INSERT [dbo].[CUSTOMER] ([CustomerID], [CustomerName], [Email], [ContactNumber], [Address], [BDay]) VALUES (7, N'MELBOURNE', N'melbourne@gmail.com', N'0912345677', N'墨爾本市', CAST(N'2000-02-02' AS Date))
INSERT [dbo].[CUSTOMER] ([CustomerID], [CustomerName], [Email], [ContactNumber], [Address], [BDay]) VALUES (14, N'CANADA', N'canada@gmail.com', N'0987123654', N'加拿大市', CAST(N'2001-01-01' AS Date))
INSERT [dbo].[CUSTOMER] ([CustomerID], [CustomerName], [Email], [ContactNumber], [Address], [BDay]) VALUES (15, N'TOKYOOO', N'tokyooo@gmail.com', N'0987234566', N'東京市', CAST(N'2002-02-02' AS Date))
INSERT [dbo].[CUSTOMER] ([CustomerID], [CustomerName], [Email], [ContactNumber], [Address], [BDay]) VALUES (16, N'AIR', N'air@gmail.com', N'0912345677', N'天市', CAST(N'2010-02-02' AS Date))
SET IDENTITY_INSERT [dbo].[CUSTOMER] OFF
GO
SET IDENTITY_INSERT [dbo].[EMPLOYEE] ON 

INSERT [dbo].[EMPLOYEE] ([EmployeeID], [EmployeeName], [e_password], [ContactNumber], [Address], [BDay], [Permission]) VALUES (1, N'ROLEXXX', N'rolexxx2000', N'0987123657', N'東京市幸福路100號', CAST(N'2000-02-02' AS Date), 0)
INSERT [dbo].[EMPLOYEE] ([EmployeeID], [EmployeeName], [e_password], [ContactNumber], [Address], [BDay], [Permission]) VALUES (2, N'BENTLEY', N'bentley1998', N'0998456777', N'京都市', CAST(N'1998-08-08' AS Date), 10)
INSERT [dbo].[EMPLOYEE] ([EmployeeID], [EmployeeName], [e_password], [ContactNumber], [Address], [BDay], [Permission]) VALUES (3, N'MAYBACH', N'maybach1997', N'0900125678', N'邁霸市', CAST(N'1997-07-07' AS Date), 100)
INSERT [dbo].[EMPLOYEE] ([EmployeeID], [EmployeeName], [e_password], [ContactNumber], [Address], [BDay], [Permission]) VALUES (4, N'SUPREME', N'supreme1996', N'0945871244', N'釜山市', CAST(N'1996-06-06' AS Date), 1000)
INSERT [dbo].[EMPLOYEE] ([EmployeeID], [EmployeeName], [e_password], [ContactNumber], [Address], [BDay], [Permission]) VALUES (5, N'GOYARD', N'goyard1995', N'0999887001', N'台北市', CAST(N'1995-05-05' AS Date), 1000)
INSERT [dbo].[EMPLOYEE] ([EmployeeID], [EmployeeName], [e_password], [ContactNumber], [Address], [BDay], [Permission]) VALUES (6, N'PRADA', N'prada1994', N'0954122299', N'東京市', CAST(N'1994-04-04' AS Date), 1000)
INSERT [dbo].[EMPLOYEE] ([EmployeeID], [EmployeeName], [e_password], [ContactNumber], [Address], [BDay], [Permission]) VALUES (7, N'KENZO', N'kenzo2000', N'0987123555', N'東京市幸福路125號', CAST(N'2000-01-10' AS Date), 1000)
INSERT [dbo].[EMPLOYEE] ([EmployeeID], [EmployeeName], [e_password], [ContactNumber], [Address], [BDay], [Permission]) VALUES (8, N'Kenzoo', N'Kenzoo2011', N'0923123455', N'東京市', CAST(N'2005-03-01' AS Date), 1000)
INSERT [dbo].[EMPLOYEE] ([EmployeeID], [EmployeeName], [e_password], [ContactNumber], [Address], [BDay], [Permission]) VALUES (9, N'kenzoooo', N'kenzooooo2000', N'0987263455', N'東京市', CAST(N'2000-02-02' AS Date), 1000)
INSERT [dbo].[EMPLOYEE] ([EmployeeID], [EmployeeName], [e_password], [ContactNumber], [Address], [BDay], [Permission]) VALUES (10, N'ROLEX', N'ROLEX2000', N'0910294445', N'勞力市', CAST(N'2000-01-01' AS Date), 1000)
INSERT [dbo].[EMPLOYEE] ([EmployeeID], [EmployeeName], [e_password], [ContactNumber], [Address], [BDay], [Permission]) VALUES (11, N'BENTLEYLEY', N'bentleyley1998', N'0998456777', N'京都市', CAST(N'1998-01-01' AS Date), 1000)
INSERT [dbo].[EMPLOYEE] ([EmployeeID], [EmployeeName], [e_password], [ContactNumber], [Address], [BDay], [Permission]) VALUES (12, N'MAYBACHHH', N'maybachhh1997', N'0900125678', N'邁霸市', CAST(N'1997-10-01' AS Date), 1000)
INSERT [dbo].[EMPLOYEE] ([EmployeeID], [EmployeeName], [e_password], [ContactNumber], [Address], [BDay], [Permission]) VALUES (13, N'LOCO', N'loco1996', N'0945871244', N'釜山市', CAST(N'1996-06-06' AS Date), 1000)
INSERT [dbo].[EMPLOYEE] ([EmployeeID], [EmployeeName], [e_password], [ContactNumber], [Address], [BDay], [Permission]) VALUES (14, N'GOYARDGO', N'goyardgo1995', N'0998871117', N'台北市', CAST(N'1995-06-05' AS Date), 1000)
INSERT [dbo].[EMPLOYEE] ([EmployeeID], [EmployeeName], [e_password], [ContactNumber], [Address], [BDay], [Permission]) VALUES (15, N'LOUIS', N'Louis1994', N'0954111199', N'東京市', CAST(N'1994-08-08' AS Date), 1000)
INSERT [dbo].[EMPLOYEE] ([EmployeeID], [EmployeeName], [e_password], [ContactNumber], [Address], [BDay], [Permission]) VALUES (16, N'VITTON', N'vitton2000', N'0987123555', N'東京市幸福路125號', CAST(N'2000-02-10' AS Date), 1000)
INSERT [dbo].[EMPLOYEE] ([EmployeeID], [EmployeeName], [e_password], [ContactNumber], [Address], [BDay], [Permission]) VALUES (17, N'ROLLS', N'rolls2001', N'0987124577', N'勞斯市', CAST(N'2001-01-01' AS Date), 1000)
INSERT [dbo].[EMPLOYEE] ([EmployeeID], [EmployeeName], [e_password], [ContactNumber], [Address], [BDay], [Permission]) VALUES (18, N'AIR', N'air2000', N'0933455981', N'天市', CAST(N'2000-02-02' AS Date), 1000)
SET IDENTITY_INSERT [dbo].[EMPLOYEE] OFF
GO
SET IDENTITY_INSERT [dbo].[ORDERDETAIL] ON 

INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (1, 1, 1, 1, 280)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (2, 1, 1, 2, 560)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (3, 2, 2, 3, 180)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (4, 2, 6, 3, 450)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (5, 2, 4, 1, 90)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (15, 20, 2, 3, 840)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (16, 20, 3, 2, 120)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (17, 20, 4, 2, 180)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (18, 24, 2, 3, 840)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (19, 24, 3, 1, 60)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (20, 24, 4, 1, 90)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (21, 24, 6, 1, 150)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (22, 25, 4, 1, 90)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (23, 25, 6, 1, 150)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (24, 25, 2, 1, 280)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (25, 25, 1, 1, 280)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (26, 26, 1, 2, 560)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (27, 26, 2, 1, 280)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (28, 26, 4, 1, 90)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (29, 27, 2, 9, 2520)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (30, 27, 1, 9, 2520)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (31, 27, 4, 9, 810)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (32, 27, 7, 6, 450)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (33, 28, 2, 9, 2520)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (34, 28, 4, 9, 810)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (35, 28, 7, 6, 450)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (36, 29, 1, 2, 560)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (37, 31, 2, 1, 280)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (38, 34, 1, 1, 280)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (39, 34, 2, 1, 280)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (40, 35, 2, 1, 280)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (41, 35, 1, 1, 280)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (42, 35, 1, 1, 280)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (43, 36, 1, 1, 280)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (44, 37, 1, 1, 280)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (45, 38, 1, 1, 280)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (46, 39, 1, 1, 280)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (47, 40, 1, 2, 560)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (48, 41, 1, 2, 560)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (49, 42, 1, 2, 560)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (50, 43, 1, 2, 560)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (51, 44, 2, 1, 280)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (52, 44, 1, 1, 280)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (53, 44, 7, 2, 150)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (54, 45, 2, 3, 840)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (55, 45, 1, 3, 840)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (56, 46, 14, 1, 270)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (57, 46, 16, 1, 180)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (58, 46, 17, 1, 200)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (59, 46, 18, 1, 160)
INSERT [dbo].[ORDERDETAIL] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Subtotal]) VALUES (60, 45, 3, 2, 180)
SET IDENTITY_INSERT [dbo].[ORDERDETAIL] OFF
GO
SET IDENTITY_INSERT [dbo].[ORDERS] ON 

INSERT [dbo].[ORDERS] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalPrice]) VALUES (1, 1, 2, CAST(N'2023-10-27' AS Date), 840)
INSERT [dbo].[ORDERS] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalPrice]) VALUES (2, 3, 5, CAST(N'2023-11-01' AS Date), 720)
INSERT [dbo].[ORDERS] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalPrice]) VALUES (20, NULL, 11, CAST(N'2023-11-02' AS Date), NULL)
INSERT [dbo].[ORDERS] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalPrice]) VALUES (24, 14, 11, CAST(N'2023-11-02' AS Date), 1140)
INSERT [dbo].[ORDERS] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalPrice]) VALUES (25, 14, 11, CAST(N'2023-11-02' AS Date), 800)
INSERT [dbo].[ORDERS] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalPrice]) VALUES (26, 14, 11, CAST(N'2023-11-10' AS Date), 930)
INSERT [dbo].[ORDERS] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalPrice]) VALUES (27, 14, 11, CAST(N'2024-01-11' AS Date), 6300)
INSERT [dbo].[ORDERS] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalPrice]) VALUES (28, 14, 11, CAST(N'2024-01-11' AS Date), 3780)
INSERT [dbo].[ORDERS] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalPrice]) VALUES (29, 14, 11, CAST(N'2024-01-11' AS Date), 560)
INSERT [dbo].[ORDERS] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalPrice]) VALUES (31, 7, 11, CAST(N'2024-01-12' AS Date), 280)
INSERT [dbo].[ORDERS] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalPrice]) VALUES (34, 6, 11, CAST(N'2024-01-12' AS Date), 560)
INSERT [dbo].[ORDERS] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalPrice]) VALUES (35, 1, 11, CAST(N'2024-01-12' AS Date), 840)
INSERT [dbo].[ORDERS] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalPrice]) VALUES (36, 14, 11, CAST(N'2024-01-12' AS Date), 280)
INSERT [dbo].[ORDERS] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalPrice]) VALUES (37, 5, 11, CAST(N'2024-01-12' AS Date), 280)
INSERT [dbo].[ORDERS] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalPrice]) VALUES (38, 15, 11, CAST(N'2024-01-12' AS Date), 280)
INSERT [dbo].[ORDERS] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalPrice]) VALUES (39, 15, 11, CAST(N'2024-01-12' AS Date), 280)
INSERT [dbo].[ORDERS] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalPrice]) VALUES (40, 7, 10, CAST(N'2024-01-12' AS Date), 560)
INSERT [dbo].[ORDERS] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalPrice]) VALUES (41, 14, 10, CAST(N'2024-01-12' AS Date), 560)
INSERT [dbo].[ORDERS] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalPrice]) VALUES (42, 7, 10, CAST(N'2024-01-12' AS Date), 560)
INSERT [dbo].[ORDERS] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalPrice]) VALUES (43, 7, 10, CAST(N'2024-01-12' AS Date), 560)
INSERT [dbo].[ORDERS] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalPrice]) VALUES (44, 1, 10, CAST(N'2024-01-15' AS Date), 710)
INSERT [dbo].[ORDERS] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalPrice]) VALUES (45, 7, 10, CAST(N'2024-01-15' AS Date), 1860)
INSERT [dbo].[ORDERS] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalPrice]) VALUES (46, 7, 10, CAST(N'2024-01-15' AS Date), 810)
SET IDENTITY_INSERT [dbo].[ORDERS] OFF
GO
SET IDENTITY_INSERT [dbo].[PRODUCT] ON 

INSERT [dbo].[PRODUCT] ([ProductID], [ProductName], [Unit], [Price], [Image], [CategoryID], [Description]) VALUES (1, N'瑪格麗特披薩', 30, 280, N'202401111506265016.jpg', 4, N'經典不敗的瑪格麗特披薩')
INSERT [dbo].[PRODUCT] ([ProductID], [ProductName], [Unit], [Price], [Image], [CategoryID], [Description]) VALUES (2, N'煙燻鮭魚披薩', 20, 280, N'202401111514247904.jpg', 4, N'煙燻鮭魚披薩熱賣')
INSERT [dbo].[PRODUCT] ([ProductID], [ProductName], [Unit], [Price], [Image], [CategoryID], [Description]) VALUES (3, N'柳橙果汁', 50, 60, N'202401111515592047.jpg', 1, N'新鮮現榨果汁')
INSERT [dbo].[PRODUCT] ([ProductID], [ProductName], [Unit], [Price], [Image], [CategoryID], [Description]) VALUES (4, N'美式咖啡', 100, 90, N'202401120907492147.jpg', 1, N'早晨提神必備')
INSERT [dbo].[PRODUCT] ([ProductID], [ProductName], [Unit], [Price], [Image], [CategoryID], [Description]) VALUES (6, N'拿鐵咖啡', 100, 150, N'202401120908583795.jpg', 1, N'特濃咖啡加上特濃鮮奶')
INSERT [dbo].[PRODUCT] ([ProductID], [ProductName], [Unit], [Price], [Image], [CategoryID], [Description]) VALUES (7, N'鮮奶茶', 45, 75, N'202401120908364253.jpg', 1, N'鮮奶茶')
INSERT [dbo].[PRODUCT] ([ProductID], [ProductName], [Unit], [Price], [Image], [CategoryID], [Description]) VALUES (8, N'卡布奇諾', 40, 90, N'202401120906382099.jpg', 1, N'卡布奇諾')
INSERT [dbo].[PRODUCT] ([ProductID], [ProductName], [Unit], [Price], [Image], [CategoryID], [Description]) VALUES (9, N'抹茶那堤', 30, 90, N'202401120903145066.jpg', 1, N'抹茶那堤')
INSERT [dbo].[PRODUCT] ([ProductID], [ProductName], [Unit], [Price], [Image], [CategoryID], [Description]) VALUES (10, N'可可那堤', 30, 90, N'202401120905146034.jpg', 1, N'巧克力那堤')
INSERT [dbo].[PRODUCT] ([ProductID], [ProductName], [Unit], [Price], [Image], [CategoryID], [Description]) VALUES (11, N'烏龍茶那堤', 30, 70, N'202401120904188460.jpg', 1, N'烏龍茶那堤')
INSERT [dbo].[PRODUCT] ([ProductID], [ProductName], [Unit], [Price], [Image], [CategoryID], [Description]) VALUES (12, N'原味奶凍捲', 30, 250, N'202401120915005883.jpg', 5, N'原味奶凍捲')
INSERT [dbo].[PRODUCT] ([ProductID], [ProductName], [Unit], [Price], [Image], [CategoryID], [Description]) VALUES (13, N'巧克力奶凍捲', 20, 270, N'202401120916045921.jpg', 5, N'巧克力奶凍捲')
INSERT [dbo].[PRODUCT] ([ProductID], [ProductName], [Unit], [Price], [Image], [CategoryID], [Description]) VALUES (14, N'草莓奶凍捲', 20, 270, N'202401120917308856.jpg', 5, N'草莓奶凍捲')
INSERT [dbo].[PRODUCT] ([ProductID], [ProductName], [Unit], [Price], [Image], [CategoryID], [Description]) VALUES (15, N'抹茶奶凍捲', 25, 270, N'202401120915398283.jpg', 5, N'抹茶奶凍捲')
INSERT [dbo].[PRODUCT] ([ProductID], [ProductName], [Unit], [Price], [Image], [CategoryID], [Description]) VALUES (16, N'奶油培根白醬義大利麵', 30, 180, N'202401120924385182.jpg', 3, N'奶油培根白醬義大利麵')
INSERT [dbo].[PRODUCT] ([ProductID], [ProductName], [Unit], [Price], [Image], [CategoryID], [Description]) VALUES (17, N'煙燻鮭魚奶油義大利麵', 35, 200, N'202401120924528129.jpg', 3, N'煙燻鮭魚奶油義大利麵')
INSERT [dbo].[PRODUCT] ([ProductID], [ProductName], [Unit], [Price], [Image], [CategoryID], [Description]) VALUES (18, N'松露薯條', 45, 160, N'202401120922575542.jpg', 6, N'松露薯條')
SET IDENTITY_INSERT [dbo].[PRODUCT] OFF
GO
ALTER TABLE [dbo].[EMPLOYEE] ADD  DEFAULT ((1000)) FOR [Permission]
GO
ALTER TABLE [dbo].[ORDERDETAIL]  WITH CHECK ADD  CONSTRAINT [FK_ORDERDETAIL_PRODUCT] FOREIGN KEY([ProductID])
REFERENCES [dbo].[PRODUCT] ([ProductID])
GO
ALTER TABLE [dbo].[ORDERDETAIL] CHECK CONSTRAINT [FK_ORDERDETAIL_PRODUCT]
GO
ALTER TABLE [dbo].[ORDERS]  WITH CHECK ADD  CONSTRAINT [FK_ORDERS_CUSTOMER] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[CUSTOMER] ([CustomerID])
GO
ALTER TABLE [dbo].[ORDERS] CHECK CONSTRAINT [FK_ORDERS_CUSTOMER]
GO
ALTER TABLE [dbo].[ORDERS]  WITH CHECK ADD  CONSTRAINT [FK_ORDERS_EMPLOYEE] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[EMPLOYEE] ([EmployeeID])
GO
ALTER TABLE [dbo].[ORDERS] CHECK CONSTRAINT [FK_ORDERS_EMPLOYEE]
GO
ALTER TABLE [dbo].[PRODUCT]  WITH CHECK ADD  CONSTRAINT [FK_PRODUCT_CATEGORIES] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[CATEGORIES] ([CategoryID])
GO
ALTER TABLE [dbo].[PRODUCT] CHECK CONSTRAINT [FK_PRODUCT_CATEGORIES]
GO
