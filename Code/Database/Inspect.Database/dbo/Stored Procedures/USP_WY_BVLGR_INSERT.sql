
CREATE PROC dbo.[USP_WY_BVLGR_INSERT]
  @ID_GR char(50),
  @NM_GR varchar(50)=NULL,
  @TMS_CRE_RE datetime=NULL,
  @ID_BRK_CRE_RE char(8)=NULL,
  @TMS_WY_L_RE datetime=NULL,
  @ID_BRK_WY_L_RE char(8)=NULL,
  @NR_WY_L_RE int=NULL

AS
SET NOCOUNT OFF

INSERT INTO [BVLGR] (
  [ID_GR],
  [NM_GR],
  [TMS_CRE_RE],
  [ID_BRK_CRE_RE],
  [TMS_WY_L_RE],
  [ID_BRK_WY_L_RE],
  [NR_WY_L_RE]
)
VALUES (
  @ID_GR,
  @NM_GR,
  @TMS_CRE_RE,
  @ID_BRK_CRE_RE,
  @TMS_WY_L_RE,
  @ID_BRK_WY_L_RE,
  @NR_WY_L_RE
)

