CREATE TABLE [dbo].[BBDIEFST] (
    [ID_REG]                   INT            NOT NULL,
    [ID_MLD]                   INT            NULL,
    [ID_FRM]                   INT            NULL,
    [ID_DUP_IND]               INT            NULL,
    [ID_DUP]                   INT            NULL,
    [SCF_MAT_STLN]             VARCHAR (500)  NULL,
    [STA_MAT]                  VARCHAR (500)  NULL,
    [WD_MAT]                   FLOAT (53)     NULL,
    [NR_BTW]                   VARCHAR (20)   NULL,
    [SCF_LNG_DIEF]             VARCHAR (3000) NULL,
    [ID_AFD]                   INT            NULL,
    [PolitieGevraagdDoorAfdYN] BIT            NULL,
    [PolitieLangsgeweestYN]    BIT            NULL,
    [PolitiePVnummer]          NVARCHAR (100) NULL,
    CONSTRAINT [BBDIEFST_PK] PRIMARY KEY CLUSTERED ([ID_REG] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [BBBEWREG_BBDIEFST_FK1] FOREIGN KEY ([ID_REG]) REFERENCES [dbo].[BBBEWREG] ([ID_REG]),
    CONSTRAINT [BBDIEFDU_BBDIEFST_FK1] FOREIGN KEY ([ID_DUP]) REFERENCES [dbo].[BBDIEFDU] ([ID_DUP_DIEF]),
    CONSTRAINT [BBFRM_BBDIEFST_FK1] FOREIGN KEY ([ID_FRM]) REFERENCES [dbo].[BBFRM] ([ID_FRM]),
    CONSTRAINT [BBIND_BBDIEFST_FK1] FOREIGN KEY ([ID_MLD]) REFERENCES [dbo].[BBIND] ([ID_IND]),
    CONSTRAINT [FK_BBDIEFST_BBIND] FOREIGN KEY ([ID_DUP_IND]) REFERENCES [dbo].[BBIND] ([ID_IND])
);


GO
CREATE NONCLUSTERED INDEX [I_BBDIEFST_03]
    ON [dbo].[BBDIEFST]([ID_MLD] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBDIEFST_02]
    ON [dbo].[BBDIEFST]([ID_FRM] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBDIEFST_04]
    ON [dbo].[BBDIEFST]([ID_DUP_IND] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBDIEFST_01]
    ON [dbo].[BBDIEFST]([ID_DUP] ASC) WITH (FILLFACTOR = 70);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de registratie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDIEFST', @level2type = N'COLUMN', @level2name = N'ID_REG';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de melder', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDIEFST', @level2type = N'COLUMN', @level2name = N'ID_MLD';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de firma', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDIEFST', @level2type = N'COLUMN', @level2name = N'ID_FRM';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Indentificatie van de gedupeerde persoon', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDIEFST', @level2type = N'COLUMN', @level2name = N'ID_DUP_IND';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de gedupeerde', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDIEFST', @level2type = N'COLUMN', @level2name = N'ID_DUP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Omschrijving van het gestolen goed', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDIEFST', @level2type = N'COLUMN', @level2name = N'SCF_MAT_STLN';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Staat van het gestolen goed', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDIEFST', @level2type = N'COLUMN', @level2name = N'STA_MAT';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Waarde gestolen goed', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDIEFST', @level2type = N'COLUMN', @level2name = N'WD_MAT';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Het BTW nummer', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDIEFST', @level2type = N'COLUMN', @level2name = N'NR_BTW';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Een lange omschrijving betreffende de diefstal (het relaas der feiten) ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDIEFST', @level2type = N'COLUMN', @level2name = N'SCF_LNG_DIEF';

