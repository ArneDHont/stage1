
CREATE PROC dbo.[USP_WY_BVLTKWR_UPDATE]
  @ID_TOEP char(50),
  @ID_WR char(50),
  @ID_TK char(50),
  @NM_TK varchar(50),
  @NM_WR varchar(50),
  @TMS_CRE_RE datetime=NULL,
  @ID_BRK_CRE_RE char(8)=NULL,
  @TMS_WY_L_RE datetime=NULL,
  @ID_BRK_WY_L_RE char(8)=NULL,
  @NR_WY_L_RE int=NULL,
  @Original_ID_TOEP char(50), --Primary Key Field
  @Original_ID_WR char(50), --Primary Key Field
  @Original_ID_TK char(50), --Primary Key Field
  @Original_NR_WY_L_RE int=NULL 

AS
SET NOCOUNT OFF

UPDATE [BVLTKWR] SET
  [NM_TK] = @NM_TK,
  [NM_WR] = @NM_WR,
  [TMS_CRE_RE] = @TMS_CRE_RE,
  [ID_BRK_CRE_RE] = @ID_BRK_CRE_RE,
  [TMS_WY_L_RE] = @TMS_WY_L_RE,
  [ID_BRK_WY_L_RE] = @ID_BRK_WY_L_RE,
  [NR_WY_L_RE] = @NR_WY_L_RE
WHERE [ID_TOEP] = @Original_ID_TOEP
AND [ID_WR] = @Original_ID_WR
AND [ID_TK] = @Original_ID_TK
AND ([NR_WY_L_RE] = @Original_NR_WY_L_RE OR (@Original_NR_WY_L_RE IS NULL AND [NR_WY_L_RE] IS NULL))

