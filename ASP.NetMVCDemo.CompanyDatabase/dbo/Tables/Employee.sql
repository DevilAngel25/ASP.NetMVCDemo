CREATE TABLE [dbo].[Employee]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(128) NULL, 
    [PhoneNumber] NVARCHAR(MAX) NULL, 
    [Address] NVARCHAR(MAX) NULL, 
    [HourlyPayRate] NUMERIC NULL, 
    [HourlyBillingRate] NUMERIC NULL
)
