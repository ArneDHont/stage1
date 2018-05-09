CREATE TABLE [dbo].[BBOPKAST] (
    [ID_REG]             INT            NOT NULL,
    [ID_TITU_KAST]       INT            NULL,
    [ID_AFD]             INT            NULL,
    [ID_DNS_OPS_KAST_VR] INT            NULL,
    [ID_OTV_EIG_SID]     INT            NULL,
    [ID_OTV_EIG_TITU]    INT            NULL,
    [SCF_RD_OPN_KAST]    VARCHAR (3000) NULL,
    [SCF_EIG_SID]        VARCHAR (1000) NULL,
    [SCF_EIG_TITU]       VARCHAR (1000) NULL,
    [INF_EX_OPN_KAST]    VARCHAR (1000) NULL,
    CONSTRAINT [BBOPKAST_PK] PRIMARY KEY CLUSTERED ([ID_REG] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [BBAFD_BBOPKAST_FK1] FOREIGN KEY ([ID_AFD]) REFERENCES [dbo].[BBAFD] ([ID_AFD]),
    CONSTRAINT [BBBEWREG_BBOPKAST_FK1] FOREIGN KEY ([ID_REG]) REFERENCES [dbo].[BBBEWREG] ([ID_REG]),
    CONSTRAINT [BBIND_BBOPKAST_FK1] FOREIGN KEY ([ID_TITU_KAST]) REFERENCES [dbo].[BBIND] ([ID_IND]),
    CONSTRAINT [BBIND_BBOPKAST_FK2] FOREIGN KEY ([ID_DNS_OPS_KAST_VR]) REFERENCES [dbo].[BBIND] ([ID_IND]),
    CONSTRAINT [BBIND_BBOPKAST_FK3] FOREIGN KEY ([ID_OTV_EIG_SID]) REFERENCES [dbo].[BBIND] ([ID_IND]),
    CONSTRAINT [BBIND_BBOPKAST_FK4] FOREIGN KEY ([ID_OTV_EIG_TITU]) REFERENCES [dbo].[BBIND] ([ID_IND])
);


GO
CREATE NONCLUSTERED INDEX [I_BBOPKAST_02]
    ON [dbo].[BBOPKAST]([ID_TITU_KAST] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBOPKAST_01]
    ON [dbo].[BBOPKAST]([ID_AFD] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBOPKAST_03]
    ON [dbo].[BBOPKAST]([ID_DNS_OPS_KAST_VR] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBOPKAST_04]
    ON [dbo].[BBOPKAST]([ID_OTV_EIG_SID] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBOPKAST_05]
    ON [dbo].[BBOPKAST]([ID_OTV_EIG_TITU] ASC) WITH (FILLFACTOR = 70);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de registratie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBOPKAST', @level2type = N'COLUMN', @level2name = N'ID_REG';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de titularis van de kleerkast', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBOPKAST', @level2type = N'COLUMN', @level2name = N'ID_TITU_KAST';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Afdeling waar de kleerkast zich bevindt', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBOPKAST', @level2type = N'COLUMN', @level2name = N'ID_AFD';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de dienst die het openmaken van de kleerkast aanvraagt', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBOPKAST', @level2type = N'COLUMN', @level2name = N'ID_DNS_OPS_KAST_VR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de ontvanger van de eigendom die aan Sidmar behoort', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBOPKAST', @level2type = N'COLUMN', @level2name = N'ID_OTV_EIG_SID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de ontvanger van de eigendom die aan de titularis behoort', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBOPKAST', @level2type = N'COLUMN', @level2name = N'ID_OTV_EIG_TITU';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Beschrijving van de reden tot openmaken van de kleerkast', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBOPKAST', @level2type = N'COLUMN', @level2name = N'SCF_RD_OPN_KAST';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Beschrijving van de eigendom van Sidmar', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBOPKAST', @level2type = N'COLUMN', @level2name = N'SCF_EIG_SID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Beschrijving van de eigendom van de Titularis', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBOPKAST', @level2type = N'COLUMN', @level2name = N'SCF_EIG_TITU';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Bijkomende inlichtingen bij het openmaken van de kleerkast', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBOPKAST', @level2type = N'COLUMN', @level2name = N'INF_EX_OPN_KAST';

