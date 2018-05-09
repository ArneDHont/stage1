CREATE TABLE [dbo].[BBBRTY] (
    [ID_BR_TY_INTV]  INT          NOT NULL,
    [SCF_BR_TY_INTV] VARCHAR (60) NULL,
    [INDI_BZ]        BIT          NULL,
    [ID_TY_INTV]     INT          NULL,
    CONSTRAINT [BBBRTY_PK] PRIMARY KEY CLUSTERED ([ID_BR_TY_INTV] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [FK_BBBRTY_BBINTVTY] FOREIGN KEY ([ID_TY_INTV]) REFERENCES [dbo].[BBINTVTY] ([ID_TY_INTV])
);


GO
CREATE NONCLUSTERED INDEX [I_BBBRTY_01]
    ON [dbo].[BBBRTY]([ID_TY_INTV] ASC) WITH (FILLFACTOR = 70);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificiatie van de aard van de interventie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBRTY', @level2type = N'COLUMN', @level2name = N'ID_BR_TY_INTV';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Omschrijving van de aard van de interventie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBRTY', @level2type = N'COLUMN', @level2name = N'SCF_BR_TY_INTV';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Indicator aard gebruikt bij eerdere interventies (Wordt deze aard nog gebruikt bij eerdere interventies?)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBRTY', @level2type = N'COLUMN', @level2name = N'INDI_BZ';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van het interventietype', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBBRTY', @level2type = N'COLUMN', @level2name = N'ID_TY_INTV';

