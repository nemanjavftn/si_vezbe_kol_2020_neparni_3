CREATE TABLE [dbo].[Cars] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [Model]          NVARCHAR (50) NOT NULL,
    [ProductionYear] INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

