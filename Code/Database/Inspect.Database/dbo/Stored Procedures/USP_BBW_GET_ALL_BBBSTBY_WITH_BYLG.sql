
-- Doel: Ophalen alle speciale bestemmelingen waarvoor de bijlagen als attachment dienen verstuurd te worden
-- Auteur: Mieke Duynslager Sept 2007

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBBSTBY_WITH_BYLG]

AS

SET NOCOUNT OFF;

	select BBBSTBY.* 
	from BBBSTBY
	where BBBSTBY.EMAL_BYLG= 1

