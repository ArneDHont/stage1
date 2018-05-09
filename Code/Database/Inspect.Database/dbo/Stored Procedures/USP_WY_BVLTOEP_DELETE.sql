
CREATE PROC dbo.[USP_WY_BVLTOEP_DELETE]
  @Original_ID_TOEP char(50), --Primary Key Field
  @Original_NR_WY_L_RE int=NULL 

AS
SET NOCOUNT OFF

DELETE FROM [BVLTOEP]
WHERE [ID_TOEP] = @Original_ID_TOEP
AND ([NR_WY_L_RE] = @Original_NR_WY_L_RE OR (@Original_NR_WY_L_RE IS NULL AND [NR_WY_L_RE] IS NULL))

