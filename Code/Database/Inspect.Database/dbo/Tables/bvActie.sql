CREATE TABLE [dbo].[bvActie] (
    [ActieCodeID]           INT           IDENTITY (1, 1) NOT NULL,
    [ActieCodeGroepId]      INT           CONSTRAINT [DF__bvActie__ActieCo__3AD6B8E2] DEFAULT ((0)) NULL,
    [ActieOmschr]           NVARCHAR (50) NULL,
    [InDagVerslagYN]        BIT           CONSTRAINT [DF__bvActie__InDagVe__3BCADD1B] DEFAULT ((1)) NULL,
    [OpPersoonlijkeFicheYN] BIT           CONSTRAINT [DF__bvActie__OpPerso__3CBF0154] DEFAULT ((0)) NULL,
    CONSTRAINT [aaaaaActieCode_PK] PRIMARY KEY NONCLUSTERED ([ActieCodeID] ASC) WITH (FILLFACTOR = 70)
);

