INSERT INTO [grc].[Surfaces] (Surface)
Values ('Roads'), ('Trails'), ('Indoor Track'), ('Outdoor Track');

INSERT INTO [grc].[Events] (SurfaceId, Distance)
VALUES
	(1, 'Marathon'), (1, 'Half-Marathon'), (1, '10 Mile'), (1, '15K'), (1, '10K'), (1, '5K'), (1, '1 Mile'), (1, '5 Mile'),
	(2, 'Ultra-Marathon 50M'), (2, 'Ultra-Marathon 50K'), (2, 'Ultra-Marathon 100M'), (2, 'Ultra-Marathon 100K'),
	(3, '5000m'), (3, '3000m'), (3, '1 Mile'), (3, '1500m'), (3, '1000m'), (3, '800m'), (3, '600m'), (3, '500m'), (3, '400m'), (3, '300m'), (3, '200m'), (3, '55m'), -- I have no concept of hurdle events
	(3, '4x800m Relay'), (3, '4x400m'), (3, '4x200m Relay'), (3, 'Distance Medley Relay'),
	(4, '10000m'), (4, '5000m'), (4, '3000m Steeplechase'), (4, '1500m'), (4, '800m'), (4, '400m'), (4, '200m'), (4, '100m'),
	(4, '4x800m Relay'), (4, '4x400m'), (4, '4x200m Relay'), (4, '4x100m Relay');

-- All this data aside from Jerry, Nina, and Lauren is temporary. There will be a more formal process
-- to insert data in the future

-- Profile will likely get moved to a text file or will be the path to their user folder
INSERT INTO [grc].[Persons] ([Name], Email, Gender, IsActive, BirthDate, Undergraduate, Graduate, [Profile])
VALUES
	('Nina May Brekelmans', 'Nina', 'F', 0, '1990-03-06', 'Dartmouth College', Null, Null),
	('Lauren Woodall Roady', 'Lauren', 'F', 0, '1985-10-20', 'Davidson College', NULL, Null),
	('Jerry Alexander', 'jerry.alexander@live.com', 'M', 1, NULL, 'Columbia University', 'Villanova University', Null),
	('Samuel Doud', 'samueldoud@me.com', 'M', 1, '1995-10-23', 'American University', NULL, 'A Test');

INSERT INTO [grc].[PersonalRecords] (PersonId, EventId, [Time], [Date], GRC)
VALUES (4, 1, '2:19:52', '2018-12-02', 1)

INSERT INTO [grc].[Roles] (PersonId, Title)
VALUES (3, 'Head Coach');


	