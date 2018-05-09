CREATE TABLE [dbo].[BBCONF] (
    [GR_SLE] VARCHAR (50)   NOT NULL,
    [SLE]    VARCHAR (50)   NOT NULL,
    [WD]     VARCHAR (8000) NULL,
    [OPM]    VARCHAR (100)  NULL,
    CONSTRAINT [PK_BBCONF] PRIMARY KEY CLUSTERED ([GR_SLE] ASC, [SLE] ASC) WITH (FILLFACTOR = 70)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de sectie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBCONF', @level2type = N'COLUMN', @level2name = N'GR_SLE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Sleutel', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBCONF', @level2type = N'COLUMN', @level2name = N'SLE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De waarde', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBCONF', @level2type = N'COLUMN', @level2name = N'WD';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Eventuele opmerkingen', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBCONF', @level2type = N'COLUMN', @level2name = N'OPM';

