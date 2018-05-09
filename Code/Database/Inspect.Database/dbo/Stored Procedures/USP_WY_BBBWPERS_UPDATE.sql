

CREATE PROC dbo.[USP_WY_BBBWPERS_UPDATE]
  @ID_IND int,
  @ID_PLG_IND int,
  @BRDW bit,
  @WAK bit,
  @Original_ID_IND int --Primary Key Field

AS
SET NOCOUNT OFF

UPDATE [BBBWPERS] SET
  [ID_PLG_IND] = @ID_PLG_IND,
  [BRDW] = @BRDW,
  [WAK] = @WAK
WHERE [ID_IND] = @Original_ID_IND


