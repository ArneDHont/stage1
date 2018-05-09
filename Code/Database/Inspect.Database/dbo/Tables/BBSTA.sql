CREATE TABLE [dbo].[BBSTA] (
    [ID_STA]    INT           IDENTITY (1, 1) NOT NULL,
    [ID_TY_STA] INT           NULL,
    [SCF_STA]   VARCHAR (100) NULL,
    CONSTRAINT [PK_BBSTA] PRIMARY KEY CLUSTERED ([ID_STA] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [FK_BBSTA_BBTYSTA] FOREIGN KEY ([ID_TY_STA]) REFERENCES [dbo].[BBTYSTA] ([ID_TY_STA])
);


GO
CREATE NONCLUSTERED INDEX [I_BBSTA_01]
    ON [dbo].[BBSTA]([ID_TY_STA] ASC) WITH (FILLFACTOR = 70);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de toestand', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBSTA', @level2type = N'COLUMN', @level2name = N'ID_STA';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het type toestand', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBSTA', @level2type = N'COLUMN', @level2name = N'ID_TY_STA';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Omschrijving van de toestand', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBSTA', @level2type = N'COLUMN', @level2name = N'SCF_STA';

