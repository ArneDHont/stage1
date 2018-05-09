CREATE TABLE [dbo].[bmBrandblusCode] (
    [BrandblusCodeID]     INT           IDENTITY (1, 1) NOT NULL,
    [BrandblusCodeOmschr] NVARCHAR (50) NULL,
    [GroteControleFreq]   SMALLINT      NULL,
    CONSTRAINT [PK_bmBrandblusCode] PRIMARY KEY CLUSTERED ([BrandblusCodeID] ASC) WITH (FILLFACTOR = 70)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de brandblus code', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'bmBrandblusCode', @level2type = N'COLUMN', @level2name = N'BrandblusCodeID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Type van het brandblus toestel', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'bmBrandblusCode', @level2type = N'COLUMN', @level2name = N'BrandblusCodeOmschr';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Frequentie voor groot onderhoud (in maanden)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'bmBrandblusCode', @level2type = N'COLUMN', @level2name = N'GroteControleFreq';

