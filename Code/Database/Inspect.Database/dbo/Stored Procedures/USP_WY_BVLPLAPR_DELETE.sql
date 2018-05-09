
CREATE PROC dbo.[USP_WY_BVLPLAPR_DELETE]
  @Original_ID_PLA char(50), --Primary Key Field
  @Original_ID_PRFL char(50), --Primary Key Field
  @Original_ID_TOEP char(50) --Primary Key Field

AS
SET NOCOUNT OFF

DELETE FROM [BVLPLAPR]
WHERE [ID_PLA] = @Original_ID_PLA
AND [ID_PRFL] = @Original_ID_PRFL
AND [ID_TOEP] = @Original_ID_TOEP

