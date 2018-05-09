CREATE TABLE [dbo].[BBREGTY] (
    [ID_TY_REG]  INT          NOT NULL,
    [SCF_TY_REG] VARCHAR (30) NULL,
    CONSTRAINT [BBREGTY_PK] PRIMARY KEY CLUSTERED ([ID_TY_REG] ASC) WITH (FILLFACTOR = 70)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het registratietype', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBREGTY', @level2type = N'COLUMN', @level2name = N'ID_TY_REG';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Omschrijving van het registratietype', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBREGTY', @level2type = N'COLUMN', @level2name = N'SCF_TY_REG';

