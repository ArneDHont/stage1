CREATE TABLE [dbo].[BBINBRAR] (
    [ID_ART_INBR]     INT            NOT NULL,
    [ID_TY_INBR]      INT            NULL,
    [NR_ART_INBR]     VARCHAR (50)   NULL,
    [SCF_ART_INBR]    VARCHAR (2000) NULL,
    [InbreukKlasseID] INT            NULL,
    [SCF_ART_INBR_FR] VARCHAR (2000) NULL,
    [SCF_ART_INBR_EN] VARCHAR (2000) NULL,
    [SCF_ART_INBR_DE] VARCHAR (2000) NULL,
    CONSTRAINT [BBINBRAR_PK] PRIMARY KEY CLUSTERED ([ID_ART_INBR] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [FK_BBINBRAR_BBINBRTY] FOREIGN KEY ([ID_TY_INBR]) REFERENCES [dbo].[BBINBRTY] ([ID_TY_INBR])
);


GO
CREATE NONCLUSTERED INDEX [I_BBINBRAR_01]
    ON [dbo].[BBINBRAR]([ID_TY_INBR] ASC) WITH (FILLFACTOR = 70);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het inbreukartikel', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINBRAR', @level2type = N'COLUMN', @level2name = N'ID_ART_INBR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het type inbreuk', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINBRAR', @level2type = N'COLUMN', @level2name = N'ID_TY_INBR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Nr van inbreukartikel', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINBRAR', @level2type = N'COLUMN', @level2name = N'NR_ART_INBR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Omschrijving van inbreukartikel', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINBRAR', @level2type = N'COLUMN', @level2name = N'SCF_ART_INBR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Omschrijving van inbreukartikel', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINBRAR', @level2type = N'COLUMN', @level2name = N'SCF_ART_INBR_FR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Omschrijving van inbreukartikel', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINBRAR', @level2type = N'COLUMN', @level2name = N'SCF_ART_INBR_EN';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Omschrijving van inbreukartikel', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINBRAR', @level2type = N'COLUMN', @level2name = N'SCF_ART_INBR_DE';

