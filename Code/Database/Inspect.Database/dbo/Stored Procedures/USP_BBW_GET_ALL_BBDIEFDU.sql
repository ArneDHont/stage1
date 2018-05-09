
-- Doel: Ophalen alle registratietypes voor bewaking
-- Auteur: Rajiv Blancke - Koen Heye 31/03/2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBDIEFDU]

AS

SET NOCOUNT OFF;

	SELECT * 
	FROM BBDIEFDU
	ORDER BY ID_DUP_DIEF

