﻿

CREATE PROC dbo.[USP_WY_BBTSP_DELETE]
  @Original_ID_TSP int --Primary Key Field

AS
SET NOCOUNT OFF

DELETE FROM [BBTSP]
WHERE [ID_TSP] = @Original_ID_TSP


