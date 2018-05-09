CREATE PROC [dbo].[USP_WY_BBAFDAMC_UPDATE]
  @ID_AFD int,
  @ID_IND int,
  @Original_ID_AFD int, --Primary Key Field
  @Original_ID_IND int

AS
SET NOCOUNT OFF

UPDATE BBAFDAMC SET
  [ID_IND] = @ID_IND
WHERE [ID_AFD] = @Original_ID_AFD