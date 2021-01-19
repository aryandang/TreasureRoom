USE [TreasureRoom]
GO

/****** Object:  Table [dbo].[dbo.LostItems]    Script Date: 19/01/2021 14:14:34 ******/
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
	[Image] [nvarchar](50) NULL,
	[DatePosted] [datetime] NULL
) ON [PRIMARY]
GO

