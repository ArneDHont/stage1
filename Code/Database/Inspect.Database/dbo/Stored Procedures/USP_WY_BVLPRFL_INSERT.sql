﻿
CREATE PROC dbo.[USP_WY_BVLPRFL_INSERT]
  @ID_TOEP char(50),
  @ID_PRFL char(50),
  @NM_PRFL varchar(50)=NULL,
  @TMS_CRE_RE datetime=NULL,
  @ID_BRK_CRE_RE char(8)=NULL,
  @TMS_WY_L_RE datetime=NULL,
  @ID_BRK_WY_L_RE char(8)=NULL,
  @NR_WY_L_RE int=NULL

AS
SET NOCOUNT OFF

INSERT INTO [BVLPRFL] (
  [ID_TOEP],
  [ID_PRFL],
  [NM_PRFL],
  [TMS_CRE_RE],
  [ID_BRK_CRE_RE],
  [TMS_WY_L_RE],
  [ID_BRK_WY_L_RE],
  [NR_WY_L_RE]
)
VALUES (
  @ID_TOEP,
  @ID_PRFL,
  @NM_PRFL,
  @TMS_CRE_RE,
  @ID_BRK_CRE_RE,
  @TMS_WY_L_RE,
  @ID_BRK_WY_L_RE,
  @NR_WY_L_RE
)

