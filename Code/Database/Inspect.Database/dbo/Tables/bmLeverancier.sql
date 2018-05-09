CREATE TABLE [dbo].[bmLeverancier] (
    [LeverancierID]   INT           IDENTITY (1, 1) NOT NULL,
    [NaamLeverancier] NVARCHAR (50) NULL,
    CONSTRAINT [PK_bmLeverancier] PRIMARY KEY CLUSTERED ([LeverancierID] ASC) WITH (FILLFACTOR = 70)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Id van de Leverancier', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'bmLeverancier', @level2type = N'COLUMN', @level2name = N'LeverancierID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Naam van de Leverancier', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'bmLeverancier', @level2type = N'COLUMN', @level2name = N'NaamLeverancier';

