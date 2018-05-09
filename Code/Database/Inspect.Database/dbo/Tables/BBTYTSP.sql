CREATE TABLE [dbo].[BBTYTSP] (
    [ID_TY_TSP]  INT           NOT NULL,
    [SCF_TY_TSP] VARCHAR (100) NULL,
    CONSTRAINT [BBTYTSP_PK] PRIMARY KEY CLUSTERED ([ID_TY_TSP] ASC) WITH (FILLFACTOR = 70)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het type voertuig', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBTYTSP', @level2type = N'COLUMN', @level2name = N'ID_TY_TSP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Omschrijving van het type voertuig', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBTYTSP', @level2type = N'COLUMN', @level2name = N'SCF_TY_TSP';

