

CREATE PROC dbo.[USP_WY_BBOGVSTA_DELETE]
  @Original_ID_REG int, --Primary Key Field
  @Original_ID_STA int --Primary Key Field

AS
SET NOCOUNT OFF

DELETE FROM [BBOGVSTA]
WHERE [ID_REG] = @Original_ID_REG
AND [ID_STA] = @Original_ID_STA


