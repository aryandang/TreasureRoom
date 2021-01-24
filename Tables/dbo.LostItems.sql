USE [TreasureRoom]
GO

/****** Object:  Table [dbo].[dbo.LostItems]    Script Date: 24/01/2021 10:40:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[dbo.LostItems](
	[ID] [nvarchar](50) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[Description] [nvarchar](255) NULL,
	[Postcode] [nvarchar](50) NULL,
	[ItemType] [nvarchar](50) NULL,
	[ImagePath] [nvarchar](500) NULL,
	[DatePosted] [datetime] NULL,
	[UserTitle] [nvarchar](50) NULL,
	[UserFullName] [nvarchar](100) NULL,
	[UserEmailAddress] [nvarchar](50) NULL
) ON [PRIMARY]
GO

