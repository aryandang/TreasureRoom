USE [TreasureRoom]
GO

/****** Object:  Table [dbo].[dbo.RetrieveItemsUsers]    Script Date: 27/01/2021 14:17:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[dbo.RetrieveItemsUsers](
	[ID] [nvarchar](50) NOT NULL,
	[FullName] [nvarchar](100) NULL,
	[EmailAddress] [nvarchar](100) NULL,
	[PhoneNumber] [nvarchar](50) NULL
) ON [PRIMARY]
GO

