CREATE TABLE [dbo].[Cards] (
    [Id]             INT          IDENTITY (1, 1) NOT NULL,
    [CardNumber]     VARCHAR (16) NOT NULL,
    [ExpirationDate] INT          NOT NULL,
	[TCard]			 INT		  NULL,
	[VCard]			 INT		  NULL,
    [CreationDate]   DATETIME     DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

