CREATE TABLE [dbo].[BBINBRSanctionMatrix] (
    [SanctionMatrixID]    BIGINT         NOT NULL,
    [SanctionMatrixDescr] NVARCHAR (100) NULL,
    [Zone]                INT            NULL,
    [SpeedFrom]           INT            NULL,
    [SpeedTo]             INT            NULL,
    [CarMotorYN]          BIT            NULL,
    [TruckYN]             BIT            NULL,
    [Sanction1]           INT            NULL,
    [Sanction2_24months]  INT            NULL,
    [Sanction3_24months]  INT            NULL,
    [Remark]              NVARCHAR (250) NULL,
    CONSTRAINT [PK_BBINBRSanction] PRIMARY KEY CLUSTERED ([SanctionMatrixID] ASC) WITH (FILLFACTOR = 70)
);

