CREATE TABLE [dbo].[WorkOrder]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EstimateId] INT NOT NULL, 
    [Approved] BIT NOT NULL, 
    [Date] DATETIME NOT NULL, 
    [Notes] TEXT NULL, 
    CONSTRAINT [FK_WorkOrder_Estimate] FOREIGN KEY ([EstimateId]) REFERENCES [Estimate]([Id])
)
