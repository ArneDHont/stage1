CREATE TABLE [dbo].[BBINTART] (
    [ID_ART_INTV]    INT          NOT NULL,
    [ID_EH]          VARCHAR (10) NULL,
    [ID_GR_ART]      INT          NULL,
    [SCF_ART_INTV]   VARCHAR (50) NULL,
    [PR_EH_ART_INTV] FLOAT (53)   NULL,
    [TSP_DU_INTV]    BIT          NULL,
    CONSTRAINT [BBINTART_PK] PRIMARY KEY CLUSTERED ([ID_ART_INTV] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [BBARTGR_BBINTART_FK1] FOREIGN KEY ([ID_GR_ART]) REFERENCES [dbo].[BBARTGR] ([ID_GR_ART]),
    CONSTRAINT [BBEH_BBINTART_FK1] FOREIGN KEY ([ID_EH]) REFERENCES [dbo].[BBEH] ([ID_EH])
);


GO
CREATE NONCLUSTERED INDEX [I_BBINTART_02]
    ON [dbo].[BBINTART]([ID_EH] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBINTART_01]
    ON [dbo].[BBINTART]([ID_GR_ART] ASC) WITH (FILLFACTOR = 70);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het interventieartikel', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTART', @level2type = N'COLUMN', @level2name = N'ID_ART_INTV';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificeert de eenheid van het interventieartikel', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTART', @level2type = N'COLUMN', @level2name = N'ID_EH';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de artikelgroep', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTART', @level2type = N'COLUMN', @level2name = N'ID_GR_ART';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Omschrijving van het interventieartikel', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTART', @level2type = N'COLUMN', @level2name = N'SCF_ART_INTV';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Eenheidsprijs van het interventieartikel', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTART', @level2type = N'COLUMN', @level2name = N'PR_EH_ART_INTV';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Werd er een interventievoertuig gebruikt?', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTART', @level2type = N'COLUMN', @level2name = N'TSP_DU_INTV';

