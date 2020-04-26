
CREATE PROCEDURE dbo.spTable_GetAll 

AS
BEGIN

	SET NOCOUNT ON;

	select *
	from dbo.DiningTable;

END
