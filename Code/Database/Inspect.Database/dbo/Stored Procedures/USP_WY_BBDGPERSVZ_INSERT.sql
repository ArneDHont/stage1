﻿

CREATE PROC dbo.[USP_WY_BBDGPERSVZ_INSERT]
  @DT_VZ datetime

AS
SET NOCOUNT OFF

INSERT INTO [BBDGPERSVZ] (
  [DT_VZ]
)
VALUES (
  @DT_VZ
)


