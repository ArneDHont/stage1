﻿
CREATE PROC dbo.[USP_WY_BBARTGR_UPDATE]
  @ID_GR_ART int,
  @SCF_GR_ART varchar(30)=NULL,
  @Original_ID_GR_ART int --Primary Key Field

AS
SET NOCOUNT OFF

UPDATE [BBARTGR] SET
  [SCF_GR_ART] = @SCF_GR_ART
WHERE [ID_GR_ART] = @Original_ID_GR_ART

