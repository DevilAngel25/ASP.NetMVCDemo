﻿CREATE TABLE [dbo].[CompanyDetails]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Address] NVARCHAR(MAX) NOT NULL, 
    [PhoneNumber] NVARCHAR(MAX) NOT NULL, 
    [Email] NVARCHAR(128) NOT NULL, 
    [VATRate] DECIMAL NULL
)
