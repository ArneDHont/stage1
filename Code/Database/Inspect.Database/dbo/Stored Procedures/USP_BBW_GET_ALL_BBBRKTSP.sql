
-- Doel: Ophalen alle gebruik van voertuigen
-- Auteur: Rajiv Blancke - Koen Heye 19/04/2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBBRKTSP]

AS

SET NOCOUNT OFF;

	SELECT * FROM BBBRKTSP
	ORDER BY SCF_BRK_TSP

