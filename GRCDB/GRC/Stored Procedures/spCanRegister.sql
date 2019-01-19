CREATE PROCEDURE [grc].[spCanRegister]
(
	@Email nvarchar(64)
)
AS
	SELECT CASE WHEN @Email in (SELECT Email FROM GRC.Persons WHERE IsRegistered = 0) THEN 1 ELSE 0 END;
RETURN 0
