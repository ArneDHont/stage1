CREATE TABLE [dbo].[BBDGPODL] (
    [ID_DG_PO_DL]  INT          NOT NULL,
    [SCF_DG_PO_DL] VARCHAR (50) NULL,
    [INV_PO]       BIT          NULL,
    [VLG]          INT          NULL,
    CONSTRAINT [PK_BBDGPODL] PRIMARY KEY CLUSTERED ([ID_DG_PO_DL] ASC) WITH (FILLFACTOR = 70)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de rubriek voor dagverslag posten', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDGPODL', @level2type = N'COLUMN', @level2name = N'ID_DG_PO_DL';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Omschrijving van de rubriek voor dagverslag posten', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDGPODL', @level2type = N'COLUMN', @level2name = N'SCF_DG_PO_DL';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Input per post (indien false => enkel algemeen invullen)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDGPODL', @level2type = N'COLUMN', @level2name = N'INV_PO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Volgnummer (sortering)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBDGPODL', @level2type = N'COLUMN', @level2name = N'VLG';

