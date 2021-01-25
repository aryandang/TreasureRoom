USE [TreasureRoom]
GO

/****** Object:  Table [dbo].[dbo.Questions.Keys]    Script Date: 25/01/2021 14:38:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[dbo.Questions.Keys](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Question] [nvarchar](100) NULL
) ON [PRIMARY]
GO

