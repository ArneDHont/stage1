
CREATE PROC dbo.[USP_WY_BBAFD_UPDATE]
  @ID_AFD int,
  @SCF_AFD varchar(200)=NULL,
  @KRT_AFD varchar(3)=NULL,
  @Original_ID_AFD int --Primary Key Field

AS
SET NOCOUNT OFF

UPDATE [BBAFD] SET
  [SCF_AFD] = @SCF_AFD,
  [KRT_AFD] = @KRT_AFD
WHERE [ID_AFD] = @Original_ID_AFD

