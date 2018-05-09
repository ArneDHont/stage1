
-- Doel: Ophalen alle schadeobjecten voor de registratie van een schadegeval
-- Auteur: Rajiv Blancke - Koen Heye 11/04/2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBSCADAN]

AS

SET NOCOUNT OFF;

	SELECT * 
	FROM BBSCADAN
	ORDER BY ID_OBJ_SCAD

