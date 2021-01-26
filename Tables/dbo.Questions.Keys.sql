USE [TreasureRoom]
GO

/****** Object:  Table [dbo].[dbo.Questions.Keys]    Script Date: 26/01/2021 14:05:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[dbo.Questions.Keys](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Question] [nvarchar](100) NULL
) ON [PRIMARY]
GO

