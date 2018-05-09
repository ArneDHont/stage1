CREATE TABLE [dbo].[BBDIEFDU] (
    [ID_DUP_DIEF]    INT           NOT NULL,
    [SCF_DUP]        VARCHAR (100) NULL,
    [INDI_NR_ST_VP]  BIT           NULL,
    [INDI_NM_FRM_VP] BIT           NULL,
    CONSTRAINT [BBDIEFDU_PK] PRIMARY KEY CLUSTERED ([ID_DUP_DIEF] ASC) WITH (FILLFACTOR = 70)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de benadeelde van de diefstal', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDIEFDU', @level2type = N'COLUMN', @level2name = N'ID_DUP_DIEF';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Omschrijving van de benadeelde ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDIEFDU', @level2type = N'COLUMN', @level2name = N'SCF_DUP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Indicator stamnummer verplicht', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDIEFDU', @level2type = N'COLUMN', @level2name = N'INDI_NR_ST_VP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Indicator firmanaam verplicht', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDIEFDU', @level2type = N'COLUMN', @level2name = N'INDI_NM_FRM_VP';

