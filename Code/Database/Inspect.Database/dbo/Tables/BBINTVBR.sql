CREATE TABLE [dbo].[BBINTVBR] (
    [ID_INTV_BRDW]         INT            NOT NULL,
    [ID_TY_INTV]           INT            NULL,
    [ID_BR_TY_INTV]        INT            NULL,
    [ID_BR_RD_INTV]        INT            NULL,
    [ID_AFD]               INT            NULL,
    [ID_OPS]               INT            NULL,
    [ID_CHEF_PO]           INT            NULL,
    [ID_HFD_BRDW]          INT            NULL,
    [ID_OK]                INT            NULL,
    [IND_OPR_DR]           VARCHAR (50)   NULL,
    [TMS_INTV]             DATETIME       NULL,
    [VLG_TY_INTV_JR]       INT            NULL,
    [VLG_TY_INTV_AFD]      INT            NULL,
    [PLA_INTV]             VARCHAR (1000) NULL,
    [ID_OK_VU_TK]          VARCHAR (50)   NULL,
    [SCF_LNG_INTV]         VARCHAR (8000) NULL,
    [INDI_BRD_BLUS_AFD]    BIT            NULL,
    [INDI_BRD_BLUS_SID]    BIT            NULL,
    [INDI_BRDW_SID_OPR]    BIT            NULL,
    [INDI_RAP_INC_OTV]     BIT            NULL,
    [DT_OPS_RAP_INTV]      DATETIME       NULL,
    [DT_VZ_RAP_NW]         DATETIME       NULL,
    [DT_OK]                DATETIME       NULL,
    [DT_VZ_BST]            DATETIME       NULL,
    [OPM_OPS]              VARCHAR (100)  NULL,
    [OPM_CHEF_PO]          VARCHAR (100)  NULL,
    [OPM_HFD_BRW]          VARCHAR (100)  NULL,
    [BST_OUD_PG]           VARCHAR (300)  NULL,
    [FireCauseExtraInfoId] INT            CONSTRAINT [DF_BBINTVBR_FireCauseExtraInfoId] DEFAULT ((0)) NOT NULL,
    [VeraReference]        NVARCHAR (100) NULL,
    [VeraLink]             NVARCHAR (500) NULL,
    [VerslagContractantYN] BIT            CONSTRAINT [DF_BBINTVBR_VerslagContractantYN] DEFAULT ((0)) NULL,
    CONSTRAINT [BBINTVBR_PK] PRIMARY KEY CLUSTERED ([ID_INTV_BRDW] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [BBAFD_BBINTVBR_FK1] FOREIGN KEY ([ID_AFD]) REFERENCES [dbo].[BBAFD] ([ID_AFD]),
    CONSTRAINT [BBBRRD_BBINTVBR_FK1] FOREIGN KEY ([ID_BR_RD_INTV]) REFERENCES [dbo].[BBBRRD] ([ID_BR_RD_INTV]),
    CONSTRAINT [BBBRTY_BBINTVBR_FK1] FOREIGN KEY ([ID_BR_TY_INTV]) REFERENCES [dbo].[BBBRTY] ([ID_BR_TY_INTV]),
    CONSTRAINT [BBBWPERS_BBINTVBR_FK1] FOREIGN KEY ([ID_OPS]) REFERENCES [dbo].[BBBWPERS] ([ID_IND]),
    CONSTRAINT [BBBWPERS_BBINTVBR_FK2] FOREIGN KEY ([ID_CHEF_PO]) REFERENCES [dbo].[BBBWPERS] ([ID_IND]),
    CONSTRAINT [BBBWPERS_BBINTVBR_FK3] FOREIGN KEY ([ID_HFD_BRDW]) REFERENCES [dbo].[BBBWPERS] ([ID_IND]),
    CONSTRAINT [BBBWPERS_BBINTVBR_FK4] FOREIGN KEY ([ID_OK]) REFERENCES [dbo].[BBBWPERS] ([ID_IND]),
    CONSTRAINT [BBINTVTY_BBINTVBR_FK1] FOREIGN KEY ([ID_TY_INTV]) REFERENCES [dbo].[BBINTVTY] ([ID_TY_INTV])
);


GO
CREATE NONCLUSTERED INDEX [I_BBINTVBR_08]
    ON [dbo].[BBINTVBR]([ID_TY_INTV] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBINTVBR_03]
    ON [dbo].[BBINTVBR]([ID_BR_TY_INTV] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBINTVBR_02]
    ON [dbo].[BBINTVBR]([ID_BR_RD_INTV] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBINTVBR_01]
    ON [dbo].[BBINTVBR]([ID_AFD] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBINTVBR_04]
    ON [dbo].[BBINTVBR]([ID_OPS] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBINTVBR_05]
    ON [dbo].[BBINTVBR]([ID_CHEF_PO] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBINTVBR_06]
    ON [dbo].[BBINTVBR]([ID_HFD_BRDW] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBINTVBR_07]
    ON [dbo].[BBINTVBR]([ID_OK] ASC) WITH (FILLFACTOR = 70);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de brandweerinterventie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVBR', @level2type = N'COLUMN', @level2name = N'ID_INTV_BRDW';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het interventietype', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVBR', @level2type = N'COLUMN', @level2name = N'ID_TY_INTV';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de aard van de interventie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVBR', @level2type = N'COLUMN', @level2name = N'ID_BR_TY_INTV';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de oorzaak van de interventie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVBR', @level2type = N'COLUMN', @level2name = N'ID_BR_RD_INTV';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de afdeling', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVBR', @level2type = N'COLUMN', @level2name = N'ID_AFD';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de opsteller (brandweer)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVBR', @level2type = N'COLUMN', @level2name = N'ID_OPS';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de postoverste', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVBR', @level2type = N'COLUMN', @level2name = N'ID_CHEF_PO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het hoofd van de brandweer', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVBR', @level2type = N'COLUMN', @level2name = N'ID_HFD_BRDW';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de goedkeurder', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVBR', @level2type = N'COLUMN', @level2name = N'ID_OK';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Datum van de interventie ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVBR', @level2type = N'COLUMN', @level2name = N'IND_OPR_DR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Datum van de interventie ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVBR', @level2type = N'COLUMN', @level2name = N'TMS_INTV';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Een volgnummer van een bepaalde interventietype binnen een jaar', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVBR', @level2type = N'COLUMN', @level2name = N'VLG_TY_INTV_JR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Een volgnummer van een bepaalde interventietype binnen een afdeling', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVBR', @level2type = N'COLUMN', @level2name = N'VLG_TY_INTV_AFD';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De plaats van de tussenkomst', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVBR', @level2type = N'COLUMN', @level2name = N'PLA_INTV';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De identificatie van de werkvuurvergunning', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVBR', @level2type = N'COLUMN', @level2name = N'ID_OK_VU_TK';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Een lange omschrijving van de interventie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVBR', @level2type = N'COLUMN', @level2name = N'SCF_LNG_INTV';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Indicator geblust door afdeling (Werd de brand geblust door de afdeling?)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVBR', @level2type = N'COLUMN', @level2name = N'INDI_BRD_BLUS_AFD';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Indicator geblust door Sidmar (Werd de brand geblust door Sidmar?)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVBR', @level2type = N'COLUMN', @level2name = N'INDI_BRD_BLUS_SID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Indicator branweer Sidmar opgeroepen (Werd de brandweer van Sidmar opgeroepen?)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVBR', @level2type = N'COLUMN', @level2name = N'INDI_BRDW_SID_OPR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Indicator incidentenverslag ontvangen (Werd er een incidentenverslag ontvangen?)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVBR', @level2type = N'COLUMN', @level2name = N'INDI_RAP_INC_OTV';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Datum van opstelling interventieverslag', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVBR', @level2type = N'COLUMN', @level2name = N'DT_OPS_RAP_INTV';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Datum van verzending van het nieuwe verslag', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVBR', @level2type = N'COLUMN', @level2name = N'DT_VZ_RAP_NW';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Datum van de goedkeuring', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVBR', @level2type = N'COLUMN', @level2name = N'DT_OK';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Datum van de verzending naar de bestemmelingen', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVBR', @level2type = N'COLUMN', @level2name = N'DT_VZ_BST';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Opmerkingen van de opsteller', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVBR', @level2type = N'COLUMN', @level2name = N'OPM_OPS';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Opmerkingen van de postoverste', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVBR', @level2type = N'COLUMN', @level2name = N'OPM_CHEF_PO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Opmerkingen van de hoofd van de brandweer', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVBR', @level2type = N'COLUMN', @level2name = N'OPM_HFD_BRW';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Bestemmelingen oude programma Brandweer (VB6)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINTVBR', @level2type = N'COLUMN', @level2name = N'BST_OUD_PG';

