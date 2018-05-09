CREATE PROC [dbo].[USP_WY_BBDIEFST_UPDATE]
  @ID_REG int,
  @ID_MLD int,
  @ID_FRM int,
  @ID_DUP_IND int,
  @ID_DUP int,
  @SCF_MAT_STLN varchar(500),
  @STA_MAT varchar(500),
  @WD_MAT float,
  @NR_BTW varchar(20),
  @SCF_LNG_DIEF varchar(3000),
  @ID_AFD int,
  @PolitieGevraagdDoorAfdYN bit,
  @PolitieLangsgeweestYN bit,
  @PolitiePVnummer varchar(100),
  @Original_ID_REG int --Primary Key Field

AS
SET NOCOUNT OFF

UPDATE [BBDIEFST] SET
  [ID_MLD] = @ID_MLD,
  [ID_FRM] = @ID_FRM,
  [ID_DUP_IND] = @ID_DUP_IND,
  [ID_DUP] = @ID_DUP,
  [SCF_MAT_STLN] = @SCF_MAT_STLN,
  [STA_MAT] = @STA_MAT,
  [WD_MAT] = @WD_MAT,
  [NR_BTW] = @NR_BTW,
  [SCF_LNG_DIEF] = @SCF_LNG_DIEF,
  [ID_AFD] = @ID_AFD,
  [PolitieGevraagdDoorAfdYN] = @PolitieGevraagdDoorAfdYN,
  [PolitieLangsgeweestYN] = @PolitieLangsgeweestYN,
  [PolitiePVnummer] = @PolitiePVnummer
WHERE [ID_REG] = @Original_ID_REG