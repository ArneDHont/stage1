﻿
CREATE PROC dbo.[USP_WY_BBBEWDUP_DELETE]
  @Original_ID_BEW_DUP int --Primary Key Field

AS
SET NOCOUNT OFF

DELETE FROM [BBBEWDUP]
WHERE [ID_BEW_DUP] = @Original_ID_BEW_DUP

