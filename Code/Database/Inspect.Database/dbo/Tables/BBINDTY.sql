CREATE TABLE [dbo].[BBINDTY] (
    [ID_TY_IND]  INT          NOT NULL,
    [SCF_TY_IND] VARCHAR (50) NOT NULL,
    CONSTRAINT [BBINDTY_PK] PRIMARY KEY CLUSTERED ([ID_TY_IND] ASC) WITH (FILLFACTOR = 70)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het type individu', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINDTY', @level2type = N'COLUMN', @level2name = N'ID_TY_IND';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Omschrijving van het type individu', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINDTY', @level2type = N'COLUMN', @level2name = N'SCF_TY_IND';

