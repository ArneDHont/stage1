CREATE TABLE [dbo].[bmStatus] (
    [StatusId] INT           IDENTITY (1, 1) NOT NULL,
    [Status]   NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_bmStatus] PRIMARY KEY CLUSTERED ([StatusId] ASC) WITH (FILLFACTOR = 70)
);

