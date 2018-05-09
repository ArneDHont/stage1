
-- Doel: Ophalen alle vaststellers van een aanrijding
-- reglementen en schadegeval
-- Auteur: Rajiv Blancke - Koen Heye 12/05/2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBVASTOGV]

AS

SET NOCOUNT OFF;

	SELECT * 
	FROM BBVASTOGV

