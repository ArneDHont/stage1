
-- Doel: Ophalen alle inbreukartikels
-- Auteur: Rajiv Blancke - Koen Heye 08/05/2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBINBRAR]

AS

SET NOCOUNT OFF;

	SELECT * FROM BBINBRAR
	ORDER BY NR_ART_INBR

