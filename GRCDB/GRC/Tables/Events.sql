CREATE TABLE [grc].[Events]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Distance] VARCHAR(50) NOT NULL, 
    [SurfaceId] INT NOT NULL, 
    CONSTRAINT [FK_Events_Surfaces] FOREIGN KEY ([SurfaceId]) REFERENCES [grc].[Surfaces]([Id])
)
