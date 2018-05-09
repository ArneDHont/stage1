
-- Doel: Ophalen alle inbreuktypes (bewaking)
-- Auteur: Rajiv Blancke - Koen Heye 04/04/2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBINBRTY]

AS

SET NOCOUNT OFF;

	SELECT * 
	FROM BBINBRTY
	ORDER BY SCF_TY_INBR

