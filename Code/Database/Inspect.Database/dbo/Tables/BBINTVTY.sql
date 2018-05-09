CREATE TABLE [dbo].[BBINTVTY] (
    [ID_TY_INTV]  INT          NOT NULL,
    [SCF_TY_INTV] VARCHAR (30) NULL,
    CONSTRAINT [BBINTVTY_PK] PRIMARY KEY CLUSTERED ([ID_TY_INTV] ASC) WITH (FILLFACTOR = 70)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het interventietype', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVTY', @level2type = N'COLUMN', @level2name = N'ID_TY_INTV';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Omschrijving van het interventietype', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVTY', @level2type = N'COLUMN', @level2name = N'SCF_TY_INTV';

