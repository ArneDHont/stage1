
CREATE PROC dbo.[USP_WY_BBBST_UPDATE]
  @ID_BST int,
  @ID_INTV_BRDW int=NULL,
  @ID_REG int=NULL,
  @ID_IND int=NULL,
  @Original_ID_BST int --Primary Key Field

AS
SET NOCOUNT OFF

UPDATE [BBBST] SET
  [ID_INTV_BRDW] = @ID_INTV_BRDW,
  [ID_REG] = @ID_REG,
  [ID_IND] = @ID_IND
WHERE [ID_BST] = @Original_ID_BST

