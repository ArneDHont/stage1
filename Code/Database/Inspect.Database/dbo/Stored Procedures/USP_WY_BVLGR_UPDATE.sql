
CREATE PROC dbo.[USP_WY_BVLGR_UPDATE]
  @ID_GR char(50),
  @NM_GR varchar(50)=NULL,
  @TMS_CRE_RE datetime=NULL,
  @ID_BRK_CRE_RE char(8)=NULL,
  @TMS_WY_L_RE datetime=NULL,
  @ID_BRK_WY_L_RE char(8)=NULL,
  @NR_WY_L_RE int=NULL,
  @Original_ID_GR char(50), --Primary Key Field
  @Original_NR_WY_L_RE int=NULL 

AS
SET NOCOUNT OFF

UPDATE [BVLGR] SET
  [NM_GR] = @NM_GR,
  [TMS_CRE_RE] = @TMS_CRE_RE,
  [ID_BRK_CRE_RE] = @ID_BRK_CRE_RE,
  [TMS_WY_L_RE] = @TMS_WY_L_RE,
  [ID_BRK_WY_L_RE] = @ID_BRK_WY_L_RE,
  [NR_WY_L_RE] = @NR_WY_L_RE
WHERE [ID_GR] = @Original_ID_GR
AND ([NR_WY_L_RE] = @Original_NR_WY_L_RE OR (@Original_NR_WY_L_RE IS NULL AND [NR_WY_L_RE] IS NULL))

