CREATE PROCEDURE [grc].[spCanRegister]
(
	@Email nvarchar(64)
)
AS
	SELECT
		CAST (
			CASE
				WHEN @Email in (SELECT Email FROM grc.Persons WHERE IsRegistered = 0) THEN 1
				ELSE 0 END
			AS BIT
			) as CanRegister;
RETURN 0
