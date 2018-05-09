
-- Doel: Ophalen alle  dagverslagen personeel
-- Auteur: SIDDIEN okt 2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBDGPERS]
 @datumVanaf datetime
AS

SET NOCOUNT OFF;

	SELECT  
	BBIND.NM_IND
	,BBIND.VNM_IND
	,BBDGPERS.*
	, datepart(yyyy, TMS_REG_DG_PERS) as jaar 
	, datepart(mm, TMS_REG_DG_PERS) as maand
	, datepart(wk, TMS_REG_DG_PERS) as weekNr
	FROM BBDGPERS
	INNER JOIN BBIND
	ON BBIND.ID_IND = BBDGPERS.ID_IND
	WHERE TMS_REG_DG_PERS >= @datumVanaf
	ORDER BY TMS_REG_DG_PERS

