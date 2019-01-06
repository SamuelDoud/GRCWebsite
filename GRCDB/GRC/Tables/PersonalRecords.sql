CREATE TABLE [grc].[PersonalRecords]
(
	[PersonId] INT NOT NULL , 
    [EventId] INT NOT NULL, 
    [Time] TIME NOT NULL, 
    [Date] DATE NULL, 
    [RaceName] NVARCHAR(50) NULL, 
    [GRC] BIT NOT NULL DEFAULT 0, 
    PRIMARY KEY ([PersonId], [EventId]), 
    CONSTRAINT [FK_PersonalRecords_Person] FOREIGN KEY ([PersonId]) REFERENCES [grc].[Persons]([Id]), 
    CONSTRAINT [FK_PersonalRecords_Event] FOREIGN KEY ([EventId]) REFERENCES [grc].[Events]([Id])
)
