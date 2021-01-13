USE [TreasureRoom]
GO

/****** Object:  StoredProcedure [dbo].[Get_LostItems]    Script Date: 13/01/2021 13:07:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Aryan Dang
-- Create date: 13 JAN 2021
-- Description:	Get the values from the table dbo.LostItems
-- =============================================
CREATE PROCEDURE [dbo].[Get_LostItems] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM [dbo.LostItems]
END
GO

