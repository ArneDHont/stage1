CREATE TABLE [dbo].[BBUserBrandweer] (
    [UserBrandweerID] INT            IDENTITY (1, 1) NOT NULL,
    [UserName]        NVARCHAR (50)  NULL,
    [UserPw]          NVARCHAR (20)  NULL,
    [PersonalNr]      INT            NULL,
    [Remark]          NVARCHAR (150) NULL,
    [DateCreated]     DATETIME       NULL,
    CONSTRAINT [PK_BBUserBrandweer] PRIMARY KEY CLUSTERED ([UserBrandweerID] ASC)
);

