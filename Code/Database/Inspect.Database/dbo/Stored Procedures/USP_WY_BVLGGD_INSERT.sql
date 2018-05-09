
CREATE PROC dbo.[USP_WY_BVLGGD_INSERT]
  @ID_TOEP char(50),
  @ID_GGD char(50),
  @NM_GGD varchar(50)=NULL,
  @COD_BVG char(1),
  @TMS_CRE_RE datetime=NULL,
  @ID_BRK_CRE_RE char(8)=NULL,
  @TMS_WY_L_RE datetime=NULL,
  @ID_BRK_WY_L_RE char(8)=NULL,
  @NR_WY_L_RE int=NULL

AS
SET NOCOUNT OFF

INSERT INTO [BVLGGD] (
  [ID_TOEP],
  [ID_GGD],
  [NM_GGD],
  [COD_BVG],
  [TMS_CRE_RE],
  [ID_BRK_CRE_RE],
  [TMS_WY_L_RE],
  [ID_BRK_WY_L_RE],
  [NR_WY_L_RE]
)
VALUES (
  @ID_TOEP,
  @ID_GGD,
  @NM_GGD,
  @COD_BVG,
  @TMS_CRE_RE,
  @ID_BRK_CRE_RE,
  @TMS_WY_L_RE,
  @ID_BRK_WY_L_RE,
  @NR_WY_L_RE
)

