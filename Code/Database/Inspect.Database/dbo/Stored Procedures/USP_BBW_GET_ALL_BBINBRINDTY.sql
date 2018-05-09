
-- Doel: Ophalen alle soorten overtreders voor inbreuk reglementen
-- Auteur: Nancy Coppens - 19/12/2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBINBRINDTY]

AS

SET NOCOUNT OFF;

	SELECT * FROM BBINBRINDTY
	ORDER BY SCF_INBR_IND_TY

