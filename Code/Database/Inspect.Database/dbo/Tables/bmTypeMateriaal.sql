CREATE TABLE [dbo].[bmTypeMateriaal] (
    [TypeMatID]          INT           IDENTITY (1, 1) NOT NULL,
    [TypeMatOmschr]      NVARCHAR (50) NULL,
    [KleineControleFreq] TINYINT       NULL,
    CONSTRAINT [PK_bmTypeMateriaal] PRIMARY KEY CLUSTERED ([TypeMatID] ASC) WITH (FILLFACTOR = 70)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Id van het type Materiaal', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'bmTypeMateriaal', @level2type = N'COLUMN', @level2name = N'TypeMatID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Omschrijving van het type Materiaal', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'bmTypeMateriaal', @level2type = N'COLUMN', @level2name = N'TypeMatOmschr';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Frequentie voor de visuele controle (in maanden)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'bmTypeMateriaal', @level2type = N'COLUMN', @level2name = N'KleineControleFreq';

