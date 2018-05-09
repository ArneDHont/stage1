CREATE TABLE [dbo].[BBINBRINDTY] (
    [ID_INBR_IND_TY]  INT          NOT NULL,
    [SCF_INBR_IND_TY] VARCHAR (50) NULL,
    CONSTRAINT [PK_BBINBRINDTY] PRIMARY KEY CLUSTERED ([ID_INBR_IND_TY] ASC) WITH (FILLFACTOR = 70)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie type overtreder inbreuk reglementen', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINBRINDTY', @level2type = N'COLUMN', @level2name = N'ID_INBR_IND_TY';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Omschrijving type overtreder inbreuk reglementen', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBINBRINDTY', @level2type = N'COLUMN', @level2name = N'SCF_INBR_IND_TY';

