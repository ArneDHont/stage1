
CREATE PROC dbo.[USP_WY_BBEH_DELETE]
  @Original_ID_EH varchar(10) --Primary Key Field

AS
SET NOCOUNT OFF

DELETE FROM [BBEH]
WHERE [ID_EH] = @Original_ID_EH

