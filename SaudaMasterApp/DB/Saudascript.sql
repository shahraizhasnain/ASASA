USE [saudadb]
GO
/****** Object:  Table [dbo].[Brand]    Script Date: 10/16/2016 8:26:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Brand](
	[BrandID] [int] IDENTITY(1,1) NOT NULL,
	[BrandName] [varchar](50) NOT NULL,
	[BrandTitle] [varchar](50) NOT NULL,
	[BrandDescription] [varchar](50) NOT NULL,
	[BrandImage] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Brand] PRIMARY KEY CLUSTERED 
(
	[BrandID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Category]    Script Date: 10/16/2016 8:26:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[StoreID] [int] NOT NULL,
	[CategoryName] [varchar](50) NOT NULL,
	[CategoryDisplayName] [varchar](50) NOT NULL,
	[CategoryImage] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 10/16/2016 8:26:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [varchar](50) NOT NULL,
	[CustomerContact] [varchar](50) NOT NULL,
	[CustomerAddress1] [varchar](50) NOT NULL,
	[CustomerAddress2] [varchar](50) NOT NULL,
	[CustomerNIC] [varchar](50) NOT NULL,
	[CustomerCode] [varchar](50) NOT NULL,
	[CustomerUserName] [varchar](50) NOT NULL,
	[CustomerPassword] [varchar](50) NOT NULL,
	[CustomerLastLogin] [varchar](50) NOT NULL,
	[CustomerSecurityCode] [varbinary](50) NOT NULL,
	[CustomerActive] [bit] NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CustomerStoreRelation]    Script Date: 10/16/2016 8:26:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CustomerStoreRelation](
	[CustomerStoreID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[StoreID] [int] NOT NULL,
	[Description] [varchar](500) NOT NULL,
	[RewardCheck] [bit] NOT NULL,
 CONSTRAINT [PK_CustomerStoreRelation] PRIMARY KEY CLUSTERED 
(
	[CustomerStoreID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Item]    Script Date: 10/16/2016 8:26:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Item](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[StoreID] [int] NOT NULL,
	[CategoryID] [int] NOT NULL,
	[SubCategoryID] [int] NOT NULL,
	[BrandID] [int] NOT NULL,
	[ItemName] [varchar](50) NOT NULL,
	[ItemDescription] [varchar](50) NOT NULL,
	[ItemPrice] [varchar](50) NOT NULL,
	[ItemAvailability] [bit] NOT NULL,
	[ItemDiscountPercentage] [decimal](18, 0) NOT NULL,
	[ItemImage] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ListDetail]    Script Date: 10/16/2016 8:26:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListDetail](
	[ListDetailID] [int] IDENTITY(1,1) NOT NULL,
	[ListHeaderID] [int] NOT NULL,
	[ItemID] [int] NOT NULL,
	[ItemQuantity] [int] NOT NULL,
	[ItemTotal] [decimal](18, 0) NOT NULL,
	[ItemActive] [bit] NOT NULL,
 CONSTRAINT [PK_ListDetail] PRIMARY KEY CLUSTERED 
(
	[ListDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ListHeader]    Script Date: 10/16/2016 8:26:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ListHeader](
	[ListHeaderID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[ListName] [varchar](50) NOT NULL,
	[ListCreationDate] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ListHeader] PRIMARY KEY CLUSTERED 
(
	[ListHeaderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ListStoreAssociation]    Script Date: 10/16/2016 8:26:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListStoreAssociation](
	[ListStoreID] [int] IDENTITY(1,1) NOT NULL,
	[ListDetailID] [int] NOT NULL,
	[StoreID] [int] NOT NULL,
 CONSTRAINT [PK_ListStoreAssociation] PRIMARY KEY CLUSTERED 
(
	[ListStoreID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Store]    Script Date: 10/16/2016 8:26:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Store](
	[StoreID] [int] IDENTITY(1,1) NOT NULL,
	[StoreName] [varchar](50) NOT NULL,
	[StoreAddressPrimary] [varchar](500) NOT NULL,
	[StoreAddressSecondary] [varchar](500) NOT NULL,
	[StoreContact] [varchar](20) NOT NULL,
	[StoreContactPerson] [varchar](20) NOT NULL,
	[StoreEstablishmentDate] [varchar](50) NOT NULL,
	[StoreDescription] [varchar](500) NOT NULL,
	[StoreUsername] [varchar](20) NOT NULL,
	[StorePassword] [varchar](10) NOT NULL,
	[StoreTitle] [varchar](20) NOT NULL,
	[StoreLogo] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Store] PRIMARY KEY CLUSTERED 
(
	[StoreID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SubCategory]    Script Date: 10/16/2016 8:26:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SubCategory](
	[SubCategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryID] [int] NOT NULL,
	[SubCategoryName] [varchar](50) NOT NULL,
	[SubCategoryDisplayName] [varchar](50) NOT NULL,
	[SubCategoryImage] [varchar](max) NOT NULL,
 CONSTRAINT [PK_SubCategory] PRIMARY KEY CLUSTERED 
(
	[SubCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Category]  WITH CHECK ADD  CONSTRAINT [FK_Category_Store] FOREIGN KEY([StoreID])
REFERENCES [dbo].[Store] ([StoreID])
GO
ALTER TABLE [dbo].[Category] CHECK CONSTRAINT [FK_Category_Store]
GO
ALTER TABLE [dbo].[CustomerStoreRelation]  WITH CHECK ADD  CONSTRAINT [FK_CustomerStoreRelation_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[CustomerStoreRelation] CHECK CONSTRAINT [FK_CustomerStoreRelation_Customer]
GO
ALTER TABLE [dbo].[CustomerStoreRelation]  WITH CHECK ADD  CONSTRAINT [FK_CustomerStoreRelation_Store] FOREIGN KEY([StoreID])
REFERENCES [dbo].[Store] ([StoreID])
GO
ALTER TABLE [dbo].[CustomerStoreRelation] CHECK CONSTRAINT [FK_CustomerStoreRelation_Store]
GO
ALTER TABLE [dbo].[Item]  WITH CHECK ADD  CONSTRAINT [FK_Item_Brand] FOREIGN KEY([BrandID])
REFERENCES [dbo].[Brand] ([BrandID])
GO
ALTER TABLE [dbo].[Item] CHECK CONSTRAINT [FK_Item_Brand]
GO
ALTER TABLE [dbo].[Item]  WITH CHECK ADD  CONSTRAINT [FK_Item_Category] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[Item] CHECK CONSTRAINT [FK_Item_Category]
GO
ALTER TABLE [dbo].[Item]  WITH CHECK ADD  CONSTRAINT [FK_Item_Store] FOREIGN KEY([StoreID])
REFERENCES [dbo].[Store] ([StoreID])
GO
ALTER TABLE [dbo].[Item] CHECK CONSTRAINT [FK_Item_Store]
GO
ALTER TABLE [dbo].[Item]  WITH CHECK ADD  CONSTRAINT [FK_Item_SubCategory] FOREIGN KEY([SubCategoryID])
REFERENCES [dbo].[SubCategory] ([SubCategoryID])
GO
ALTER TABLE [dbo].[Item] CHECK CONSTRAINT [FK_Item_SubCategory]
GO
ALTER TABLE [dbo].[ListDetail]  WITH CHECK ADD  CONSTRAINT [FK_ListDetail_ListHeader] FOREIGN KEY([ListHeaderID])
REFERENCES [dbo].[ListHeader] ([ListHeaderID])
GO
ALTER TABLE [dbo].[ListDetail] CHECK CONSTRAINT [FK_ListDetail_ListHeader]
GO
ALTER TABLE [dbo].[ListHeader]  WITH CHECK ADD  CONSTRAINT [FK_ListHeader_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[ListHeader] CHECK CONSTRAINT [FK_ListHeader_Customer]
GO
ALTER TABLE [dbo].[ListStoreAssociation]  WITH CHECK ADD  CONSTRAINT [FK_ListStoreAssociation_ListDetail] FOREIGN KEY([ListDetailID])
REFERENCES [dbo].[ListDetail] ([ListDetailID])
GO
ALTER TABLE [dbo].[ListStoreAssociation] CHECK CONSTRAINT [FK_ListStoreAssociation_ListDetail]
GO
ALTER TABLE [dbo].[ListStoreAssociation]  WITH CHECK ADD  CONSTRAINT [FK_ListStoreAssociation_Store] FOREIGN KEY([StoreID])
REFERENCES [dbo].[Store] ([StoreID])
GO
ALTER TABLE [dbo].[ListStoreAssociation] CHECK CONSTRAINT [FK_ListStoreAssociation_Store]
GO
ALTER TABLE [dbo].[SubCategory]  WITH CHECK ADD  CONSTRAINT [FK_SubCategory_Category] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[SubCategory] CHECK CONSTRAINT [FK_SubCategory_Category]
GO
