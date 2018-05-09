CREATE TABLE [dbo].[BBINBRSanction] (
    [SanctionID]       INT            NOT NULL,
    [SanctionDescr]    NVARCHAR (100) NULL,
    [SanctionNL]       NVARCHAR (500) NULL,
    [SanctionFR]       NVARCHAR (500) NULL,
    [SanctionEN]       NVARCHAR (500) NULL,
    [SanctionDE]       NVARCHAR (500) NULL,
    [SanctionDuration] INT            NULL,
    [SanctionPeriod]   NVARCHAR (50)  NULL,
    CONSTRAINT [PK_BBINBRSanction_1] PRIMARY KEY CLUSTERED ([SanctionID] ASC) WITH (FILLFACTOR = 70)
);

