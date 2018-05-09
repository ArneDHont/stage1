CREATE TABLE [dbo].[bvDagverslag] (
    [DagVerslagID]   INT          IDENTITY (1, 1) NOT NULL,
    [Datum]          DATETIME     NULL,
    [PloegoversteID] NVARCHAR (7) NULL,
    [PloegID]        INT          NULL,
    [Opmerkingen]    NTEXT        NULL,
    CONSTRAINT [PK_Dagverslag] PRIMARY KEY CLUSTERED ([DagVerslagID] ASC) WITH (FILLFACTOR = 70)
);

