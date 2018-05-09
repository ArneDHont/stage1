
CREATE PROC dbo.[USP_WY_BVLTKWR_DELETE]
  @Original_ID_TOEP char(50), --Primary Key Field
  @Original_ID_WR char(50), --Primary Key Field
  @Original_ID_TK char(50), --Primary Key Field
  @Original_NR_WY_L_RE int=NULL 

AS
SET NOCOUNT OFF

DELETE FROM [BVLTKWR]
WHERE [ID_TOEP] = @Original_ID_TOEP
AND [ID_WR] = @Original_ID_WR
AND [ID_TK] = @Original_ID_TK
AND ([NR_WY_L_RE] = @Original_NR_WY_L_RE OR (@Original_NR_WY_L_RE IS NULL AND [NR_WY_L_RE] IS NULL))

