﻿

CREATE PROC dbo.[USP_WY_BBDGTYREG_DELETE]
  @Original_ID_DG_PERS_TY_REG int --Primary Key Field

AS
SET NOCOUNT OFF

DELETE FROM [BBDGTYREG]
WHERE [ID_DG_PERS_TY_REG] = @Original_ID_DG_PERS_TY_REG


