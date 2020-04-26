
CREATE PROCEDURE dbo.spFoodType_GetAll

AS
BEGIN

	SET NOCOUNT ON;

	select distinct FoodType
	from dbo.Food;

END
