﻿
CREATE PROC dbo.[USP_WY_BBKEUTSP_DELETE]
  @Original_ID_REG int --Primary Key Field

AS
SET NOCOUNT OFF

DELETE FROM [BBKEUTSP]
WHERE [ID_REG] = @Original_ID_REG

