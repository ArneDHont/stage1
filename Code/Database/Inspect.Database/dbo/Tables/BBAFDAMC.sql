﻿CREATE TABLE [dbo].[BBAFDAMC] (
    [ID_AFD] INT NOT NULL,
    [ID_IND] INT NOT NULL,
    CONSTRAINT [PK_BBAFDAMC] PRIMARY KEY CLUSTERED ([ID_AFD] ASC, [ID_IND] ASC) WITH (FILLFACTOR = 70)
);
