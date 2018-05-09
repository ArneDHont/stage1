
CREATE PROC dbo.[USP_WY_BVLGGD_DELETE]
  @Original_ID_TOEP char(50), --Primary Key Field
  @Original_ID_GGD char(50), --Primary Key Field
  @Original_NR_WY_L_RE int=NULL 

AS
SET NOCOUNT OFF

DELETE FROM [BVLGGD]
WHERE [ID_TOEP] = @Original_ID_TOEP
AND [ID_GGD] = @Original_ID_GGD
AND ([NR_WY_L_RE] = @Original_NR_WY_L_RE OR (@Original_NR_WY_L_RE IS NULL AND [NR_WY_L_RE] IS NULL))

