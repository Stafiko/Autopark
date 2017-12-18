CREATE TABLE [dbo].[Transport]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Number] NVARCHAR(50) NOT NULL, 
    [RouteId] INT NOT NULL, 
    [TicketId] INT NOT NULL, 
    [DispatcherId] INT NOT NULL, 
    [BusId] INT NOT NULL, 
    [DriverId] INT NOT NULL, 
    CONSTRAINT [FK_Transport_Route] FOREIGN KEY ([RouteId]) REFERENCES [Route]([Id]), 
    CONSTRAINT [FK_Transport_Ticket] FOREIGN KEY ([TicketId]) REFERENCES [Ticket]([Id]), 
    CONSTRAINT [FK_Transport_Dispatcher] FOREIGN KEY ([DispatcherId]) REFERENCES [Dispatcher]([Id]), 
    CONSTRAINT [FK_Transport_Bus] FOREIGN KEY ([BusId]) REFERENCES [Bus]([Id]), 
    CONSTRAINT [FK_Transport_Driver] FOREIGN KEY ([DriverId]) REFERENCES [Driver]([Id])
)

GO

CREATE INDEX [IX_Transport_Id] ON [dbo].[Transport] ([Id])

GO

CREATE INDEX [IX_Transport_Number] ON [dbo].[Transport] ([Number])

GO

CREATE INDEX [IX_Transport_Route] ON [dbo].[Transport] ([RouteId])

GO

CREATE INDEX [IX_Transport_Ticket] ON [dbo].[Transport] ([TicketId])

GO

CREATE INDEX [IX_Transport_Dispatcher] ON [dbo].[Transport] ([DispatcherId])

GO

CREATE INDEX [IX_Transport_Bus] ON [dbo].[Transport] ([BusId])

GO

CREATE INDEX [IX_Transport_Driver] ON [dbo].[Transport] ([DriverId])
