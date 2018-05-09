CREATE TABLE [dbo].[bmAfdelingBeheerder] (
    [BeheerderAfdelingID]   INT           IDENTITY (1, 1) NOT NULL,
    [BeheerderAfdelingNaam] NVARCHAR (80) NULL,
    [AfdelingID]            INT           NULL,
    CONSTRAINT [PK_bmBeheerderAfdeling] PRIMARY KEY CLUSTERED ([BeheerderAfdelingID] ASC) WITH (FILLFACTOR = 70)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de Beheerder/Afdeling', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'bmAfdelingBeheerder', @level2type = N'COLUMN', @level2name = N'BeheerderAfdelingID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Naam van de Beheerder/Afdeling', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'bmAfdelingBeheerder', @level2type = N'COLUMN', @level2name = N'BeheerderAfdelingNaam';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Id van de afdeling voor de Beheerder/Afdeling', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'bmAfdelingBeheerder', @level2type = N'COLUMN', @level2name = N'AfdelingID';

