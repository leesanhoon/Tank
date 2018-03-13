CREATE TABLE [dbo].[Table] (
    [Id]    INT  IDENTITY (1, 1) NOT NULL,
    [Score] INT  NOT NULL,
    [Date]  DATE DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

