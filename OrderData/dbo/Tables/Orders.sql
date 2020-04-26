CREATE TABLE [dbo].[Orders] (
    [id]          INT            IDENTITY (1, 1) NOT NULL,
    [TableNumber] INT            NOT NULL,
    [Attendant]   NVARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED ([id] ASC)
);

