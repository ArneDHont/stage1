﻿
CREATE PROC dbo.[USP_WY_BVLPLA_UPDATE]
  @ID_PLA char(50),
  @NM_PLA varchar(50)=NULL,
  @TMS_CRE_RE datetime=NULL,
  @ID_BRK_CRE_RE char(8)=NULL,
  @TMS_WY_L_RE datetime=NULL,
  @ID_BRK_WY_L_RE char(8)=NULL,
  @NR_WY_L_RE int=NULL,
  @Original_ID_PLA char(50), --Primary Key Field
  @Original_NR_WY_L_RE int=NULL 

AS
SET NOCOUNT OFF

UPDATE [BVLPLA] SET
  [NM_PLA] = @NM_PLA,
  [TMS_CRE_RE] = @TMS_CRE_RE,
  [ID_BRK_CRE_RE] = @ID_BRK_CRE_RE,
  [TMS_WY_L_RE] = @TMS_WY_L_RE,
  [ID_BRK_WY_L_RE] = @ID_BRK_WY_L_RE,
  [NR_WY_L_RE] = @NR_WY_L_RE
WHERE [ID_PLA] = @Original_ID_PLA
AND ([NR_WY_L_RE] = @Original_NR_WY_L_RE OR (@Original_NR_WY_L_RE IS NULL AND [NR_WY_L_RE] IS NULL))

