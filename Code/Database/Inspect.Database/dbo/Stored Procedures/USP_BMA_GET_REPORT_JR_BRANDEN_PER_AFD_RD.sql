
-- Doel: 	Ophalen gegevens voor maandrapport: branden per afdeling
--	Het is de bedoeling om dit in een pivot-tabel te tonen op een rapport (links oorzaak, bovenaan afdeling, midden aantal)
-- Opmerking: geen afdelingen tonen waarin AFG (afgekeurd), VERD (verdwenen) of VERV (vervangen) in voorkomt
-- Auteur: Stein Peeters - 27/08/2006


CREATE PROCEDURE [dbo].[USP_BMA_GET_REPORT_JR_BRANDEN_PER_AFD_RD]
	(@Jaar integer)

AS

SET NOCOUNT OFF;
SELECT SCF_BR_RD_INTV, KRT_AFD, COUNT(ID_INTV_BRDW) AS TOTAAL

FROM BBINTVBR

JOIN BBBRRD ON BBBRRD.ID_BR_RD_INTV = BBINTVBR.ID_BR_RD_INTV
JOIN BBAFD ON BBAFD.ID_AFD = BBINTVBR.ID_AFD

AND YEAR(DT_OPS_RAP_INTV) = @Jaar
AND (NOT (BBAFD.KRT_AFD LIKE '%AFG%')) 
AND (NOT (BBAFD.KRT_AFD LIKE '%VERD%')) 
AND (NOT (BBAFD.KRT_AFD LIKE '%VERV%')) 
AND BBINTVBR.ID_TY_INTV = 1

GROUP BY SCF_BR_RD_INTV, KRT_AFD
ORDER BY SCF_BR_RD_INTV, KRT_AFD

