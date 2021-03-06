﻿
CREATE PROC dbo.[USP_WY_BBINTART_INSERT]
  @ID_ART_INTV int,
  @ID_EH varchar(10)=NULL,
  @ID_GR_ART int=NULL,
  @SCF_ART_INTV varchar(50)=NULL,
  @PR_EH_ART_INTV float=NULL,
  @TSP_DU_INTV bit=NULL

AS
SET NOCOUNT OFF

INSERT INTO [BBINTART] (
  [ID_ART_INTV],
  [ID_EH],
  [ID_GR_ART],
  [SCF_ART_INTV],
  [PR_EH_ART_INTV],
  [TSP_DU_INTV]
)
VALUES (
  @ID_ART_INTV,
  @ID_EH,
  @ID_GR_ART,
  @SCF_ART_INTV,
  @PR_EH_ART_INTV,
  @TSP_DU_INTV
)

