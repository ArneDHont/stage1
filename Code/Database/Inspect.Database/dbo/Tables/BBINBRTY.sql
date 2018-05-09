CREATE TABLE [dbo].[BBINBRTY] (
    [ID_TY_INBR]  INT          NOT NULL,
    [SCF_TY_INBR] VARCHAR (30) NULL,
    CONSTRAINT [BBINRBTY_PK] PRIMARY KEY CLUSTERED ([ID_TY_INBR] ASC) WITH (FILLFACTOR = 70)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het type inbreuk', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINBRTY', @level2type = N'COLUMN', @level2name = N'ID_TY_INBR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Omschrijving van het type inbreuk', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINBRTY', @level2type = N'COLUMN', @level2name = N'SCF_TY_INBR';

