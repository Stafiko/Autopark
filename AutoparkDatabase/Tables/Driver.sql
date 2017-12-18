CREATE TABLE [dbo].[Driver]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [BirthDate] DATE NOT NULL, 
    [Address] NVARCHAR(50) NOT NULL, 
    [Passport] NVARCHAR(50) NOT NULL UNIQUE
)

GO

CREATE INDEX [IX_Driver_Id] ON [dbo].[Driver] ([Id])

GO

CREATE INDEX [IX_Driver_Name] ON [dbo].[Driver] ([Name])
