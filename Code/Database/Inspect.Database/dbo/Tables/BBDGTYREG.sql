CREATE TABLE [dbo].[BBDGTYREG] (
    [ID_DG_PERS_TY_REG]  INT           NOT NULL,
    [SCF_DG_PERS_TY_REG] VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_BBDGTYREG] PRIMARY KEY CLUSTERED ([ID_DG_PERS_TY_REG] ASC) WITH (FILLFACTOR = 70)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van registratietype dagverslag', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDGTYREG', @level2type = N'COLUMN', @level2name = N'ID_DG_PERS_TY_REG';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Omschrijving van registratietype dagverslag', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDGTYREG', @level2type = N'COLUMN', @level2name = N'SCF_DG_PERS_TY_REG';

