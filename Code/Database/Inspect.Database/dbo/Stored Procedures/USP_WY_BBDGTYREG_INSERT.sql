﻿

CREATE PROC dbo.[USP_WY_BBDGTYREG_INSERT]
  @ID_DG_PERS_TY_REG int,
  @SCF_DG_PERS_TY_REG varchar(100)

AS
SET NOCOUNT OFF

INSERT INTO [BBDGTYREG] (
  [ID_DG_PERS_TY_REG],
  [SCF_DG_PERS_TY_REG]
)
VALUES (
  @ID_DG_PERS_TY_REG,
  @SCF_DG_PERS_TY_REG
)


