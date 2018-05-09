CREATE TABLE [dbo].[BBBST] (
    [ID_BST]       INT IDENTITY (1, 1) NOT NULL,
    [ID_INTV_BRDW] INT NULL,
    [ID_REG]       INT NULL,
    [ID_IND]       INT NULL,
    CONSTRAINT [BBBST_PK] PRIMARY KEY CLUSTERED ([ID_BST] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [BBIND_BBBST_FK1] FOREIGN KEY ([ID_IND]) REFERENCES [dbo].[BBIND] ([ID_IND]),
    CONSTRAINT [BBINTVBR_BBBST_FK1] FOREIGN KEY ([ID_INTV_BRDW]) REFERENCES [dbo].[BBINTVBR] ([ID_INTV_BRDW]),
    CONSTRAINT [FK_BBBST_BBBEWREG] FOREIGN KEY ([ID_REG]) REFERENCES [dbo].[BBBEWREG] ([ID_REG])
);


GO
CREATE NONCLUSTERED INDEX [I_BBBST_02]
    ON [dbo].[BBBST]([ID_INTV_BRDW] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBBST_03]
    ON [dbo].[BBBST]([ID_REG] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBBST_01]
    ON [dbo].[BBBST]([ID_IND] ASC) WITH (FILLFACTOR = 70);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de bestemmeling van het interventieverslag', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBST', @level2type = N'COLUMN', @level2name = N'ID_BST';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de brandweerinterventie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBST', @level2type = N'COLUMN', @level2name = N'ID_INTV_BRDW';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de registratie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBST', @level2type = N'COLUMN', @level2name = N'ID_REG';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het individu', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBST', @level2type = N'COLUMN', @level2name = N'ID_IND';

