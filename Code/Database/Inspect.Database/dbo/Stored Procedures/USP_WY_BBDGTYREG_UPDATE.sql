﻿

CREATE PROC dbo.[USP_WY_BBDGTYREG_UPDATE]
  @ID_DG_PERS_TY_REG int,
  @SCF_DG_PERS_TY_REG varchar(100),
  @Original_ID_DG_PERS_TY_REG int --Primary Key Field

AS
SET NOCOUNT OFF

UPDATE [BBDGTYREG] SET
  [SCF_DG_PERS_TY_REG] = @SCF_DG_PERS_TY_REG
WHERE [ID_DG_PERS_TY_REG] = @Original_ID_DG_PERS_TY_REG

