CREATE TABLE [dbo].[bmMateriaalActie] (
    [ActieID]         INT            IDENTITY (1, 1) NOT NULL,
    [TypeMatID]       INT            NOT NULL,
    [MateriaalVolgNr] INT            NOT NULL,
    [Datum]           DATETIME       NOT NULL,
    [ActieCodeID]     INT            NULL,
    [Gewicht]         NUMERIC (5, 2) NULL,
    CONSTRAINT [PK_qryActies] PRIMARY KEY CLUSTERED ([ActieID] ASC) WITH (FILLFACTOR = 70)
);

