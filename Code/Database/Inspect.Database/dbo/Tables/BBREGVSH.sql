CREATE TABLE [dbo].[BBREGVSH] (
    [ID_REG]           INT            NOT NULL,
    [ID_FRM]           INT            NULL,
    [ID_FRM_VZK]       INT            NULL,
    [SCF_FRM_BTRK_ALT] VARCHAR (300)  NULL,
    [NR_BTW]           VARCHAR (20)   NULL,
    [SCF_KRT_REG_VSH]  VARCHAR (1000) NULL,
    [SCF_LNG_REG_VSH]  VARCHAR (8000) NULL,
    [NR_POLIS]         VARCHAR (30)   NULL,
    [ID_AFD]           INT            NULL,
    CONSTRAINT [BBREGVSH_PK] PRIMARY KEY CLUSTERED ([ID_REG] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [BBBEWREG_BBREGVSH_FK1] FOREIGN KEY ([ID_REG]) REFERENCES [dbo].[BBBEWREG] ([ID_REG]),
    CONSTRAINT [BBFRM_BBREGVSH_FK1] FOREIGN KEY ([ID_FRM]) REFERENCES [dbo].[BBFRM] ([ID_FRM]),
    CONSTRAINT [BBVZKFRM_BBREGVSH_FK1] FOREIGN KEY ([ID_FRM_VZK]) REFERENCES [dbo].[BBVZKFRM] ([ID_FRM_VZK])
);


GO
CREATE NONCLUSTERED INDEX [I_BBREGVSH_01]
    ON [dbo].[BBREGVSH]([ID_FRM] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBREGVSH_02]
    ON [dbo].[BBREGVSH]([ID_FRM_VZK] ASC) WITH (FILLFACTOR = 70);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de registratie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBREGVSH', @level2type = N'COLUMN', @level2name = N'ID_REG';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de firma', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBREGVSH', @level2type = N'COLUMN', @level2name = N'ID_FRM';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de verzekeringsfirma', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBREGVSH', @level2type = N'COLUMN', @level2name = N'ID_FRM_VZK';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Beschrijving van andere betrokken firma''s', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBREGVSH', @level2type = N'COLUMN', @level2name = N'SCF_FRM_BTRK_ALT';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Het btw-nummer', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBREGVSH', @level2type = N'COLUMN', @level2name = N'NR_BTW';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Een korte omschrijving van de diverse registratie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBREGVSH', @level2type = N'COLUMN', @level2name = N'SCF_KRT_REG_VSH';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Het relaas der feiten van de diverse registratie (uitgebreidere omschrijving)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBREGVSH', @level2type = N'COLUMN', @level2name = N'SCF_LNG_REG_VSH';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Het polisnummer', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBREGVSH', @level2type = N'COLUMN', @level2name = N'NR_POLIS';

