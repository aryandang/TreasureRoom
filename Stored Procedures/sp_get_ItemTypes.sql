USE [TreasureRoom]
GO
/****** Object:  StoredProcedure [dbo].[get_ItemTypes]    Script Date: 02/01/2021 11:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		ARYAN DANG
-- Create date: 02 JAN 2021
-- Description: Stored procedure to get data from dbo.ItemTypes to populate drop down list on the home page
-- =============================================
ALTER PROCEDURE [dbo].[get_ItemTypes]
AS
BEGIN
	SELECT * FROM [dbo.ItemTypes]
END
