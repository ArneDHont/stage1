CREATE TABLE [dbo].[BBFireCauseExtraInfo] (
    [FireCauseExtraInfoId] INT           NOT NULL,
    [FireCauseExtraInfo]   NVARCHAR (50) NULL,
    CONSTRAINT [PK_BBFireCauseExtraInfo] PRIMARY KEY CLUSTERED ([FireCauseExtraInfoId] ASC) WITH (FILLFACTOR = 70)
);

