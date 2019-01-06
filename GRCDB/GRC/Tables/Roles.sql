CREATE TABLE [grc].[Roles]
(
	[PersonId] INT NOT NULL , 
    [Title] VARCHAR(50) NOT NULL, 
    [BeginDate] DATE NOT NULL DEFAULT GETDATE(), 
    [EndDate] DATE NULL, 
    PRIMARY KEY ([Title], [PersonId]), 
    CONSTRAINT [FK_Roles_Person] FOREIGN KEY ([PersonId]) REFERENCES [grc].[Persons]([Id])
)
