
CREATE PROC dbo.[USP_WY_BVLPTKWR_DELETE]
  @Original_ID_TOEP_PRFL char(50), --Primary Key Field
  @Original_ID_PRFL char(50), --Primary Key Field
  @Original_ID_TOEP_TK_WR char(50), --Primary Key Field
  @Original_ID_WR char(50), --Primary Key Field
  @Original_ID_TK char(50) --Primary Key Field

AS
SET NOCOUNT OFF

DELETE FROM [BVLPTKWR]
WHERE [ID_TOEP_PRFL] = @Original_ID_TOEP_PRFL
AND [ID_PRFL] = @Original_ID_PRFL
AND [ID_TOEP_TK_WR] = @Original_ID_TOEP_TK_WR
AND [ID_WR] = @Original_ID_WR
AND [ID_TK] = @Original_ID_TK

