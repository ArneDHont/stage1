﻿
CREATE PROC dbo.[USP_WY_BBINTVTY_DELETE]
  @Original_ID_TY_INTV int --Primary Key Field

AS
SET NOCOUNT OFF

DELETE FROM [BBINTVTY]
WHERE [ID_TY_INTV] = @Original_ID_TY_INTV

