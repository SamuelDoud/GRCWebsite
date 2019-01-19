CREATE TABLE [grc].[Persons]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(128) NOT NULL, 
    [Email] NVARCHAR(64) NULL, 
    [PhoneNumber] VARCHAR(16) NULL, 
    [IsActive] BIT NOT NULL,
	[IsRegistered] BIT DEFAULT 0 NOT NULL,
    [Profile] NVARCHAR(MAX) NULL, 
    [Gender] CHAR NOT NULL, 
    [BirthDate] DATE NULL,
    [Undergraduate] VARCHAR(50) NULL,
    [Graduate] VARCHAR(50) NULL,
	[AdditionalSchools] VARCHAR(64) NULL
)
