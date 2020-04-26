
CREATE PROCEDURE dbo.spFood_GetByOrder 
	@OrderID int

AS
BEGIN

	SET NOCOUNT ON;

	select *
	from dbo.OrderFood
	where OrderID = @OrderID;

END
