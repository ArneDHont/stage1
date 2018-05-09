

CREATE PROC dbo.[USP_WY_BBBTROGV_INSERT]
  @ID_BTRK_OGV int,
  @ID_REG int,
  @ID_IND_BTRK int,
  @ID_TY_BTRK int,
  @ID_BRK_TSP int,
  @ID_FRM_VZK int,
  @NR_POLIS varchar(20),
  @ROMP_LTSL varchar(500),
  @MAT_LTSL varchar(500),
  @KAR_TSP bit,
  @Q_IND_TSP_BRTK varchar(2),
  @INDI_TRL_VKM_TSP bit,
  @SCF_Q_KG_VKM_TSP varchar(10),
  @RB_NR varchar(100),
  @RB_CAT varchar(50),
  @RB_DAT_UITG datetime,
  @RB_PL_UITG varchar(100),
  @BTW_NR varchar(20),
  @HD_NM_VN varchar(100),
  @ID_TSP int

AS
SET NOCOUNT OFF

INSERT INTO [BBBTROGV] (
  [ID_REG],
  [ID_IND_BTRK],
  [ID_TY_BTRK],
  [ID_BRK_TSP],
  [ID_FRM_VZK],
  [NR_POLIS],
  [ROMP_LTSL],
  [MAT_LTSL],
  [KAR_TSP],
  [Q_IND_TSP_BRTK],
  [INDI_TRL_VKM_TSP],
  [SCF_Q_KG_VKM_TSP],
  [RB_NR],
  [RB_CAT],
  [RB_DAT_UITG],
  [RB_PL_UITG],
  [BTW_NR],
  [HD_NM_VN],
  [ID_TSP]
)
VALUES (
  @ID_REG,
  @ID_IND_BTRK,
  @ID_TY_BTRK,
  @ID_BRK_TSP,
  @ID_FRM_VZK,
  @NR_POLIS,
  @ROMP_LTSL,
  @MAT_LTSL,
  @KAR_TSP,
  @Q_IND_TSP_BRTK,
  @INDI_TRL_VKM_TSP,
  @SCF_Q_KG_VKM_TSP,
  @RB_NR,
  @RB_CAT,
  @RB_DAT_UITG,
  @RB_PL_UITG,
  @BTW_NR,
  @HD_NM_VN,
  @ID_TSP
)


