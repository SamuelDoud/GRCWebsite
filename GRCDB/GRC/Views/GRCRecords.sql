CREATE VIEW [grc].[GRCRecords]
	AS
	WITH TOPFIVE AS
	(
		SELECT TOP 100000 -- workaround as views cannot have order bys without a TOP
			ppl.[Name],
			e.Distance,
			e.Surface,
			pr.RaceName,
			pr.[Date],
			pr.[Time],
			ppl.Gender,
			ROW_NUMBER() OVER (PARTITION BY pr.EventID, pr.PersonId, e.Distance, e.Surface, ppl.Gender) RowNum
		FROM
			[grc].[PersonalRecords] pr
			INNER JOIN
				[grc].[Persons] ppl
				ON
				pr.PersonId = ppl.[Name]
			INNER JOIN
				[grc].[Events] e
				ON
				pr.EventId = e.Id
		WHERE
			pr.GRC = 1
		ORDER BY
			e.Distance ASC, ppl.Gender, e.Surface, pr.[Time]
	)
	SELECT * FROM TOPFIVE WHERE RowNum <= 5;