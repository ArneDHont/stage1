﻿
CREATE PROC dbo.[USP_WY_BBBST_INSERT]
  @ID_BST int,
  @ID_INTV_BRDW int=NULL,
  @ID_REG int=NULL,
  @ID_IND int=NULL

AS
SET NOCOUNT OFF

INSERT INTO [BBBST] (
  [ID_INTV_BRDW],
  [ID_REG],
  [ID_IND]
)
VALUES (
  @ID_INTV_BRDW,
  @ID_REG,
  @ID_IND
)

