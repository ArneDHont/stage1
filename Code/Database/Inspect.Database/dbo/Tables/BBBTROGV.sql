CREATE TABLE [dbo].[BBBTROGV] (
    [ID_BTRK_OGV]      INT           IDENTITY (1, 1) NOT NULL,
    [ID_REG]           INT           NOT NULL,
    [ID_IND_BTRK]      INT           NULL,
    [ID_TY_BTRK]       INT           NULL,
    [ID_BRK_TSP]       INT           NULL,
    [ID_FRM_VZK]       INT           NULL,
    [NR_POLIS]         VARCHAR (20)  NULL,
    [ROMP_LTSL]        VARCHAR (500) NULL,
    [MAT_LTSL]         VARCHAR (500) NULL,
    [KAR_TSP]          BIT           NULL,
    [Q_IND_TSP_BRTK]   VARCHAR (2)   NULL,
    [INDI_TRL_VKM_TSP] BIT           NULL,
    [SCF_Q_KG_VKM_TSP] VARCHAR (10)  NULL,
    [RB_NR]            VARCHAR (100) NULL,
    [RB_CAT]           VARCHAR (50)  NULL,
    [RB_DAT_UITG]      DATETIME      NULL,
    [RB_PL_UITG]       VARCHAR (100) NULL,
    [BTW_NR]           VARCHAR (20)  NULL,
    [HD_NM_VN]         VARCHAR (100) NULL,
    [ID_TSP]           INT           NULL,
    CONSTRAINT [BBBTROGV_PK] PRIMARY KEY CLUSTERED ([ID_BTRK_OGV] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [FK_BBBTROGV_BBOGVTSP] FOREIGN KEY ([ID_REG]) REFERENCES [dbo].[BBOGVTSP] ([ID_REG])
);


GO
CREATE NONCLUSTERED INDEX [I_BBBTROGV_01]
    ON [dbo].[BBBTROGV]([ID_REG] ASC) WITH (FILLFACTOR = 70);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de betrokkene van de aanrijding', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBTROGV', @level2type = N'COLUMN', @level2name = N'ID_BTRK_OGV';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het individu dat betrokken is', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBTROGV', @level2type = N'COLUMN', @level2name = N'ID_IND_BTRK';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het type betrokkenene', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBTROGV', @level2type = N'COLUMN', @level2name = N'ID_TY_BTRK';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het gebruik van het voertuig', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBTROGV', @level2type = N'COLUMN', @level2name = N'ID_BRK_TSP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de verzekeringsfirma', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBTROGV', @level2type = N'COLUMN', @level2name = N'ID_FRM_VZK';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Het polisnummer van de betrokkene', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBTROGV', @level2type = N'COLUMN', @level2name = N'NR_POLIS';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N' lichamelijke letsels', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBTROGV', @level2type = N'COLUMN', @level2name = N'ROMP_LTSL';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'materiële schade', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBTROGV', @level2type = N'COLUMN', @level2name = N'MAT_LTSL';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Beschrijving van de hoedanigheid van het voertuig', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBTROGV', @level2type = N'COLUMN', @level2name = N'KAR_TSP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Het aantal personen dat vervoerd werd met het betrokken voertuig', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBTROGV', @level2type = N'COLUMN', @level2name = N'Q_IND_TSP_BRTK';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Was er een aanhangwagen aanwezig aan het betrokken voertuig?', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBTROGV', @level2type = N'COLUMN', @level2name = N'INDI_TRL_VKM_TSP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Beschrijving van het aantal kg aanwezig op de aanhangwagen', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBTROGV', @level2type = N'COLUMN', @level2name = N'SCF_Q_KG_VKM_TSP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'rijbewijs nummer', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBTROGV', @level2type = N'COLUMN', @level2name = N'RB_NR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'rijbewijs categorie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBTROGV', @level2type = N'COLUMN', @level2name = N'RB_CAT';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'datum uitgifte rijbewijs', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBTROGV', @level2type = N'COLUMN', @level2name = N'RB_DAT_UITG';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'rijbewijs plaats uitgifte', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBTROGV', @level2type = N'COLUMN', @level2name = N'RB_PL_UITG';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Handelend in naam van', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBTROGV', @level2type = N'COLUMN', @level2name = N'HD_NM_VN';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Voertuig (indien null--> fiets...)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBTROGV', @level2type = N'COLUMN', @level2name = N'ID_TSP';

