﻿
CREATE PROC dbo.[USP_WY_BBWRFTSP_INSERT]
  @ID_WRF_TSP int,
  @SCF_WRF_TSP varchar(50)=NULL

AS
SET NOCOUNT OFF

INSERT INTO [BBWRFTSP] (
  [ID_WRF_TSP],
  [SCF_WRF_TSP]
)
VALUES (
  @ID_WRF_TSP,
  @SCF_WRF_TSP
)

