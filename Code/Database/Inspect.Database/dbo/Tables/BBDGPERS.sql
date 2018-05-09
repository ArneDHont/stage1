CREATE TABLE [dbo].[BBDGPERS] (
    [ID_DG_PERS]        INT          IDENTITY (1, 1) NOT NULL,
    [ID_IND]            INT          NULL,
    [TMS_REG_DG_PERS]   DATETIME     NULL,
    [ID_DG_PERS_TY_REG] INT          NULL,
    [OPM]               VARCHAR (50) NULL,
    CONSTRAINT [PK_BBDGPERS] PRIMARY KEY CLUSTERED ([ID_DG_PERS] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [FK_BBDGPERS_BBDGTYREG] FOREIGN KEY ([ID_DG_PERS_TY_REG]) REFERENCES [dbo].[BBDGTYREG] ([ID_DG_PERS_TY_REG])
);


GO
CREATE NONCLUSTERED INDEX [I_BBDGPERS_01]
    ON [dbo].[BBDGPERS]([ID_DG_PERS_TY_REG] ASC) WITH (FILLFACTOR = 70);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van dagverslag personeel', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDGPERS', @level2type = N'COLUMN', @level2name = N'ID_DG_PERS';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Stamnummer', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDGPERS', @level2type = N'COLUMN', @level2name = N'ID_IND';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Datum registratie dagverslag personeel', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDGPERS', @level2type = N'COLUMN', @level2name = N'TMS_REG_DG_PERS';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie registratietype voor dagverslag', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDGPERS', @level2type = N'COLUMN', @level2name = N'ID_DG_PERS_TY_REG';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Opmerking (commentaar)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDGPERS', @level2type = N'COLUMN', @level2name = N'OPM';

