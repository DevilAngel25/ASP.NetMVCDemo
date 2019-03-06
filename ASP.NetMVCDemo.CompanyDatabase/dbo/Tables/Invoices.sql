CREATE TABLE [dbo].[Invoices]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [WorkLogId] INT NOT NULL, 
    [WorkOrderId] INT NOT NULL, 
    [ClientId] INT NOT NULL, 
    [Date] DATETIME NOT NULL, 
    [Terms] TEXT NULL, 
    [DetailsOfCharges] TEXT NOT NULL, 
    [SubTotal] NUMERIC NOT NULL, 
    CONSTRAINT [FK_Invoices_WorkLog] FOREIGN KEY ([WorkLogId]) REFERENCES [WorkLog]([Id]), 
    CONSTRAINT [FK_Invoices_WorkOrder] FOREIGN KEY ([WorkOrderId]) REFERENCES [WorkOrder]([Id]), 
    CONSTRAINT [FK_Invoices_Client] FOREIGN KEY ([ClientId]) REFERENCES [Client]([Id])
)
