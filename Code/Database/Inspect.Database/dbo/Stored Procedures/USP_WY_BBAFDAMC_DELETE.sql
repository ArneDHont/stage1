CREATE PROC [dbo].[USP_WY_BBAFDAMC_DELETE]
  @Original_ID_AFD int, --Primary Key Field
  @Original_ID_IND int --Primary Key Field

AS
SET NOCOUNT OFF

DELETE FROM [BBAFDAMC]
WHERE [ID_AFD] = @Original_ID_AFD
AND [ID_IND] = @Original_ID_IND