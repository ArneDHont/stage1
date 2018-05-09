
CREATE PROC dbo.[USP_WY_BBSCAD_INSERT]
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
  @OPM_SCAD varchar(5000)

AS
SET NOCOUNT OFF

INSERT INTO [BBSCAD] (
  [ID_REG],
  [ID_FRM],
  [ID_MLD],
  [ID_TSP],
  [ID_FRM_VZK],
  [ID_OBJ_SCAD],
  [ID_BEW_DUP],
  [NR_BTW],
  [NR_POLIS],
  [TY_SCAD],
  [RD_SCAD],
  [OPM_SCAD]
)
VALUES (
  @ID_REG,
  @ID_FRM,
  @ID_MLD,
  @ID_TSP,
  @ID_FRM_VZK,
  @ID_OBJ_SCAD,
  @ID_BEW_DUP,
  @NR_BTW,
  @NR_POLIS,
  @TY_SCAD,
  @RD_SCAD,
  @OPM_SCAD
)

