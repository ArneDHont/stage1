CREATE TABLE [dbo].[BBBRKART] (
    [ID_ART_BRK]     INT          IDENTITY (105, 1) NOT NULL,
    [ID_GR_ART]      INT          NULL,
    [ID_EH]          VARCHAR (10) NULL,
    [NR_ART_BRK_SAP] VARCHAR (20) NULL,
    [SCF_ART]        VARCHAR (80) NULL,
    [STK_ACT_ART]    INT          NULL,
    [STK_MIN_ART]    INT          NULL,
    [STK_MAX_ART]    FLOAT (53)   NULL,
    [PR_EH_ART_INTV] FLOAT (53)   NULL,
    [DT_WY_L]        DATETIME     NULL,
    CONSTRAINT [BBBRKART_PK] PRIMARY KEY CLUSTERED ([ID_ART_BRK] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [BBARTGR_BBBRKART_FK1] FOREIGN KEY ([ID_GR_ART]) REFERENCES [dbo].[BBARTGR] ([ID_GR_ART]),
    CONSTRAINT [BBEH_BBBRKART_FK1] FOREIGN KEY ([ID_EH]) REFERENCES [dbo].[BBEH] ([ID_EH])
);


GO
CREATE NONCLUSTERED INDEX [I_BBBRKART_01]
    ON [dbo].[BBBRKART]([ID_GR_ART] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBBRKART_02]
    ON [dbo].[BBBRKART]([ID_EH] ASC) WITH (FILLFACTOR = 70);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het verbruiksartikel', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBRKART', @level2type = N'COLUMN', @level2name = N'ID_ART_BRK';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de artikelgroep', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBRKART', @level2type = N'COLUMN', @level2name = N'ID_GR_ART';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de eenheid', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBRKART', @level2type = N'COLUMN', @level2name = N'ID_EH';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Nummer van het artikel in het SAP systeem', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBRKART', @level2type = N'COLUMN', @level2name = N'NR_ART_BRK_SAP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Een omschrijving van het artikel', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBRKART', @level2type = N'COLUMN', @level2name = N'SCF_ART';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De huidige stock van het artikel', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBRKART', @level2type = N'COLUMN', @level2name = N'STK_ACT_ART';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De minimum stock van het artikel', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBRKART', @level2type = N'COLUMN', @level2name = N'STK_MIN_ART';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De maximum stock van het artikel', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBRKART', @level2type = N'COLUMN', @level2name = N'STK_MAX_ART';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De eenheidsprijs van het artikel', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBRKART', @level2type = N'COLUMN', @level2name = N'PR_EH_ART_INTV';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Datum van de laatste wijziging', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBRKART', @level2type = N'COLUMN', @level2name = N'DT_WY_L';

