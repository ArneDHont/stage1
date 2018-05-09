
-- Doel: Ophalen alle registratietypes voor bewaking
-- Auteur: Rajiv Blancke - Koen Heye 31/03/2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBREGTY]

AS

SET NOCOUNT OFF;

	SELECT * FROM BBREGTY
	ORDER BY SCF_TY_REG

