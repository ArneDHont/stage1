
CREATE PROC dbo.[USP_WY_BBDGPO_INSERT]
  @ID_DG_PO int,
  @ID_DG_PO_DL int,
  @TMS_REG_DG_PO smalldatetime,
  @Q_PO_1 bigint,
  @Q_PO_2 bigint,
  @Q_PO_4 bigint,
  @Q_PO_ALG bigint

AS
SET NOCOUNT OFF

INSERT INTO [BBDGPO] (
  [ID_DG_PO_DL],
  [TMS_REG_DG_PO],
  [Q_PO_1],
  [Q_PO_2],
  [Q_PO_4],
  [Q_PO_ALG]
)
VALUES (
  @ID_DG_PO_DL,
  @TMS_REG_DG_PO,
  @Q_PO_1,
  @Q_PO_2,
  @Q_PO_4,
  @Q_PO_ALG
)

