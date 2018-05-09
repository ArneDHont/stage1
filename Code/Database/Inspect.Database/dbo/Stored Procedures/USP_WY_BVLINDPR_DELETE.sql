
CREATE PROC dbo.[USP_WY_BVLINDPR_DELETE]
  @Original_ID_IND char(50), --Primary Key Field
  @Original_ID_TOEP char(50), --Primary Key Field
  @Original_ID_PRFL char(50) --Primary Key Field

AS
SET NOCOUNT OFF

DELETE FROM [BVLINDPR]
WHERE [ID_IND] = @Original_ID_IND
AND [ID_TOEP] = @Original_ID_TOEP
AND [ID_PRFL] = @Original_ID_PRFL

