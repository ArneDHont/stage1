CREATE TABLE [dbo].[bvActieGroep] (
    [ActieCodeGroepId]     INT           IDENTITY (1, 1) NOT NULL,
    [ActieCodeGroepOmschr] NVARCHAR (80) NULL,
    [brdw]                 BIT           CONSTRAINT [DF_bvActieGroep_brdw] DEFAULT ((0)) NOT NULL,
    [wak]                  BIT           CONSTRAINT [DF_bvActieGroep_wak] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_ActieCodeGroep] PRIMARY KEY CLUSTERED ([ActieCodeGroepId] ASC) WITH (FILLFACTOR = 70)
);

