
-- Doel: Ophalen alle voertuigtypes
-- Auteur: Rajiv Blancke - Koen Heye 19/04/2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBTYTSP]

AS

SET NOCOUNT OFF;

	SELECT * FROM BBTYTSP
	ORDER BY SCF_TY_TSP

