﻿
CREATE PROC dbo.[USP_WY_BBFRM_INSERT]
  @ID_FRM float,
  @NM_FRM varchar(50)=NULL,
  @STRA_FRM varchar(50)=NULL,
  @PO_COD_PLA_FRM varchar(10)=NULL,
  @PLA_FRM varchar(50)=NULL

AS
SET NOCOUNT OFF

INSERT INTO [BBFRM] (
  [ID_FRM],
  [NM_FRM],
  [STRA_FRM],
  [PO_COD_PLA_FRM],
  [PLA_FRM]
)
VALUES (
  @ID_FRM,
  @NM_FRM,
  @STRA_FRM,
  @PO_COD_PLA_FRM,
  @PLA_FRM
)

