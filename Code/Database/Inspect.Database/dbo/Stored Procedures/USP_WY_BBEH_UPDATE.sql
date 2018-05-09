
CREATE PROC dbo.[USP_WY_BBEH_UPDATE]
  @ID_EH varchar(10),
  @SCF_EH varchar(30)=NULL,
  @Original_ID_EH varchar(10) --Primary Key Field

AS
SET NOCOUNT OFF

UPDATE [BBEH] SET
  [SCF_EH] = @SCF_EH
WHERE [ID_EH] = @Original_ID_EH

