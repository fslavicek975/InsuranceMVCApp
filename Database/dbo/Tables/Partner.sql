CREATE TABLE [dbo].[Partner]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(255) NOT NULL, 
    [LastName] NVARCHAR(255) NOT NULL, 
    [Address] NVARCHAR(255) NOT NULL, 
    [PartnerNumber] DECIMAL(20) NOT NULL, 
    [CroatianPIN] NVARCHAR(11) NULL, 
    [PartnerTypeId] INT NOT NULL, 
    [CreatedAtUtc] DATETIME NOT NULL, 
    [CreateByUser] NVARCHAR(255) NOT NULL, 
    [IsForeign] BIT NOT NULL, 
    [ExternalCode] NVARCHAR(20) NOT NULL, 
    [Gender] NCHAR(1) NOT NULL
)
