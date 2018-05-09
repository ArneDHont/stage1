
-- Doel: Ophalen alle toestandtypes
-- Auteur: Rajiv Blancke - Koen Heye 18/04/2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBTYSTA]

AS

SET NOCOUNT OFF;

	SELECT * FROM BBTYSTA
	ORDER BY SCF_TY_STA

