CREATE TABLE [dbo].[BBOGVTSP] (
    [ID_REG]      INT            NOT NULL,
    [ID_MLD]      INT            NULL,
    [SCF_LNG_OGV] VARCHAR (8000) NULL,
    [ID_OGV_VAST] INT            NULL,
    [INF_EX]      VARCHAR (200)  NULL,
    [PLA_OGV]     VARCHAR (100)  NULL,
    [SCF_STA]     VARCHAR (100)  NULL,
    [ZBH]         VARCHAR (500)  NULL,
    [WND_RIC]     VARCHAR (500)  NULL,
    [WND_KR]      VARCHAR (500)  NULL,
    [GBEU]        VARCHAR (500)  NULL,
    CONSTRAINT [BBOGVTSP_PK] PRIMARY KEY CLUSTERED ([ID_REG] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [BBBEWREG_BBOGVTSP_FK1] FOREIGN KEY ([ID_REG]) REFERENCES [dbo].[BBBEWREG] ([ID_REG]),
    CONSTRAINT [BBIND_BBOGVTSP_FK1] FOREIGN KEY ([ID_MLD]) REFERENCES [dbo].[BBIND] ([ID_IND]),
    CONSTRAINT [FK_BBOGVTSP_BBVASTOGV] FOREIGN KEY ([ID_OGV_VAST]) REFERENCES [dbo].[BBVASTOGV] ([ID_VAST_OGV])
);


GO
CREATE NONCLUSTERED INDEX [I_BBOGVTSP_01]
    ON [dbo].[BBOGVTSP]([ID_MLD] ASC) WITH (FILLFACTOR = 70);


GO
CREATE NONCLUSTERED INDEX [I_BBOGVTSP_02]
    ON [dbo].[BBOGVTSP]([ID_OGV_VAST] ASC) WITH (FILLFACTOR = 70);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de registratie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBOGVTSP', @level2type = N'COLUMN', @level2name = N'ID_REG';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de melder', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBOGVTSP', @level2type = N'COLUMN', @level2name = N'ID_MLD';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Het relaas der feiten (een uitgebreidere omschrijving)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBOGVTSP', @level2type = N'COLUMN', @level2name = N'SCF_LNG_OGV';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Identificatie van de vaststeller', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBOGVTSP', @level2type = N'COLUMN', @level2name = N'ID_OGV_VAST';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Bijkomende informatie', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBOGVTSP', @level2type = N'COLUMN', @level2name = N'INF_EX';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'De plaats van de aanrijding', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBOGVTSP', @level2type = N'COLUMN', @level2name = N'PLA_OGV';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Een beschrijving van de toestand', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBOGVTSP', @level2type = N'COLUMN', @level2name = N'SCF_STA';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'zichtbaarheid', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBOGVTSP', @level2type = N'COLUMN', @level2name = N'ZBH';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'windrichting', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBOGVTSP', @level2type = N'COLUMN', @level2name = N'WND_RIC';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'windkracht', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBOGVTSP', @level2type = N'COLUMN', @level2name = N'WND_KR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Voorval (default: een aanrijding)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BBOGVTSP', @level2type = N'COLUMN', @level2name = N'GBEU';

