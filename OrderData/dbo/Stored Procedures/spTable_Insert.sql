CREATE PROCEDURE dbo.spTable_Insert 
	@TableNumber int,
	@Seats int,
	@id int = 0 output
AS
BEGIN

	SET NOCOUNT ON;

	insert into dbo.DiningTable (TableNumber, Seats)
	values (@TableNumber, @Seats);

	select @id = SCOPE_IDENTITY();

END
