CREATE TABLE [dbo].[BBTYSTA] (
    [ID_TY_STA]  INT          IDENTITY (1, 1) NOT NULL,
    [SCF_TY_STA] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_BBTYSTA] PRIMARY KEY CLUSTERED ([ID_TY_STA] ASC) WITH (FILLFACTOR = 70)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het toestandstype', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBTYSTA', @level2type = N'COLUMN', @level2name = N'ID_TY_STA';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Omschrijving van het toestandstype', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBTYSTA', @level2type = N'COLUMN', @level2name = N'SCF_TY_STA';

