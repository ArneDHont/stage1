﻿CREATE TABLE [dbo].[BVLIND] (
    [ID_IND]         CHAR (50)    NOT NULL,
    [KRT_IND]        CHAR (50)    NOT NULL,
    [NM_IND]         VARCHAR (50) NULL,
    [TMS_CRE_RE]     DATETIME     NULL,
    [ID_BRK_CRE_RE]  CHAR (8)     NULL,
    [TMS_WY_L_RE]    DATETIME     NULL,
    [ID_BRK_WY_L_RE] CHAR (8)     NULL,
    [NR_WY_L_RE]     INT          NULL,
    CONSTRAINT [BVLIND_PK] PRIMARY KEY CLUSTERED ([ID_IND] ASC) WITH (FILLFACTOR = 70)
);

