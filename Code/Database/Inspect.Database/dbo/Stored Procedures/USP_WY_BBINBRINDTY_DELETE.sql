﻿
CREATE PROC dbo.[USP_WY_BBINBRINDTY_DELETE]
  @Original_ID_INBR_IND_TY int --Primary Key Field

AS
SET NOCOUNT OFF

DELETE FROM [BBINBRINDTY]
WHERE [ID_INBR_IND_TY] = @Original_ID_INBR_IND_TY

