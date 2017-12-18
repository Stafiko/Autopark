CREATE TABLE [dbo].[Route]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Number] NVARCHAR(50) NOT NULL, 
    [Departure] NVARCHAR(50) NOT NULL DEFAULT 'Ижевск', 
    [Destination] NVARCHAR(50) NOT NULL, 
    [Distance] INT NOT NULL, 
    [BeginDate] DATE NOT NULL, 
    [EndDate] DATE NOT NULL, 
    CONSTRAINT [CK_Route_Distance] CHECK (Distance > 0)
)

GO

CREATE INDEX [IX_Route_Id] ON [dbo].[Route] ([Id])

GO

CREATE INDEX [IX_Route_Number] ON [dbo].[Route] ([Number])

GO

CREATE INDEX [IX_Route_Departure] ON [dbo].[Route] ([Departure])

GO

CREATE INDEX [IX_Route_Destination] ON [dbo].[Route] ([Destination])
