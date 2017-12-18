CREATE TABLE [dbo].[Bus]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Number] NVARCHAR(50) NOT NULL, 
    [Model] NVARCHAR(50) NOT NULL, 
    [Numberplate] NVARCHAR(50) NOT NULL UNIQUE, 
    [Size] INT NOT NULL, 
    CONSTRAINT [CK_Bus_Size] CHECK (Size > 0)
)

GO

CREATE INDEX [IX_Bus_Id] ON [dbo].[Bus] ([Id])

GO

CREATE INDEX [IX_Bus_Number] ON [dbo].[Bus] ([Number])
