CREATE TABLE [dbo].[bmAfdeling] (
    [AfdelingID]   INT           IDENTITY (1, 1) NOT NULL,
    [AfdelingCode] NVARCHAR (10) NULL,
    [AfdelingNaam] NVARCHAR (50) NULL,
    CONSTRAINT [PK_bmAfdeling] PRIMARY KEY CLUSTERED ([AfdelingID] ASC) WITH (FILLFACTOR = 70)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie Afdeling', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'bmAfdeling', @level2type = N'COLUMN', @level2name = N'AfdelingID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Code van de afdeling (AG, KW, WW, ...)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'bmAfdeling', @level2type = N'COLUMN', @level2name = N'AfdelingCode';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Naam afdeling', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'bmAfdeling', @level2type = N'COLUMN', @level2name = N'AfdelingNaam';

