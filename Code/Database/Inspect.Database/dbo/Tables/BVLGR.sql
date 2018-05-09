CREATE TABLE [dbo].[BVLGR] (
    [ID_GR]          CHAR (50)    NOT NULL,
    [NM_GR]          VARCHAR (50) NULL,
    [TMS_CRE_RE]     DATETIME     NULL,
    [ID_BRK_CRE_RE]  CHAR (8)     NULL,
    [TMS_WY_L_RE]    DATETIME     NULL,
    [ID_BRK_WY_L_RE] CHAR (8)     NULL,
    [NR_WY_L_RE]     INT          NULL,
    CONSTRAINT [BVLGR_PK] PRIMARY KEY CLUSTERED ([ID_GR] ASC) WITH (FILLFACTOR = 70)
);

