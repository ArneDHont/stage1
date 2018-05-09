CREATE TABLE [dbo].[BBBEWREG] (
    [ID_REG]               INT            NOT NULL,
    [ID_OPS]               INT            NULL,
    [ID_TY_REG]            INT            NULL,
    [TMS_OPS_REG]          DATETIME       NULL,
    [TMS_INC]              DATETIME       NULL,
    [SCF_REG]              VARCHAR (250)  NULL,
    [PLA_INC]              VARCHAR (200)  NULL,
    [VLG_REG_JR_BPL]       INT            NULL,
    [DT_VZ_RAP_NW]         DATETIME       NULL,
    [DT_OK]                DATETIME       NULL,
    [DT_VZ_BST]            DATETIME       NULL,
    [OPM_OPS]              VARCHAR (100)  NULL,
    [OPM_CHEF_PO]          VARCHAR (100)  NULL,
    [OPM_HFD_BRW]          VARCHAR (100)  NULL,
    [DT_OPS_RAP_INTV]      DATETIME       NULL,
    [SAP_SUPPLIER_ID]      VARCHAR (30)   NULL,
    [DT_CHIP]              DATETIME       NULL,
    [OPM_CHIP]             VARCHAR (100)  NULL,
    [CHIP_YN]              BIT            NULL,
    [OPM_IKP]              NVARCHAR (250) NULL,
    [TMS_IKP_SENDMAIL]     DATETIME       NULL,
    [OPM_PEB]              NVARCHAR (250) NULL,
    [TMS_PEB_SENDMAIL]     DATETIME       NULL,
    [VeraReference]        NVARCHAR (100) NULL,
    [VeraLink]             NVARCHAR (500) NULL,
    [VerslagContractantYN] BIT            CONSTRAINT [DF_BBBEWREG_VerslagContractantYN] DEFAULT ((0)) NULL,
    [DateInvalid]          DATETIME       NULL,
    [UserInvalid]          VARCHAR (30)   NULL,
    [RemarkInvalid]        VARCHAR (200)  NULL,
    [CHIPReadYN]           BIT            CONSTRAINT [DF_BBBEWREG_CHIPReadYN] DEFAULT ((0)) NULL,
    [CHIPReadTms]          DATETIME       NULL,
    [CHIPRemark]           NVARCHAR (250) NULL,
    CONSTRAINT [BBBEWREG_PK] PRIMARY KEY CLUSTERED ([ID_REG] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [BBBWPERS_BBBEWREG_FK1] FOREIGN KEY ([ID_OPS]) REFERENCES [dbo].[BBBWPERS] ([ID_IND]),
    CONSTRAINT [BBREGTY_BBBEWREG_FK1] FOREIGN KEY ([ID_TY_REG]) REFERENCES [dbo].[BBREGTY] ([ID_TY_REG])
);


GO
CREATE NONCLUSTERED INDEX [I_BBBEWREG_01]
    ON [dbo].[BBBEWREG]([ID_OPS] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBBEWREG_02]
    ON [dbo].[BBBEWREG]([ID_TY_REG] ASC) WITH (FILLFACTOR = 70);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de registratie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBEWREG', @level2type = N'COLUMN', @level2name = N'ID_REG';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de opsteller', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBEWREG', @level2type = N'COLUMN', @level2name = N'ID_OPS';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het registratietype', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBEWREG', @level2type = N'COLUMN', @level2name = N'ID_TY_REG';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Tijdstip van opstellen van de registratie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBEWREG', @level2type = N'COLUMN', @level2name = N'TMS_OPS_REG';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Datum van het incident', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBEWREG', @level2type = N'COLUMN', @level2name = N'TMS_INC';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Plaats waar het incident voorviel', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBEWREG', @level2type = N'COLUMN', @level2name = N'PLA_INC';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Volgnummer van de registratie binnen een bepaald jaar', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBEWREG', @level2type = N'COLUMN', @level2name = N'VLG_REG_JR_BPL';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Datum van verzending van het nieuwe verslag', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBEWREG', @level2type = N'COLUMN', @level2name = N'DT_VZ_RAP_NW';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Datum van de goedkeuring', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBEWREG', @level2type = N'COLUMN', @level2name = N'DT_OK';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Datum van de verzending naar de bestemmelingen', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBEWREG', @level2type = N'COLUMN', @level2name = N'DT_VZ_BST';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Opmerkingen van de opsteller', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBEWREG', @level2type = N'COLUMN', @level2name = N'OPM_OPS';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Opmerkingen van de postoverste', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBEWREG', @level2type = N'COLUMN', @level2name = N'OPM_CHEF_PO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Opmerkingen van hoofd van de brandweer', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBEWREG', @level2type = N'COLUMN', @level2name = N'OPM_HFD_BRW';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Datum van opstelling interventieverslag', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBEWREG', @level2type = N'COLUMN', @level2name = N'DT_OPS_RAP_INTV';

