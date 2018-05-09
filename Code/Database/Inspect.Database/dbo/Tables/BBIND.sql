CREATE TABLE [dbo].[BBIND] (
    [ID_IND]          INT           NOT NULL,
    [NM_IND]          VARCHAR (50)  NULL,
    [VNM_IND]         VARCHAR (50)  NULL,
    [AD_IND]          VARCHAR (150) NULL,
    [PO_COD_WNPL_IND] VARCHAR (10)  NULL,
    [WNPL_IND]        VARCHAR (60)  NULL,
    [PLA_GBR_IND]     VARCHAR (60)  NULL,
    [DT_GBR_IND]      DATETIME      NULL,
    [SAP_DIR]         VARCHAR (5)   NULL,
    [SAP_AFD]         VARCHAR (5)   NULL,
    [SAP_SECT]        VARCHAR (5)   NULL,
    [DT_UIT_DNS]      DATETIME      NULL,
    [NR_TEL_SID]      VARCHAR (50)  NULL,
    [SCF_FIE]         VARCHAR (100) NULL,
    [ID_GSL_IND]      INT           CONSTRAINT [DF_BBIND_ID_GSL_IND] DEFAULT (1) NULL,
    [ID_TY_IND]       INT           CONSTRAINT [DF_BBIND_ID_TY_IND] DEFAULT (1) NULL,
    [ID_FRM_IND_TK]   INT           CONSTRAINT [DF_BBIND_ID_FRM_IND_TK] DEFAULT (1000201) NULL,
    [AD_EMAL_IND]     VARCHAR (100) NULL,
    [BST_IND]         BIT           CONSTRAINT [DF_BBIND_BST_IND] DEFAULT (0) NULL,
    [NR_IND_WKG]      INT           NULL,
    [NM_JUR_VENO]     NVARCHAR (40) NULL,
    [VLG_INT_COD_PO]  NVARCHAR (12) NULL,
    [BST_ACTIVE]      BIT           CONSTRAINT [DF_BBIND_BST_ACTIVE] DEFAULT ((1)) NULL,
    CONSTRAINT [BBIND_PK] PRIMARY KEY CLUSTERED ([ID_IND] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [BBFRM_BBIND_FK1] FOREIGN KEY ([ID_FRM_IND_TK]) REFERENCES [dbo].[BBFRM] ([ID_FRM]),
    CONSTRAINT [BBINDTY_BBIND_FK1] FOREIGN KEY ([ID_TY_IND]) REFERENCES [dbo].[BBINDTY] ([ID_TY_IND]),
    CONSTRAINT [FK_BBIND_BBINDGSL] FOREIGN KEY ([ID_GSL_IND]) REFERENCES [dbo].[BBINDGSL] ([ID_GSL_IND])
);


GO
CREATE NONCLUSTERED INDEX [I_BBIND_03]
    ON [dbo].[BBIND]([ID_GSL_IND] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBIND_02]
    ON [dbo].[BBIND]([ID_TY_IND] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBIND_01]
    ON [dbo].[BBIND]([ID_FRM_IND_TK] ASC) WITH (FILLFACTOR = 70);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het individu', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBIND', @level2type = N'COLUMN', @level2name = N'ID_IND';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De naam van het individu', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBIND', @level2type = N'COLUMN', @level2name = N'NM_IND';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De voornaam van het individu', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBIND', @level2type = N'COLUMN', @level2name = N'VNM_IND';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Het adres van het individu (straat + nr)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBIND', @level2type = N'COLUMN', @level2name = N'AD_IND';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De postcode van de woonplaats van het individu', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBIND', @level2type = N'COLUMN', @level2name = N'PO_COD_WNPL_IND';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De woonplaats van het individu', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBIND', @level2type = N'COLUMN', @level2name = N'WNPL_IND';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De geboorteplaats van het individu', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBIND', @level2type = N'COLUMN', @level2name = N'PLA_GBR_IND';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De geboortedatum van het individu', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBIND', @level2type = N'COLUMN', @level2name = N'DT_GBR_IND';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'SAP directie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBIND', @level2type = N'COLUMN', @level2name = N'SAP_DIR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'SAP afdeling', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBIND', @level2type = N'COLUMN', @level2name = N'SAP_AFD';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'SAP sectie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBIND', @level2type = N'COLUMN', @level2name = N'SAP_SECT';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Datum uit dienst', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBIND', @level2type = N'COLUMN', @level2name = N'DT_UIT_DNS';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Intern telefoonnummer Sidmar', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBIND', @level2type = N'COLUMN', @level2name = N'NR_TEL_SID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Functie-omschrijving', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBIND', @level2type = N'COLUMN', @level2name = N'SCF_FIE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Geslacht (man/vrouw)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBIND', @level2type = N'COLUMN', @level2name = N'ID_GSL_IND';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het type individu', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBIND', @level2type = N'COLUMN', @level2name = N'ID_TY_IND';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de firma waar het individu tewerkgesteld is', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBIND', @level2type = N'COLUMN', @level2name = N'ID_FRM_IND_TK';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Het emailadres van het individu', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBIND', @level2type = N'COLUMN', @level2name = N'AD_EMAL_IND';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Is dit individu een bestemmelling?', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBIND', @level2type = N'COLUMN', @level2name = N'BST_IND';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Toegevoegd naco - 16/06/2011 - firma SAP Aristos', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBIND', @level2type = N'COLUMN', @level2name = N'NR_IND_WKG';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Toegevoegd naco - 16/06/2011 - firma SAP Aristos', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBIND', @level2type = N'COLUMN', @level2name = N'NM_JUR_VENO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Intern postvaknummer', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBIND', @level2type = N'COLUMN', @level2name = N'VLG_INT_COD_PO';

