CREATE TABLE [dbo].[BBARTGR] (
    [ID_GR_ART]  INT          NOT NULL,
    [SCF_GR_ART] VARCHAR (30) NULL,
    CONSTRAINT [BBARTGR_PK] PRIMARY KEY CLUSTERED ([ID_GR_ART] ASC) WITH (FILLFACTOR = 70)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de artikelgroep', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBARTGR', @level2type = N'COLUMN', @level2name = N'ID_GR_ART';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Omschrijving van de artikelgroep', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBARTGR', @level2type = N'COLUMN', @level2name = N'SCF_GR_ART';

