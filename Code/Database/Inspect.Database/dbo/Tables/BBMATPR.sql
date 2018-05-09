CREATE TABLE [dbo].[BBMATPR] (
    [ID_PR_MAT]    INT        IDENTITY (60, 1) NOT NULL,
    [ID_INTV_BRDW] INT        NULL,
    [ID_ART_INTV]  INT        NULL,
    [Q_ART]        INT        NULL,
    [PR_TOT_ART]   FLOAT (53) NULL,
    CONSTRAINT [BBMATPR_PK] PRIMARY KEY CLUSTERED ([ID_PR_MAT] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [BBINTART_BBMATPR_FK1] FOREIGN KEY ([ID_ART_INTV]) REFERENCES [dbo].[BBINTART] ([ID_ART_INTV]),
    CONSTRAINT [BBINTVBR_BBMATPR_FK1] FOREIGN KEY ([ID_INTV_BRDW]) REFERENCES [dbo].[BBINTVBR] ([ID_INTV_BRDW])
);


GO
CREATE NONCLUSTERED INDEX [I_BBMATPR_02]
    ON [dbo].[BBMATPR]([ID_INTV_BRDW] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBMATPR_01]
    ON [dbo].[BBMATPR]([ID_ART_INTV] ASC) WITH (FILLFACTOR = 70);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de materiaalkost', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBMATPR', @level2type = N'COLUMN', @level2name = N'ID_PR_MAT';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de brandweerinterventie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBMATPR', @level2type = N'COLUMN', @level2name = N'ID_INTV_BRDW';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het artikel', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBMATPR', @level2type = N'COLUMN', @level2name = N'ID_ART_INTV';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Het aantal artikels', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBMATPR', @level2type = N'COLUMN', @level2name = N'Q_ART';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De totale prijs per artikel', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBMATPR', @level2type = N'COLUMN', @level2name = N'PR_TOT_ART';

