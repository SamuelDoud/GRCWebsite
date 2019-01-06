CREATE TABLE [grc].[Persons]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(128) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [PhoneNumber] VARCHAR(16) NULL, 
    [AlmaMater] VARCHAR(50) NULL,
    [IsActive] BIT NOT NULL,
	[IsRegistered] BIT DEFAULT 0 NOT NULL,
    [Profile] NVARCHAR(MAX) NULL, 
    [Gender] CHAR NOT NULL, 
    [BirthDate] DATE NULL 
)
