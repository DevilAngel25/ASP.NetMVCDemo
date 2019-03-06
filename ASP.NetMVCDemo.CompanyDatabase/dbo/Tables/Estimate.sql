CREATE TABLE [dbo].[Estimate]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ClientId] INT NOT NULL, 
    [DateIssued ] DATETIME NULL, 
    [HourlyCharge] NUMERIC NULL, 
    [TotalCharge] NUMERIC NULL, 
	[JobDescription] TEXT NULL, 
    [Conditionals] TEXT NULL, 
    [Notes] TEXT NULL, 
    CONSTRAINT [FK_Estimate_Client] FOREIGN KEY ([ClientId]) REFERENCES [Client]([Id])
)
