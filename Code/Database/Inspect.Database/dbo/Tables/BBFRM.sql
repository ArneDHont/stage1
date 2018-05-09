CREATE TABLE [dbo].[BBFRM] (
    [ID_FRM]                INT            NOT NULL,
    [NM_FRM]                VARCHAR (50)   NULL,
    [STRA_FRM]              VARCHAR (50)   NULL,
    [PO_COD_PLA_FRM]        VARCHAR (10)   NULL,
    [PLA_FRM]               VARCHAR (50)   NULL,
    [NR_IND_FRM_SAP]        INT            NULL,
    [NM_FRM_SAP]            NVARCHAR (50)  NULL,
    [BBW_FirmEmailContacts] NVARCHAR (250) NULL,
    [BBW_FirmRemark]        NVARCHAR (250) NULL,
    [BBW_FirmLanguage]      NVARCHAR (10)  CONSTRAINT [DF_BBFRM_BBW_FirmLanguage] DEFAULT (N'NL') NULL,
    [DateCreatedFirm]       DATETIME       CONSTRAINT [DF_BBFRM_DateCreatedFirm] DEFAULT (getdate()) NULL,
    CONSTRAINT [BBFRM_PK] PRIMARY KEY CLUSTERED ([ID_FRM] ASC) WITH (FILLFACTOR = 70)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de firma', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBFRM', @level2type = N'COLUMN', @level2name = N'ID_FRM';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De naam van de firma', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBFRM', @level2type = N'COLUMN', @level2name = N'NM_FRM';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De straat van de firma (+nr)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBFRM', @level2type = N'COLUMN', @level2name = N'STRA_FRM';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De postcode van de plaats waar de firma gevestigd is', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBFRM', @level2type = N'COLUMN', @level2name = N'PO_COD_PLA_FRM';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De plaats waar de firma gevestigd is', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBFRM', @level2type = N'COLUMN', @level2name = N'PLA_FRM';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Toegevoegd naco - 16/06/2011 - firma SAP Aristos', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBFRM', @level2type = N'COLUMN', @level2name = N'NR_IND_FRM_SAP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Toegevoegd naco - 16/06/2011 - firma SAP Aristos', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBFRM', @level2type = N'COLUMN', @level2name = N'NM_FRM_SAP';

