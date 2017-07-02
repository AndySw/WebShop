CREATE TABLE [dbo].[product]
(
	[id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [name] NVARCHAR(16) NOT NULL, 
    [price] REAL NOT NULL
)
