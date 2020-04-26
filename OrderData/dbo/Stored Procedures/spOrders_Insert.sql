
CREATE PROCEDURE [dbo].[spOrders_Insert]
	@TableNumber int,
	@Attendant nvarchar(100),
	@id int = 0 output

AS
BEGIN

	SET NOCOUNT ON;

	insert into dbo.Orders (TableNumber, Attendant)
	values (@TableNumber, @Attendant);

	select @id = SCOPE_IDENTITY();

END
