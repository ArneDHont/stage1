
-- Doel: Ophalen alle configuratie settings
-- Auteur: Rajiv Blancke - Koen Heye 24/04/2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBCONF]

AS

SET NOCOUNT OFF;

	SELECT * 
	FROM BBCONF

