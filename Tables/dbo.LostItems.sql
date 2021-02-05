USE [TreasureRoom]
GO

/****** Object:  Table [dbo].[dbo.LostItems]    Script Date: 04/02/2021 11:20:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[dbo.LostItems](
	[ID] [nvarchar](50) NOT NULL,
	[EditID] [nvarchar](50) NULL,
	[Title] [nvarchar](50) NULL,
	[Description] [nvarchar](255) NULL,
	[Postcode] [nvarchar](50) NULL,
	[ItemType] [nvarchar](50) NULL,
	[ImagePath] [nvarchar](500) NULL,
	[DatePosted] [datetime] NULL,
	[UserTitle] [nvarchar](50) NULL,
	[UserFullName] [nvarchar](100) NULL,
	[UserEmailAddress] [nvarchar](50) NULL,
	[Question1] [nvarchar](100) NULL,
	[Answer1] [nvarchar](100) NULL,
	[Question2] [nvarchar](100) NULL,
	[Answer2] [nvarchar](100) NULL,
	[Question3] [nvarchar](100) NULL,
	[Answer3] [nvarchar](100) NULL,
	[AgeAbove18AndHonesty] [bit] NULL,
	[ConsentToData] [bit] NULL
) ON [PRIMARY]
GO

