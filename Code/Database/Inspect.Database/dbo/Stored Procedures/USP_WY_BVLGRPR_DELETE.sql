
CREATE PROC dbo.[USP_WY_BVLGRPR_DELETE]
  @Original_ID_GR char(50), --Primary Key Field
  @Original_ID_TOEP char(50), --Primary Key Field
  @Original_ID_PRFL char(50) --Primary Key Field

AS
SET NOCOUNT OFF

DELETE FROM [BVLGRPR]
WHERE [ID_GR] = @Original_ID_GR
AND [ID_TOEP] = @Original_ID_TOEP
AND [ID_PRFL] = @Original_ID_PRFL

