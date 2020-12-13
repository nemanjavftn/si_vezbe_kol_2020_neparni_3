CREATE TABLE [dbo].[Car]
(
	[Id] INT  NOT NULL IDENTITY(1,1), 
    [Model] NVARCHAR(50) NOT NULL, 
    [ProductionYear] INT NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([Id])
)
