

CREATE PROC dbo.[USP_WY_BBTSP_INSERT]
  @ID_TSP int,
  @ID_TY_TSP int,
  @ID_EIG_TSP int,
  @ID_FRM_TSP int,
  @INDI_TSP_ARC bit,
  @INDI_TSP_PRIV bit,
  @SCF_MRK_TSP varchar(20),
  @PL_NR_TSP varchar(15),
  @INH_CYL_TSP varchar(10),
  @JR_BOU_TSP varchar(4),
  @NR_CHAS_TSP varchar(20),
  @DT_KEU_L_TSP datetime

AS
SET NOCOUNT OFF

INSERT INTO [BBTSP] (
  [ID_TSP],
  [ID_TY_TSP],
  [ID_EIG_TSP],
  [ID_FRM_TSP],
  [INDI_TSP_ARC],
  [INDI_TSP_PRIV],
  [SCF_MRK_TSP],
  [PL_NR_TSP],
  [INH_CYL_TSP],
  [JR_BOU_TSP],
  [NR_CHAS_TSP],
  [DT_KEU_L_TSP]
)
VALUES (
  @ID_TSP,
  @ID_TY_TSP,
  @ID_EIG_TSP,
  @ID_FRM_TSP,
  @INDI_TSP_ARC,
  @INDI_TSP_PRIV,
  @SCF_MRK_TSP,
  @PL_NR_TSP,
  @INH_CYL_TSP,
  @JR_BOU_TSP,
  @NR_CHAS_TSP,
  @DT_KEU_L_TSP
)


