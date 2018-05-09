
-- Doel: 	Ophalen gegevens voor maandrapport: branden per afdeling
--	Het is de bedoeling om dit in een pivot-tabel te tonen op een rapport (links aard en oorzaak, bovenaan afdeling, midden aantal)
-- Opmerking: geen afdelingen tonen waarin AFG (afgekeurd), VERD (verdwenen) of VERV (vervangen) in voorkomt
-- Auteur: Stein Peeters - 25/08/2006


CREATE PROCEDURE [dbo].[USP_BMA_GET_REPORT_JR_BRANDEN_PER_AFD]
	(@Jaar integer)

AS

SET NOCOUNT OFF;
SELECT KRT_AFD, SCF_BR_TY_INTV, SCF_BR_RD_INTV, COUNT(ID_INTV_BRDW) AS TOTAAL

FROM BBINTVBR

JOIN BBBRTY ON BBBRTY.ID_BR_TY_INTV = BBINTVBR.ID_BR_TY_INTV
JOIN BBBRRD ON BBBRRD.ID_BR_RD_INTV = BBINTVBR.ID_BR_RD_INTV
JOIN BBAFD ON BBAFD.ID_AFD = BBINTVBR.ID_AFD

AND YEAR(DT_OPS_RAP_INTV) = @Jaar
AND (NOT (BBAFD.KRT_AFD LIKE '%AFG%')) 
AND (NOT (BBAFD.KRT_AFD LIKE '%VERD%')) 
AND (NOT (BBAFD.KRT_AFD LIKE '%VERV%')) 
AND BBINTVBR.ID_TY_INTV = 1

GROUP BY KRT_AFD, SCF_BR_TY_INTV, SCF_BR_RD_INTV 
ORDER BY KRT_AFD, SCF_BR_TY_INTV, SCF_BR_RD_INTV

