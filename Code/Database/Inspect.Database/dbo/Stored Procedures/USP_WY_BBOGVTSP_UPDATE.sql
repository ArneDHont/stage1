

CREATE PROC dbo.[USP_WY_BBOGVTSP_UPDATE]
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
  @GBEU varchar(500),
  @Original_ID_REG int --Primary Key Field

AS
SET NOCOUNT OFF

UPDATE [BBOGVTSP] SET
  [ID_MLD] = @ID_MLD,
  [SCF_LNG_OGV] = @SCF_LNG_OGV,
  [ID_OGV_VAST] = @ID_OGV_VAST,
  [INF_EX] = @INF_EX,
  [PLA_OGV] = @PLA_OGV,
  [SCF_STA] = @SCF_STA,
  [ZBH] = @ZBH,
  [WND_RIC] = @WND_RIC,
  [WND_KR] = @WND_KR,
  [GBEU] = @GBEU
WHERE [ID_REG] = @Original_ID_REG


