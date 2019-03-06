CREATE TABLE [dbo].[Client]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[FirstName] NVARCHAR(50) NOT NULL, 
	[LastName] NVARCHAR(50) NOT NULL, 
	[CompanyName] NVARCHAR(50) NOT NULL, 
    [CompanyAddress] NVARCHAR(128) NOT NULL, 
    [CompanyPostCode] NVARCHAR(50) NOT NULL,
	[EmailAddress] NVARCHAR(128) NOT NULL,
	[PhoneNumber] NVARCHAR(50) NOT NULL
)
