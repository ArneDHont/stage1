CREATE TABLE [dbo].[BBVZKFRM] (
    [ID_FRM_VZK]  INT           NOT NULL,
    [NM_FRM_VZK]  VARCHAR (100) NULL,
    [AD_FRM_VZK]  VARCHAR (200) NULL,
    [PLA_FRM_VZK] VARCHAR (100) NULL,
    CONSTRAINT [BBVZKFRM_PK] PRIMARY KEY CLUSTERED ([ID_FRM_VZK] ASC) WITH (FILLFACTOR = 70)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de verzekeringsfirma', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBVZKFRM', @level2type = N'COLUMN', @level2name = N'ID_FRM_VZK';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Naam van de verzekeringsfirma', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBVZKFRM', @level2type = N'COLUMN', @level2name = N'NM_FRM_VZK';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Adres van de verzekeringsfirma', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBVZKFRM', @level2type = N'COLUMN', @level2name = N'AD_FRM_VZK';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De plaats waar de verzekeringsfirma gevestigd is', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBVZKFRM', @level2type = N'COLUMN', @level2name = N'PLA_FRM_VZK';

