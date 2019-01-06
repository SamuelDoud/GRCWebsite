/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO [grc].[Persons] ([Name], NickName, Email, Gender, IsActive, BirthDate, Undergraduate, Graduate)
VALUES
	('Nina May Brekelmans', 'Nina', NULL, 'F', 0, '1990-03-06', 'Dartmouth College', Null),
	('Lauren Woodall Roady', 'Lauren', NULL, 'F', 0, '1985-10-20', 'Davidson College', NULL),
	('Jerry Alexander', 'Jerry', 'jerry.alexander@live.com', 'M', 1, NULL, 'Columbia University', 'Villanova University'),
	('Samuel Doud', 'Mileage Sam', 'samueldoud@me.com', 'M', 1, '1995-10-23', 'American University', NULL);

INSERT INTO [grc].[Roles] (PersonId, Title)
VALUES
	(3, 'Head Coach');
	