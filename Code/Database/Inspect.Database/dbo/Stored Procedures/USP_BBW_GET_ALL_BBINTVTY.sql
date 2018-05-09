
-- Doel: Ophalen alle interventietypes voor brandweer
-- Auteur: Rajiv Blancke - Koen Heye 30/03/2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBINTVTY]

AS

SET NOCOUNT OFF;

	SELECT * FROM BBINTVTY
	ORDER BY SCF_TY_INTV

