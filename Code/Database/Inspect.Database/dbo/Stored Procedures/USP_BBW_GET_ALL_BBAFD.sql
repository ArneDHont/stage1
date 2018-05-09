
-- Doel: Ophalen alle afdelingen
-- Auteur: Rajiv Blancke - Koen Heye 30/03/2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBAFD]

AS

SET NOCOUNT OFF;

	SELECT * FROM BBAFD
	ORDER BY KRT_AFD

