CREATE TABLE [dbo].[BBINDGSL] (
    [ID_GSL_IND]      INT          NOT NULL,
    [SCF_IND_GSL_RAP] VARCHAR (10) NULL,
    CONSTRAINT [PK_BBINDGSL] PRIMARY KEY CLUSTERED ([ID_GSL_IND] ASC) WITH (FILLFACTOR = 70)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de aanspreektitel', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINDGSL', @level2type = N'COLUMN', @level2name = N'ID_GSL_IND';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Aanspreektitel op rapporten (Dhr. - Mevr.)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINDGSL', @level2type = N'COLUMN', @level2name = N'SCF_IND_GSL_RAP';

