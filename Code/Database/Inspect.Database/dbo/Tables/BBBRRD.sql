CREATE TABLE [dbo].[BBBRRD] (
    [ID_BR_RD_INTV]  INT          NOT NULL,
    [SCF_BR_RD_INTV] VARCHAR (50) NULL,
    [INDI_BZ]        BIT          NULL,
    [ID_TY_INTV]     INT          NULL,
    CONSTRAINT [BBBRRD_PK] PRIMARY KEY CLUSTERED ([ID_BR_RD_INTV] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [FK_BBBRRD_BBINTVTY] FOREIGN KEY ([ID_TY_INTV]) REFERENCES [dbo].[BBINTVTY] ([ID_TY_INTV])
);


GO
CREATE NONCLUSTERED INDEX [I_BBBRRD_01]
    ON [dbo].[BBBRRD]([ID_TY_INTV] ASC) WITH (FILLFACTOR = 70);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de oorzaak van de interventie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBRRD', @level2type = N'COLUMN', @level2name = N'ID_BR_RD_INTV';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Omschrijving van de oorzaak van de interventie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBRRD', @level2type = N'COLUMN', @level2name = N'SCF_BR_RD_INTV';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Indicator oorzaak gebruikt bij eerdere interventies (Wordt deze oorzaak nog gebruikt bij eerdere interventies?)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBRRD', @level2type = N'COLUMN', @level2name = N'INDI_BZ';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het interventietype', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBRRD', @level2type = N'COLUMN', @level2name = N'ID_TY_INTV';

