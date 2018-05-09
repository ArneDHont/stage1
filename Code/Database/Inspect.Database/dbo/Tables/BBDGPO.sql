CREATE TABLE [dbo].[BBDGPO] (
    [ID_DG_PO]      INT           IDENTITY (1, 1) NOT NULL,
    [ID_DG_PO_DL]   INT           NULL,
    [TMS_REG_DG_PO] SMALLDATETIME NULL,
    [Q_PO_1]        BIGINT        NULL,
    [Q_PO_2]        BIGINT        NULL,
    [Q_PO_4]        BIGINT        NULL,
    [Q_PO_ALG]      BIGINT        NULL,
    CONSTRAINT [PK_BBDGPO] PRIMARY KEY CLUSTERED ([ID_DG_PO] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [FK_BBDGPO_BBDGPODL] FOREIGN KEY ([ID_DG_PO_DL]) REFERENCES [dbo].[BBDGPODL] ([ID_DG_PO_DL])
);


GO
CREATE NONCLUSTERED INDEX [I_BBDGPO_01]
    ON [dbo].[BBDGPO]([ID_DG_PO_DL] ASC) WITH (FILLFACTOR = 70);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van dagverslag posten (autonummer)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDGPO', @level2type = N'COLUMN', @level2name = N'ID_DG_PO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de rubriek voor dagverslag', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDGPO', @level2type = N'COLUMN', @level2name = N'ID_DG_PO_DL';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Datum registratie dagverslag personeel', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDGPO', @level2type = N'COLUMN', @level2name = N'TMS_REG_DG_PO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Aantal op post 1', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDGPO', @level2type = N'COLUMN', @level2name = N'Q_PO_1';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Aantal op post 2', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDGPO', @level2type = N'COLUMN', @level2name = N'Q_PO_2';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Aantal op post 4', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDGPO', @level2type = N'COLUMN', @level2name = N'Q_PO_4';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Algemeen aantal (post is hier van geen belang)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDGPO', @level2type = N'COLUMN', @level2name = N'Q_PO_ALG';

