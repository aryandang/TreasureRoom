USE [TreasureRoom]
GO
/****** Object:  StoredProcedure [dbo].[Get_ItemTypes]    Script Date: 13/01/2021 13:22:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Aryan Dang
-- Create date: 13 JAN 2021
-- Description:	To get the item types from the table dbo.LostItems
-- =============================================
ALTER PROCEDURE [dbo].[Get_ItemTypes]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM [dbo.ItemTypes]
END
