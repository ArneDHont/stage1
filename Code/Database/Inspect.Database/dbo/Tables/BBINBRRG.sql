CREATE TABLE [dbo].[BBINBRRG] (
    [ID_REG]          INT            NOT NULL,
    [ID_BEW_DUP]      INT            NULL,
    [ID_INBR]         INT            NULL,
    [ID_FRM]          INT            NULL,
    [ID_TSP]          INT            NULL,
    [VKLR_INBR]       VARCHAR (3000) NULL,
    [OPM_EX_INBR_VSF] VARCHAR (3000) NULL,
    [ID_INBR_IND_TY]  INT            NULL,
    CONSTRAINT [BBINBRRG_PK] PRIMARY KEY CLUSTERED ([ID_REG] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [BBBEWREG_BBINBRRG_FK1] FOREIGN KEY ([ID_REG]) REFERENCES [dbo].[BBBEWREG] ([ID_REG]),
    CONSTRAINT [BBFRM_BBINBRRG_FK1] FOREIGN KEY ([ID_FRM]) REFERENCES [dbo].[BBFRM] ([ID_FRM]),
    CONSTRAINT [BBIND_BBINBRRG_FK1] FOREIGN KEY ([ID_INBR]) REFERENCES [dbo].[BBIND] ([ID_IND]),
    CONSTRAINT [FK_BBINBRRG_BBBEWDUP] FOREIGN KEY ([ID_BEW_DUP]) REFERENCES [dbo].[BBBEWDUP] ([ID_BEW_DUP]),
    CONSTRAINT [FK_BBINBRRG_BBTSP] FOREIGN KEY ([ID_TSP]) REFERENCES [dbo].[BBTSP] ([ID_TSP])
);


GO
CREATE NONCLUSTERED INDEX [I_BBINBRRG_03]
    ON [dbo].[BBINBRRG]([ID_BEW_DUP] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBINBRRG_02]
    ON [dbo].[BBINBRRG]([ID_INBR] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBINBRRG_01]
    ON [dbo].[BBINBRRG]([ID_FRM] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBINBRRG_04]
    ON [dbo].[BBINBRRG]([ID_TSP] ASC) WITH (FILLFACTOR = 70);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de registratie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINBRRG', @level2type = N'COLUMN', @level2name = N'ID_REG';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de overtreder', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINBRRG', @level2type = N'COLUMN', @level2name = N'ID_INBR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de firma', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINBRRG', @level2type = N'COLUMN', @level2name = N'ID_FRM';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het voertuig', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINBRRG', @level2type = N'COLUMN', @level2name = N'ID_TSP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De verklaring van de overtreder', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINBRRG', @level2type = N'COLUMN', @level2name = N'VKLR_INBR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Bijkomende opmerkingen bij de inbreuk op reglementen', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINBRRG', @level2type = N'COLUMN', @level2name = N'OPM_EX_INBR_VSF';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Type overtreder (Vrachtvervoerder, Arcelor Gent, ...)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINBRRG', @level2type = N'COLUMN', @level2name = N'ID_INBR_IND_TY';

