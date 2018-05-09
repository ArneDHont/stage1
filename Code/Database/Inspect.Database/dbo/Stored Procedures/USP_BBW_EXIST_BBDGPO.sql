
-- Doel: Ophalen alle  dagverslagen voor die dag.
-- Auteur: SIDDIEN okt 2006

CREATE PROCEDURE [dbo].[USP_BBW_EXIST_BBDGPO]
 @datum datetime

AS

SET NOCOUNT OFF;


SELECT count(*) as aantal
FROM BBDGPO
WHERE BBDGPO.TMS_REG_DG_PO = @datum

