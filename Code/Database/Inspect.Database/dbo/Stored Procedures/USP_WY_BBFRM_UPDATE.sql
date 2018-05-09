
CREATE PROC dbo.[USP_WY_BBFRM_UPDATE]
  @ID_FRM float,
  @NM_FRM varchar(50)=NULL,
  @STRA_FRM varchar(50)=NULL,
  @PO_COD_PLA_FRM varchar(10)=NULL,
  @PLA_FRM varchar(50)=NULL,
  @Original_ID_FRM float --Primary Key Field

AS
SET NOCOUNT OFF

UPDATE [BBFRM] SET
  [NM_FRM] = @NM_FRM,
  [STRA_FRM] = @STRA_FRM,
  [PO_COD_PLA_FRM] = @PO_COD_PLA_FRM,
  [PLA_FRM] = @PLA_FRM
WHERE [ID_FRM] = @Original_ID_FRM

