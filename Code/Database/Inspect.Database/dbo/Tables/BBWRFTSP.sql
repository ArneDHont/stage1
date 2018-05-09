CREATE TABLE [dbo].[BBWRFTSP] (
    [ID_WRF_TSP]  INT          NOT NULL,
    [SCF_WRF_TSP] VARCHAR (50) NULL,
    CONSTRAINT [PK_BBWRFTSP] PRIMARY KEY CLUSTERED ([ID_WRF_TSP] ASC) WITH (FILLFACTOR = 70)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het werfvoertuig', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBWRFTSP', @level2type = N'COLUMN', @level2name = N'ID_WRF_TSP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Omschrijving van het werfvoertuig', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBWRFTSP', @level2type = N'COLUMN', @level2name = N'SCF_WRF_TSP';

