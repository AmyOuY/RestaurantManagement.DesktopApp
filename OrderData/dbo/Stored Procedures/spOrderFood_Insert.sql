
CREATE PROCEDURE [dbo].[spOrderFood_Insert] 
	@OrderID int,
	@FoodType nvarchar(100),
	@FoodName nvarchar(100),
	@Price money,
	@Quantity int,
	@id int = 0 output

AS
BEGIN

	SET NOCOUNT ON;

	insert into dbo.OrderFood (OrderID, FoodType, FoodName, Price, Quantity)
	values (@OrderID, @FoodType, @FoodName, @Price, @Quantity);

	select @id = SCOPE_IDENTITY();

END
