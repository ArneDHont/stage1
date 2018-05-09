
-- Doel: Ophalen alle iondividutypes
-- Auteur: Rajiv Blancke - Koen Heye 18/04/2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBINDTY]

AS

SET NOCOUNT OFF;

	SELECT * FROM BBINDTY
	ORDER BY SCF_TY_IND

