﻿
CREATE PROC dbo.[USP_WY_BBTYBTRK_DELETE]
  @Original_ID_TY_BTRK char(10) --Primary Key Field

AS
SET NOCOUNT OFF

DELETE FROM [BBTYBTRK]
WHERE [ID_TY_BTRK] = @Original_ID_TY_BTRK

