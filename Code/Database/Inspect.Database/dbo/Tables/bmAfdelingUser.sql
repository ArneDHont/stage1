CREATE TABLE [dbo].[bmAfdelingUser] (
    [AfdelingUserID] INT            IDENTITY (1, 1) NOT NULL,
    [LoginNaam]      NVARCHAR (12)  NULL,
    [AfdelingID]     INT            NULL,
    [AfdelingOmschr] NVARCHAR (100) NULL,
    [BrandweerYN]    BIT            NULL,
    [AfdelingID2]    INT            NULL,
    [AfdelingID3]    INT            NULL,
    CONSTRAINT [PK_bmAfdelingUser] PRIMARY KEY CLUSTERED ([AfdelingUserID] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [FK_bmAfdelingUser_bmAfdeling] FOREIGN KEY ([AfdelingID]) REFERENCES [dbo].[bmAfdeling] ([AfdelingID])
);


GO
CREATE NONCLUSTERED INDEX [I_bmAfdelingUser_01]
    ON [dbo].[bmAfdelingUser]([AfdelingID] ASC) WITH (FILLFACTOR = 70);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Id van de User/Afdeling', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'bmAfdelingUser', @level2type = N'COLUMN', @level2name = N'AfdelingUserID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Windows login naam van de User/Afdeling', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'bmAfdelingUser', @level2type = N'COLUMN', @level2name = N'LoginNaam';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Id van de afdeling voor de User/Afdeling', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'bmAfdelingUser', @level2type = N'COLUMN', @level2name = N'AfdelingID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Naam van de afdeling voor de User/Afdeling (nodig voor het rapport)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'bmAfdelingUser', @level2type = N'COLUMN', @level2name = N'AfdelingOmschr';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Mensen van de brandweer krijgen een uitgebreidere versie van het programma Brandweer', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'bmAfdelingUser', @level2type = N'COLUMN', @level2name = N'BrandweerYN';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'17/05/2001 => gegevens van meerdere afdelingen kunnen raadplegen (bv. SIDGAL en GALTEC)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'bmAfdelingUser', @level2type = N'COLUMN', @level2name = N'AfdelingID2';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'17/05/2001 => gegevens van meerdere afdelingen kunnen raadplegen (bv. SIDGAL en GALTEC)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'bmAfdelingUser', @level2type = N'COLUMN', @level2name = N'AfdelingID3';

