
CREATE PROCEDURE dbo.spFood_GetByType 
	@type nvarchar(100)
AS
BEGIN

	SET NOCOUNT ON;

	select *
	from dbo.Food
	where FoodType = @type;

END
