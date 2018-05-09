
-- Doel: Ophalen alle eenheden
-- Auteur: Rajiv Blancke - Koen Heye 18/04/2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBEH]

AS

SET NOCOUNT OFF;

	SELECT * FROM BBEH
	ORDER BY SCF_EH

