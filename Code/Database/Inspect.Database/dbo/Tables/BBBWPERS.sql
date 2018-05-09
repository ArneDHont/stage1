CREATE TABLE [dbo].[BBBWPERS] (
    [ID_IND]     INT NOT NULL,
    [ID_PLG_IND] INT NULL,
    [BRDW]       BIT NULL,
    [WAK]        BIT NULL,
    [ActiefYN]   BIT CONSTRAINT [DF_BBBWPERS_ActiefYN] DEFAULT ((1)) NULL,
	[VolgnrBewaking_Identificatiekaart] NVARCHAR(50) CONSTRAINT [DF_BBBWPERS_VolgnrBewaking_Identificatiekaart]  DEFAULT ((0)) NULL,
    CONSTRAINT [BBBWPERS_PK] PRIMARY KEY CLUSTERED ([ID_IND] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [FK_BBBWPERS_BBBWPLG] FOREIGN KEY ([ID_PLG_IND]) REFERENCES [dbo].[BBBWPLG] ([ID_PLG_IND]),
    CONSTRAINT [FK_BBBWPERS_BBIND] FOREIGN KEY ([ID_IND]) REFERENCES [dbo].[BBIND] ([ID_IND])
);


GO
CREATE NONCLUSTERED INDEX [I_BBBWPERS_01]
    ON [dbo].[BBBWPERS]([ID_PLG_IND] ASC) WITH (FILLFACTOR = 70);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het individu (personeelslid)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBWPERS', @level2type = N'COLUMN', @level2name = N'ID_IND';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Het ploegnummer van het individu (BBWPersoneelslid)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBWPERS', @level2type = N'COLUMN', @level2name = N'ID_PLG_IND';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Brandweerman?', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBWPERS', @level2type = N'COLUMN', @level2name = N'BRDW';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Bewaker?', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBWPERS', @level2type = N'COLUMN', @level2name = N'WAK';

