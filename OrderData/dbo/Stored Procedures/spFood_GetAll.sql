
CREATE PROCEDURE dbo.spFood_GetAll 

AS
BEGIN
	SET NOCOUNT ON;

	select *
	from dbo.Food;

END
