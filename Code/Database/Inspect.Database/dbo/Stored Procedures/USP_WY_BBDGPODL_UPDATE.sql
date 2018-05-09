

CREATE PROC dbo.[USP_WY_BBDGPODL_UPDATE]
  @ID_DG_PO_DL int,
  @SCF_DG_PO_DL varchar(50),
  @INV_PO bit,
  @VLG int,
  @Original_ID_DG_PO_DL int --Primary Key Field

AS
SET NOCOUNT OFF

UPDATE [BBDGPODL] SET
  [SCF_DG_PO_DL] = @SCF_DG_PO_DL,
  [INV_PO] = @INV_PO,
  [VLG] = @VLG
WHERE [ID_DG_PO_DL] = @Original_ID_DG_PO_DL


