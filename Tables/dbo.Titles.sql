USE [TreasureRoom]
GO

/****** Object:  Table [dbo].[dbo.Titles]    Script Date: 24/01/2021 10:40:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[dbo.Titles](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL
) ON [PRIMARY]
GO

