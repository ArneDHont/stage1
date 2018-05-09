
CREATE PROC dbo.[USP_WY_BVLGR_DELETE]
  @Original_ID_GR char(50), --Primary Key Field
  @Original_NR_WY_L_RE int=NULL 

AS
SET NOCOUNT OFF

DELETE FROM [BVLGR]
WHERE [ID_GR] = @Original_ID_GR
AND ([NR_WY_L_RE] = @Original_NR_WY_L_RE OR (@Original_NR_WY_L_RE IS NULL AND [NR_WY_L_RE] IS NULL))

