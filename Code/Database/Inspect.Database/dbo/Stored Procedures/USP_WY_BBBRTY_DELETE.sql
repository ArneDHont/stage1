﻿
CREATE PROC dbo.[USP_WY_BBBRTY_DELETE]
  @Original_ID_BR_TY_INTV int --Primary Key Field

AS
SET NOCOUNT OFF

DELETE FROM [BBBRTY]
WHERE [ID_BR_TY_INTV] = @Original_ID_BR_TY_INTV

