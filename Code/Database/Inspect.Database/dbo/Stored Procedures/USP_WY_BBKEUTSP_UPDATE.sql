﻿
CREATE PROC dbo.[USP_WY_BBKEUTSP_UPDATE]
  @ID_REG int,
  @ID_STUR_TSP_KEU int,
  @ID_FRM int=NULL,
  @ID_TSP_KEU int=NULL,
  @ID_DNS_VTW_WR_KEU int=NULL,
  @ID_BEW_DUP int=NULL,
  @ID_WRF_TSP int=NULL,
  @SCF_ORG_KEU_TSP varchar(100)=NULL,
  @DT_L_KEU_TSP datetime=NULL,
  @OPM_VKLR_TSP varchar(2000)=NULL,
  @FA_BST_TSP varchar(300)=NULL,
  @SCF_DFC_REG_TSP varchar(500)=NULL,
  @RGL_NEM_KEU varchar(2000)=NULL,
  @Original_ID_REG int --Primary Key Field

AS
SET NOCOUNT OFF

UPDATE [BBKEUTSP] SET
  [ID_STUR_TSP_KEU] = @ID_STUR_TSP_KEU,
  [ID_FRM] = @ID_FRM,
  [ID_TSP_KEU] = @ID_TSP_KEU,
  [ID_DNS_VTW_WR_KEU] = @ID_DNS_VTW_WR_KEU,
  [ID_BEW_DUP] = @ID_BEW_DUP,
  [ID_WRF_TSP] = @ID_WRF_TSP,
  [SCF_ORG_KEU_TSP] = @SCF_ORG_KEU_TSP,
  [DT_L_KEU_TSP] = @DT_L_KEU_TSP,
  [OPM_VKLR_TSP] = @OPM_VKLR_TSP,
  [FA_BST_TSP] = @FA_BST_TSP,
  [SCF_DFC_REG_TSP] = @SCF_DFC_REG_TSP,
  [RGL_NEM_KEU] = @RGL_NEM_KEU
WHERE [ID_REG] = @Original_ID_REG
