﻿
CREATE PROC dbo.[USP_WY_BBREGTY_UPDATE]
  @ID_TY_REG int,
  @SCF_TY_REG varchar(30)=NULL,
  @Original_ID_TY_REG int --Primary Key Field

AS
SET NOCOUNT OFF

UPDATE [BBREGTY] SET
  [SCF_TY_REG] = @SCF_TY_REG
WHERE [ID_TY_REG] = @Original_ID_TY_REG

