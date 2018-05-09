
CREATE PROC dbo.[USP_WY_BVLIND_DELETE]
  @Original_ID_IND char(50), --Primary Key Field
  @Original_NR_WY_L_RE int=NULL 

AS
SET NOCOUNT OFF

DELETE FROM [BVLIND]
WHERE [ID_IND] = @Original_ID_IND
AND ([NR_WY_L_RE] = @Original_NR_WY_L_RE OR (@Original_NR_WY_L_RE IS NULL AND [NR_WY_L_RE] IS NULL))

