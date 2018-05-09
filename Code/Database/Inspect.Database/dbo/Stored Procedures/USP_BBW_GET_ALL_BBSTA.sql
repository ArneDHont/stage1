
-- Doel: Ophalen alle toestanden (bewaking)
-- Auteur: Rajiv Blancke - Koen Heye 20/04/2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBSTA]

AS

SET NOCOUNT OFF;

	SELECT * 
	FROM BBSTA
	inner join BBTYSTA on BBSTA.ID_TY_STA = BBTYSTA.ID_TY_STA
	ORDER BY BBTYSTA.ID_TY_STA, BBSTA.SCF_STA

