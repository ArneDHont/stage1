CREATE TABLE [dbo].[BBTYBTRK] (
    [ID_TY_BTRK]  INT       NOT NULL,
    [SCF_TY_BTRK] CHAR (10) NULL,
    CONSTRAINT [BBTYBTRK_PK] PRIMARY KEY CLUSTERED ([ID_TY_BTRK] ASC) WITH (FILLFACTOR = 70)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het type betrokkene', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBTYBTRK', @level2type = N'COLUMN', @level2name = N'ID_TY_BTRK';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Omschrijving van het type betrokkene', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBTYBTRK', @level2type = N'COLUMN', @level2name = N'SCF_TY_BTRK';

