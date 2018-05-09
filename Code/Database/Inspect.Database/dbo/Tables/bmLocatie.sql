CREATE TABLE [dbo].[bmLocatie] (
    [LocatieID]   INT          IDENTITY (1, 1) NOT NULL,
    [AfdelingID]  INT          NULL,
    [LocatieZone] NVARCHAR (4) NULL,
    CONSTRAINT [PK_bmLocatie] PRIMARY KEY CLUSTERED ([LocatieID] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [FK_bmLocatie_bmAfdeling] FOREIGN KEY ([AfdelingID]) REFERENCES [dbo].[bmAfdeling] ([AfdelingID])
);


GO
CREATE NONCLUSTERED INDEX [I_bmLocatie_01]
    ON [dbo].[bmLocatie]([AfdelingID] ASC) WITH (FILLFACTOR = 70);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Id van de locatie (zone binnen een afdeling)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'bmLocatie', @level2type = N'COLUMN', @level2name = N'LocatieID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Id van de Afdeling waar de Locatie toe behoort', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'bmLocatie', @level2type = N'COLUMN', @level2name = N'AfdelingID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Naam van de locatie (zone binnen een afdeling)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'bmLocatie', @level2type = N'COLUMN', @level2name = N'LocatieZone';

