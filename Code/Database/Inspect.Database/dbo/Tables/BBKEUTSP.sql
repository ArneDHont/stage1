CREATE TABLE [dbo].[BBKEUTSP] (
    [ID_REG]            INT            NOT NULL,
    [ID_STUR_TSP_KEU]   INT            NOT NULL,
    [ID_FRM]            INT            NULL,
    [ID_TSP_KEU]        INT            NULL,
    [ID_DNS_VTW_WR_KEU] INT            NULL,
    [ID_BEW_DUP]        INT            NULL,
    [ID_WRF_TSP]        INT            NULL,
    [SCF_ORG_KEU_TSP]   VARCHAR (100)  NULL,
    [DT_L_KEU_TSP]      DATETIME       NULL,
    [OPM_VKLR_TSP]      VARCHAR (2000) NULL,
    [FA_BST_TSP]        VARCHAR (300)  NULL,
    [SCF_DFC_REG_TSP]   VARCHAR (500)  NULL,
    [RGL_NEM_KEU]       VARCHAR (2000) NULL,
    CONSTRAINT [BBKEUTSP_PK] PRIMARY KEY CLUSTERED ([ID_REG] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [BBBEWREG_BBKEUTSP_FK1] FOREIGN KEY ([ID_REG]) REFERENCES [dbo].[BBBEWREG] ([ID_REG]),
    CONSTRAINT [BBIND_BBKEUTSP_FK1] FOREIGN KEY ([ID_STUR_TSP_KEU]) REFERENCES [dbo].[BBIND] ([ID_IND]),
    CONSTRAINT [BBIND_BBKEUTSP_FK2] FOREIGN KEY ([ID_DNS_VTW_WR_KEU]) REFERENCES [dbo].[BBIND] ([ID_IND]),
    CONSTRAINT [BBTSP_BBKEUTSP_FK1] FOREIGN KEY ([ID_TSP_KEU]) REFERENCES [dbo].[BBTSP] ([ID_TSP]),
    CONSTRAINT [FK_BBKEUTSP_BBBEWDUP] FOREIGN KEY ([ID_BEW_DUP]) REFERENCES [dbo].[BBBEWDUP] ([ID_BEW_DUP]),
    CONSTRAINT [FK_BBKEUTSP_BBFRM] FOREIGN KEY ([ID_FRM]) REFERENCES [dbo].[BBFRM] ([ID_FRM]),
    CONSTRAINT [FK_BBKEUTSP_BBWRFTSP] FOREIGN KEY ([ID_WRF_TSP]) REFERENCES [dbo].[BBWRFTSP] ([ID_WRF_TSP])
);


GO
CREATE NONCLUSTERED INDEX [I_BBKEUTSP_01]
    ON [dbo].[BBKEUTSP]([ID_STUR_TSP_KEU] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBKEUTSP_05]
    ON [dbo].[BBKEUTSP]([ID_FRM] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBKEUTSP_03]
    ON [dbo].[BBKEUTSP]([ID_TSP_KEU] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBKEUTSP_02]
    ON [dbo].[BBKEUTSP]([ID_DNS_VTW_WR_KEU] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBKEUTSP_04]
    ON [dbo].[BBKEUTSP]([ID_BEW_DUP] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBKEUTSP_06]
    ON [dbo].[BBKEUTSP]([ID_WRF_TSP] ASC) WITH (FILLFACTOR = 70);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de registratie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBKEUTSP', @level2type = N'COLUMN', @level2name = N'ID_REG';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de bestuurder van het gecontroleerde voertuig', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBKEUTSP', @level2type = N'COLUMN', @level2name = N'ID_STUR_TSP_KEU';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het gecontroleerde voertuig', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBKEUTSP', @level2type = N'COLUMN', @level2name = N'ID_TSP_KEU';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de dienst die verantwoordelijk is voor het uitvoeren van de controle', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBKEUTSP', @level2type = N'COLUMN', @level2name = N'ID_DNS_VTW_WR_KEU';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Benadeelde', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBKEUTSP', @level2type = N'COLUMN', @level2name = N'ID_BEW_DUP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Omschrijving van het type voertuig', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBKEUTSP', @level2type = N'COLUMN', @level2name = N'ID_WRF_TSP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Beschrijving van het keuringsorganisme van het voertuig', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBKEUTSP', @level2type = N'COLUMN', @level2name = N'SCF_ORG_KEU_TSP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De datum van de laatste keuring van het voertuig', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBKEUTSP', @level2type = N'COLUMN', @level2name = N'DT_L_KEU_TSP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Het opmerkingsattest van het voertig', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBKEUTSP', @level2type = N'COLUMN', @level2name = N'OPM_VKLR_TSP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De bestemming binnen de fabriek van het voertuig', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBKEUTSP', @level2type = N'COLUMN', @level2name = N'FA_BST_TSP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Beschrijving van de geregistreerde defecten aan het voertuig', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBKEUTSP', @level2type = N'COLUMN', @level2name = N'SCF_DFC_REG_TSP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De getroffen maatregelen tengevolge van de controle', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBKEUTSP', @level2type = N'COLUMN', @level2name = N'RGL_NEM_KEU';

