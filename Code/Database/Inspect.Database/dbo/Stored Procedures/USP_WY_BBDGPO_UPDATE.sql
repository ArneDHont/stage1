
CREATE PROC dbo.[USP_WY_BBDGPO_UPDATE]
  @ID_DG_PO int,
  @ID_DG_PO_DL int,
  @TMS_REG_DG_PO smalldatetime,
  @Q_PO_1 bigint,
  @Q_PO_2 bigint,
  @Q_PO_4 bigint,
  @Q_PO_ALG bigint,
  @Original_ID_DG_PO int --Primary Key Field

AS
SET NOCOUNT OFF

UPDATE [BBDGPO] SET
  [ID_DG_PO_DL] = @ID_DG_PO_DL,
  [TMS_REG_DG_PO] = @TMS_REG_DG_PO,
  [Q_PO_1] = @Q_PO_1,
  [Q_PO_2] = @Q_PO_2,
  [Q_PO_4] = @Q_PO_4,
  [Q_PO_ALG] = @Q_PO_ALG
WHERE [ID_DG_PO] = @Original_ID_DG_PO

