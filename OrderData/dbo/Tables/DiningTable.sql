CREATE TABLE [dbo].[DiningTable] (
    [id]          INT IDENTITY (1, 1) NOT NULL,
    [TableNumber] INT NOT NULL,
    [Seats]       INT NOT NULL,
    CONSTRAINT [PK_DiningTable] PRIMARY KEY CLUSTERED ([id] ASC)
);

