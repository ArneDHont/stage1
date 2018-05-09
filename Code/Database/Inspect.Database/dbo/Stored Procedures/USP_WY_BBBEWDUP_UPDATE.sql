﻿
CREATE PROC dbo.[USP_WY_BBBEWDUP_UPDATE]
  @ID_BEW_DUP int,
  @SCF_BEW_DUP varchar(50),
  @Original_ID_BEW_DUP int --Primary Key Field

AS
SET NOCOUNT OFF

UPDATE [BBBEWDUP] SET
  [SCF_BEW_DUP] = @SCF_BEW_DUP
WHERE [ID_BEW_DUP] = @Original_ID_BEW_DUP
