CREATE PROCEDURE [grc].[spRegisterPerson]
(
	@Email nvarchar(64)
)
AS
	UPDATE grc.Persons
	SET IsRegistered = 1
	WHERE @Email = Email;
RETURN 0
