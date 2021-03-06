USE [TreasureRoom]
GO
/****** Object:  StoredProcedure [dbo].[Post_RetrieveItemsUsers]    Script Date: 04/02/2021 11:21:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Aryan Dang
-- Create date: 27 JAN 2021
-- Description:	To store values to dbo.RetrieveItemsUsers
-- =============================================
ALTER PROCEDURE [dbo].[Post_RetrieveItemsUsers]
	@ID nvarchar(100),
	@FullName nvarchar(100),
	@EmailAddress nvarchar(100),
	@PhoneNumber nvarchar(50),
	@AgeAbove18AndHonesty bit,
	@ConsentToData bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO [dbo.RetrieveItemsUsers]
	(
	ID,
	FullName,
	EmailAddress,
	PhoneNumber,
	AgeAbove18AndHonesty,
	ConsentToData
	)
	VALUES
	(
	@ID,
	@FullName,
	@EmailAddress,
	@PhoneNumber,
	@AgeAbove18AndHonesty,
	@ConsentToData
	)
END
