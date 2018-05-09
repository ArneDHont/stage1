﻿
CREATE PROC dbo.[USP_WY_BBSCADAN_UPDATE]
  @ID_OBJ_SCAD int,
  @SCF_OBJ_SCAD varchar(50)=NULL,
  @Original_ID_OBJ_SCAD int --Primary Key Field

AS
SET NOCOUNT OFF

UPDATE [BBSCADAN] SET
  [SCF_OBJ_SCAD] = @SCF_OBJ_SCAD
WHERE [ID_OBJ_SCAD] = @Original_ID_OBJ_SCAD
