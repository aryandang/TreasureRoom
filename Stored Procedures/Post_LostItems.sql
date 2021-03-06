USE [TreasureRoom]
GO
/****** Object:  StoredProcedure [dbo].[Post_LostItems]    Script Date: 04/02/2021 11:23:06 ******/
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
	@EditID nvarchar(50),
	@Title nvarchar(50),
	@Description nvarchar(255),
	@Postcode nvarchar(50),
	@ItemType nvarchar(50),
	@ImagePath nvarchar(500),
	@DatePosted datetime,
	@UserTitle nvarchar(50),
	@UserFullName nvarchar(100),
	@UserEmailAddress nvarchar(50),
	@Question1 nvarchar(100),
	@Answer1 nvarchar(100),
	@Question2 nvarchar(100),
	@Answer2 nvarchar(100),
	@Question3 nvarchar(100),
	@Answer3 nvarchar(100),
	@AgeAbove18AndHonesty bit,
	@ConsentToData bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	INSERT INTO [dbo.LostItems]
	(
	ID,
	EditID,
	Title,
	Description,
	Postcode,
	ItemType,
	ImagePath,
	DatePosted,
	UserTitle,
	UserFullName,
	UserEmailAddress,
	Question1,
	Answer1,
	Question2,
	Answer2,
	Question3,
	Answer3,
	AgeAbove18AndHonesty,
	ConsentToData
	)
	VALUES
	(
	@ID,
	@EditID,
	@Title,
	@Description,
	@Postcode,
	@ItemType,
	@ImagePath,
	@DatePosted,
	@UserTitle,
	@UserFullName,
	@UserEmailAddress,
	@Question1,
	@Answer1,
	@Question2,
	@Answer2,
	@Question3,
	@Answer3,
	@AgeAbove18AndHonesty,
	@ConsentToData
	)
END
