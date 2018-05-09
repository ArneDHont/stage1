CREATE TABLE [dbo].[BBSCADAN] (
    [ID_OBJ_SCAD]  INT          NOT NULL,
    [SCF_OBJ_SCAD] VARCHAR (50) NULL,
    CONSTRAINT [BBSCADAN_PK] PRIMARY KEY CLUSTERED ([ID_OBJ_SCAD] ASC) WITH (FILLFACTOR = 70)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie schadeobject', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBSCADAN', @level2type = N'COLUMN', @level2name = N'ID_OBJ_SCAD';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Omschrijving schadeobject', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBSCADAN', @level2type = N'COLUMN', @level2name = N'SCF_OBJ_SCAD';

