CREATE TABLE [dbo].[BBINBRVA] (
    [ID_INBRVA]             INT            IDENTITY (1, 1) NOT NULL,
    [ID_REG]                INT            NOT NULL,
    [ID_ART_INBR]           INT            NULL,
    [SNL_OK]                INT            NULL,
    [SNL_REG]               INT            NULL,
    [PBH_NOK_SNL_DT_VAN]    DATETIME       NULL,
    [PBH_NOK_SNL_DT_TOT]    DATETIME       NULL,
    [PBH_DT_OVK]            DATETIME       NULL,
    [PBH_TMS_PRINT]         DATETIME       NULL,
    [SODIE_CNT_ID]          INT            NULL,
    [DatePrintLetterExt]    DATETIME       NULL,
    [Language]              NVARCHAR (5)   NULL,
    [Recidive]              INT            NULL,
    [KindOfSanction]        NVARCHAR (100) NULL,
    [SanctionID]            INT            NULL,
    [IdFirm]                INT            NULL,
    [Remark]                NVARCHAR (250) NULL,
    [SanctionDuration]      INT            NULL,
    [SanctionPeriod]        NVARCHAR (50)  NULL,
    [LastSanctionDoubledYN] BIT            CONSTRAINT [DF_BBINBRVA_LastSanctionDoubledYN] DEFAULT ((0)) NULL,
    CONSTRAINT [PK_BBINBRVA] PRIMARY KEY CLUSTERED ([ID_INBRVA] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [BBINBRAR_BBINBRVA_FK1] FOREIGN KEY ([ID_ART_INBR]) REFERENCES [dbo].[BBINBRAR] ([ID_ART_INBR]),
    CONSTRAINT [BBINBRRG_BBINBRVA_FK1] FOREIGN KEY ([ID_REG]) REFERENCES [dbo].[BBINBRRG] ([ID_REG])
);


GO
CREATE NONCLUSTERED INDEX [I_BBINBRVA_02]
    ON [dbo].[BBINBRVA]([ID_REG] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBINBRVA_01]
    ON [dbo].[BBINBRVA]([ID_ART_INBR] ASC) WITH (FILLFACTOR = 70);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het inbreukartikel', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINBRVA', @level2type = N'COLUMN', @level2name = N'ID_REG';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de inbreukregistratie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINBRVA', @level2type = N'COLUMN', @level2name = N'ID_ART_INBR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De toegelaten snelheid', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINBRVA', @level2type = N'COLUMN', @level2name = N'SNL_OK';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De geregistreerde snelheid (vastgestelde)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINBRVA', @level2type = N'COLUMN', @level2name = N'SNL_REG';

