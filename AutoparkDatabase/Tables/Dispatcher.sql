CREATE TABLE [dbo].[Dispatcher]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [BirthDate] DATE NOT NULL, 
    [Address] NVARCHAR(50) NOT NULL, 
    [Passport] NVARCHAR(50) NOT NULL UNIQUE
)

GO

CREATE INDEX [IX_Dispatcher_Id] ON [dbo].[Dispatcher] ([Id])

GO

CREATE INDEX [IX_Dispatcher_Name] ON [dbo].[Dispatcher] ([Name])
