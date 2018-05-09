CREATE TABLE [dbo].[bmActieCode] (
    [ActieCodeID] INT           NOT NULL,
    [ActieOmschr] NVARCHAR (50) NULL,
    CONSTRAINT [PK_qryActieCode] PRIMARY KEY CLUSTERED ([ActieCodeID] ASC) WITH (FILLFACTOR = 70)
);

