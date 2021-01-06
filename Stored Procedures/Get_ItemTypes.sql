USE [TreasureRoom]
GO

/****** Object:  StoredProcedure [dbo].[Get_ItemTypes]    Script Date: 04/01/2021 10:13:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		ARYAN DANG
-- Create date: 04 JAN 2021
-- Description:	Get the values from the table dbo.ItemTypes
-- =============================================
CREATE PROCEDURE [dbo].[Get_ItemTypes]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM [dbo.ItemTypes]
END
GO

