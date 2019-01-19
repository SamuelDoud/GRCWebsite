CREATE TABLE [grc].[Nicknames]
(
	[PersonId] INT NOT NULL , 
    [NickName] VARCHAR(64) NOT NULL, 
    PRIMARY KEY ([PersonId], [NickName]), 
    CONSTRAINT [FK_Nicknames_Person] FOREIGN KEY ([PersonId]) REFERENCES [grc].[Persons]([Id])
)
