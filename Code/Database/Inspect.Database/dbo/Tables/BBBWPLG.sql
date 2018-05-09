CREATE TABLE [dbo].[BBBWPLG] (
    [ID_PLG_IND]  INT          NOT NULL,
    [SCF_PLG_IND] VARCHAR (50) NULL,
    [PLG_Mail] NVARCHAR(250) NULL, 
    CONSTRAINT [PK_BBBWPLG] PRIMARY KEY CLUSTERED ([ID_PLG_IND] ASC) WITH (FILLFACTOR = 70)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie ploeg', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBWPLG', @level2type = N'COLUMN', @level2name = N'ID_PLG_IND';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Omschrijving ploeg', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBWPLG', @level2type = N'COLUMN', @level2name = N'SCF_PLG_IND';

