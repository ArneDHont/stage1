CREATE TABLE [dbo].[BBTranslation] (
    [TranslationNr]    INT            NOT NULL,
    [TranslationDescr] NVARCHAR (250) NULL,
    [Category]         NVARCHAR (250) NULL,
    [ValueNL]          NVARCHAR (250) NULL,
    [ValueFR]          NVARCHAR (250) NULL,
    [ValueEN]          NVARCHAR (250) NULL,
    [ValueDE]          NVARCHAR (250) NULL,
    CONSTRAINT [PK_BBTranslation] PRIMARY KEY CLUSTERED ([TranslationNr] ASC) WITH (FILLFACTOR = 70)
);

