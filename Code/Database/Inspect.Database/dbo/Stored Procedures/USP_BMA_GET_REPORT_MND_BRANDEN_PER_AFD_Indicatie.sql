
-- Doel: 	Ophalen gegevens voor maandrapport: branden per afdeling
--	Het is de bedoeling om dit in een pivot-tabel te tonen op een rapport:
--	1. Geblust door eigen personeel
--	2. Oproep brandweerdienst
--	3. Tussenkomst brandweerdienst
--	4. Aantal incidentenrapporten
-- Opmerking: geen afdelingen tonen waarin AFG (afgekeurd), VERD (verdwenen) of VERV (vervangen) in voorkomt
-- Auteur: Nancy Coppens - 27/09/2006


CREATE PROCEDURE [dbo].[USP_BMA_GET_REPORT_MND_BRANDEN_PER_AFD_Indicatie]
	(@Maand integer, @Jaar integer)

AS

SET NOCOUNT OFF;
SELECT     dbo.BBAFD.KRT_AFD, 'Geblust door eigen personeel' AS Indicatie, SUM(CAST(dbo.BBINTVBR.INDI_BRD_BLUS_AFD AS smallint)) AS Totaal
FROM         dbo.BBINTVBR INNER JOIN
                      dbo.BBAFD ON dbo.BBAFD.ID_AFD = dbo.BBINTVBR.ID_AFD
WHERE     (MONTH(dbo.BBINTVBR.DT_OPS_RAP_INTV) = @Maand) AND (YEAR(dbo.BBINTVBR.DT_OPS_RAP_INTV) = @Jaar) AND 
                      (NOT (dbo.BBAFD.KRT_AFD LIKE '%AFG%')) AND (NOT (dbo.BBAFD.KRT_AFD LIKE '%VERD%')) AND (NOT (dbo.BBAFD.KRT_AFD LIKE '%VERV%')) AND 
                      (dbo.BBINTVBR.ID_TY_INTV = 1)
GROUP BY dbo.BBAFD.KRT_AFD
UNION
SELECT     dbo.BBAFD.KRT_AFD, 'Oproep brandweerdienst' AS Indicatie, SUM(CAST(dbo.BBINTVBR.INDI_BRDW_SID_OPR AS smallint)) AS Totaal
FROM         dbo.BBINTVBR INNER JOIN
                      dbo.BBAFD ON dbo.BBAFD.ID_AFD = dbo.BBINTVBR.ID_AFD
WHERE     (MONTH(dbo.BBINTVBR.DT_OPS_RAP_INTV) = @Maand) AND (YEAR(dbo.BBINTVBR.DT_OPS_RAP_INTV) = @Jaar) AND 
                      (NOT (dbo.BBAFD.KRT_AFD LIKE '%AFG%')) AND (NOT (dbo.BBAFD.KRT_AFD LIKE '%VERD%')) AND (NOT (dbo.BBAFD.KRT_AFD LIKE '%VERV%')) AND 
                      (dbo.BBINTVBR.ID_TY_INTV = 1)
GROUP BY dbo.BBAFD.KRT_AFD
UNION
SELECT     dbo.BBAFD.KRT_AFD, 'Tussenkomst brandweerdienst' AS Indicatie, SUM(CAST(dbo.BBINTVBR.INDI_BRD_BLUS_SID AS smallint)) AS Totaal
FROM         dbo.BBINTVBR INNER JOIN
                      dbo.BBAFD ON dbo.BBAFD.ID_AFD = dbo.BBINTVBR.ID_AFD
WHERE     (MONTH(dbo.BBINTVBR.DT_OPS_RAP_INTV) = @Maand) AND (YEAR(dbo.BBINTVBR.DT_OPS_RAP_INTV) = @Jaar) AND 
                      (NOT (dbo.BBAFD.KRT_AFD LIKE '%AFG%')) AND (NOT (dbo.BBAFD.KRT_AFD LIKE '%VERD%')) AND (NOT (dbo.BBAFD.KRT_AFD LIKE '%VERV%')) AND 
                      (dbo.BBINTVBR.ID_TY_INTV = 1)
GROUP BY dbo.BBAFD.KRT_AFD
UNION
SELECT     dbo.BBAFD.KRT_AFD, 'IncidentenVerslag' AS Indicatie, SUM(CAST(dbo.BBINTVBR.INDI_RAP_INC_OTV AS smallint)) AS Totaal
FROM         dbo.BBINTVBR INNER JOIN
                      dbo.BBAFD ON dbo.BBAFD.ID_AFD = dbo.BBINTVBR.ID_AFD
WHERE     (MONTH(dbo.BBINTVBR.DT_OPS_RAP_INTV) = @Maand) AND (YEAR(dbo.BBINTVBR.DT_OPS_RAP_INTV) = @Jaar) AND 
                      (NOT (dbo.BBAFD.KRT_AFD LIKE '%AFG%')) AND (NOT (dbo.BBAFD.KRT_AFD LIKE '%VERD%')) AND (NOT (dbo.BBAFD.KRT_AFD LIKE '%VERV%')) AND 
                      (dbo.BBINTVBR.ID_TY_INTV = 1)
GROUP BY dbo.BBAFD.KRT_AFD
ORDER BY dbo.BBAFD.KRT_AFD

