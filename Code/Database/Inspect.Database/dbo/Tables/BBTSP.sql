CREATE TABLE [dbo].[BBTSP] (
    [ID_TSP]        INT          NOT NULL,
    [ID_TY_TSP]     INT          NULL,
    [ID_EIG_TSP]    INT          NULL,
    [ID_FRM_TSP]    INT          NULL,
    [INDI_TSP_ARC]  BIT          NULL,
    [INDI_TSP_PRIV] BIT          NULL,
    [SCF_MRK_TSP]   VARCHAR (20) NULL,
    [PL_NR_TSP]     VARCHAR (15) NULL,
    [INH_CYL_TSP]   VARCHAR (10) NULL,
    [JR_BOU_TSP]    VARCHAR (4)  NULL,
    [NR_CHAS_TSP]   VARCHAR (20) NULL,
    [DT_KEU_L_TSP]  DATETIME     NULL,
    CONSTRAINT [BBTSP_PK] PRIMARY KEY CLUSTERED ([ID_TSP] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [BBFRM_BBTSP_FK1] FOREIGN KEY ([ID_FRM_TSP]) REFERENCES [dbo].[BBFRM] ([ID_FRM]),
    CONSTRAINT [BBIND_BBTSP_FK1] FOREIGN KEY ([ID_EIG_TSP]) REFERENCES [dbo].[BBIND] ([ID_IND]),
    CONSTRAINT [BBTYTSP_BBTSP_FK1] FOREIGN KEY ([ID_TY_TSP]) REFERENCES [dbo].[BBTYTSP] ([ID_TY_TSP])
);


GO
CREATE NONCLUSTERED INDEX [I_BBTSP_03]
    ON [dbo].[BBTSP]([ID_TY_TSP] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBTSP_02]
    ON [dbo].[BBTSP]([ID_EIG_TSP] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBTSP_01]
    ON [dbo].[BBTSP]([ID_FRM_TSP] ASC) WITH (FILLFACTOR = 70);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het voertuig', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBTSP', @level2type = N'COLUMN', @level2name = N'ID_TSP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het type voertuig', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBTSP', @level2type = N'COLUMN', @level2name = N'ID_TY_TSP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de eigenaar van het voertuig', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBTSP', @level2type = N'COLUMN', @level2name = N'ID_EIG_TSP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de firma aan wie het voertuig behoort', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBTSP', @level2type = N'COLUMN', @level2name = N'ID_FRM_TSP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Indicator Arcelor-voertuig', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBTSP', @level2type = N'COLUMN', @level2name = N'INDI_TSP_ARC';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Indicator PRIVE-voertuig', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBTSP', @level2type = N'COLUMN', @level2name = N'INDI_TSP_PRIV';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Bechrijving van het merk van het voertuig', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBTSP', @level2type = N'COLUMN', @level2name = N'SCF_MRK_TSP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De nummerplaat van het voertuig', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBTSP', @level2type = N'COLUMN', @level2name = N'PL_NR_TSP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De cilinderinhoud van het voertuig', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBTSP', @level2type = N'COLUMN', @level2name = N'INH_CYL_TSP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Het bouwjaar van het voertuig', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBTSP', @level2type = N'COLUMN', @level2name = N'JR_BOU_TSP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Het chassisnummer van het voertuig', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBTSP', @level2type = N'COLUMN', @level2name = N'NR_CHAS_TSP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De datum van de laatste controle van het voertuig', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBTSP', @level2type = N'COLUMN', @level2name = N'DT_KEU_L_TSP';

