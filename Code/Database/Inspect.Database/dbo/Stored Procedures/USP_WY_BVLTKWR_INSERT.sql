
CREATE PROC dbo.[USP_WY_BVLTKWR_INSERT]
  @ID_TOEP char(50),
  @ID_WR char(50),
  @ID_TK char(50),
  @NM_TK varchar(50),
  @NM_WR varchar(50),
  @TMS_CRE_RE datetime=NULL,
  @ID_BRK_CRE_RE char(8)=NULL,
  @TMS_WY_L_RE datetime=NULL,
  @ID_BRK_WY_L_RE char(8)=NULL,
  @NR_WY_L_RE int=NULL

AS
SET NOCOUNT OFF

INSERT INTO [BVLTKWR] (
  [ID_TOEP],
  [ID_WR],
  [ID_TK],
  [NM_TK],
  [NM_WR],
  [TMS_CRE_RE],
  [ID_BRK_CRE_RE],
  [TMS_WY_L_RE],
  [ID_BRK_WY_L_RE],
  [NR_WY_L_RE]
)
VALUES (
  @ID_TOEP,
  @ID_WR,
  @ID_TK,
  @NM_TK,
  @NM_WR,
  @TMS_CRE_RE,
  @ID_BRK_CRE_RE,
  @TMS_WY_L_RE,
  @ID_BRK_WY_L_RE,
  @NR_WY_L_RE
)

