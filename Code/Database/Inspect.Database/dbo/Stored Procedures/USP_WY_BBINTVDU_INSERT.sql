﻿
CREATE PROC dbo.[USP_WY_BBINTVDU_INSERT]
  @ID_DU_INTV int,
  @ID_INTV_BRDW int=NULL,
  @ID_ART_INTV int=NULL,
  @TYD_OPR datetime=NULL,
  @TYD_KO datetime=NULL,
  @TYD_END datetime=NULL

AS
SET NOCOUNT OFF

INSERT INTO [BBINTVDU] (
  [ID_INTV_BRDW],
  [ID_ART_INTV],
  [TYD_OPR],
  [TYD_KO],
  [TYD_END]
)
VALUES (
  @ID_INTV_BRDW,
  @ID_ART_INTV,
  @TYD_OPR,
  @TYD_KO,
  @TYD_END
)

