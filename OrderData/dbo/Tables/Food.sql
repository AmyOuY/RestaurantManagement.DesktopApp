CREATE TABLE [dbo].[Food] (
    [id]       INT            IDENTITY (1, 1) NOT NULL,
    [FoodType] NVARCHAR (100) NOT NULL,
    [FoodName] NVARCHAR (100) NOT NULL,
    [Price]    MONEY          NOT NULL,
    [Quantity] INT            NULL,
    CONSTRAINT [PK_Food] PRIMARY KEY CLUSTERED ([id] ASC)
);

