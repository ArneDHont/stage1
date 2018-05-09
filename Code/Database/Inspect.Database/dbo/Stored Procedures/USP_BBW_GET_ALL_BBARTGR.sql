
-- Doel: Ophalen alle artikelgroepen
-- Auteur: Rajiv Blancke - Koen Heye 18/04/2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBARTGR]

AS

SET NOCOUNT OFF;

	SELECT * FROM BBARTGR
	ORDER BY SCF_GR_ART

