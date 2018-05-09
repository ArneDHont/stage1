CREATE TABLE [dbo].[bvDagVerslagActie] (
    [DagVerslagActieID]       INT          IDENTITY (1, 1) NOT NULL,
    [DagVerslagID]            INT          CONSTRAINT [DF__DagVersla__DagVe__19FFD4FC] DEFAULT ((0)) NULL,
    [WerknemerID]             NVARCHAR (7) NULL,
    [ActieCodeID]             INT          NULL,
    [AantalUur]               INT          NULL,
    [AantalMinuten]           INT          CONSTRAINT [DF__DagVersla__Aanta__1AF3F935] DEFAULT ((0)) NULL,
    [OpleidingAfdelingID]     INT          NULL,
    [OpleidingAantalPersonen] SMALLINT     NULL,
    CONSTRAINT [aaaaaDagVerslagActie_PK] PRIMARY KEY NONCLUSTERED ([DagVerslagActieID] ASC) WITH (FILLFACTOR = 70)
);

