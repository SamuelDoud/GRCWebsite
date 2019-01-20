CREATE PROCEDURE [grc].[spGetPerson]
(
	@PersonId int
)
AS
	SELECT
		*
	FROM
		[grc].[Persons]
	WHERE
		@PersonId = Id;
RETURN 0
