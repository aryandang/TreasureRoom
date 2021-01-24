USE [TreasureRoom]
GO
/****** Object:  StoredProcedure [dbo].[Post_LostItems]    Script Date: 24/01/2021 11:31:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		ARYAN DANG
-- Create date: 24 JAN 2021
-- Description:	Input data into the table dbo.LostItems
-- =============================================
ALTER PROCEDURE [dbo].[Post_LostItems]
	-- Add the parameters for the stored procedure here
	@ID nvarchar(50),
	@Title nvarchar(50),
	@Description nvarchar(255),
	@Postcode nvarchar(50),
	@ItemType nvarchar(50),
	@ImagePath nvarchar(500),
	@DatePosted datetime,
	@UserTitle nvarchar(50),
	@UserFullName nvarchar(100),
	@UserEmailAddress nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	INSERT INTO [dbo.LostItems]
	(
	ID,
	Title,
	Description,
	Postcode,
	ItemType,
	ImagePath,
	DatePosted,
	UserTitle,
	UserFullName,
	UserEmailAddress
	)
	VALUES
	(
	@ID,
	@Title,
	@Description,
	@Postcode,
	@ItemType,
	@ImagePath,
	@DatePosted,
	@UserTitle,
	@UserFullName,
	@UserEmailAddress
	)
END
