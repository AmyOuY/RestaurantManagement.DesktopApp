
CREATE PROCEDURE [dbo].[spPeople_Insert]
	@EmployeeID int,
	@FirstName nvarchar(100),
	@LastName nvarchar(100),
	@EmailAddress nvarchar(100),
	@CellphoneNumber varchar(20),
	@id int = 0 output
AS
BEGIN

	SET NOCOUNT ON;

	insert into dbo.People (EmployeeID, FirstName, LastName, EmailAddress, CellphoneNumber)
	values (@EmployeeID, @FirstName, @LastName, @EmailAddress, @CellphoneNumber);

	select @id = SCOPE_IDENTITY();

END
