﻿
CREATE PROC dbo.[USP_WY_BBINDTY_UPDATE]
  @ID_TY_IND int,
  @SCF_TY_IND char(50),
  @Original_ID_TY_IND int --Primary Key Field

AS
SET NOCOUNT OFF

UPDATE [BBINDTY] SET
  [SCF_TY_IND] = @SCF_TY_IND
WHERE [ID_TY_IND] = @Original_ID_TY_IND

