﻿

CREATE PROC dbo.[USP_WY_BBBWPERS_DELETE]
  @Original_ID_IND int --Primary Key Field

AS
SET NOCOUNT OFF

DELETE FROM [BBBWPERS]
WHERE [ID_IND] = @Original_ID_IND


