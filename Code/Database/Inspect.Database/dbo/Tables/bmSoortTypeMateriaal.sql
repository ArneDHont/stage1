CREATE TABLE [dbo].[bmSoortTypeMateriaal] (
    [SoortTypeMatID]     INT           IDENTITY (1, 1) NOT NULL,
    [TypeMatID]          INT           NULL,
    [BrandblusCodeID]    INT           NULL,
    [BrandblusInhoud]    TINYINT       NULL,
    [SoortTypeMatOmschr] NVARCHAR (50) NULL,
    CONSTRAINT [PK_bmSoortTypeMateriaal] PRIMARY KEY CLUSTERED ([SoortTypeMatID] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [FK_bmSoortTypeMateriaal_bmBrandblusCode] FOREIGN KEY ([BrandblusCodeID]) REFERENCES [dbo].[bmBrandblusCode] ([BrandblusCodeID])
);


GO
CREATE NONCLUSTERED INDEX [I_bmSoortTypeMateriaal_01]
    ON [dbo].[bmSoortTypeMateriaal]([BrandblusCodeID] ASC) WITH (FILLFACTOR = 70);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Id van het soort type Materiaal', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'bmSoortTypeMateriaal', @level2type = N'COLUMN', @level2name = N'SoortTypeMatID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Id van het type Materiaal', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'bmSoortTypeMateriaal', @level2type = N'COLUMN', @level2name = N'TypeMatID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Id van de brandblus code', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'bmSoortTypeMateriaal', @level2type = N'COLUMN', @level2name = N'BrandblusCodeID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Inhoud van een brandblustoestel (in kg)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'bmSoortTypeMateriaal', @level2type = N'COLUMN', @level2name = N'BrandblusInhoud';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Omschrijving van het soort type Materiaal', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'bmSoortTypeMateriaal', @level2type = N'COLUMN', @level2name = N'SoortTypeMatOmschr';

