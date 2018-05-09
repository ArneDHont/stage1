
CREATE PROC dbo.[USP_WY_BBALCTST_UPDATE]
  @ID_REG int,
  @ID_MLD int,
  @ID_BTRK int,
  @ID_FRM int,
  @SCF_LNG_TST_ALC varchar(8000),
  @TYD_TST_ALC_1 varchar(10),
  @INDI_TST_1_POS bit,
  @PLA_TST_ALC_1 varchar(100),
  @TYD_TST_ALC_2 varchar(10),
  @INDI_TST_2_POS bit,
  @PLA_TST_ALC_2 varchar(100),
  @SCF_RGL_NEM varchar(2000),
  @INF_EX_TST_ALC varchar(2000),
  @Original_ID_REG int --Primary Key Field

AS
SET NOCOUNT OFF

UPDATE [BBALCTST] SET
  [ID_MLD] = @ID_MLD,
  [ID_BTRK] = @ID_BTRK,
  [ID_FRM] = @ID_FRM,
  [SCF_LNG_TST_ALC] = @SCF_LNG_TST_ALC,
  [TYD_TST_ALC_1] = @TYD_TST_ALC_1,
  [INDI_TST_1_POS] = @INDI_TST_1_POS,
  [PLA_TST_ALC_1] = @PLA_TST_ALC_1,
  [TYD_TST_ALC_2] = @TYD_TST_ALC_2,
  [INDI_TST_2_POS] = @INDI_TST_2_POS,
  [PLA_TST_ALC_2] = @PLA_TST_ALC_2,
  [SCF_RGL_NEM] = @SCF_RGL_NEM,
  [INF_EX_TST_ALC] = @INF_EX_TST_ALC
WHERE [ID_REG] = @Original_ID_REG

