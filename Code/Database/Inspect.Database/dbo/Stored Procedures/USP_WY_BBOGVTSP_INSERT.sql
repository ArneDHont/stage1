

CREATE PROC dbo.[USP_WY_BBOGVTSP_INSERT]
  @ID_REG int,
  @ID_MLD int,
  @SCF_LNG_OGV varchar(8000),
  @ID_OGV_VAST int,
  @INF_EX varchar(200),
  @PLA_OGV varchar(100),
  @SCF_STA varchar(100),
  @ZBH varchar(500),
  @WND_RIC varchar(500),
  @WND_KR varchar(500),
  @GBEU varchar(500)

AS
SET NOCOUNT OFF

INSERT INTO [BBOGVTSP] (
  [ID_REG],
  [ID_MLD],
  [SCF_LNG_OGV],
  [ID_OGV_VAST],
  [INF_EX],
  [PLA_OGV],
  [SCF_STA],
  [ZBH],
  [WND_RIC],
  [WND_KR],
  [GBEU]
)
VALUES (
  @ID_REG,
  @ID_MLD,
  @SCF_LNG_OGV,
  @ID_OGV_VAST,
  @INF_EX,
  @PLA_OGV,
  @SCF_STA,
  @ZBH,
  @WND_RIC,
  @WND_KR,
  @GBEU
)


