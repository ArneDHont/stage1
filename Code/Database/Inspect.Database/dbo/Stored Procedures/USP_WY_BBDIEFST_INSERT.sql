CREATE PROC [dbo].[USP_WY_BBDIEFST_INSERT]
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
  @PolitiePVnummer varchar(100)

AS
SET NOCOUNT OFF

INSERT INTO [BBDIEFST] (
  [ID_REG],
  [ID_MLD],
  [ID_FRM],
  [ID_DUP_IND],
  [ID_DUP],
  [SCF_MAT_STLN],
  [STA_MAT],
  [WD_MAT],
  [NR_BTW],
  [SCF_LNG_DIEF],
  [ID_AFD],
  [PolitieGevraagdDoorAfdYN],
  [PolitieLangsgeweestYN],
  [PolitiePVnummer]
)
VALUES (
  @ID_REG,
  @ID_MLD,
  @ID_FRM,
  @ID_DUP_IND,
  @ID_DUP,
  @SCF_MAT_STLN,
  @STA_MAT,
  @WD_MAT,
  @NR_BTW,
  @SCF_LNG_DIEF,
  @ID_AFD,
  @PolitieGevraagdDoorAfdYN,
  @PolitieLangsgeweestYN,
  @PolitiePVnummer 
)