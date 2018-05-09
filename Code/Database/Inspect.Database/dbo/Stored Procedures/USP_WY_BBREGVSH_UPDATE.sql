

CREATE PROC dbo.[USP_WY_BBREGVSH_UPDATE]
  @ID_REG int,
  @ID_FRM int,
  @ID_FRM_VZK int,
  @SCF_FRM_BTRK_ALT varchar(300),
  @NR_BTW varchar(20),
  @SCF_KRT_REG_VSH varchar(1000),
  @SCF_LNG_REG_VSH varchar(8000),
  @NR_POLIS varchar(30),
  @ID_AFD int,
  @Original_ID_REG int --Primary Key Field

AS
SET NOCOUNT OFF

UPDATE [BBREGVSH] SET
  [ID_FRM] = @ID_FRM,
  [ID_FRM_VZK] = @ID_FRM_VZK,
  [SCF_FRM_BTRK_ALT] = @SCF_FRM_BTRK_ALT,
  [NR_BTW] = @NR_BTW,
  [SCF_KRT_REG_VSH] = @SCF_KRT_REG_VSH,
  [SCF_LNG_REG_VSH] = @SCF_LNG_REG_VSH,
  [NR_POLIS] = @NR_POLIS,
  [ID_AFD] = @ID_AFD
WHERE [ID_REG] = @Original_ID_REG

