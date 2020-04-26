CREATE TABLE [dbo].[OrderFood] (
    [id]       INT            IDENTITY (1, 1) NOT NULL,
    [OrderID]  INT            NOT NULL,
    [FoodType] NVARCHAR (100) NOT NULL,
    [FoodName] NVARCHAR (100) NOT NULL,
    [Price]    MONEY          NOT NULL,
    [Quantity] INT            NOT NULL,
    CONSTRAINT [PK_OrderFood] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_OrderFood_OrderFood] FOREIGN KEY ([OrderID]) REFERENCES [dbo].[Orders] ([id])
);

