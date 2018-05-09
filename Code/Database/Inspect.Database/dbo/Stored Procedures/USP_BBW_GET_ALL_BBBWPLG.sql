
-- Doel: Ophalen alle ploegen
-- Auteur: Rajiv Blancke - Koen Heye 19/04/2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBBWPLG]

AS

SET NOCOUNT OFF;

	SELECT * FROM BBBWPLG
	ORDER BY SCF_PLG_IND

