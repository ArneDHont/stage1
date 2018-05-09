CREATE TABLE [dbo].[BBSCAD] (
    [ID_REG]      INT            NOT NULL,
    [ID_FRM]      INT            NULL,
    [ID_MLD]      INT            NULL,
    [ID_TSP]      INT            NULL,
    [ID_FRM_VZK]  INT            NULL,
    [ID_OBJ_SCAD] INT            NULL,
    [ID_BEW_DUP]  INT            NULL,
    [NR_BTW]      VARCHAR (20)   NULL,
    [NR_POLIS]    VARCHAR (20)   NULL,
    [TY_SCAD]     VARCHAR (2000) NULL,
    [RD_SCAD]     VARCHAR (2000) NULL,
    [OPM_SCAD]    VARCHAR (5000) NULL,
    CONSTRAINT [BBSCAD_PK] PRIMARY KEY CLUSTERED ([ID_REG] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [BBBEWREG_BBSCAD_FK1] FOREIGN KEY ([ID_REG]) REFERENCES [dbo].[BBBEWREG] ([ID_REG]),
    CONSTRAINT [BBFRM_BBSCAD_FK1] FOREIGN KEY ([ID_FRM]) REFERENCES [dbo].[BBFRM] ([ID_FRM]),
    CONSTRAINT [BBIND_BBSCAD_FK1] FOREIGN KEY ([ID_MLD]) REFERENCES [dbo].[BBIND] ([ID_IND]),
    CONSTRAINT [BBSCADAN_BBSCAD_FK1] FOREIGN KEY ([ID_OBJ_SCAD]) REFERENCES [dbo].[BBSCADAN] ([ID_OBJ_SCAD]),
    CONSTRAINT [BBTSP_BBSCAD_FK1] FOREIGN KEY ([ID_TSP]) REFERENCES [dbo].[BBTSP] ([ID_TSP]),
    CONSTRAINT [BBVZKFRM_BBSCAD_FK1] FOREIGN KEY ([ID_FRM_VZK]) REFERENCES [dbo].[BBVZKFRM] ([ID_FRM_VZK]),
    CONSTRAINT [FK_BBSCAD_BBBEWDUP] FOREIGN KEY ([ID_BEW_DUP]) REFERENCES [dbo].[BBBEWDUP] ([ID_BEW_DUP])
);


GO
CREATE NONCLUSTERED INDEX [I_BBSCAD_01]
    ON [dbo].[BBSCAD]([ID_FRM] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBSCAD_02]
    ON [dbo].[BBSCAD]([ID_MLD] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBSCAD_04]
    ON [dbo].[BBSCAD]([ID_TSP] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBSCAD_05]
    ON [dbo].[BBSCAD]([ID_FRM_VZK] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBSCAD_03]
    ON [dbo].[BBSCAD]([ID_OBJ_SCAD] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBSCAD_06]
    ON [dbo].[BBSCAD]([ID_BEW_DUP] ASC) WITH (FILLFACTOR = 70);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de registratie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBSCAD', @level2type = N'COLUMN', @level2name = N'ID_REG';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de firma', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBSCAD', @level2type = N'COLUMN', @level2name = N'ID_FRM';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de melder', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBSCAD', @level2type = N'COLUMN', @level2name = N'ID_MLD';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het voertuig', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBSCAD', @level2type = N'COLUMN', @level2name = N'ID_TSP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de verzekeringsfirma', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBSCAD', @level2type = N'COLUMN', @level2name = N'ID_FRM_VZK';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie schadeobject', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBSCAD', @level2type = N'COLUMN', @level2name = N'ID_OBJ_SCAD';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Het btwnummer', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBSCAD', @level2type = N'COLUMN', @level2name = N'NR_BTW';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Het polisnummer', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBSCAD', @level2type = N'COLUMN', @level2name = N'NR_POLIS';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De aard van de beschadiging', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBSCAD', @level2type = N'COLUMN', @level2name = N'TY_SCAD';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De oorzaak van de beschadiging', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBSCAD', @level2type = N'COLUMN', @level2name = N'RD_SCAD';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Opmerkingen bij de beschadiging', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBSCAD', @level2type = N'COLUMN', @level2name = N'OPM_SCAD';

