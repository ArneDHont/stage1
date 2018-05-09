CREATE TABLE [dbo].[BBEH] (
    [ID_EH]  VARCHAR (10) NOT NULL,
    [SCF_EH] VARCHAR (30) NULL,
    CONSTRAINT [BBEH_PK] PRIMARY KEY CLUSTERED ([ID_EH] ASC) WITH (FILLFACTOR = 70)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de eenheid', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBEH', @level2type = N'COLUMN', @level2name = N'ID_EH';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Omschrijving van de eenheid', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBEH', @level2type = N'COLUMN', @level2name = N'SCF_EH';

