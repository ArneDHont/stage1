
CREATE PROC dbo.[USP_WY_BBINBRRG_UPDATE]
  @ID_REG int,
  @ID_BEW_DUP int,
  @ID_INBR int,
  @ID_FRM int,
  @ID_TSP int,
  @VKLR_INBR varchar(3000),
  @OPM_EX_INBR_VSF varchar(3000),
  @ID_INBR_IND_TY int,
  @Original_ID_REG int --Primary Key Field

AS
SET NOCOUNT OFF

UPDATE [BBINBRRG] SET
  [ID_BEW_DUP] = @ID_BEW_DUP,
  [ID_INBR] = @ID_INBR,
  [ID_FRM] = @ID_FRM,
  [ID_TSP] = @ID_TSP,
  [VKLR_INBR] = @VKLR_INBR,
  [OPM_EX_INBR_VSF] = @OPM_EX_INBR_VSF,
  [ID_INBR_IND_TY] = @ID_INBR_IND_TY
WHERE [ID_REG] = @Original_ID_REG

