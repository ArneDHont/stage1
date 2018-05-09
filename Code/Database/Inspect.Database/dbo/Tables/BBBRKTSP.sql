CREATE TABLE [dbo].[BBBRKTSP] (
    [ID_BRK_TSP]  INT          NOT NULL,
    [SCF_BRK_TSP] VARCHAR (20) NULL,
    CONSTRAINT [BBBRKTSP_PK] PRIMARY KEY CLUSTERED ([ID_BRK_TSP] ASC) WITH (FILLFACTOR = 70)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het gebruik van het voertuig', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBRKTSP', @level2type = N'COLUMN', @level2name = N'ID_BRK_TSP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Omschrijving van het gebruik van het voertuig', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBRKTSP', @level2type = N'COLUMN', @level2name = N'SCF_BRK_TSP';

