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

INSERT INTO [grc].[Persons] ([Name], Email, Gender, [Profile], IsActive)
VALUES
	('Jerry Alexander', 'jerry.alexander@live.com', 'M', 'beep', 1),
	('Samuel Doud', 'samueldoud@me.com', 'M', 'beep', 1);

INSERT INTO [grc].[Roles] (PersonId, Title)
VALUES (1, 'Head Coach');
	