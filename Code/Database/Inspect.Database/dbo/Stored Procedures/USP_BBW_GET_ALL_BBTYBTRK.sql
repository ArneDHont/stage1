
-- Doel: Ophalen alle types betrokkenen
-- Auteur: Rajiv Blancke - Koen Heye 19/04/2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBTYBTRK]

AS

SET NOCOUNT OFF;

	SELECT * FROM BBTYBTRK
	ORDER BY SCF_TY_BTRK

