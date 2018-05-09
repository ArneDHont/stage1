﻿CREATE TABLE [dbo].[BVLGGD] (
    [ID_TOEP]        CHAR (50)    NOT NULL,
    [ID_GGD]         CHAR (50)    NOT NULL,
    [NM_GGD]         VARCHAR (50) NULL,
    [COD_BVG]        CHAR (1)     NOT NULL,
    [TMS_CRE_RE]     DATETIME     NULL,
    [ID_BRK_CRE_RE]  CHAR (8)     NULL,
    [TMS_WY_L_RE]    DATETIME     NULL,
    [ID_BRK_WY_L_RE] CHAR (8)     NULL,
    [NR_WY_L_RE]     INT          NULL,
    CONSTRAINT [BVLGGD_PK] PRIMARY KEY CLUSTERED ([ID_TOEP] ASC, [ID_GGD] ASC) WITH (FILLFACTOR = 70),
    CONSTRAINT [BVLTOEP_BVLGGD_FK1] FOREIGN KEY ([ID_TOEP]) REFERENCES [dbo].[BVLTOEP] ([ID_TOEP])
);

