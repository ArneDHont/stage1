﻿
CREATE PROC dbo.[USP_WY_BBINBRVA_DELETE]
  @Original_ID_INBRVA int --Primary Key Field

AS
SET NOCOUNT OFF

DELETE FROM [BBINBRVA]
WHERE [ID_INBRVA] = @Original_ID_INBRVA

