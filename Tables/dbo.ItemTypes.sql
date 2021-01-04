USE [TreasureRoom]
GO

/****** Object:  Table [dbo].[dbo.ItemTypes]    Script Date: 04/01/2021 10:11:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[dbo.ItemTypes](
	[ID] [tinyint] IDENTITY(1,1) NOT NULL,
	[ItemType] [nvarchar](50) NULL
) ON [PRIMARY]
GO

