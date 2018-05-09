
-- Doel: Ophalen alle verzekeringsfirma's
-- Auteur: Rajiv Blancke - Koen Heye 05/04/2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBVZKFRM]

AS

SET NOCOUNT OFF;

	select *
	from BBVZKFRM
	order by NM_FRM_VZK

