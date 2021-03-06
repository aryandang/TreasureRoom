USE [TreasureRoom]
GO
/****** Object:  StoredProcedure [dbo].[Update_LostItems]    Script Date: 01/02/2021 10:30:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Aryan Dang
-- Create date: 01 FEB 2021
-- Description:	Update data in dbo.LostItems
-- =============================================
ALTER PROCEDURE [dbo].[Update_LostItems]
	-- Add the parameters for the stored procedure here
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
	@Answer3 nvarchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo.LostItems]
	SET
	Title = @Title,
	Description = @Description,
	Postcode = @Postcode,
	ItemType = @ItemType,
	ImagePath = @ImagePath,
	DatePosted = @DatePosted,
	UserTitle = @UserTitle,
	UserFullName = @UserFullName,
	UserEmailAddress = @UserEmailAddress,
	Question1 = @Question1,
	Answer1 = @Answer1,
	Question2 = @Question2,
	Answer2 = @Answer2,
	Question3 = @Question3,
	Answer3 = Answer3
	WHERE
	EditID = @EditID
END
