CREATE TABLE [dbo].[BBINBRKlasse] (
    [InbreukKlasseID] INT            NOT NULL,
    [InbreukKlasse]   NVARCHAR (100) NULL,
    [Opmerking]       NVARCHAR (250) NULL,
    [ValueNL]         NVARCHAR (100) NULL,
    [ValueFR]         NVARCHAR (100) NULL,
    [ValueEN]         NVARCHAR (100) NULL,
    [ValueDE]         NVARCHAR (100) NULL,
    CONSTRAINT [PK_BBINBRKlasses] PRIMARY KEY CLUSTERED ([InbreukKlasseID] ASC) WITH (FILLFACTOR = 70)
);

