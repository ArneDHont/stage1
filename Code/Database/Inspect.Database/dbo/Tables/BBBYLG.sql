CREATE TABLE [dbo].[BBBYLG] (
    [ID_BYLG]      INT           IDENTITY (1, 1) NOT NULL,
    [ID_INTV_BRDW] INT           NULL,
    [ID_REG]       INT           NULL,
    [PLA_BYLG]     VARCHAR (100) NULL,
    [SCF_BYLG]     VARCHAR (200) NULL,
    [ID_DOC]       VARCHAR (50)  NULL,
    CONSTRAINT [BBBYLREG_PK] PRIMARY KEY CLUSTERED ([ID_BYLG] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [BBBEWREG_BBBYLREG_FK1] FOREIGN KEY ([ID_REG]) REFERENCES [dbo].[BBBEWREG] ([ID_REG]),
    CONSTRAINT [FK_BBBYLG_BBINTVBR] FOREIGN KEY ([ID_INTV_BRDW]) REFERENCES [dbo].[BBINTVBR] ([ID_INTV_BRDW])
);


GO
CREATE NONCLUSTERED INDEX [I_BBBYLG_02]
    ON [dbo].[BBBYLG]([ID_INTV_BRDW] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBBYLG_01]
    ON [dbo].[BBBYLG]([ID_REG] ASC) WITH (FILLFACTOR = 70);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de bijlage van de interventie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBYLG', @level2type = N'COLUMN', @level2name = N'ID_BYLG';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de brandweerinterventie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBYLG', @level2type = N'COLUMN', @level2name = N'ID_INTV_BRDW';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de registratie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBYLG', @level2type = N'COLUMN', @level2name = N'ID_REG';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De plaats van de bijlage (locatie op schijf)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBYLG', @level2type = N'COLUMN', @level2name = N'PLA_BYLG';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Beschrijving van de bijlage', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBYLG', @level2type = N'COLUMN', @level2name = N'SCF_BYLG';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Chronicle ID Documentum', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBYLG', @level2type = N'COLUMN', @level2name = N'ID_DOC';

