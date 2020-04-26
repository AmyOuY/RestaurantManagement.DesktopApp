
CREATE PROCEDURE dbo.spFood_Insert
	@FoodType nvarchar(100),
	@FoodName nvarchar(100),
	@Price money,
	@Quantity int,
	@id int = 0 output
AS
BEGIN

	SET NOCOUNT ON;

	insert into dbo.Food (FoodType, FoodName, Price, Quantity)
	values (@FoodType, @FoodName, @Price, @Quantity);

	select @id = SCOPE_IDENTITY();
END
