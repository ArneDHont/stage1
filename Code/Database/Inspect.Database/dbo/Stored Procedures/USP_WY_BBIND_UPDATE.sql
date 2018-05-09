CREATE PROC [dbo].[USP_WY_BBIND_UPDATE]
  @ID_IND int,
  @ID_TY_IND int=NULL,
  @ID_FRM_IND_TK int=NULL,
  @NM_IND varchar(50)=NULL,
  @VNM_IND varchar(50)=NULL,
  @AD_IND varchar(150)=NULL,
  @PO_COD_WNPL_IND varchar(10)=NULL,
  @WNPL_IND varchar(60)=NULL,
  @PLA_GBR_IND varchar(60)=NULL,
  @DT_GBR_IND datetime=NULL,
  @AD_EMAL_IND varchar(100)=NULL,
  @ID_GSL_IND int=NULL,
  @BST_IND bit=NULL,
  @SAP_DIR varchar(5)=NULL,
  @SAP_AFD varchar(5)=NULL,
  @SAP_SECT varchar(5)=NULL,
  @DT_UIT_DNS datetime=NULL,
  @BST_ACTIVE bit,
  @Original_ID_IND int --Primary Key Field

AS
SET NOCOUNT OFF

UPDATE [BBIND] SET
  [ID_TY_IND] = @ID_TY_IND,
  [ID_FRM_IND_TK] = @ID_FRM_IND_TK,
  [NM_IND] = @NM_IND,
  [VNM_IND] = @VNM_IND,
  [AD_IND] = @AD_IND,
  [PO_COD_WNPL_IND] = @PO_COD_WNPL_IND,
  [WNPL_IND] = @WNPL_IND,
  [PLA_GBR_IND] = @PLA_GBR_IND,
  [DT_GBR_IND] = @DT_GBR_IND,
  [AD_EMAL_IND] = @AD_EMAL_IND,
  [ID_GSL_IND] = @ID_GSL_IND,
  [BST_IND] = @BST_IND,
  [SAP_DIR] = @SAP_DIR,
  [SAP_AFD] = @SAP_AFD,
  [SAP_SECT] = @SAP_SECT,
  [DT_UIT_DNS] = @DT_UIT_DNS,
  [BST_ACTIVE] = @BST_ACTIVE
WHERE [ID_IND] = @Original_ID_IND
