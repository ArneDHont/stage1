
CREATE PROC dbo.[USP_WY_BVLPGGD_DELETE]
  @Original_ID_TOEP_PRFL char(50), --Primary Key Field
  @Original_ID_PRFL char(50), --Primary Key Field
  @Original_ID_TOEP_GGD char(50), --Primary Key Field
  @Original_ID_GGD char(50) --Primary Key Field

AS
SET NOCOUNT OFF

DELETE FROM [BVLPGGD]
WHERE [ID_TOEP_PRFL] = @Original_ID_TOEP_PRFL
AND [ID_PRFL] = @Original_ID_PRFL
AND [ID_TOEP_GGD] = @Original_ID_TOEP_GGD
AND [ID_GGD] = @Original_ID_GGD

