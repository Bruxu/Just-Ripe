CREATE TABLE [dbo].[Vehicle]
(
	[NumberPlate] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Quantity] VARCHAR(50) NOT NULL, 
    [Status] VARCHAR(50) NULL, 
    [Availability] BINARY(50) NOT NULL
)
