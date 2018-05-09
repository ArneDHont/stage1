CREATE TABLE [dbo].[BBALCTST] (
    [ID_REG]          INT            NOT NULL,
    [ID_MLD]          INT            NULL,
    [ID_BTRK]         INT            NULL,
    [ID_FRM]          INT            NULL,
    [SCF_LNG_TST_ALC] VARCHAR (8000) NULL,
    [TYD_TST_ALC_1]   VARCHAR (10)   NULL,
    [INDI_TST_1_POS]  BIT            NULL,
    [PLA_TST_ALC_1]   VARCHAR (100)  NULL,
    [TYD_TST_ALC_2]   VARCHAR (10)   NULL,
    [INDI_TST_2_POS]  BIT            NULL,
    [PLA_TST_ALC_2]   VARCHAR (100)  NULL,
    [SCF_RGL_NEM]     VARCHAR (2000) NULL,
    [INF_EX_TST_ALC]  VARCHAR (2000) NULL,
    CONSTRAINT [BBALCTST_PK] PRIMARY KEY CLUSTERED ([ID_REG] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [BBBEWREG_BBALCTST_FK1] FOREIGN KEY ([ID_REG]) REFERENCES [dbo].[BBBEWREG] ([ID_REG]),
    CONSTRAINT [BBFRM_BBALCTST_FK1] FOREIGN KEY ([ID_FRM]) REFERENCES [dbo].[BBFRM] ([ID_FRM]),
    CONSTRAINT [BBIND_BBALCTST_FK1] FOREIGN KEY ([ID_MLD]) REFERENCES [dbo].[BBIND] ([ID_IND]),
    CONSTRAINT [BBIND_BBALCTST_FK2] FOREIGN KEY ([ID_BTRK]) REFERENCES [dbo].[BBIND] ([ID_IND])
);


GO
CREATE NONCLUSTERED INDEX [I_BBALCTST_02]
    ON [dbo].[BBALCTST]([ID_MLD] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBALCTST_03]
    ON [dbo].[BBALCTST]([ID_BTRK] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBALCTST_01]
    ON [dbo].[BBALCTST]([ID_FRM] ASC) WITH (FILLFACTOR = 70);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de registratie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBALCTST', @level2type = N'COLUMN', @level2name = N'ID_REG';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de melder', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBALCTST', @level2type = N'COLUMN', @level2name = N'ID_MLD';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de betrokkene', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBALCTST', @level2type = N'COLUMN', @level2name = N'ID_BTRK';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de firma', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBALCTST', @level2type = N'COLUMN', @level2name = N'ID_FRM';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Het relaas van de feiten (uitgebreide omschrijving)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBALCTST', @level2type = N'COLUMN', @level2name = N'SCF_LNG_TST_ALC';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Het tijdstip van de alcoholtest 1', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBALCTST', @level2type = N'COLUMN', @level2name = N'TYD_TST_ALC_1';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Indicator test 1 is positief', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBALCTST', @level2type = N'COLUMN', @level2name = N'INDI_TST_1_POS';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De locatie van de alcoholtest 1', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBALCTST', @level2type = N'COLUMN', @level2name = N'PLA_TST_ALC_1';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Het tijdstip van de alcoholtest 2', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBALCTST', @level2type = N'COLUMN', @level2name = N'TYD_TST_ALC_2';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Indicator test 2 is positief', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBALCTST', @level2type = N'COLUMN', @level2name = N'INDI_TST_2_POS';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De locatie van de alcoholtest 2', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBALCTST', @level2type = N'COLUMN', @level2name = N'PLA_TST_ALC_2';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Beschrijving van de getroffen maatregelen', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBALCTST', @level2type = N'COLUMN', @level2name = N'SCF_RGL_NEM';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Bijkomende inlichtingen bij de alcoholtest', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBALCTST', @level2type = N'COLUMN', @level2name = N'INF_EX_TST_ALC';

