CREATE TABLE [dbo].[BBINTVDU] (
    [ID_DU_INTV]   INT      IDENTITY (13, 1) NOT NULL,
    [ID_INTV_BRDW] INT      NULL,
    [ID_ART_INTV]  INT      NULL,
    [TYD_OPR]      DATETIME NULL,
    [TYD_KO]       DATETIME NULL,
    [TYD_END]      DATETIME NULL,
    CONSTRAINT [BBINTVDU_PK] PRIMARY KEY CLUSTERED ([ID_DU_INTV] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [BBINTART_BBINTVDU_FK1] FOREIGN KEY ([ID_ART_INTV]) REFERENCES [dbo].[BBINTART] ([ID_ART_INTV]),
    CONSTRAINT [BBINTVBR_BBINTVDU_FK1] FOREIGN KEY ([ID_INTV_BRDW]) REFERENCES [dbo].[BBINTVBR] ([ID_INTV_BRDW])
);


GO
CREATE NONCLUSTERED INDEX [I_BBINTVDU_02]
    ON [dbo].[BBINTVDU]([ID_INTV_BRDW] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBINTVDU_01]
    ON [dbo].[BBINTVDU]([ID_ART_INTV] ASC) WITH (FILLFACTOR = 70);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de interventietijd', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVDU', @level2type = N'COLUMN', @level2name = N'ID_DU_INTV';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de brandweerinterventie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVDU', @level2type = N'COLUMN', @level2name = N'ID_INTV_BRDW';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het interventieartikel', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVDU', @level2type = N'COLUMN', @level2name = N'ID_ART_INTV';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Het tijdstip van de oproep', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVDU', @level2type = N'COLUMN', @level2name = N'TYD_OPR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Het tijdstip van de aankomst', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVDU', @level2type = N'COLUMN', @level2name = N'TYD_KO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Het tijdstip van inrukken (einde)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVDU', @level2type = N'COLUMN', @level2name = N'TYD_END';

