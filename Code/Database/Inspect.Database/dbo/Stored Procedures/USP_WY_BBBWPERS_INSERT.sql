﻿

CREATE PROC dbo.[USP_WY_BBBWPERS_INSERT]
  @ID_IND int,
  @ID_PLG_IND int,
  @BRDW bit,
  @WAK bit

AS
SET NOCOUNT OFF

INSERT INTO [BBBWPERS] (
  [ID_IND],
  [ID_PLG_IND],
  [BRDW],
  [WAK]
)
VALUES (
  @ID_IND,
  @ID_PLG_IND,
  @BRDW,
  @WAK
)


