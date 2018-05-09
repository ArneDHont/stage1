
CREATE PROC dbo.[USP_WY_BVLPLA_DELETE]
  @Original_ID_PLA char(50), --Primary Key Field
  @Original_NR_WY_L_RE int=NULL 

AS
SET NOCOUNT OFF

DELETE FROM [BVLPLA]
WHERE [ID_PLA] = @Original_ID_PLA
AND ([NR_WY_L_RE] = @Original_NR_WY_L_RE OR (@Original_NR_WY_L_RE IS NULL AND [NR_WY_L_RE] IS NULL))

