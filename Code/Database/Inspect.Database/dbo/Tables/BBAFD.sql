CREATE TABLE [dbo].[BBAFD] (
    [ID_AFD]  INT           NOT NULL,
    [SCF_AFD] VARCHAR (200) NULL,
    [KRT_AFD] VARCHAR (3)   NULL,
    CONSTRAINT [BBAFD_PK] PRIMARY KEY CLUSTERED ([ID_AFD] ASC) WITH (FILLFACTOR = 70)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de afdeling', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBAFD', @level2type = N'COLUMN', @level2name = N'ID_AFD';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Omschrijving van de afdeling', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBAFD', @level2type = N'COLUMN', @level2name = N'SCF_AFD';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Een korte omschrijving van de afdeling', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBAFD', @level2type = N'COLUMN', @level2name = N'KRT_AFD';

