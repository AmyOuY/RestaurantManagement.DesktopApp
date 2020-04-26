
CREATE PROCEDURE dbo.[spPeople_GetAll]

AS
BEGIN

	SET NOCOUNT ON;
	
	select * 
	from dbo.People;
END
