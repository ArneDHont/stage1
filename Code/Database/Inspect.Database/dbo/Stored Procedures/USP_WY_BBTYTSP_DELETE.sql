﻿
CREATE PROC dbo.[USP_WY_BBTYTSP_DELETE]
  @Original_ID_TY_TSP int --Primary Key Field

AS
SET NOCOUNT OFF

DELETE FROM [BBTYTSP]
WHERE [ID_TY_TSP] = @Original_ID_TY_TSP

