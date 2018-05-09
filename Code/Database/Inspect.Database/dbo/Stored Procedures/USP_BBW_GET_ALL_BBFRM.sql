-- Doel: Ophalen alle firma's
-- Auteur: Rajiv Blancke - Koen Heye 05/04/2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBFRM]

AS

SET NOCOUNT OFF;

	select *
	from BBFRM
	order by NM_FRM