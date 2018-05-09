
CREATE PROC dbo.[USP_WY_BVLGGD_UPDATE]
  @ID_TOEP char(50),
  @ID_GGD char(50),
  @NM_GGD varchar(50)=NULL,
  @COD_BVG char(1),
  @TMS_CRE_RE datetime=NULL,
  @ID_BRK_CRE_RE char(8)=NULL,
  @TMS_WY_L_RE datetime=NULL,
  @ID_BRK_WY_L_RE char(8)=NULL,
  @NR_WY_L_RE int=NULL,
  @Original_ID_TOEP char(50), --Primary Key Field
  @Original_ID_GGD char(50), --Primary Key Field
  @Original_NR_WY_L_RE int=NULL 

AS
SET NOCOUNT OFF

UPDATE [BVLGGD] SET
  [NM_GGD] = @NM_GGD,
  [COD_BVG] = @COD_BVG,
  [TMS_CRE_RE] = @TMS_CRE_RE,
  [ID_BRK_CRE_RE] = @ID_BRK_CRE_RE,
  [TMS_WY_L_RE] = @TMS_WY_L_RE,
  [ID_BRK_WY_L_RE] = @ID_BRK_WY_L_RE,
  [NR_WY_L_RE] = @NR_WY_L_RE
WHERE [ID_TOEP] = @Original_ID_TOEP
AND [ID_GGD] = @Original_ID_GGD
AND ([NR_WY_L_RE] = @Original_NR_WY_L_RE OR (@Original_NR_WY_L_RE IS NULL AND [NR_WY_L_RE] IS NULL))

