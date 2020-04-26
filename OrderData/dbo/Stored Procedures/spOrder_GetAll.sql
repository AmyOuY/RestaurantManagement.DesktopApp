
CREATE PROCEDURE dbo.spOrder_GetAll

AS
BEGIN

	SET NOCOUNT ON;

	select *
	from dbo.Orders;

END
