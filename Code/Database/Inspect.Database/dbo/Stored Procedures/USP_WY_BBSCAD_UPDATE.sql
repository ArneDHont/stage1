
CREATE PROC dbo.[USP_WY_BBSCAD_UPDATE]
  @ID_REG int,
  @ID_FRM int,
  @ID_MLD int,
  @ID_TSP int,
  @ID_FRM_VZK int,
  @ID_OBJ_SCAD int,
  @ID_BEW_DUP int,
  @NR_BTW varchar(20),
  @NR_POLIS varchar(20),
  @TY_SCAD varchar(2000),
  @RD_SCAD varchar(2000),
  @OPM_SCAD varchar(5000),
  @Original_ID_REG int --Primary Key Field

AS
SET NOCOUNT OFF

UPDATE [BBSCAD] SET
  [ID_FRM] = @ID_FRM,
  [ID_MLD] = @ID_MLD,
  [ID_TSP] = @ID_TSP,
  [ID_FRM_VZK] = @ID_FRM_VZK,
  [ID_OBJ_SCAD] = @ID_OBJ_SCAD,
  [ID_BEW_DUP] = @ID_BEW_DUP,
  [NR_BTW] = @NR_BTW,
  [NR_POLIS] = @NR_POLIS,
  [TY_SCAD] = @TY_SCAD,
  [RD_SCAD] = @RD_SCAD,
  [OPM_SCAD] = @OPM_SCAD
WHERE [ID_REG] = @Original_ID_REG

