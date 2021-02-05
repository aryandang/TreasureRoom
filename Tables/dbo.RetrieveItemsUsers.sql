USE [TreasureRoom]
GO

/****** Object:  Table [dbo].[dbo.RetrieveItemsUsers]    Script Date: 04/02/2021 11:21:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[dbo.RetrieveItemsUsers](
	[ID] [nvarchar](50) NOT NULL,
	[FullName] [nvarchar](100) NULL,
	[EmailAddress] [nvarchar](100) NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[AgeAbove18AndHonesty] [bit] NULL,
	[ConsentToData] [bit] NULL
) ON [PRIMARY]
GO

