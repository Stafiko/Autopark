CREATE TABLE [dbo].[Ticket]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Price] INT NOT NULL, 
    [BuyDate] DATE NOT NULL, 
    [Place] INT NOT NULL, 
    [Passenger] NVARCHAR(50) NOT NULL, 
    [Passport] NVARCHAR(50) NOT NULL UNIQUE, 
    [Discount] BIT NOT NULL DEFAULT 0, 
    CONSTRAINT [CK_Ticket_Price] CHECK (Price > 0), 
    CONSTRAINT [CK_Ticket_Place] CHECK (Place > 0)
)

GO

CREATE INDEX [IX_Ticket_Id] ON [dbo].[Ticket] ([Id])

GO

CREATE INDEX [IX_Ticket_Passenger] ON [dbo].[Ticket] ([Passenger])
