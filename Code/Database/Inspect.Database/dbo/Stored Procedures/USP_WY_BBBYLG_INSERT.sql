﻿

CREATE PROC dbo.[USP_WY_BBBYLG_INSERT]
  @ID_BYLG int,
  @ID_INTV_BRDW int=NULL,
  @ID_REG int=NULL,
  @PLA_BYLG varchar(100)=NULL,
  @SCF_BYLG varchar(200)=NULL,
  @ID_DOC varchar(50)=NULL

AS
SET NOCOUNT OFF

INSERT INTO [BBBYLG] (
  [ID_INTV_BRDW],
  [ID_REG],
  [PLA_BYLG],
  [SCF_BYLG],
  [ID_DOC]
)
VALUES (
  @ID_INTV_BRDW,
  @ID_REG,
  @PLA_BYLG,
  @SCF_BYLG,
  @ID_DOC
)

