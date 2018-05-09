
-- Doel: Ophalen alle  dagverslagen voor die dag.
-- Auteur: SIDDIEN okt 2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_BestemmelingenAfdeling]
 @id_afd int

AS

SET NOCOUNT OFF;


SELECT BBAFDAMC.*,BBIND.NM_IND, BBIND.VNM_IND, BBIND.AD_EMAL_IND as mail  FROM BBAFDAMC
INNER JOIN BBIND
ON BBIND.ID_IND = BBAFDAMC.ID_IND
where ID_AFD = @ID_AFD