
-- Doel: Ophalen alle soorten werfvoertuigen
-- Auteur: Rajiv Blancke - Koen Heye 19/04/2006

CREATE PROCEDURE [dbo].[USP_BBW_GET_ALL_BBWRFTSP]

AS

SET NOCOUNT OFF;

	select *
	from BBWRFTSP

