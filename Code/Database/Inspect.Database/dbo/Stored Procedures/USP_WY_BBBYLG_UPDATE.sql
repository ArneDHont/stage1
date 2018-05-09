

CREATE PROC dbo.[USP_WY_BBBYLG_UPDATE]
  @ID_BYLG int,
  @ID_INTV_BRDW int=NULL,
  @ID_REG int=NULL,
  @PLA_BYLG varchar(100)=NULL,
  @SCF_BYLG varchar(200)=NULL,
  @ID_DOC varchar(50)=NULL,
  @Original_ID_BYLG int --Primary Key Field

AS
SET NOCOUNT OFF

UPDATE [BBBYLG] SET
  [ID_INTV_BRDW] = @ID_INTV_BRDW,
  [ID_REG] = @ID_REG,
  [PLA_BYLG] = @PLA_BYLG,
  [SCF_BYLG] = @SCF_BYLG,
  [ID_DOC] = @ID_DOC
WHERE [ID_BYLG] = @Original_ID_BYLG

