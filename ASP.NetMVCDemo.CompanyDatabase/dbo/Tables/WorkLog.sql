CREATE TABLE [dbo].[WorkLog]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EmployeeId] INT NOT NULL, 
    [WorkOrderId] INT NOT NULL, 
    [DateofJob] DATETIME NOT NULL, 
    [HoursWorked] NUMERIC NOT NULL, 
    CONSTRAINT [FK_WorkLog_Employee] FOREIGN KEY ([EmployeeId]) REFERENCES [Employee]([Id]), 
    CONSTRAINT [FK_WorkLog_WorkOrder] FOREIGN KEY ([WorkOrderId]) REFERENCES [WorkOrder]([Id])
)
